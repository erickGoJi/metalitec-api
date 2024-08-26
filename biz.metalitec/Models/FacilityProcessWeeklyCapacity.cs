using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class FacilityProcessWeeklyCapacity
    {
        public int FacilityProcessWeeklyCapacityId { get; set; }
        public int FacilityId { get; set; }
        public int ItemLocationId { get; set; }
        public int ProductionProcessId { get; set; }
        public double WeeklyCapacityMins { get; set; }

        public virtual Facility Facility { get; set; }
        public virtual ItemLocation ItemLocation { get; set; }
        public virtual ProductionProcess ProductionProcess { get; set; }
    }
}
