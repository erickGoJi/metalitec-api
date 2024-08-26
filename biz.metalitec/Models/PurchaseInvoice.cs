using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class PurchaseInvoice
    {
        public PurchaseInvoice()
        {
            PurchaseInvoiceCredits = new HashSet<PurchaseInvoiceCredit>();
            PurchaseInvoiceItems = new HashSet<PurchaseInvoiceItem>();
        }

        /// <summary>
        /// Unique Identifier
        /// </summary>
        public int PurchaseInvoiceId { get; set; }
        /// <summary>
        /// Unique Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Details of the Purchase Invoice
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Date of Invoice Document
        /// </summary>
        public DateTime InvoiceDate { get; set; }
        /// <summary>
        /// Issuing Supplier
        /// </summary>
        public int SupplierId { get; set; }
        /// <summary>
        /// Payment Address details
        /// </summary>
        public int? SupplierAddressId { get; set; }
        /// <summary>
        /// Supplier Invoice Reference
        /// </summary>
        public string SupplierReference { get; set; }
        /// <summary>
        /// Other reference
        /// </summary>
        public string RequisitionName { get; set; }
        /// <summary>
        /// Invoice Currency
        /// </summary>
        public int CurrencyId { get; set; }
        /// <summary>
        /// Date of Exchange Rate
        /// </summary>
        public DateTime? ExchangeRateDate { get; set; }
        /// <summary>
        /// Spot Rate to calculate the Value of the Invoice in the System Currency
        /// </summary>
        public double? ExchangeRate { get; set; }
        /// <summary>
        /// Status of the Invoice 1) Preparation 2) Awaiting Approval 3) Approved
        /// </summary>
        public int StatusId { get; set; }
        /// <summary>
        /// Payment Terms for Invoice
        /// </summary>
        public int? PaymentTermsId { get; set; }
        /// <summary>
        /// Default Tax Code for the Invoice Items
        /// </summary>
        public int? TaxCodeId { get; set; }
        public string Notes { get; set; }
        /// <summary>
        /// Exported to External System
        /// </summary>
        public bool Exported { get; set; }
        /// <summary>
        /// Who performed the Export
        /// </summary>
        public string ExportedBy { get; set; }
        /// <summary>
        /// When the Export was performed
        /// </summary>
        public DateTime? ExportedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int Version { get; set; }
        public bool Paid { get; set; }
        public string PaidBy { get; set; }
        public DateTime? PaidOn { get; set; }
        public int FacilityId { get; set; }
        public int? InventoryUpdateTransactionId { get; set; }
        public int PurchaseInvoiceTypeId { get; set; }

        public virtual Facility Facility { get; set; }
        public virtual ItemInventoryTransaction InventoryUpdateTransaction { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<PurchaseInvoiceCredit> PurchaseInvoiceCredits { get; set; }
        public virtual ICollection<PurchaseInvoiceItem> PurchaseInvoiceItems { get; set; }
    }
}
