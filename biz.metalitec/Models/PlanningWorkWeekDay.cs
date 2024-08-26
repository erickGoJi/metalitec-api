using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class PlanningWorkWeekDay
    {
        public int WorkWeekDayId { get; set; }
        public int DayOfWeek { get; set; }
        public bool IsNonWorkingDay { get; set; }
        public int? WorkWeekId { get; set; }

        public virtual PlanningWorkWeek WorkWeek { get; set; }
    }
}
