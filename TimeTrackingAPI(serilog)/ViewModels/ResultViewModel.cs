using System;

namespace TimeTrackingAPI.ViewModels
{
    public class ResultViewModel
    {
        public int TrackRecordId { get; set; }
        public int Hours { get; set; }
        public DateTime TrackDate { get; set; }
        public int WeekNumber { get; set; }
        public string EmployeeName { get; set; }
        public string ActivityName { get; set; }
        public string RoleName { get; set; }
        public string ProjectName { get; set; }
    }
}
