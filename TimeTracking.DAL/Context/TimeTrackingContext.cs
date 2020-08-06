using Microsoft.EntityFrameworkCore;

using TimeTracking.Domain.Entities;

namespace TimeTracking.DAL.Context
{
    public class TimeTrackingContext : DbContext
    {
        public TimeTrackingContext(DbContextOptions<TimeTrackingContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ActivityType> ActivityTypes { get; set; }
        public DbSet<TrackRecord> TrackRecords { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
            optionsBuilder.UseSqlServer(@"Data Source=localhost;Initial Catalog=TrackingDB;
                                        Trusted_Connection=True;Integrated security=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TimeTrackingContext).Assembly);  
            
        }
    }
}
