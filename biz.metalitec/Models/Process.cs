using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class Process
    {
        public Process()
        {
            EstimateItemFittingProcesses = new HashSet<EstimateItemFittingProcess>();
            EstimateItemUsageProcesses = new HashSet<EstimateItemUsageProcess>();
            FittingProcesses = new HashSet<FittingProcess>();
            ItemUsageProcesses = new HashSet<ItemUsageProcess>();
        }

        public int ProcessId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProcessTypeId { get; set; }
        public double HourlyRate { get; set; }
        public int CostCodeId { get; set; }
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

        public virtual CostCode CostCode { get; set; }
        public virtual ICollection<EstimateItemFittingProcess> EstimateItemFittingProcesses { get; set; }
        public virtual ICollection<EstimateItemUsageProcess> EstimateItemUsageProcesses { get; set; }
        public virtual ICollection<FittingProcess> FittingProcesses { get; set; }
        public virtual ICollection<ItemUsageProcess> ItemUsageProcesses { get; set; }
    }
}
