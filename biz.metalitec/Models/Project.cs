using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class Project
    {
        public Project()
        {
            Contracts = new HashSet<Contract>();
        }

        /// <summary>
        /// The unique Project ID number generated automatically.
        /// </summary>
        public int ProjectId { get; set; }
        /// <summary>
        /// Specify a name for the Project
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Give the Project a description.
        /// </summary>
        public string Description { get; set; }
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
        public string Notes { get; set; }

        public virtual ICollection<Contract> Contracts { get; set; }
    }
}
