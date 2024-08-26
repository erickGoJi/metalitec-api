using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class Qsanalysis
    {
        public Qsanalysis()
        {
            Contracts = new HashSet<Contract>();
            QsanalysisCategories = new HashSet<QsanalysisCategory>();
        }

        public int QsanalysisId { get; set; }
        /// <summary>
        /// ~~1=Contract, 2=Estimating
        /// </summary>
        public byte QstypeId { get; set; }
        /// <summary>
        /// Will default to the Name of the Estimate or Contract
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// ContractID for Contract Category Analysis
        /// </summary>
        public int? ContractId { get; set; }
        /// <summary>
        /// EstimateID for Estimate Category Analysis
        /// </summary>
        public int? EstimateId { get; set; }
        /// <summary>
        /// Total Weight of all Categories
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// Total Area of all Categories
        /// </summary>
        public double Area { get; set; }
        /// <summary>
        /// Total Value of all Categories
        /// </summary>
        public double CostValue { get; set; }
        /// <summary>
        /// Total Value of all Categories
        /// </summary>
        public double SellValue { get; set; }
        /// <summary>
        /// Enter any additional notes you may wish to add about the Analysis
        /// </summary>
        public string Notes { get; set; }
        /// <summary>
        /// The record creator
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// Date the record was created.
        /// </summary>
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// The last updater
        /// </summary>
        public string UpdatedBy { get; set; }
        /// <summary>
        /// The date of the last update.
        /// </summary>
        public DateTime? UpdatedOn { get; set; }
        public int Version { get; set; }

        public virtual ICollection<Contract> Contracts { get; set; }
        public virtual ICollection<QsanalysisCategory> QsanalysisCategories { get; set; }
    }
}
