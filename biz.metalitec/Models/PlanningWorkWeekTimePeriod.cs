using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class PlanningWorkWeekTimePeriod
    {
        public int WorkWeekId { get; set; }
        public int TimePeriodId { get; set; }

        public virtual PlanningTimePeriod TimePeriod { get; set; }
        public virtual PlanningWorkWeek WorkWeek { get; set; }
    }
}
