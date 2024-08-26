using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwEstimateItemListingLiteGetbyid
    {
        public int ItemListingId { get; set; }
        public int? EstimateSubSectionId { get; set; }
        public int? ItemId { get; set; }
        public int ItemListingTypeId { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Area { get; set; }
        public double Value { get; set; }
        public double Weight { get; set; }
        public double UnitPrice { get; set; }
        public int EstimateUnitId { get; set; }
        public string EstimateUnit { get; set; }
        public int PriceSourceId { get; set; }
        public string ItemListingType { get; set; }
    }
}
