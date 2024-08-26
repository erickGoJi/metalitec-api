using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class FacilityCalendar
    {
        public int? FacilityId { get; set; }
        public int? CalendarId { get; set; }

        public virtual PlanningCalendar Calendar { get; set; }
        public virtual Facility Facility { get; set; }
    }
}
