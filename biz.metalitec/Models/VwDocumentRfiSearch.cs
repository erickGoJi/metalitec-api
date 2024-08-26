using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwDocumentRfiSearch
    {
        public int DocumentTransmittalRevisionId { get; set; }
        public int DocumentTransmittalId { get; set; }
        public string Name { get; set; }
        public int? Sender { get; set; }
        public string SentBy { get; set; }
        public string Recipients { get; set; }
        public byte? Sent { get; set; }
        public byte? Received { get; set; }
        public int? SentViaId { get; set; }
        public string SentVia { get; set; }
        public string Subject { get; set; }
        public string Details { get; set; }
        public string Contract { get; set; }
        public int? ContractId { get; set; }
        public DateTime? AcknowledgementReceivedOn { get; set; }
        public DateTime? RequireResponseBy { get; set; }
        public DateTime? ResponseReceivedOn { get; set; }
        public string ResponseInstructions { get; set; }
        public int? ResponseId { get; set; }
        public int DocumentTransmittalTypeId { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public int? FacilityId { get; set; }
        public string Facility { get; set; }
        public byte Latest { get; set; }
        public int DocumentRevisionCodeId { get; set; }
        public string Revision { get; set; }
        public int? VariationId { get; set; }
        public string Variation { get; set; }
        public string Label { get; set; }
        public int? LabelId { get; set; }
        public int ContactId { get; set; }
        public string Notes { get; set; }
    }
}
