using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportDocumenttransmittal
    {
        public int DocumentTransmittalId { get; set; }
        public string Transmittal { get; set; }
        public string Reason { get; set; }
        public byte? TransmittalSent { get; set; }
        public DateTime? SentOn { get; set; }
        public byte? TransmittalReceived { get; set; }
        public byte? TransmittalAcknowledged { get; set; }
        public byte? TransmittalPending { get; set; }
        public string TransmittalNotes { get; set; }
        public byte? RequestAcknowledgement { get; set; }
        public DateTime? AcknowledgementReceivedOn { get; set; }
        public byte? RequiresResponse { get; set; }
        public DateTime? RequireResponseBy { get; set; }
        public DateTime? ResponseReceivedOn { get; set; }
        public string ResponseInstructionMessage { get; set; }
        public int ContactId { get; set; }
        public string Contact { get; set; }
        public int? TransmittalCopies { get; set; }
        public string Contract { get; set; }
    }
}
