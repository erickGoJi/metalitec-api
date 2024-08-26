using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportEstimate
    {
        public int EstimateId { get; set; }
        public string Estimate { get; set; }
        public string EstimateDescription { get; set; }
        public string EstimateType { get; set; }
        public string EstimateStatus { get; set; }
        public byte ApplyLabourUsages { get; set; }
        public string ApplyFittings { get; set; }
        public double? FittingsWeight { get; set; }
        public double? RatePerWeight { get; set; }
        public double? HoursPerWeight { get; set; }
        public double? FabricationRatePerHour { get; set; }
        public string DefaultGrade { get; set; }
        public string LinkedToEnquiry { get; set; }
        public string Project { get; set; }
        public string DefaultPriceSource { get; set; }
        public double TotalWeight { get; set; }
        public double TotalValue { get; set; }
        public double TotalArea { get; set; }
    }
}
