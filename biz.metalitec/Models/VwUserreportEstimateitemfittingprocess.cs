using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportEstimateitemfittingprocess
    {
        public int EstimateItemFittingId { get; set; }
        public int ItemListingId { get; set; }
        public int FittingId { get; set; }
        public int ItemId { get; set; }
        public string Item { get; set; }
        public string SectionType { get; set; }
        public string Grade { get; set; }
        public int Quantity { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Weight { get; set; }
        public double Area { get; set; }
        public double Value { get; set; }
        public double UnitPrice { get; set; }
        public string PriceUnit { get; set; }
        public string PriceSource { get; set; }
        public string CostCode { get; set; }
        public string CostCentre { get; set; }
        public string Process { get; set; }
        public int? ProcessQuantity { get; set; }
        public string ProcessUnitType { get; set; }
        public double? SetupTime { get; set; }
        public double? UnitTimeMins { get; set; }
    }
}
