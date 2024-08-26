using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class EstimateAssemblyItemUsageProcess
    {
        public int EstimateAssemblyItemUsageProcessId { get; set; }
        public int EstimateAssemblyItemId { get; set; }
        public int ProcessId { get; set; }
        public int Quantity { get; set; }
        public double PerUnitMinutes { get; set; }
        public double FixedMinutes { get; set; }
        public double Minutes { get; set; }

        public virtual EstimateAssemblyItem EstimateAssemblyItem { get; set; }
    }
}
