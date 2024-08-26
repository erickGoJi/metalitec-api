using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwEstimateassemblyitemExtraGetbyid
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
        public string Reference { get; set; }
        public double? Quantity { get; set; }
        public double? UnitPrice { get; set; }
        public string ExtraType { get; set; }
        public string RollType { get; set; }
        public string RecalcRollType { get; set; }
        public string CostCode { get; set; }
        public string CalculationType { get; set; }
        public int Sort { get; set; }
    }
}
