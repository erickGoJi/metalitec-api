using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class SalesInvoice
    {
        public SalesInvoice()
        {
            SalesInvoiceItems = new HashSet<SalesInvoiceItem>();
        }

        public int SalesInvoiceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SalesInvoiceTypeId { get; set; }
        /// <summary>
        /// Date of Invoice Document
        /// </summary>
        public DateTime InvoiceDate { get; set; }
        public int StatusId { get; set; }
        /// <summary>
        /// Customer Name
        /// </summary>
        public int CustomerId { get; set; }
        /// <summary>
        /// Address to send Invoice to
        /// </summary>
        public int? CustomerBillingAddressId { get; set; }
        /// <summary>
        /// Customers Purchase Order Number or Reference
        /// </summary>
        public string CustomerReference { get; set; }
        /// <summary>
        /// Order Category from Sales Order
        /// </summary>
        public int? OrderCategory { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        public int? CurrencyId { get; set; }
        /// <summary>
        /// Date of Exchange Rate
        /// </summary>
        public DateTime? ExchangeRateDate { get; set; }
        /// <summary>
        /// Exchange Rate
        /// </summary>
        public double? ExchangeRate { get; set; }
        public int? PaymentTermsId { get; set; }
        /// <summary>
        /// Calculated from terms
        /// </summary>
        public DateTime? PaymentDueBy { get; set; }
        /// <summary>
        /// FK Tax Code
        /// </summary>
        public int? TaxCodeId { get; set; }
        public int? ContractId { get; set; }
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
        public bool PaymentReceived { get; set; }
        public string PaymentReceivedBy { get; set; }
        public DateTime? PaymentReceivedOn { get; set; }
        public int? ApplicationForPaymentId { get; set; }

        public virtual ApplicationForPayment ApplicationForPayment { get; set; }
        public virtual Contract Contract { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<SalesInvoiceItem> SalesInvoiceItems { get; set; }
    }
}
