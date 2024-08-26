using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class PlanningExceptionWorkingTime
    {
        public int CalendarExceptionId { get; set; }
        public int WorkingTimeId { get; set; }

        public virtual PlanningException CalendarException { get; set; }
        public virtual PlanningWorkingTime WorkingTime { get; set; }
    }
}
