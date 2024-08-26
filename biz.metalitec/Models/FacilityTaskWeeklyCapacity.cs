using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class FacilityTaskWeeklyCapacity
    {
        public int FacilityTaskWeeklyCapacityId { get; set; }
        public int FacilityId { get; set; }
        public int LocationId { get; set; }
        public int TaskId { get; set; }
        public double WeeklyCapacityWeight { get; set; }
        public double WeeklyCapacityMins { get; set; }
        public int? ShiftId { get; set; }

        public virtual Facility Facility { get; set; }
        public virtual ItemLocation Location { get; set; }
    }
}
