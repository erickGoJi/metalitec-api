using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwDocumentTransmittalSearch
    {
        public int DocumentTransmittalId { get; set; }
        public string Name { get; set; }
        public int? Sender { get; set; }
        public string SentBy { get; set; }
        public int? SentById { get; set; }
        public string Recipients { get; set; }
        public int? ReasonId { get; set; }
        public string Reason { get; set; }
        public byte? Sent { get; set; }
        public byte? Received { get; set; }
        public byte? RequestAcknowledgement { get; set; }
        public DateTime? ReceivedAcknowledgement { get; set; }
        public DateTime? RespondBy { get; set; }
        public DateTime? ResponseOn { get; set; }
        public int? Copies { get; set; }
        public int DocumentTransmittalTypeId { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public int? FacilityId { get; set; }
        public string Facility { get; set; }
        public int DocumentTransmittalRevisionId { get; set; }
    }
}
