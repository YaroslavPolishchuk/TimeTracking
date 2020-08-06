using System;

namespace TimeTracking.Domain.Entities
{
    public class TrackRecord
    {
        public int TrackRecordId { get; set; }
        public int Hours { get; set; }
        public DateTime TrackDate { get; set; }
        public int WeekNumber { get; set; }
        public int EmployeeId { get; set; }
        public int ActivityId { get; set; }
        public int RoleId { get; set; }
        public int ProjectId { get; set; }
        public ActivityType ActivityType { get; set; }
        public Employee Employee { get; set; }
        public Project Project { get; set; }
        public Role Role { get; set; }

    }
}
