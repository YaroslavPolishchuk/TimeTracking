using GenericRepository;
using TimeTracking.BLL.DTO;
using TimeTracking.Domain.Entities;


namespace TimeTracking.BLL.Services
{
    public class TrackRecordService : GenericService<TrackRecord, TrackRecordDTO, int>
    {
        public TrackRecordService(IGenericRepository<TrackRecord, int> repository) : base(repository)
        {
        }
    }
}
