using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemUsage
    {
        public ItemUsage()
        {
            ItemUsageFittingPercentages = new HashSet<ItemUsageFittingPercentage>();
            ItemUsageFittings = new HashSet<ItemUsageFitting>();
            ItemUsageProcesses = new HashSet<ItemUsageProcess>();
        }

        public int ItemUsageId { get; set; }
        public string Name { get; set; }
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
        public byte Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedOn { get; set; }
        public int FacilityId { get; set; }

        public virtual Facility Facility { get; set; }
        public virtual ICollection<ItemUsageFittingPercentage> ItemUsageFittingPercentages { get; set; }
        public virtual ICollection<ItemUsageFitting> ItemUsageFittings { get; set; }
        public virtual ICollection<ItemUsageProcess> ItemUsageProcesses { get; set; }
    }
}
