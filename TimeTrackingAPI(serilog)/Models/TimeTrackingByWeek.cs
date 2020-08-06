namespace TimeTrackingAPI.Models
{
    public class TimeTrackingByWeek: TimeTracking      
    {
        public int EmployeeId { get; set; }
        public int WeekNumber { get; set; }
    }
}
