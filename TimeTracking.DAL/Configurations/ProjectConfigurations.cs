using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TimeTracking.Domain.Entities;

namespace TimeTracking.DAL.Configurations
{
    public class ProjectConfigurations : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(e => e.ProjectId);
            builder.Property(e => e.ProjectId).ValueGeneratedOnAdd();
            builder.Property(e => e.ProjectName).IsRequired().HasMaxLength(54);
            builder.Property(e => e.DateStart).HasColumnType("Date");
            builder.Property(e => e.DateEnd).HasColumnType("Date");
            builder.HasData(new Project
            {
                ProjectId=1,
                ProjectName = "TestProject",
                DateStart = new DateTime(2020, 04, 08),
                DateEnd = new DateTime(2020, 08, 20)
            });
        }
    }
}
