using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportEstimateitemusageprocess
    {
        public int EstimateItemUsageProcessId { get; set; }
        public int ItemListingId { get; set; }
        public string Process { get; set; }
        public string ProcessDescription { get; set; }
        public string ProcessType { get; set; }
        public double HourlyRate { get; set; }
        public string CostCode { get; set; }
        public string CostCentre { get; set; }
        public int ProcessQuantity { get; set; }
        public double UnitTimeMins { get; set; }
        public double SetupTime { get; set; }
        public double ProcessHourlyRate { get; set; }
        public double Minutes { get; set; }
    }
}
