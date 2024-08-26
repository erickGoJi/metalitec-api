using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class EstimateAssemblyItem
    {
        public EstimateAssemblyItem()
        {
            EstimateAssemblyItemExtras = new HashSet<EstimateAssemblyItemExtra>();
            EstimateAssemblyItemFittings = new HashSet<EstimateAssemblyItemFitting>();
            EstimateAssemblyItemUsageProcesses = new HashSet<EstimateAssemblyItemUsageProcess>();
        }

        public int EstimateAssemblyItemId { get; set; }
        public int EstimateAssemblyId { get; set; }
        public int? ItemId { get; set; }
        public int ItemListingTypeId { get; set; }
        public string Name { get; set; }
        public double QuantityPerAssembly { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Weight { get; set; }
        public double Area { get; set; }
        public bool? UseEstimatePercentages { get; set; }
        public double EstimateFittingsPerWeight { get; set; }
        public double EstimateRatePerWeightValue { get; set; }
        public double EstimateHoursPerWeightValue { get; set; }
        public int PriceSourceId { get; set; }
        public int EstimateUnitId { get; set; }
        public double UnitPrice { get; set; }
        public int CostCodeId { get; set; }
        public string Reference { get; set; }
        public int? EstimateItemUsageId { get; set; }
        public int? TempKey { get; set; }
        public int Version { get; set; }

        public virtual EstimateAssembly EstimateAssembly { get; set; }
        public virtual ICollection<EstimateAssemblyItemExtra> EstimateAssemblyItemExtras { get; set; }
        public virtual ICollection<EstimateAssemblyItemFitting> EstimateAssemblyItemFittings { get; set; }
        public virtual ICollection<EstimateAssemblyItemUsageProcess> EstimateAssemblyItemUsageProcesses { get; set; }
    }
}
