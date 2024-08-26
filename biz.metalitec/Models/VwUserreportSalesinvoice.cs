using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportSalesinvoice
    {
        public int SalesInvoiceId { get; set; }
        public string SalesInvoice { get; set; }
        public string SalesInvoiceDescription { get; set; }
        public string SalesInvoiceType { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string SalesInvoiceStatus { get; set; }
        public int CustomerId { get; set; }
        public string Customer { get; set; }
        public string CustomerBillingAddressLine1 { get; set; }
        public string CustomerBillingAddressLine2 { get; set; }
        public string CustomerBillingAddressLine3 { get; set; }
        public string CustomerBillingAddressLine4 { get; set; }
        public string CustomerBillingAddressPostCode { get; set; }
        public string CustomerBillingAddressCountry { get; set; }
        public string CustomerBillingContact { get; set; }
        public string CustomerBillingTelephone { get; set; }
        public string CustomerBillingFaxNumber { get; set; }
        public string CustomerBillingMobilePhoneNumber { get; set; }
        public string CustomerBillingEMailAddress { get; set; }
        public string CustomerReference { get; set; }
        public string OrderCategory { get; set; }
        public string Currency { get; set; }
        public DateTime? ExchangeRateDate { get; set; }
        public double? ExchangeRate { get; set; }
        public string PaymentTerms { get; set; }
        public DateTime? PaymentDueBy { get; set; }
        public string TaxCode { get; set; }
        public int? ContractId { get; set; }
        public string Contract { get; set; }
        public string ContractDescription { get; set; }
        public string SalesInvoiceNotes { get; set; }
        public bool Exported { get; set; }
        public DateTime? ExportedOn { get; set; }
        public bool PaymentReceived { get; set; }
        public DateTime? PaymentReceivedOn { get; set; }
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
