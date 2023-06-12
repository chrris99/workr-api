using Microsoft.EntityFrameworkCore;
using Workr.Application.Repositories;
using Workr.Core;
using Workr.Domain.Errors;
using Workr.Domain.Workout;

namespace Workr.Infrastructure.Persistence.Repositories;

public sealed class WorkoutRepository : IWorkoutRepository
{
    private readonly ApplicationDbContext _context;
    public WorkoutRepository(ApplicationDbContext context) => _context = context;
    
    public async Task<Result<Workout>> CreateWorkout(Workout workout)
    {
        try
        {
            foreach (var workoutItem in workout.Blocks.SelectMany(block =>
                         block.Items))
            {
                var exercise =
                    await _context.Exercises.SingleOrDefaultAsync(e => e.Id.Equals(workoutItem.Exercise.Id));

                if (exercise == null)
                    return Result.Failure<Workout>(DomainErrors.Exercise.NotFoundById);

                workoutItem.Exercise = exercise;
            }
            
            var entity = _context.Workouts.Add(workout).Entity;
            await _context.SaveChangesAsync();
            return entity;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return Result.Failure<Workout>(DomainErrors.General.ServerError);
        }
    }

    public async Task<Result<Workout>> GetWorkoutById(Guid workoutId)
    {
        var workout = await _context.Workouts
            .Include(workout => workout.Blocks)
            .ThenInclude(workoutBlock => workoutBlock.Items)
            .ThenInclude(workoutItem => workoutItem.Exercise)
            .SingleOrDefaultAsync(e => e.Id.Equals(workoutId));
        
        return workout ?? Result.Failure<Workout>(DomainErrors.WorkoutTemplate.NotFoundById);
    }

    public async Task<Result<List<Workout>>> GetWorkouts(string userId)
    {
        var templates = await _context.Workouts
            .Where(template => template.CreatedBy.Equals(userId))
            .Include(workout => workout.Blocks)
            .ThenInclude(block => block.Items)
            .ThenInclude(item => item.Exercise)
            .ToListAsync();

        return templates;
    }

    public async Task<Result> UpdateWorkout(Workout workout)
    {
        var entity = await _context.Workouts
            .FindAsync(workout.Id);

        if (entity == null)
            return Result.Failure(DomainErrors.Workout.NotFoundById);

        if (entity.CreatedBy != workout.CreatedBy)
            return Result.Failure(DomainErrors.Workout.Forbidden);

        _context.Workouts.Update(workout);
        await _context.SaveChangesAsync();

        return Result.Success();
    }

    public async Task<Result> DeleteWorkout(Guid workoutId, string userId)
    {
        var workout = await _context.Workouts.FindAsync(workoutId);

        if (workout == null) return Result.Success();

        if (workout.CreatedBy != userId)
            return Result.Failure(DomainErrors.Workout.Forbidden); // should return no content and success?
        
        _context.Workouts.Remove(workout);
        await _context.SaveChangesAsync();

        return Result.Success();
    }
}