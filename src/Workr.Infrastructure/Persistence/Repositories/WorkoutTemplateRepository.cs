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
}