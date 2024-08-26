using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class Extra
    {
        /// <summary>
        /// The unique extra ID number generated automatically.
        /// </summary>
        public int ExtraId { get; set; }
        /// <summary>
        /// Specify a name for the extra.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Give the extra a description for future reference.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Define the estimate type; take off or bill of quantities.
        /// </summary>
        public int EstimateTypeId { get; set; }
        /// <summary>
        /// Define whether the extra is a material or labour extra.
        /// </summary>
        public int ExtraTypeId { get; set; }
        /// <summary>
        /// Specify whether the value of the extra is to be added to or subtracted from the estimate. 
        /// </summary>
        public byte? Addition { get; set; }
        /// <summary>
        /// Select from list the roll type this extra should be applied to.
        /// </summary>
        public int RecalculateSectionRollTypeId { get; set; }
        /// <summary>
        /// Specify the cost code under which the extra will be priced.
        /// </summary>
        public int CostCodeId { get; set; }
        /// <summary>
        /// Define a roll type for the extra.
        /// </summary>
        public int SectionRollTypeId { get; set; }
        /// <summary>
        /// Select the type of calculation on which this extra should be based.
        /// </summary>
        public int ExtraCalculationTypeId { get; set; }
        /// <summary>
        /// Specify a default quantity for the extra.
        /// </summary>
        public double? Quantity { get; set; }
        /// <summary>
        /// Specify a rate for the extra.
        /// </summary>
        public double? UnitPrice { get; set; }
        /// <summary>
        /// The date of the last update.
        /// </summary>
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// The last updater
        /// </summary>
        public string UpdatedBy { get; set; }
        /// <summary>
        /// Date the record was created.
        /// </summary>
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// The record creator
        /// </summary>
        public string CreatedBy { get; set; }
        public int Version { get; set; }
        public int? ItemExtraRateId { get; set; }
        public int FacilityId { get; set; }

        public virtual CostCode CostCode { get; set; }
        public virtual ExtraCalculationType ExtraCalculationType { get; set; }
        public virtual Facility Facility { get; set; }
        public virtual EstimateItemExtraRate ItemExtraRate { get; set; }
        public virtual SectionRollType SectionRollType { get; set; }
    }
}
