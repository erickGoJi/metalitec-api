using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwDocumentSearch
    {
        public int? DocumentRevisionId { get; set; }
        public int? DocumentId { get; set; }
        public string Name { get; set; }
        public string Contract { get; set; }
        public string ContractDescription { get; set; }
        public string Customer { get; set; }
        public int? ContractId { get; set; }
        public string Revision { get; set; }
        public int? RevisionSequence { get; set; }
        public string LatestRevision { get; set; }
        public bool? Latest { get; set; }
        public int? DocumentRevisionCodeId { get; set; }
        public int DocumentKindId { get; set; }
        public string DocumentKind { get; set; }
        public string DocumentType { get; set; }
        public int? DocumentTypeId { get; set; }
        public string DocumentStatus { get; set; }
        public string ApprovalCode { get; set; }
        public int? DocumentStatusId { get; set; }
        public int? Status { get; set; }
        public string DocumentPhase { get; set; }
        public int? PhaseId { get; set; }
        public string Owner { get; set; }
        public int? OwnerId { get; set; }
        public string AltName { get; set; }
        public string Description { get; set; }
        public string Discipline { get; set; }
        public string Category { get; set; }
        public int? Key1 { get; set; }
        public int? Key2 { get; set; }
        public int? Key3 { get; set; }
        public string FileName { get; set; }
        public DateTime? Received { get; set; }
        public DateTime? Reviewed { get; set; }
        public DateTime? Approved { get; set; }
        public string DependantFile { get; set; }
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
        public string Label { get; set; }
        public int? VariationId { get; set; }
        public string Variation { get; set; }
        public int? LabelId { get; set; }
        public DateTime? RevisedOn { get; set; }
        public string RevisedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
    }
}
