using Microsoft.EntityFrameworkCore;
using Workr.Application;
using Workr.Application.Repositories;
using Workr.Core;
using Workr.Domain;
using Workr.Domain.Errors;
using Workr.Domain.Exercise;

namespace Workr.Infrastructure.Persistence.Repositories;

public sealed class ExerciseRepository : IExerciseRepository
{
    private readonly ApplicationDbContext _context;

    public ExerciseRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Result<Exercise>> CreateExercise(Exercise exercise)
    {
        try
        {
            var entity = _context.Exercises.Add(exercise).Entity;
            await _context.SaveChangesAsync();
            return entity;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return Result.Failure<Exercise>(DomainErrors.General.ServerError);
        }
    }

    public async Task<Result<Exercise>> GetExerciseById(Guid exerciseId)
    {
        var exercise = await _context.Exercises.SingleOrDefaultAsync(e => e.Id.Equals(exerciseId));
        return exercise ?? Result.Failure<Exercise>(DomainErrors.Exercise.NotFoundById);
    }

    public async Task<Result<List<Exercise>>> GetExercises()
    {
        return await _context.Exercises
            .OrderBy(e => e.Name)
            .ToListAsync();
    }

    public async Task<Result> UpdateExercise(Exercise exercise)
    {
        _context.Exercises.Update(exercise);
        await _context.SaveChangesAsync();

        return Result.Success();
    }

    public async Task<Result> RemoveExercise(Guid exerciseId)
    {
        var exercise = await _context.Exercises.FindAsync(exerciseId);

        if (exercise == null) return Result.Success();

        _context.Exercises.Remove(exercise);
        await _context.SaveChangesAsync();

        return Result.Success();
    }
}