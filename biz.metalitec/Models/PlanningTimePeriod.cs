using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class PlanningTimePeriod
    {
        public PlanningTimePeriod()
        {
            PlanningExceptions = new HashSet<PlanningException>();
        }

        public int TimePeriodId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }

        public virtual ICollection<PlanningException> PlanningExceptions { get; set; }
    }
}
