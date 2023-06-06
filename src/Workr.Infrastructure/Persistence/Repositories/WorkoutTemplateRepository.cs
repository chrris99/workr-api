using Microsoft.EntityFrameworkCore;
using Workr.Application.Repositories;
using Workr.Core;
using Workr.Domain.Errors;
using Workr.Domain.Workout.Template;

namespace Workr.Infrastructure.Persistence.Repositories;

public sealed class WorkoutTemplateRepository : IWorkoutTemplateRepository
{
    private readonly ApplicationDbContext _context;

    public WorkoutTemplateRepository(ApplicationDbContext context) => _context = context;
    
    public async Task<Result<WorkoutTemplate>> CreateWorkoutTemplate(WorkoutTemplate workoutTemplate)
    {
        try
        {
            foreach (var itemTemplate in workoutTemplate.BlockTemplates.SelectMany(blockTemplate =>
                         blockTemplate.ItemTemplates))
            {
                var exercise =
                    await _context.Exercises.SingleOrDefaultAsync(e => e.Id.Equals(itemTemplate.Exercise.Id));

                if (exercise == null)
                    return Result.Failure<WorkoutTemplate>(DomainErrors.Exercise.NotFoundById);

                itemTemplate.Exercise = exercise;
            }
            
            var entity = _context.WorkoutTemplates.Add(workoutTemplate).Entity;
            await _context.SaveChangesAsync();
            return entity;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return Result.Failure<WorkoutTemplate>(DomainErrors.General.ServerError);
        }
    }

    public async Task<Result<WorkoutTemplate>> GetWorkoutTemplateById(Guid workoutTemplateId)
    {
        var workoutTemplate = await _context.WorkoutTemplates
            .Include(template => template.BlockTemplates)
            .ThenInclude(blockTemplate => blockTemplate.ItemTemplates)
            .ThenInclude(itemTemplate => itemTemplate.Exercise)
            .SingleOrDefaultAsync(e => e.Id.Equals(workoutTemplateId));
        
        return workoutTemplate ?? Result.Failure<WorkoutTemplate>(DomainErrors.WorkoutTemplate.NotFoundById);
    }
}