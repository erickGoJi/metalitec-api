using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionWorkOrderProcessPriority
    {
        public int ProductionWorkOrderProcessPriorityId { get; set; }
        public int ProductionWorkOrderProcessId { get; set; }
        public int? LinkId { get; set; }
        public DateTime StartDate { get; set; }
        public int Priority { get; set; }

        public virtual ProductionWorkOrderProcess ProductionWorkOrderProcess { get; set; }
    }
}
