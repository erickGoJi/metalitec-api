using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class EstimateSubsectionSet
    {
        public EstimateSubsectionSet()
        {
            EstimateSubsectionSetItems = new HashSet<EstimateSubsectionSetItem>();
        }

        public int EstimateSubsectionSetId { get; set; }
        public string Name { get; set; }
        public int SetTypeId { get; set; }
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

        public virtual ICollection<EstimateSubsectionSetItem> EstimateSubsectionSetItems { get; set; }
    }
}
