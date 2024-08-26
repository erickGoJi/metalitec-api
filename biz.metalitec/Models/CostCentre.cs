using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class CostCentre
    {
        public CostCentre()
        {
            CostCodes = new HashSet<CostCode>();
        }

        /// <summary>
        /// The unique cost centre ID number generated automatically.
        /// </summary>
        public int CostCentreId { get; set; }
        /// <summary>
        /// Specify a name for the cost centre.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Give the cost centre a description.
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
        public int System { get; set; }

        public virtual ICollection<CostCode> CostCodes { get; set; }
    }
}
