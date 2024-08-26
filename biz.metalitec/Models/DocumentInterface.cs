using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class DocumentInterface
    {
        /// <summary>
        /// Unique Identifier of Document Interface
        /// </summary>
        public int DocumentInterfaceId { get; set; }
        /// <summary>
        /// Name of Document Interface
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description of Document Interface
        /// </summary>
        public string Description { get; set; }
        public string FileExtention { get; set; }
        public string DefaultFilePath { get; set; }
        public string MappingName { get; set; }
        public string MappingRevision { get; set; }
        public string MappingDocumentType { get; set; }
        public string MappingDocumentStatus { get; set; }
        public string MappingFileName { get; set; }
        public string MappingFileCreatedOn { get; set; }
        public string MappingFileUpdatedOn { get; set; }
        public string MappingFileSize { get; set; }
        public string MappingDescription { get; set; }
        public string Script { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? Version { get; set; }
        public byte? System { get; set; }
        public string MappingOwner { get; set; }
        public int DocumentKindId { get; set; }
        public string MappingDependantFileName { get; set; }
        /// <summary>
        /// Is this reading from a Specific file or a Directory?
        /// </summary>
        public bool? SpecificFile { get; set; }
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
        public string Phase { get; set; }
        public string MappingDocumentKindId { get; set; }
        public string MappingAlternativeName { get; set; }
        public string StorageLocationPath { get; set; }
        public string MappingMarkItemGuid { get; set; }
        public bool UseStoragePath { get; set; }
    }
}
