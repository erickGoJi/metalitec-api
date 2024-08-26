using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionWorkStationCalendar
    {
        public int? ProductionWorkStationId { get; set; }
        public int? CalendarId { get; set; }

        public virtual PlanningCalendar Calendar { get; set; }
        public virtual ProductionWorkStation ProductionWorkStation { get; set; }
    }
}
