using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class PlanningCalendarBase
    {
        public int PlanningCalendarBaseId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int CalendarId { get; set; }
        public int BaseCalendarId { get; set; }

        public virtual PlanningCalendar BaseCalendar { get; set; }
        public virtual PlanningCalendar Calendar { get; set; }
    }
}
