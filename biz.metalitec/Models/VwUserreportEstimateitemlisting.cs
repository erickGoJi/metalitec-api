using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportEstimateitemlisting
    {
        public int ItemListingId { get; set; }
        public int? EstimateSubSectionId { get; set; }
        public string Subsection { get; set; }
        public int? ItemId { get; set; }
        public string Item { get; set; }
        public string SectionType { get; set; }
        public string Grade { get; set; }
        public string ItemListingType { get; set; }
        public double Quantity { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double ShaftWeight { get; set; }
        public double Area { get; set; }
        public double ShaftValue { get; set; }
        public double FittingsPerWeight { get; set; }
        public double RatePerWeightValue { get; set; }
        public double HoursPerWeightValue { get; set; }
        public double UnitPrice { get; set; }
        public string PriceUnit { get; set; }
        public string PriceSource { get; set; }
        public string CostCode { get; set; }
        public string CostCentre { get; set; }
        public string Reference { get; set; }
        public int? ItemUsageId { get; set; }
    }
}
