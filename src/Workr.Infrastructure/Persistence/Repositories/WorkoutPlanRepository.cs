using Microsoft.EntityFrameworkCore;
using Workr.Application.Repositories;
using Workr.Core;
using Workr.Domain.Errors;
using Workr.Domain.Workout;

namespace Workr.Infrastructure.Persistence.Repositories;

public sealed class WorkoutPlanRepository : IWorkoutPlanRepository
{
    private readonly ApplicationDbContext _context;

    public WorkoutPlanRepository(ApplicationDbContext context) => _context = context;
    
    public async Task<Result<WorkoutPlan>> CreateWorkoutPlan(WorkoutPlan workoutPlan)
    {
        try
        {
            var workouts = workoutPlan.Workouts
                .Select(w => _context.Workouts.Single(e => e.Id.Equals(w.Id)))
                .ToList();

            workoutPlan.Workouts = workouts;
            
            var entity = _context.WorkoutPlans.Add(workoutPlan).Entity;
            await _context.SaveChangesAsync();
            return entity;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return Result.Failure<WorkoutPlan>(DomainErrors.General.ServerError);
        }
    }

    public async Task<Result<WorkoutPlan>> GetWorkoutPlanById(Guid workoutPlanId)
    {
        var workoutPlan = await _context.WorkoutPlans
            .Include(workoutPlan => workoutPlan.Workouts)
            .SingleOrDefaultAsync(e => e.Id.Equals(workoutPlanId));

        return workoutPlan ?? Result.Failure<WorkoutPlan>(DomainErrors.WorkoutPlan.NotFoundById);
    }

    public async Task<Result<List<WorkoutPlan>>> GetWorkoutPlans(string userId)
    {
        var workoutPlans = await _context.WorkoutPlans
            .Where(wp => wp.CreatedBy.Equals(userId))
            .Include(workoutPlan => workoutPlan.Workouts)
            .ToListAsync();

        return workoutPlans;
    }

    public Task<Result> UpdateWorkoutPlan(WorkoutPlan workoutPlan)
    {
        throw new NotImplementedException();
    }

    public async Task<Result> DeleteWorkoutPlan(Guid workoutPlanId, string userId)
    {
        var workoutPlan = await _context.WorkoutPlans.FindAsync(workoutPlanId);

        if (workoutPlan == null) return Result.Success();

        if (workoutPlan.CreatedBy != userId)
            return Result.Failure(DomainErrors.WorkoutPlan.Forbidden); // should return no content and success?
        
        _context.WorkoutPlans.Remove(workoutPlan);
        await _context.SaveChangesAsync();

        return Result.Success();
    }
}