using GenericRepository;
using Microsoft.EntityFrameworkCore;
using TimeTracking.Domain.Entities;

namespace TimeTracking.DAL.Repositories
{
    public class ActivityTypeRepository : GenericRepository<ActivityType, int>
    {
        public ActivityTypeRepository(DbContext context) : base(context)
        {
        }
    }
}
