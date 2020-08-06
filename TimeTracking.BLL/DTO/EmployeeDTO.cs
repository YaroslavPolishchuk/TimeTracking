using System;

namespace TimeTracking.BLL.DTO
{
    public class EmployeeDTO
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public DateTime Birthday { get; set; }
    }
}
