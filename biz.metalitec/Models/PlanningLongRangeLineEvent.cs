using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class PlanningLongRangeLineEvent
    {
        public int PlanningLongRangeLineEventId { get; set; }
        public int PlanningLongRangeLineId { get; set; }
        public int EventTypeId { get; set; }
        public string Name { get; set; }

        public virtual PlanningLongRangeLine PlanningLongRangeLine { get; set; }
    }
}
