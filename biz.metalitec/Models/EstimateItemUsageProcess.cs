using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class EstimateItemUsageProcess
    {
        public int EstimateItemUsageProcessId { get; set; }
        public int ItemListingId { get; set; }
        public int ProcessId { get; set; }
        public double HourlyRate { get; set; }
        public int Quantity { get; set; }
        public double PerUnitMinutes { get; set; }
        public double FixedMinutes { get; set; }
        public double? Minutes { get; set; }

        public virtual ItemListing ItemListing { get; set; }
        public virtual Process Process { get; set; }
    }
}
