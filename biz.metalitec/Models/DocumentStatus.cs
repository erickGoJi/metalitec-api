using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class DocumentStatus
    {
        public DocumentStatus()
        {
            DocumentRevisions = new HashSet<DocumentRevision>();
        }

        /// <summary>
        /// The unique status type ID number generated automatically.
        /// </summary>
        public int DocumentStatusId { get; set; }
        /// <summary>
        /// Name of the Status Type
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description of the Status Type
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The percent that the Status represents
        /// </summary>
        public int? Percent { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int Version { get; set; }
        public byte? System { get; set; }
        /// <summary>
        /// Is this Document Status linked to the Approval Milestone?
        /// </summary>
        public bool? IsApproved { get; set; }
        /// <summary>
        /// Is this Document Status linked to the Reviewed Milestone?
        /// </summary>
        public bool? IsReviewed { get; set; }
        /// <summary>
        /// Is this Document Status linked to the Completed Milestone?
        /// </summary>
        public bool? IsCompleted { get; set; }

        public virtual ICollection<DocumentRevision> DocumentRevisions { get; set; }
    }
}
