using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class PlanningCalendar
    {
        public PlanningCalendar()
        {
            Facilities = new HashSet<Facility>();
            PlanningCalendarBaseBaseCalendars = new HashSet<PlanningCalendarBase>();
            PlanningCalendarBaseCalendars = new HashSet<PlanningCalendarBase>();
            PlanningExceptions = new HashSet<PlanningException>();
            PlanningWorkWeeks = new HashSet<PlanningWorkWeek>();
        }

        public int CalendarId { get; set; }
        public int Version { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string Name { get; set; }
        public int? CodeId { get; set; }

        public virtual ICollection<Facility> Facilities { get; set; }
        public virtual ICollection<PlanningCalendarBase> PlanningCalendarBaseBaseCalendars { get; set; }
        public virtual ICollection<PlanningCalendarBase> PlanningCalendarBaseCalendars { get; set; }
        public virtual ICollection<PlanningException> PlanningExceptions { get; set; }
        public virtual ICollection<PlanningWorkWeek> PlanningWorkWeeks { get; set; }
    }
}
