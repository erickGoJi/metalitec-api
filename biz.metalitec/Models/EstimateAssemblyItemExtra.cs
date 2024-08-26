using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class EstimateAssemblyItemExtra
    {
        public int EstimateAssemblyItemExtraId { get; set; }
        public int EstimateAssemblyItemId { get; set; }
        public int ExtraId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int EstimateTypeId { get; set; }
        public int ExtraTypeId { get; set; }
        public byte? Addition { get; set; }
        public int RecalculateSectionRollTypeId { get; set; }
        public int CostCodeId { get; set; }
        public int SectionRollTypeId { get; set; }
        public int ExtraCalculationTypeId { get; set; }
        public int? ItemExtraRateId { get; set; }
        public double? Quantity { get; set; }
        public double? UnitPrice { get; set; }
        public string Reference { get; set; }
        public int Sort { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public int Version { get; set; }

        public virtual EstimateAssemblyItem EstimateAssemblyItem { get; set; }
        public virtual EstimateItemExtraRate ItemExtraRate { get; set; }
    }
}
