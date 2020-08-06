using GenericRepository;
using Microsoft.EntityFrameworkCore;
using TimeTracking.Domain.Entities;

namespace TimeTracking.DAL.Repositories
{
    public class ProjectRepository : GenericRepository<Project, int>
    {
        public ProjectRepository(DbContext context) : base(context)
        {
        }
    }
}
