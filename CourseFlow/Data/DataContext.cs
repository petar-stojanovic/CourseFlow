using CourseFlow.Models;
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
    public DbSet<User> Users { get; set; }

    public DbSet<AuthorCourses> AuthorCourses { get; set; }
    public DbSet<UserTakesCourse> UserTakesCourses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Course>()
            .Property(p => p.Id)
            .ValueGeneratedOnAdd();
        
        modelBuilder.Entity<Lesson>()
            .Property(p => p.Id)
            .ValueGeneratedOnAdd();

        modelBuilder.Entity<Category>()
            .Property(p => p.Id)
            .ValueGeneratedOnAdd();

        modelBuilder.Entity<User>()
            .Property(p => p.Id)
            .ValueGeneratedOnAdd();

        
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
        
        
        modelBuilder.Entity<AuthorCourses>()
            .HasKey(cc => new { cc.AuthorId, cc.CourseId });
        
        modelBuilder.Entity<AuthorCourses>()
            .HasOne(c => c.Author)
            .WithMany(cc => cc.AuthorCourses)
            .HasForeignKey(c => c.AuthorId);
        
        modelBuilder.Entity<AuthorCourses>()
            .HasOne(c => c.Course)
            .WithMany(cc => cc.AuthorCourses)
            .HasForeignKey(c => c.CourseId);
        
        
        modelBuilder.Entity<UserTakesCourse>()
            .HasKey(cc => new { cc.UserId, cc.CourseId });
        
        modelBuilder.Entity<UserTakesCourse>()
            .HasOne(c => c.User)
            .WithMany(cc => cc.UserTakesCourse)
            .HasForeignKey(c => c.UserId);
        
        modelBuilder.Entity<UserTakesCourse>()
            .HasOne(c => c.Course)
            .WithMany(cc => cc.UserTakesCourse)
            .HasForeignKey(c => c.CourseId);
        
        SeedCategories(modelBuilder);
    }
    
    
    private void SeedCategories(ModelBuilder modelBuilder)
    {
        // Define the list of category names
        var categoryNames = new[]
        {
            "Web Development", "Mobile App Development", "Game Development",
            "Database Management", "DevOps", "Machine Learning", "Artificial Intelligence",
            "Data Science", "Cloud Computing", "Cybersecurity",
            "Frontend Development", "Backend Development", "Full Stack Development",
            "UI/UX Design", "Version Control", "Agile Methodology",
            "Software Testing", "Continuous Integration", "API Development",
            "Microservices", "Blockchain", "IoT Development", "Embedded Systems",
            "Natural Language Processing", "Big Data", "Virtual Reality",
            "Augmented Reality", "Quantum Computing", "Functional Programming",
            "Object-Oriented Programming", "Low-Level Programming", "High-Level Programming",
            "Concurrency", "Parallel Programming", "Responsive Design",
            "RESTful APIs", "GraphQL", "Secure Coding Practices", "Code Optimization",
            "Code Review", "Pair Programming", "Scrum", "Kanban",
            "Software Architecture", "Design Patterns", "Refactoring",
            "Code Documentation", "Legacy Code Maintenance", "Code Quality",
            "Technical Debt", "Software Development Lifecycle", "Project Management",
            "C#", "C++", "Java", "Python", "JavaScript",
            "Ruby", "Swift", "Kotlin", "Go", "Rust",
            "PHP", "Perl", "Scala", "Haskell", "Lua",
            "TypeScript", "Dart", "F#", "Groovy", "Objective-C",
            "R", "Matlab", "Julia", "COBOL", "Fortran",
            "Assembly", "PL/SQL", "T-SQL", "VBScript", "Ada",
            "Lisp", "Prolog", "Scheme", "Smalltalk", "Logo",
            "Clojure", "Elixir", "Erlang", "VHDL", "Verilog",
            "SQL", "HTML", "CSS", "XML", "JSON",
            "Bash", "PowerShell", "Pascal", "Racket", "Ada"
        };

        // Add the categories to the database
        foreach (var categoryName in categoryNames)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = Guid.NewGuid(),
                    Name = categoryName
                });
        }
    }
}