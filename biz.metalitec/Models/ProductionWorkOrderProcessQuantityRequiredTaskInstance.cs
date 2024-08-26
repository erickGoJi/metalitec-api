using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionWorkOrderProcessQuantityRequiredTaskInstance
    {
        public int ProductionWorkOrderProcessQuantityId { get; set; }
        public int ProductionRequiredTaskInstanceId { get; set; }
        public bool Complete { get; set; }
        public Guid? Wipbatch { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Notes { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual ProductionRequiredTaskInstance ProductionRequiredTaskInstance { get; set; }
        public virtual ProductionWorkOrderProcessQuantity ProductionWorkOrderProcessQuantity { get; set; }
    }
}
