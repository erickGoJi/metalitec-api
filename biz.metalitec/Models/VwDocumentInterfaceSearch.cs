using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwDocumentInterfaceSearch
    {
        public int DocumentInterfaceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FilePath { get; set; }
        public string MapName { get; set; }
        public string MapDescription { get; set; }
        public string MapRevision { get; set; }
        public string MapDocType { get; set; }
        public string MapDocStatus { get; set; }
        public string MapFileName { get; set; }
        public string MapFileCreated { get; set; }
        public string MapFileUpdated { get; set; }
        public string MapFileSize { get; set; }
        public string MapDependantFile { get; set; }
        public string Phase { get; set; }
        public string DocumentKind { get; set; }
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
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public byte? System { get; set; }
    }
}
