using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportPurchaseinvoice
    {
        public int PurchaseInvoiceId { get; set; }
        public string PurchaseInvoice { get; set; }
        public string PurchaseInvoiceDescription { get; set; }
        public DateTime PurchaseInvoiceDate { get; set; }
        public int SupplierId { get; set; }
        public string Supplier { get; set; }
        public string SupplierType { get; set; }
        public string SupplierAddressLine1 { get; set; }
        public string SupplierAddressLine2 { get; set; }
        public string SupplierAddressLine3 { get; set; }
        public string SupplierAddressLine4 { get; set; }
        public string SupplierAddressPostCode { get; set; }
        public string SupplierAddressCountry { get; set; }
        public string SupplierContact { get; set; }
        public string SupplierTelephone { get; set; }
        public string SupplierFaxNumber { get; set; }
        public string SupplierMobilePhoneNumber { get; set; }
        public string SupplierEMailAddress { get; set; }
        public string SupplierReference { get; set; }
        public string RequisitionName { get; set; }
        public string Currency { get; set; }
        public DateTime? ExchangeRateDate { get; set; }
        public double? ExchangeRate { get; set; }
        public string PurchaseInvoiceStatus { get; set; }
        public string PaymentTerms { get; set; }
        public string TaxCode { get; set; }
        public double? TaxPercentage { get; set; }
        public string PurchaseInvoiceNotes { get; set; }
        public bool Exported { get; set; }
        public DateTime? ExportedOn { get; set; }
        public bool Paid { get; set; }
        public DateTime? PaidOn { get; set; }
        public double? TotalWeight { get; set; }
        public double? TotalArea { get; set; }
        public double? TotalLength { get; set; }
        public double? TotalWidth { get; set; }
        public double? TotalValueAfterDiscountSystemCurrency { get; set; }
        public double? TotalValueAfterDiscountDocumentCurrency { get; set; }
        public double? TotalValueAfterDiscountAndTaxSystemCurrency { get; set; }
        public double? TotalValueAfterDiscountAndTaxDocumentCurrency { get; set; }
    }
}
