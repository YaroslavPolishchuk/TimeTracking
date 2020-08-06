using GenericRepository;
using TimeTracking.BLL.DTO;
using TimeTracking.Domain.Entities;

namespace TimeTracking.BLL.Services
{
    public class ActivityTypeService : GenericService<ActivityType, ActivityTypeDTO, int>
    {
        public ActivityTypeService(IGenericRepository<ActivityType, int> repository) : base(repository)
        {
        }
    }
}
