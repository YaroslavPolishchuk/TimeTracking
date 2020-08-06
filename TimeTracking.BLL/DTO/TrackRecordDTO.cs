using System;
using System.Globalization;

namespace TimeTracking.BLL.DTO
{
    public class TrackRecordDTO
    {
        static DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
        Calendar cal = dfi.Calendar;
        public int TrackRecordId { get; set; }
        public int Hours { get; set; }
        public DateTime TrackDate { get; set; }
        private int weekNumber;
        public int WeekNumber
        {
            get
            {
                return weekNumber;
            }
            set
            {
                weekNumber = cal.GetWeekOfYear(TrackDate, dfi.CalendarWeekRule, dfi.FirstDayOfWeek);
            }
        }

        public int EmployeeId { get; set; }
        public int ActivityId { get; set; }
        public int RoleId { get; set; }
        public int ProjectId { get; set; }
    }
}
