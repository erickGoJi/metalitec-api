using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwItemSearch
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string ItemType { get; set; }
        public int ItemTypeId { get; set; }
        public string AlternativeName { get; set; }
        public string Description { get; set; }
        public string SectionType { get; set; }
        public int? SectionTypeId { get; set; }
        public int? GradeId { get; set; }
        public string Grade { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string ItemGroup { get; set; }
        public int? ItemGroupId { get; set; }
        public string ItemClass { get; set; }
        public int? ItemClassId { get; set; }
        public string CostCode { get; set; }
        public string Region { get; set; }
        public string RollType { get; set; }
        public string TrackingType { get; set; }
        public double Depth { get; set; }
        public double Width { get; set; }
        public double RootRadius { get; set; }
        public double WebThickness { get; set; }
        public double FlangeThickness { get; set; }
        public double SurfaceArea { get; set; }
        public double WeightPer { get; set; }
        public int WeightCalcTypeId { get; set; }
        public string Procurement { get; set; }
        public bool? CreateProductionWorkOrder { get; set; }
        public string DefaultInventoryUnit { get; set; }
        public double DefaultPurchasingPrice { get; set; }
        public string DefaultPurchaseUnit { get; set; }
        public double DefaultSellingPrice { get; set; }
        public string DefaultSellingUnit { get; set; }
        public int ScrapCostCodeId { get; set; }
        public string WasteScrapCostCode { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool? AlwaysDisplayIndividualInstancesWhenNesting { get; set; }
        public byte? Linear { get; set; }
        public string ScrapType { get; set; }
        public int? ScrapTypeId { get; set; }
        public string Notes { get; set; }
    }
}
