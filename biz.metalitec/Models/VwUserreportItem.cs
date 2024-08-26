using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportItem
    {
        public int ItemId { get; set; }
        public string ItemPartNumber { get; set; }
        public string ItemType { get; set; }
        public string ItemGroup { get; set; }
        public string ItemClass { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public byte? Manufactured { get; set; }
        public string Item { get; set; }
        public string AlternativeName { get; set; }
        public string ItemDescription { get; set; }
        public string CostCode { get; set; }
        public string CostCentre { get; set; }
        public double Weight { get; set; }
        public string Region { get; set; }
        public string SectionType { get; set; }
        public byte? Enabled { get; set; }
        public byte? HasGrades { get; set; }
        public byte? Linear { get; set; }
        public string SectionSize { get; set; }
        public string Grade { get; set; }
        public double Density { get; set; }
        public double SurfaceArea { get; set; }
        public double CrossSectionalArea { get; set; }
        public double Perimeter { get; set; }
        public double Depth { get; set; }
        public double Width { get; set; }
        public double Tweb { get; set; }
        public double Tflange { get; set; }
        public string InventoryTracking { get; set; }
        public string TrackingNumberMask { get; set; }
        public string TrackingLevel { get; set; }
        public double? ScrapLengthArea { get; set; }
        public int MinimumQuantity { get; set; }
        public string Procurement { get; set; }
        public bool? CreateProductionWorkOrder { get; set; }
        public bool? BackFlush { get; set; }
        public double DefaultPurchasingPrice { get; set; }
        public string DefaultPurchasingPriceUnit { get; set; }
        public double DefaultSellingPrice { get; set; }
        public string DefaultSellingPriceUnit { get; set; }
        public string ItemNotes { get; set; }
    }
}
