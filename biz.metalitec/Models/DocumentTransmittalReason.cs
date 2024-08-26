using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class DocumentTransmittalReason
    {
        public DocumentTransmittalReason()
        {
            DocumentPackages = new HashSet<DocumentPackage>();
            DocumentTransmittalRevisions = new HashSet<DocumentTransmittalRevision>();
        }

        /// <summary>
        /// The unique Transmittal Reason ID number generated automatically.
        /// </summary>
        public int DocumentTransmittalReasonId { get; set; }
        /// <summary>
        /// Specify a name for the Transmittal Reason.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Give the Transmittal Reason a description for future reference.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The sequence the Reasons appear in
        /// </summary>
        public int? Sequence { get; set; }
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
        public bool Default { get; set; }

        public virtual ICollection<DocumentPackage> DocumentPackages { get; set; }
        public virtual ICollection<DocumentTransmittalRevision> DocumentTransmittalRevisions { get; set; }
    }
}
