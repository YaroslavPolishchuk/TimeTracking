using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TimeTracking.Domain.Entities;

namespace TimeTracking.DAL.Configurations
{
    class ActivityTypeConfigurations : IEntityTypeConfiguration<ActivityType>
    {
        public void Configure(EntityTypeBuilder<ActivityType> builder)
        {
            builder.HasKey(e => e.ActivityId);
            builder.Property(e=>e.ActivityId).UseIdentityColumn().ValueGeneratedOnAdd();
            builder.Property(e => e.ActivityName).IsRequired().HasMaxLength(54);
            builder.HasData(
                new ActivityType
                {   
                    ActivityId=1,
                    ActivityName = "Regular work"
                },
                new ActivityType
                {                
                    ActivityId=2,
                    ActivityName = "Overtime"
                });
        }
    }
}
