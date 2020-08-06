using GenericRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TimeTracking.BLL.DTO;
using TimeTracking.BLL.Services;
using TimeTracking.DAL.Context;
using TimeTracking.DAL.Repositories;
using TimeTracking.Domain.Entities;

namespace TimeTracking.BLL
{
    public static class DI
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services, IConfiguration cfg)
        {
            string connection = cfg.GetConnectionString("DefaultConnection");
            services.AddTransient<IGenericRepository<Project, int>, ProjectRepository>();
            services.AddTransient<IGenericService<ProjectDTO, int>, ProjectService>();

            services.AddTransient<IGenericRepository<ActivityType, int>, ActivityTypeRepository>();
            services.AddTransient<IGenericService<ActivityTypeDTO, int>, ActivityTypeService>();

            services.AddTransient<IGenericRepository<Employee, int>, EmployeeRepository>();
            services.AddTransient<IGenericService<EmployeeDTO, int>, EmployeeService>();

            services.AddTransient<IGenericRepository<Role, int>, RoleRepository>();
            services.AddTransient<IGenericService<RoleDTO, int>, RoleService>();

            services.AddTransient<IGenericRepository<TrackRecord, int>, TrackRecordRepository>();
            services.AddTransient<IGenericService<TrackRecordDTO, int>, TrackRecordService>();

            services.AddTransient<DbContext, TimeTrackingContext>();
            services.AddDbContext<TimeTrackingContext>(x => x.UseSqlServer(connection));

            return services;
        }
    }
}
