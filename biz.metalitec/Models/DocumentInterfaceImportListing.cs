using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class DocumentInterfaceImportListing
    {
        public int DocumentInterfaceImportListingId { get; set; }
        public bool? Ignore { get; set; }
        public string ContractId { get; set; }
        public string SourceName { get; set; }
        public string SourceDescription { get; set; }
        public string SourceRevision { get; set; }
        public string SourceDocumentType { get; set; }
        public string SourceDocumentStatus { get; set; }
        public string SourceFilePath { get; set; }
        public string SourceFileSize { get; set; }
        public string SourceFileCreatedOn { get; set; }
        public string SourceLastModified { get; set; }
        public int? DocumentStatusId { get; set; }
        public int? DocumentTypeId { get; set; }
        public int? DocumentRevisionCodeId { get; set; }
        public int? DocumentRevisionId { get; set; }
        public string CurrentRevision { get; set; }
        public int? StatusId { get; set; }
        /// <summary>
        /// Identify to the current user
        /// </summary>
        public string SessionGuid { get; set; }
        /// <summary>
        /// The owner of the document
        /// </summary>
        public int? ContactId { get; set; }
        public string SourceContact { get; set; }
        public string SourceFileName { get; set; }
        public int? DocumentKindId { get; set; }
        public string DependantFileName { get; set; }
        public int? PhaseId { get; set; }
        public string Phase { get; set; }
        public string DrawingMark { get; set; }
        public string DrawingDescription { get; set; }
        public string DrawingLength { get; set; }
        public string DrawingQuantity { get; set; }
        public string DrawingFormat { get; set; }
        public string DrawingRevision { get; set; }
        public string DrawingDate { get; set; }
        public string DrawingIssue { get; set; }
        public string DrawingScale { get; set; }
        public string DrawingType { get; set; }
        public string DrawingModified { get; set; }
        public string DrawingStamp { get; set; }
        public string DrawingViewerStatus { get; set; }
        public string DrawingNested { get; set; }
        public string DrawingPrintFlag { get; set; }
        public string SourceAlternativeName { get; set; }
        public string StorageLocationPath { get; set; }
        public string SourceMarkItemGuid { get; set; }
        public int? ChangeOrderId { get; set; }
        public int? LabelId { get; set; }
        public string SourceRevisionOriginal { get; set; }

        public virtual ChangeOrder ChangeOrder { get; set; }
    }
}
