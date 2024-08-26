using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwSalesinvoiceSearch
    {
        public int SalesInvoiceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int CustomerId { get; set; }
        public string Customer { get; set; }
        public string Currency { get; set; }
        public string CustomerReference { get; set; }
        public int? SalesOrderId { get; set; }
        public string SalesOrderName { get; set; }
        public int? ApplicationForPaymentId { get; set; }
        public string ApplicationForPayment { get; set; }
        public int? OrderCategory { get; set; }
        public string OrderCategoryName { get; set; }
        public int? ItemLocationId { get; set; }
        public string StorageLocation { get; set; }
        public int StatusId { get; set; }
        public string SalesInvoiceStatus { get; set; }
        public int? ContractId { get; set; }
        public string Contract { get; set; }
        public int SalesInvoiceTypeId { get; set; }
        public string SalesInvoiceType { get; set; }
        public DateTime? PaymentDueBy { get; set; }
        public double? InvoicedQuantity { get; set; }
        public double? TotalValueExclTax { get; set; }
        public double? TotalValueInclTax { get; set; }
        public string Notes { get; set; }
        public bool Exported { get; set; }
        public string ExportedBy { get; set; }
        public DateTime? ExportedOn { get; set; }
        public bool PaymentReceived { get; set; }
        public string PaymentReceivedBy { get; set; }
        public DateTime? PaymentReceivedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? FacilityId { get; set; }
        public string Facility { get; set; }
    }
}
