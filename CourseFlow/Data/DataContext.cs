using CourseFlow.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseFlow.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Course> Courses { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Lesson> Lessons { get; set; }

    public DbSet<CourseCategory> CourseCategories { get; set; }
    //TODO() user
    // public DbSet<Course> Courses { get; set; }
    // public DbSet<Course> Courses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CourseCategory>()
            .HasKey(cc => new { cc.CourseId, cc.CategoryId });
        
        modelBuilder.Entity<CourseCategory>()
            .HasOne(c => c.Course)
            .WithMany(cc => cc.CourseCategories)
            .HasForeignKey(c => c.CourseId);
        
        modelBuilder.Entity<CourseCategory>()
            .HasOne(c => c.Category)
            .WithMany(cc => cc.CourseCategories)
            .HasForeignKey(c => c.CategoryId);
    }
}