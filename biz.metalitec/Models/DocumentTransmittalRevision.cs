using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class DocumentTransmittalRevision
    {
        public DocumentTransmittalRevision()
        {
            DocumentTransmittalDocuments = new HashSet<DocumentTransmittalDocument>();
            DocumentTransmittalRecipients = new HashSet<DocumentTransmittalRecipient>();
            DocumentTransmittalResponses = new HashSet<DocumentTransmittalResponse>();
        }

        /// <summary>
        /// The unique transmittal revision ID number generated automatically.
        /// </summary>
        public int DocumentTransmittalRevisionId { get; set; }
        public int DocumentTransmittalId { get; set; }
        /// <summary>
        /// Lookup the reason for the Transmittal
        /// </summary>
        public int? DocumentTransmittalReasonId { get; set; }
        /// <summary>
        /// Has the Transmittal been sent
        /// </summary>
        public byte? Sent { get; set; }
        public DateTime? SentOn { get; set; }
        /// <summary>
        /// Has the Transmittal been received
        /// </summary>
        public byte? Received { get; set; }
        /// <summary>
        /// Has the Transmittal been acknowledged
        /// </summary>
        public byte? Acknowledged { get; set; }
        /// <summary>
        /// Is the Transmittal Pending
        /// </summary>
        public byte? Pending { get; set; }
        /// <summary>
        /// Enter any additional notes you may wish to add about the transmittal.
        /// </summary>
        public string Notes { get; set; }
        /// <summary>
        /// Request Acknowledgement of this Transmittal
        /// </summary>
        public byte? RequestAcknowledgement { get; set; }
        /// <summary>
        /// Date Acknowledgement was Received
        /// </summary>
        public DateTime? AcknowledgeReceivedOn { get; set; }
        /// <summary>
        /// Require Response for this Transmittal
        /// </summary>
        public byte? ResponseRequired { get; set; }
        /// <summary>
        /// The Date a Response is Required By
        /// </summary>
        public DateTime? ResponseRequestBy { get; set; }
        /// <summary>
        /// The Date a Response was Received on
        /// </summary>
        public DateTime? ResponseReceivedOn { get; set; }
        /// <summary>
        /// Response Message
        /// </summary>
        public int? ResponseId { get; set; }
        /// <summary>
        /// Who is this transmittal from?
        /// </summary>
        public int ContactId { get; set; }
        /// <summary>
        /// Number of Copies of this Transmittal
        /// </summary>
        public int? Copies { get; set; }
        public string Subject { get; set; }
        public int? SentViaId { get; set; }
        public string Priority { get; set; }
        public string SupplierRfiNumber { get; set; }
        public string VendorRfiNumber { get; set; }
        public string Category { get; set; }
        public int DocumentRevisionCodeId { get; set; }
        public byte Latest { get; set; }
        public string RevisedBy { get; set; }
        public string RevisionDetails { get; set; }
        /// <summary>
        /// The date of the last update.
        /// </summary>
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// The last updater
        /// </summary>
        public string UpdatedBy { get; set; }
        /// <summary>
        /// Date the record was created.
        /// </summary>
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// The record creator
        /// </summary>
        public string CreatedBy { get; set; }
        public int Version { get; set; }
        public int? ChangeOrderId { get; set; }
        public int? LabelId { get; set; }

        public virtual ChangeOrder ChangeOrder { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual DocumentTransmittalReason DocumentTransmittalReason { get; set; }
        public virtual ICollection<DocumentTransmittalDocument> DocumentTransmittalDocuments { get; set; }
        public virtual ICollection<DocumentTransmittalRecipient> DocumentTransmittalRecipients { get; set; }
        public virtual ICollection<DocumentTransmittalResponse> DocumentTransmittalResponses { get; set; }
    }
}
