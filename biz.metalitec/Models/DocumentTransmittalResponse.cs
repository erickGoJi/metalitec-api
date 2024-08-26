using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class DocumentTransmittalResponse
    {
        public int DocumentTransmittalResponseId { get; set; }
        public int ContactId { get; set; }
        public string Response { get; set; }
        public DateTime ResponseDate { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public int? Version { get; set; }
        public int? DocumentTransmittalRevisionId { get; set; }

        public virtual DocumentTransmittalRevision DocumentTransmittalRevision { get; set; }
    }
}
