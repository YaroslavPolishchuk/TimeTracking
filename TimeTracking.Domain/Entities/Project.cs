using System;
using System.Collections.Generic;

namespace TimeTracking.Domain.Entities
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public ICollection<TrackRecord> TrackRecords { get; private set; }
    }
}
