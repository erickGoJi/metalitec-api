using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ExtraGroup
    {
        /// <summary>
        /// The unique extra group ID number generated automatically.
        /// </summary>
        public int ExtraGroupId { get; set; }
        /// <summary>
        /// Specify a name for the extra group.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Give the extra group a description for future reference.
        /// </summary>
        public string Description { get; set; }
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
        public int FacilityId { get; set; }

        public virtual Facility Facility { get; set; }
    }
}
