using GenericRepository;
using Microsoft.EntityFrameworkCore;

using TimeTracking.Domain.Entities;

namespace TimeTracking.DAL.Repositories
{
    public class RoleRepository : GenericRepository<Role, int>
    {
        public RoleRepository(DbContext context) : base(context)
        {
        }
    }
}
