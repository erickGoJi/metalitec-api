using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportDocumentRfiDocument
    {
        public int OccurenceId { get; set; }
        public int DocumentTransmittalId { get; set; }
        public int? DocumentRevisionId { get; set; }
        public int? ContractId { get; set; }
        public string Contract { get; set; }
        public string DocumentKind { get; set; }
        public string Document { get; set; }
        public string DocumentDescription { get; set; }
        public string DocumentRevisionCode { get; set; }
        public string RevisedBy { get; set; }
        public DateTime? RevisedOn { get; set; }
        public string RevisionDetails { get; set; }
        public string DocumentType { get; set; }
        public string DocumentStatus { get; set; }
        public DateTime? Received { get; set; }
        public string DocumentDiscipline { get; set; }
        public DateTime? Reviewed { get; set; }
        public DateTime? Approved { get; set; }
        public DateTime? RequiredBy { get; set; }
        public string DocumentCategory { get; set; }
        public string FileName { get; set; }
        public string DocumentSize { get; set; }
        public string DocumentRevisionNotes { get; set; }
        public DateTime? Completed { get; set; }
        public double? FileSize { get; set; }
        public DateTime? FileCreatedOn { get; set; }
        public DateTime? FileUpdatedOn { get; set; }
        public string DependantFileName { get; set; }
        public string ApprovalCode { get; set; }
    }
}
