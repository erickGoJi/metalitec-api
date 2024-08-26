using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionWorkOrderProcessRequiredTaskInstance
    {
        public int ProductionWorkOrderProcessId { get; set; }
        public int ProductionRequiredTaskInstanceId { get; set; }

        public virtual ProductionRequiredTaskInstance ProductionRequiredTaskInstance { get; set; }
        public virtual ProductionWorkOrderProcess ProductionWorkOrderProcess { get; set; }
    }
}
