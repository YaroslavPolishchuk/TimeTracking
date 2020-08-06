using System;

namespace TimeTrackingAPI.Models
{
    public class TimeTrackingByDate : TimeTracking
    {
        public int EmployeeId { get; set; }
        public DateTime DateTrack { get; set; }
    }
}
