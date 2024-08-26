using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemListing
    {
        public ItemListing()
        {
            EstimateItemFittings = new HashSet<EstimateItemFitting>();
            EstimateItemUsageProcesses = new HashSet<EstimateItemUsageProcess>();
        }

        public int ItemListingId { get; set; }
        public int? EstimateSubSectionId { get; set; }
        public int? ItemId { get; set; }
        public int ItemListingTypeId { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Weight { get; set; }
        public double Area { get; set; }
        public double Value { get; set; }
        public double EstimateFittingsPerWeight { get; set; }
        public double EstimateRatePerWeightValue { get; set; }
        public double EstimateHoursPerWeightValue { get; set; }
        public double UnitPrice { get; set; }
        public int EstimateUnitId { get; set; }
        public int PriceSourceId { get; set; }
        public int CostCodeId { get; set; }
        public string Reference { get; set; }
        public int? EstimateItemUsageId { get; set; }
        public int? TempKey { get; set; }
        public int Version { get; set; }
        public bool IsAssemblyItem { get; set; }
        public string AssemblyGuid { get; set; }
        public string AssemblyName { get; set; }
        public string AssemblyDescription { get; set; }
        public double AssemblyQuantity { get; set; }
        public double QuantityPerAssembly { get; set; }
        public byte? ReviewedRateId { get; set; }
        public int? LineNumber { get; set; }
        public string PaintFinish { get; set; }
        public string Phase { get; set; }
        public string Notes { get; set; }

        public virtual CostCode CostCode { get; set; }
        public virtual Unit EstimateUnit { get; set; }
        public virtual ICollection<EstimateItemFitting> EstimateItemFittings { get; set; }
        public virtual ICollection<EstimateItemUsageProcess> EstimateItemUsageProcesses { get; set; }
    }
}
