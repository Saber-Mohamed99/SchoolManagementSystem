using Microsoft.EntityFrameworkCore;

namespace SchoolManagementSystem.DataAccess;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Level> Levels { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<ClassRoom> ClassRooms { get; set; }
    public DbSet<Schedule> Schedules { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }
    public DbSet<Exam> Exams { get; set; }
    public DbSet<Result> Results { get; set; }
    public DbSet<Attendance> Attendances { get; set; }
    public DbSet<ParentsPhone> ParentsPhones { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Unique constraints
        modelBuilder.Entity<Student>()
            .HasIndex(s => s.Email).IsUnique();

        modelBuilder.Entity<Teacher>()
            .HasIndex(t => t.Email).IsUnique();

        modelBuilder.Entity<Subject>()
            .HasIndex(s => s.Code).IsUnique();

        // Decimal precision
        modelBuilder.Entity<Teacher>()
            .Property(t => t.Salary).HasColumnType("decimal(18,2)");

        //  avoid multiple cascade paths
        modelBuilder.Entity<Schedule>()
            .HasOne(s => s.Teacher)
            .WithMany(t => t.Schedules)
            .HasForeignKey(s => s.TeacherId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Schedule>()
            .HasOne(s => s.Subject)
            .WithMany(sub => sub.Schedules)
            .HasForeignKey(s => s.SubjectId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Exam>()
            .HasOne(e => e.Teacher)
            .WithMany(t => t.Exams)
            .HasForeignKey(e => e.TeacherId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Exam>()
            .HasOne(e => e.Subject)
            .WithMany(s => s.Exams)
            .HasForeignKey(e => e.SubjectId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}