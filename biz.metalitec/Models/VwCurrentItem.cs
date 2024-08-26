using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwCurrentItem
    {
        public int ItemId { get; set; }
        public string ItemPartNumber { get; set; }
        public int ItemTypeId { get; set; }
        public int? ItemGroupId { get; set; }
        public int? ItemClassId { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public byte? Manufactured { get; set; }
        public string Name { get; set; }
        public string AltName { get; set; }
        public string Description { get; set; }
        public int CostCodeId { get; set; }
        public double Weight { get; set; }
        public int? RegionId { get; set; }
        public int? SectionTypeId { get; set; }
        public string SectionSize { get; set; }
        public int? GradeId { get; set; }
        public double Density { get; set; }
        public double SurfaceArea { get; set; }
        public double Depth { get; set; }
        public double Width { get; set; }
        public double Tweb { get; set; }
        public double Tflange { get; set; }
        public byte TrackingTypeId { get; set; }
        public byte TrackInventoryLevel { get; set; }
        public string Notes { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int Version { get; set; }
        public double ScrapLength { get; set; }
        public double MinimumQuantity { get; set; }
        public byte IgnoreInNest { get; set; }
        public byte ProductionTypeId { get; set; }
        public bool IgnoreForAssembly { get; set; }
        public double CrossSectionArea { get; set; }
        public double Perimeter { get; set; }
        public string TrackNumberMask { get; set; }
        public double DefaultCostUnitPrice { get; set; }
        public int DefaultCostUnitId { get; set; }
        public double DefaultSellUnitPrice { get; set; }
        public int DefaultSellUnitId { get; set; }
        public bool? CreateProductionWorkOrder { get; set; }
        public bool? BackFlush { get; set; }
        public int? DefaultInventoryUnitId { get; set; }
        public string Shape { get; set; }
    }
}
