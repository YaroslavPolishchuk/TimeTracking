using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TimeTracking.Domain.Entities;

namespace TimeTracking.DAL.Configurations
{
    public class TrackRecordConfigurations : IEntityTypeConfiguration<TrackRecord>
    {
        public void Configure(EntityTypeBuilder<TrackRecord> builder)
        {
            builder.HasKey(e => e.TrackRecordId);
            builder.Property(e => e.TrackRecordId).UseIdentityColumn();
            builder.Property(e => e.TrackDate).IsRequired().HasColumnType("Date");
            builder.HasOne(x => x.ActivityType).WithMany(x => x.TrackRecords).HasForeignKey(x => x.ActivityId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_TrackRecord_ActivityId");
            builder.HasOne(x => x.Employee).WithMany(x => x.TrackRecords).HasForeignKey(x => x.EmployeeId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_TrackRecord_EmployeeId");
            builder.HasOne(x => x.Project).WithMany(x => x.TrackRecords).HasForeignKey(x => x.ProjectId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_TrackRecord_ProjectId");
            builder.HasOne(x => x.Role).WithMany(x => x.TrackRecords).HasForeignKey(x => x.RoleId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_TrackRecord_RoleId");
            builder.HasData(
                new TrackRecord
                {             
                    TrackRecordId=1,
                    Hours = 4,
                    TrackDate = new DateTime(2020, 07, 20),
                    WeekNumber = 30,
                    EmployeeId = 1,
                    ActivityId = 1,
                    RoleId = 1,
                    ProjectId = 1
                },
                new TrackRecord
                {
                    TrackRecordId = 2,
                    Hours = 2,
                    TrackDate = new DateTime(2020, 07, 20),
                    WeekNumber = 30,
                    EmployeeId = 1,
                    ActivityId = 2,
                    RoleId = 2,
                    ProjectId = 1
                },
                new TrackRecord
                {
                    TrackRecordId = 3,
                    Hours = 3,
                    TrackDate = new DateTime(2020, 07, 20),
                    WeekNumber = 30,
                    EmployeeId = 3,
                    ActivityId = 1,
                    RoleId = 2,
                    ProjectId = 1
                },
                new TrackRecord
                {
                    TrackRecordId = 4,
                    Hours = 6,
                    TrackDate = new DateTime(2020, 07, 21),
                    WeekNumber = 30,
                    EmployeeId = 2,
                    ActivityId = 1,
                    RoleId = 1,
                    ProjectId = 1
                },
                new TrackRecord
                {
                    TrackRecordId = 5,
                    Hours = 8,
                    TrackDate = new DateTime(2020, 07, 22),
                    WeekNumber = 30,
                    EmployeeId = 2,
                    ActivityId = 1,
                    RoleId = 1,
                    ProjectId = 1
                },
                new TrackRecord
                {
                    TrackRecordId = 6,
                    Hours = 2,
                    TrackDate = new DateTime(2020, 07, 20),
                    WeekNumber = 30,
                    EmployeeId = 3,
                    ActivityId = 2,
                    RoleId = 4,
                    ProjectId = 1
                });
        }
    }
}
