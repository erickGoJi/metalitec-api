using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class PlanningLongRangeLine
    {
        public PlanningLongRangeLine()
        {
            PlanningLongRangeLineEvents = new HashSet<PlanningLongRangeLineEvent>();
            PlanningLongRangeLineLotLinks = new HashSet<PlanningLongRangeLineLotLink>();
        }

        public int PlanningLongRangeLineId { get; set; }
        public int PlanningLongRangeId { get; set; }
        public int? WeekNumber { get; set; }
        public DateTime? StartDate { get; set; }
        public double? Minutes { get; set; }
        public double? Weight { get; set; }
        public int? Version { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual PlanningLongRange PlanningLongRange { get; set; }
        public virtual ICollection<PlanningLongRangeLineEvent> PlanningLongRangeLineEvents { get; set; }
        public virtual ICollection<PlanningLongRangeLineLotLink> PlanningLongRangeLineLotLinks { get; set; }
    }
}
