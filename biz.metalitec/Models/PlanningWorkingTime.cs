using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class PlanningWorkingTime
    {
        public int WorkingTimeId { get; set; }
        public long FromTime { get; set; }
        public long ToTime { get; set; }
    }
}
