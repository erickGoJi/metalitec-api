using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwTransactioninterfaceSalesinvoice
    {
        public int Id { get; set; }
        public string SalesInvoiceName { get; set; }
        public string SalesInvoiceDescription { get; set; }
        public DateTime SalesInvoiceDate { get; set; }
        public string CustomerReference { get; set; }
        public DateTime? ExchangeRateDate { get; set; }
        public double? ExchangeRate { get; set; }
        public DateTime? PaymentDueBy { get; set; }
        public string SalesInvoiceNotes { get; set; }
        public string SalesInvoiceItemName { get; set; }
        public string SalesInvoiceItemDescription { get; set; }
        public double? Length { get; set; }
        public double? Width { get; set; }
        public double? Weight { get; set; }
        public double? Area { get; set; }
        public string CustomerPartNumber { get; set; }
        public double? InvoicedQuantity { get; set; }
        public double? UnitPriceForeign { get; set; }
        public double? UnitPriceHome { get; set; }
        public string PriceUnit { get; set; }
        public double? DiscountPercentage { get; set; }
        public double? DiscountValueForeign { get; set; }
        public double? DiscountValueHome { get; set; }
        public double? TaxValueForeign { get; set; }
        public double? TaxValueHome { get; set; }
        public double? ValueBeforeDiscountForeign { get; set; }
        public double? ValueBeforeDiscountHome { get; set; }
        public double? ValueAfterDiscountForeign { get; set; }
        public double? ValueAfterDiscountHome { get; set; }
        public string SalesInvoiceItemNotes { get; set; }
        public string Customer { get; set; }
        public string CustomerExternalReference { get; set; }
        public string CostCodeName { get; set; }
        public string CostCentreName { get; set; }
        public string TaxCodeName { get; set; }
        public string TaxCodeDescription { get; set; }
        public double? TaxPercentage { get; set; }
        public string TaxCodeExternalReference { get; set; }
        public string LineTaxCodeName { get; set; }
        public string LineTaxCodeDescription { get; set; }
        public double? LineTaxPercentage { get; set; }
        public string LineTaxCodeExternalReference { get; set; }
        public string ContractName { get; set; }
        public string ContractDescription { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public string PaymentTerms { get; set; }
        public string Currency { get; set; }
        public string Status { get; set; }
        public string SalesInvoiceType { get; set; }
        public string LineType { get; set; }
        public string CustomerType { get; set; }
        public string CustomerBillingAddressName { get; set; }
        public string CustomerBillingAddressLine1 { get; set; }
        public string CustomerBillingAddressLine2 { get; set; }
        public string CustomerBillingAddressLine3 { get; set; }
        public string CustomerBillingAddressLine4 { get; set; }
        public string CustomerBillingAddressPostCode { get; set; }
        public string CustomerBillingAddressCountry { get; set; }
        public string CustomerBillingAddressContact { get; set; }
        public string CustomerBillingAddressTelephone { get; set; }
        public string CustomerBillingAddressFax { get; set; }
        public string CustomerBillingAddressMobile { get; set; }
        public string CustomerBillingAddressEMail { get; set; }
        public string CustomerDeliveryAddressName { get; set; }
        public string CustomerDeliveryAddressLine1 { get; set; }
        public string CustomerDeliveryAddressLine2 { get; set; }
        public string CustomerDeliveryAddressLine3 { get; set; }
        public string CustomerDeliveryAddressLine4 { get; set; }
        public string CustomerDeliveryAddressPostCode { get; set; }
        public string CustomerDeliveryAddressCountry { get; set; }
        public string CustomerDeliveryAddressContact { get; set; }
        public string CustomerDeliveryAddressTelephone { get; set; }
        public string CustomerDeliveryAddressFax { get; set; }
        public string CustomerDeliveryAddressMobile { get; set; }
        public string CustomerDeliveryAddressEMail { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public bool Paid { get; set; }
        public int? SalesInvoiceItemId { get; set; }
        public int? ItemId { get; set; }
        public int CustomerId { get; set; }
        public int? ContractId { get; set; }
        public int? CostCodeId { get; set; }
        public int? UnitId { get; set; }
    }
}
