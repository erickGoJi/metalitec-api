using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class EstimateAssemblyItemFittingProcess
    {
        public int EstimateAssemblyItemFittingProcessId { get; set; }
        public int EstimateAssemblyItemFittingId { get; set; }
        public int ProcessId { get; set; }
        public int Quantity { get; set; }
        public double PerUnitMinutes { get; set; }
        public double FixedMinutes { get; set; }
        public double Minutes { get; set; }

        public virtual EstimateAssemblyItemFitting EstimateAssemblyItemFitting { get; set; }
    }
}
