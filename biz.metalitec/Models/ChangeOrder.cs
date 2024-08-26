using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ChangeOrder
    {
        public ChangeOrder()
        {
            ApplicationForPaymentItems = new HashSet<ApplicationForPaymentItem>();
            ChangeOrderImpacts = new HashSet<ChangeOrderImpact>();
            ChangeOrderKeyRequirements = new HashSet<ChangeOrderKeyRequirement>();
            ChangeOrderLinks = new HashSet<ChangeOrderLink>();
            ChangeOrderRevisions = new HashSet<ChangeOrderRevision>();
            ChangeOrderValuations = new HashSet<ChangeOrderValuation>();
            DocumentInterfaceImportListings = new HashSet<DocumentInterfaceImportListing>();
            DocumentRevisions = new HashSet<DocumentRevision>();
            DocumentTransmittalRevisions = new HashSet<DocumentTransmittalRevision>();
            SalesInvoiceItems = new HashSet<SalesInvoiceItem>();
        }

        public int ChangeOrderId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int FacilityId { get; set; }
        public int ContractId { get; set; }
        public int? PhaseId { get; set; }
        public int? ChangeOrderTypeId { get; set; }
        public int ChangeOrderStatusId { get; set; }
        public int Status { get; set; }
        public int? ParentChangeOrderId { get; set; }
        public string CustomerReference { get; set; }
        public double? Value { get; set; }
        public double? Weight { get; set; }
        public double? Hours { get; set; }
        public bool? UseValuationTotals { get; set; }
        public string ChangeOrderDetails { get; set; }
        public DateTime? ReceivedOn { get; set; }
        public int? ReceivedBy { get; set; }
        public DateTime? ChangeOrderCreatedOn { get; set; }
        public int? ChangeOrderCreatedBy { get; set; }
        public DateTime? ClientNotifiedOn { get; set; }
        public int? ClientNotifiedBy { get; set; }
        public DateTime? SubmittedToEstimatingOn { get; set; }
        public int? SubmittedToEstimatingBy { get; set; }
        public DateTime? PricingCompleteOn { get; set; }
        public int? PricingCompleteBy { get; set; }
        public DateTime? SubmittedToClientOn { get; set; }
        public int? SubmittedToClientBy { get; set; }
        public DateTime? AuthorisedByClientOn { get; set; }
        public int? AuthorisedByClientBy { get; set; }
        public DateTime? ApprovedByClientOn { get; set; }
        public int? ApprovedByClientBy { get; set; }
        public DateTime? DeclinedOn { get; set; }
        public int? DeclinedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public int Version { get; set; }
        public bool IsParent { get; set; }
        public double InvoicedCompletion { get; set; }
        public double InvoicedRetention { get; set; }
        public string Notes { get; set; }
        public int? PrimaryContactId { get; set; }

        public virtual Contract Contract { get; set; }
        public virtual ICollection<ApplicationForPaymentItem> ApplicationForPaymentItems { get; set; }
        public virtual ICollection<ChangeOrderImpact> ChangeOrderImpacts { get; set; }
        public virtual ICollection<ChangeOrderKeyRequirement> ChangeOrderKeyRequirements { get; set; }
        public virtual ICollection<ChangeOrderLink> ChangeOrderLinks { get; set; }
        public virtual ICollection<ChangeOrderRevision> ChangeOrderRevisions { get; set; }
        public virtual ICollection<ChangeOrderValuation> ChangeOrderValuations { get; set; }
        public virtual ICollection<DocumentInterfaceImportListing> DocumentInterfaceImportListings { get; set; }
        public virtual ICollection<DocumentRevision> DocumentRevisions { get; set; }
        public virtual ICollection<DocumentTransmittalRevision> DocumentTransmittalRevisions { get; set; }
        public virtual ICollection<SalesInvoiceItem> SalesInvoiceItems { get; set; }
    }
}
