using GenericRepository;
using Microsoft.EntityFrameworkCore;

using TimeTracking.Domain.Entities;

namespace TimeTracking.DAL.Repositories
{
    public class TrackRecordRepository : GenericRepository<TrackRecord, int>
    {
        public TrackRecordRepository(DbContext context) : base(context)
        {
        }
    }
}
