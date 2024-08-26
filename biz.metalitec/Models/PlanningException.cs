using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class PlanningException
    {
        public int CalendarExceptionId { get; set; }
        public int Version { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string Name { get; set; }
        public bool? IsNonWorking { get; set; }
        public int? TimePeriodId { get; set; }
        public int? CalendarId { get; set; }

        public virtual PlanningCalendar Calendar { get; set; }
        public virtual PlanningTimePeriod TimePeriod { get; set; }
    }
}
