using System.Collections.Generic;

namespace TimeTracking.Domain.Entities
{
    public class ActivityType
    {
        public int ActivityId { get; set; }
        public string ActivityName { get; set; }
        public ICollection<TrackRecord> TrackRecords { get; private set; }
    }
}
