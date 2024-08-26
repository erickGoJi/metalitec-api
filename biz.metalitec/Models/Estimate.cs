using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class Estimate
    {
        public Estimate()
        {
            ChangeOrderValuations = new HashSet<ChangeOrderValuation>();
            EstimateCadlistings = new HashSet<EstimateCadlisting>();
            EstimateEnquiries = new HashSet<EstimateEnquiry>();
            EstimateExtras = new HashSet<EstimateExtra>();
            EstimateSubSections = new HashSet<EstimateSubSection>();
        }

        /// <summary>
        /// The unique estimate ID number generated automatically.
        /// </summary>
        public int EstimateId { get; set; }
        /// <summary>
        /// Specify a name for the estimate.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Give the estimate a description.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Select the estimate type; take off or bill of quantities.
        /// </summary>
        public int EstimateType { get; set; }
        /// <summary>
        /// Labour Matrix usage setting
        /// </summary>
        public byte UsageEnabled { get; set; }
        /// <summary>
        /// Define the fittings mode for the estimate.
        /// </summary>
        public int FittingsMode { get; set; }
        /// <summary>
        /// Add a percentage of the overall estimate weight to account for fittings.
        /// </summary>
        public double? FittingsPerWeight { get; set; }
        /// <summary>
        /// The estimate rate over weight value
        /// </summary>
        public double? RatePerWeightValue { get; set; }
        /// <summary>
        /// The estimate hours over weight value
        /// </summary>
        public double? HoursPerWeightValue { get; set; }
        /// <summary>
        /// Enter the fabrication rate per hour for the estimate.
        /// </summary>
        public double? FabricationRatePerHour { get; set; }
        /// <summary>
        /// Select a default grade for the estimate.
        /// </summary>
        public int? DefaultGradeId { get; set; }
        /// <summary>
        /// The final estimate weight
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// The final estimate value
        /// </summary>
        public double Value { get; set; }
        /// <summary>
        /// The final Estimate Area
        /// </summary>
        public double Area { get; set; }
        public string User1 { get; set; }
        public string User2 { get; set; }
        public string User3 { get; set; }
        public string User4 { get; set; }
        public string User5 { get; set; }
        public string User6 { get; set; }
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
        public byte? System { get; set; }
        public int DefaultPriceSourceId { get; set; }
        public int StatusId { get; set; }
        public bool AutomaticallyApplyLabourUsage { get; set; }
        public bool AssociateFittingsWithItems { get; set; }
        public string CadPath { get; set; }
        public string CamPath { get; set; }
        public string StruWalkerPath { get; set; }
        public int FacilityId { get; set; }
        /// <summary>
        /// ~~(1=Off, 2=Automatic By Estimate, 3=Automatic By Subsection, 4=Manual)
        /// </summary>
        public byte DefaultApplyLineNumber { get; set; }
        public int Increment { get; set; }
        public int NextNumber { get; set; }
        public int StartNumber { get; set; }
        public bool? ShowFittingsWithSections { get; set; }
        public string Notes { get; set; }

        public virtual Facility Facility { get; set; }
        public virtual ICollection<ChangeOrderValuation> ChangeOrderValuations { get; set; }
        public virtual ICollection<EstimateCadlisting> EstimateCadlistings { get; set; }
        public virtual ICollection<EstimateEnquiry> EstimateEnquiries { get; set; }
        public virtual ICollection<EstimateExtra> EstimateExtras { get; set; }
        public virtual ICollection<EstimateSubSection> EstimateSubSections { get; set; }
    }
}
