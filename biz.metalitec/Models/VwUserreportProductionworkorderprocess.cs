using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportProductionworkorderprocess
    {
        public int ProductionWorkOrderProcessId { get; set; }
        public int ProductionWorkOrderId { get; set; }
        public string ProductionStage { get; set; }
        public string ProductionProcess { get; set; }
        public int ProcessNumber { get; set; }
        public string ProductionWorkstation { get; set; }
        public string ItemLocation { get; set; }
        public string DisplayTimeUnit { get; set; }
        public double PerUnitMinutes { get; set; }
        public double FixedMinutes { get; set; }
        public string ProductionWorkOrderProcessNotes { get; set; }
        public double? QuantityAtWorkstation { get; set; }
        public double? QuantityCompleteAtWorkstation { get; set; }
        public double? QuantityScrappedAtWorkstation { get; set; }
        public double? QuantityLockedAtWorkstation { get; set; }
    }
}
