using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwEstimateFittingGetbyid
    {
        public int EstimateItemFittingId { get; set; }
        public int ItemListingId { get; set; }
        public int? FittingId { get; set; }
        public int? ItemId { get; set; }
        public string Name { get; set; }
        public string Item { get; set; }
        public int Quantity { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Weight { get; set; }
        public double Area { get; set; }
        public double Value { get; set; }
        public double UnitPrice { get; set; }
        public int UnitId { get; set; }
        public string CostCode { get; set; }
        public string Unit { get; set; }
        public int FittingTypeId { get; set; }
        public string Notes { get; set; }
        public bool LabourUsage { get; set; }
        public string Reference { get; set; }
    }
}
