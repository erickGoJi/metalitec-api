using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class DocumentTransmittalDocument
    {
        public int DocumentTransmittalDocumentId { get; set; }
        /// <summary>
        /// The Document Revision this is linked to
        /// </summary>
        public int DocumentRevisionId { get; set; }
        public DateTime? ResponseReceivedOn { get; set; }
        public byte? ResendOnRevision { get; set; }
        public int? DocumentTransmittalRevisionId { get; set; }

        public virtual DocumentRevision DocumentRevision { get; set; }
        public virtual DocumentTransmittalRevision DocumentTransmittalRevision { get; set; }
    }
}
