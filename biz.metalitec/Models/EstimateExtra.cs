using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class EstimateExtra
    {
        /// <summary>
        /// Unique Estimate Extra ID number.
        /// </summary>
        public int EstimateExtraId { get; set; }
        public int EstimateId { get; set; }
        public int? EstimateSubSectionId { get; set; }
        public int? ItemListingId { get; set; }
        public byte FinalExtra { get; set; }
        public int SectionRollTypeId { get; set; }
        public int RecalculateSectionRollTypeId { get; set; }
        public int? ExtraId { get; set; }
        /// <summary>
        /// Material or Labour
        /// </summary>
        public int ExtraTypeId { get; set; }
        public byte Addition { get; set; }
        /// <summary>
        /// Name of the Estimate Extra
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Cost code the extra should be priced under.
        /// </summary>
        public int CostCodeId { get; set; }
        /// <summary>
        /// Type of calculation the Extra is based on.
        /// </summary>
        public int ExtraCalculationTypeId { get; set; }
        public double UnitPrice { get; set; }
        public double Quantity { get; set; }
        public double? Value { get; set; }
        public double? Hours { get; set; }
        public double? Weight { get; set; }
        public double? Area { get; set; }
        public string Reference { get; set; }
        public string ReportDescription { get; set; }
        public int SortOrder { get; set; }
        public int? ItemExtraRateId { get; set; }
        public string Notes { get; set; }

        public virtual CostCode CostCode { get; set; }
        public virtual Estimate Estimate { get; set; }
        public virtual EstimateItemExtraRate ItemExtraRate { get; set; }
        public virtual SectionRollType SectionRollType { get; set; }
    }
}
