using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwEstimateExtraGetbyid
    {
        public int EstimateExtraId { get; set; }
        public int EstimateId { get; set; }
        public int? EstimateSubSectionId { get; set; }
        public int? ItemListingId { get; set; }
        public byte FinalExtra { get; set; }
        public int SectionRollTypeId { get; set; }
        public int RecalculateSectionRollTypeId { get; set; }
        public int? ExtraId { get; set; }
        public int CostCodeId { get; set; }
        public int ExtraCalculationTypeId { get; set; }
        public byte Addition { get; set; }
        public string Name { get; set; }
        public string ExtraType { get; set; }
        public string RollType { get; set; }
        public string RecalcRollType { get; set; }
        public string CostCode { get; set; }
        public string CalculationType { get; set; }
        public double UnitPrice { get; set; }
        public double Quantity { get; set; }
        public double? Value { get; set; }
        public double? Weight { get; set; }
        public double? Area { get; set; }
        public double? Hours { get; set; }
        public string Reference { get; set; }
        public int SortOrder { get; set; }
        public string Notes { get; set; }
    }
}
