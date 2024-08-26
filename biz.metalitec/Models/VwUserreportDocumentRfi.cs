using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportDocumentRfi
    {
        public int DocumentTransmittalId { get; set; }
        public string Rfi { get; set; }
        public byte? RfiSent { get; set; }
        public string Subject { get; set; }
        public string Details { get; set; }
        public DateTime? AcknowledgementReceivedOn { get; set; }
        public DateTime? RequireResponseBy { get; set; }
        public DateTime? ResponseReceivedOn { get; set; }
        public string ResponseInstructionMessage { get; set; }
        public int ContactId { get; set; }
        public string Contact { get; set; }
        public string Contract { get; set; }
        public string SentVia { get; set; }
    }
}
