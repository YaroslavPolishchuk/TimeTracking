using System.Collections.Generic;

namespace TimeTracking.Domain.Entities
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public ICollection<TrackRecord> TrackRecords { get; private set; }
    }
}
