using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class DocumentRevision
    {
        public DocumentRevision()
        {
            DocumentRevisionFiles = new HashSet<DocumentRevisionFile>();
            DocumentTransmittalDocuments = new HashSet<DocumentTransmittalDocument>();
        }

        public int DocumentRevisionId { get; set; }
        public int DocumentId { get; set; }
        public int DocumentRevisionCodeId { get; set; }
        public string RevisedBy { get; set; }
        public DateTime? RevisedOn { get; set; }
        public string RevisionDetails { get; set; }
        public int? DocumentTypeId { get; set; }
        public int? DocumentStatusId { get; set; }
        /// <summary>
        /// Document Has been Received on this Date.
        /// </summary>
        public DateTime? Received { get; set; }
        public int? DisciplineId { get; set; }
        /// <summary>
        /// Document Has been Reviewed on this Date.
        /// </summary>
        public DateTime? Reviewed { get; set; }
        /// <summary>
        /// Document Has been Approved on this Date.
        /// </summary>
        public DateTime? Approved { get; set; }
        /// <summary>
        /// This document should be completed by this date.
        /// </summary>
        public DateTime? RequiredBy { get; set; }
        public string AlternativeName { get; set; }
        public int? CategoryId { get; set; }
        public string FileName { get; set; }
        public int? SizeId { get; set; }
        public string Notes { get; set; }
        /// <summary>
        /// Is this the latest revision of the document
        /// </summary>
        public bool? Latest { get; set; }
        /// <summary>
        /// The Contract Phase of the Document
        /// </summary>
        public int? PhaseId { get; set; }
        /// <summary>
        /// Has this document been completed?
        /// </summary>
        public DateTime? Completed { get; set; }
        /// <summary>
        /// Who owns the document
        /// </summary>
        public int? ContactId { get; set; }
        public double? FileSize { get; set; }
        public DateTime? FileCreatedOn { get; set; }
        public DateTime? FileUpdatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string DependantFileName { get; set; }
        /// <summary>
        /// Used to Define the Status of the Revision in imports/updates
        /// </summary>
        public int? StatusId { get; set; }
        /// <summary>
        /// The Approval Code of the Document Status
        /// </summary>
        public int? ApprovalCodeId { get; set; }
        public string DrawingMark { get; set; }
        public string DrawingDescription { get; set; }
        public string DrawingLength { get; set; }
        public int? DrawingQuantity { get; set; }
        public string DrawingFormat { get; set; }
        public string DrawingRevision { get; set; }
        public DateTime? DrawingDate { get; set; }
        public DateTime? DrawingIssue { get; set; }
        public string DrawingScale { get; set; }
        public string DrawingType { get; set; }
        public string DrawingModified { get; set; }
        public string DrawingStamp { get; set; }
        public string DrawingViewerStatus { get; set; }
        public string DrawingNested { get; set; }
        public string DrawingPrintFlag { get; set; }
        public int? ImportNumber { get; set; }
        public int? ChangeOrderId { get; set; }
        public int? LabelId { get; set; }

        public virtual ChangeOrder ChangeOrder { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual Document Document { get; set; }
        public virtual DocumentRevisionCode DocumentRevisionCode { get; set; }
        public virtual DocumentStatus DocumentStatus { get; set; }
        public virtual DocumentType DocumentType { get; set; }
        public virtual ContractPhase Phase { get; set; }
        public virtual ICollection<DocumentRevisionFile> DocumentRevisionFiles { get; set; }
        public virtual ICollection<DocumentTransmittalDocument> DocumentTransmittalDocuments { get; set; }
    }
}
