using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class DocumentPackage
    {
        public DocumentPackage()
        {
            DocumentPackageDocuments = new HashSet<DocumentPackageDocument>();
            DocumentPackageRecipients = new HashSet<DocumentPackageRecipient>();
        }

        /// <summary>
        /// The unique Document Package ID number generated automatically.
        /// </summary>
        public int DocumentPackageId { get; set; }
        /// <summary>
        /// Specify a name for the Document Package.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Give the document package a description for future reference.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The number of copies of the Documents
        /// </summary>
        public int? Copies { get; set; }
        /// <summary>
        /// Lookup the Document Transmittal Reasons
        /// </summary>
        public int? DocumentTransmittalReasonId { get; set; }
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

        public virtual DocumentTransmittalReason DocumentTransmittalReason { get; set; }
        public virtual ICollection<DocumentPackageDocument> DocumentPackageDocuments { get; set; }
        public virtual ICollection<DocumentPackageRecipient> DocumentPackageRecipients { get; set; }
    }
}
