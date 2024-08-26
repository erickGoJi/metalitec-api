using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class EstimateItemFittingProcess
    {
        public int EstimateItemFittingProcessId { get; set; }
        public int EstimateItemFittingId { get; set; }
        public int ProcessId { get; set; }
        public double HourlyRate { get; set; }
        public int Quantity { get; set; }
        public double PerUnitMinutes { get; set; }
        public double FixedMinutes { get; set; }
        public double? Minutes { get; set; }

        public virtual EstimateItemFitting EstimateItemFitting { get; set; }
        public virtual Process Process { get; set; }
    }
}
