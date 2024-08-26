using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwSystemtaskSearch
    {
        public int SystemTaskId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? TaskType { get; set; }
        public string TaskType1 { get; set; }
        public DateTime? NextRunDate { get; set; }
        public string NextRunTime { get; set; }
        public byte? Enabled { get; set; }
        public string Status { get; set; }
        public DateTime? LastRunDate { get; set; }
        public string LastRunTime { get; set; }
        public DateTime? RunFromDate { get; set; }
        public DateTime? RunToDate { get; set; }
        public string Notes { get; set; }
    }
}
