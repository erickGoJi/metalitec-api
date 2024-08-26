using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class Document
    {
        public Document()
        {
            ApplicationForPaymentCorrespondences = new HashSet<ApplicationForPaymentCorrespondence>();
            ChangeOrderClientDocumentLinks = new HashSet<ChangeOrderClientDocumentLink>();
            DocumentPackageDocuments = new HashSet<DocumentPackageDocument>();
            DocumentRevisions = new HashSet<DocumentRevision>();
        }

        /// <summary>
        /// The unique document ID number generated automatically.
        /// </summary>
        public int DocumentId { get; set; }
        /// <summary>
        /// Unique Contract ID this Document is associated with.
        /// </summary>
        public int ContractId { get; set; }
        /// <summary>
        /// The identifier for this document.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The title of the document.
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
        /// <summary>
        /// Sets the Document Kind
        /// </summary>
        public int DocumentKindId { get; set; }
        public int? Tempkey { get; set; }

        public virtual Contract Contract { get; set; }
        public virtual ICollection<ApplicationForPaymentCorrespondence> ApplicationForPaymentCorrespondences { get; set; }
        public virtual ICollection<ChangeOrderClientDocumentLink> ChangeOrderClientDocumentLinks { get; set; }
        public virtual ICollection<DocumentPackageDocument> DocumentPackageDocuments { get; set; }
        public virtual ICollection<DocumentRevision> DocumentRevisions { get; set; }
    }
}
