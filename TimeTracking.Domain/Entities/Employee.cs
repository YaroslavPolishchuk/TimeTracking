using System;
using System.Collections.Generic;

namespace TimeTracking.Domain.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public DateTime Birthday { get; set; }
        public ICollection<TrackRecord> TrackRecords { get; private set; }
    }
}
