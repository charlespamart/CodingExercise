using Microsoft.EntityFrameworkCore;

namespace CodingExercise;

public class CodingExerciseContext : DbContext
{
    public CodingExerciseContext(DbContextOptions<CodingExerciseContext> options) : base(options) {}
    
    public DbSet<MyEntityData> MyEntity { get; set; }
}