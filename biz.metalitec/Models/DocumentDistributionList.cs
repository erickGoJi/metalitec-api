using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class DocumentDistributionList
    {
        public DocumentDistributionList()
        {
            DocumentDistributionListRecipients = new HashSet<DocumentDistributionListRecipient>();
        }

        /// <summary>
        /// The unique Distribution List type ID number generated automatically.
        /// </summary>
        public int DocumentDistributionListId { get; set; }
        /// <summary>
        /// Specify a name for the Distribution List.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Give the distribution list a description for future reference.
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
        public string Notes { get; set; }

        public virtual ICollection<DocumentDistributionListRecipient> DocumentDistributionListRecipients { get; set; }
    }
}
