using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwPurchaseinvoiceSearch
    {
        public int PurchaseInvoiceId { get; set; }
        public string Name { get; set; }
        public int FacilityId { get; set; }
        public string Facility { get; set; }
        public string Description { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }
        public int PurchaseInvoiceTypeId { get; set; }
        public string InvoiceType { get; set; }
        public string Supplier { get; set; }
        public string Contract { get; set; }
        public string SupplierReference { get; set; }
        public string RequisitionName { get; set; }
        public string Currency { get; set; }
        public DateTime? ExchangeRateDate { get; set; }
        public double? ExchangeRate { get; set; }
        public string PaymentTerms { get; set; }
        public string TaxCode { get; set; }
        public string PurchaseOrder { get; set; }
        public string PurchaseOrderDescription { get; set; }
        public string Receipt { get; set; }
        public string SupplierDeliveryNote { get; set; }
        public double? InvoicedQuantity { get; set; }
        public double? LineValue { get; set; }
        public double? LineValueInclTax { get; set; }
        public double? OrderValue { get; set; }
        public double? OrderValueInclTax { get; set; }
        public bool Exported { get; set; }
        public string ExportedBy { get; set; }
        public DateTime? ExportedOn { get; set; }
        public bool Paid { get; set; }
        public string PaidBy { get; set; }
        public DateTime? PaidOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
