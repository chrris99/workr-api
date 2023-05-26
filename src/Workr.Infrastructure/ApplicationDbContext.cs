using Microsoft.EntityFrameworkCore;
using Workr.Domain;

namespace Workr.Infrastructure;

public sealed class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}
    
    public DbSet<Exercise> Exercises { get; set; }
}