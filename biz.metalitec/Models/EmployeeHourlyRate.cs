using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class EmployeeHourlyRate
    {
        public int EmployeeHourlyRateId { get; set; }
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public bool Default { get; set; }
        public double HourlyRate { get; set; }
        public string Notes { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
