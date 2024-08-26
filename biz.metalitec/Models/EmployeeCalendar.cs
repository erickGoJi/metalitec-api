using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class EmployeeCalendar
    {
        public int EmployeeId { get; set; }
        public int CalendarId { get; set; }

        public virtual PlanningCalendar Calendar { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
