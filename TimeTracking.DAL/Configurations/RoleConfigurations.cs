using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TimeTracking.Domain.Entities;

namespace TimeTracking.DAL.Configurations
{
    public class RoleConfigurations : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(e => e.RoleId);
            builder.Property(e => e.RoleId).ValueGeneratedOnAdd();
            builder.Property(e => e.RoleName).IsRequired().HasMaxLength(54);
            builder.HasData(
                new Role
                {
                    RoleId = 1,
                    RoleName = "Software engineer"
                },
                new Role
                {
                    RoleId = 2,
                    RoleName = "Software architect"
                },
                new Role
                {
                    RoleId = 3,
                    RoleName = "Team lead"
                },
                new Role
                {
                    RoleId = 4,
                    RoleName = "Business analyst"
                });
        }
    }
}
