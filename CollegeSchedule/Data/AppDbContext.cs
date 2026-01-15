using CollegeSchedule.Models;
using Microsoft.EntityFrameworkCore;
namespace CollegeSchedule.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Building> Buildings => Set<Building>();
        public DbSet<Classroom> Classrooms => Set<Classroom>();
        public DbSet<Teacher> Teachers => Set<Teacher>();
        public DbSet<Subject> Subjects => Set<Subject>();
        public DbSet<Specialty> Specialties => Set<Specialty>();
        public DbSet<StudentGroup> StudentGroups => Set<StudentGroup>();
        public DbSet<Weekday> Weekdays => Set<Weekday>();
        public DbSet<LessonTime> LessonTimes => Set<LessonTime>();
        public DbSet<Schedule> Schedules => Set<Schedule>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Schedule>()
            .HasIndex(s => new {
                s.LessonDate,
                s.LessonTimeId,
                s.GroupId,
                s.GroupPart
            })
            .IsUnique();
            modelBuilder.Entity<Schedule>()
            .HasIndex(s => new { s.LessonDate, s.LessonTimeId, s.ClassroomId })
            .IsUnique();
            modelBuilder.Entity<Schedule>()
            .Property(s => s.GroupPart)
            .HasConversion<string>();
        }
    }
}