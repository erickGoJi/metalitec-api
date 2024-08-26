using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwEstimateSearch
    {
        public int EstimateId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string EstimateType { get; set; }
        public int FacilityId { get; set; }
        public string Facility { get; set; }
        public string Currency { get; set; }
        public byte UsageEnabled { get; set; }
        public string EnquiryLink { get; set; }
        public string FittingsMode { get; set; }
        public string Status { get; set; }
        public double? FittingsPerWeight { get; set; }
        public double? RatePerWeightValue { get; set; }
        public double? HoursPerWeightValue { get; set; }
        public double? FabricationRatePerHour { get; set; }
        public string DefaultGrade { get; set; }
        public double Weight { get; set; }
        public double Area { get; set; }
        public double Value { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string Notes { get; set; }
    }
}
