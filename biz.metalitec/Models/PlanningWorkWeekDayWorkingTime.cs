using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class PlanningWorkWeekDayWorkingTime
    {
        public int WorkWeekDayId { get; set; }
        public int WorkingTimeId { get; set; }

        public virtual PlanningWorkWeekDay WorkWeekDay { get; set; }
        public virtual PlanningWorkingTime WorkingTime { get; set; }
    }
}
