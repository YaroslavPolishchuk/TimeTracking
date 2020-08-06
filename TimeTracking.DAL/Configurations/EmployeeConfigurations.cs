using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TimeTracking.Domain.Entities;

namespace TimeTracking.DAL.Configurations
{
    public class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.EmployeeId);
            builder.Property(e => e.EmployeeId).ValueGeneratedOnAdd();
            builder.Property(e => e.Name).IsRequired().HasMaxLength(54);
            builder.Property(e => e.Sex).IsRequired().HasMaxLength(10);
            builder.Property(e => e.Birthday).IsRequired().HasColumnType("Date");
            builder.HasData(
                new Employee
                {
                    EmployeeId = 1,
                    Name = "Mahmud",
                    Sex = "M",
                    Birthday = new DateTime(1999, 01, 20)
                },
                new Employee
                {
                    EmployeeId = 2,
                    Name = "Serhio",
                    Sex = "M",
                    Birthday = new DateTime(1980, 01, 12)
                },
                new Employee
                {
                    EmployeeId = 3,
                    Name = "Maria",
                    Sex = "F",
                    Birthday = new DateTime(1983, 05, 14)
                });
        }
    }
}
