using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportSalesorder
    {
        public int SalesOrderId { get; set; }
        public string SalesOrderType { get; set; }
        public string SalesOrder { get; set; }
        public string SalesOrderDescription { get; set; }
        public DateTime OrderDate { get; set; }
        public int? ContractId { get; set; }
        public string Contract { get; set; }
        public string ContractDescription { get; set; }
        public int CustomerId { get; set; }
        public string Customer { get; set; }
        public string CustomerType { get; set; }
        public string EdiEMailAddress { get; set; }
        public string EdiReference { get; set; }
        public string EdiFileFormat { get; set; }
        public string CustomerDeliveryAddressLine1 { get; set; }
        public string CustomerDeliveryAddressLine2 { get; set; }
        public string CustomerDeliveryAddressLine3 { get; set; }
        public string CustomerDeliveryAddressLine4 { get; set; }
        public string CustomerDeliveryAddressPostCode { get; set; }
        public string CustomerDeliveryAddressCountry { get; set; }
        public string CustomerDeliveryContact { get; set; }
        public string CustomerDeliveryTelephone { get; set; }
        public string CustomerDeliveryFaxNumber { get; set; }
        public string CustomerDeliveryMobilePhoneNumber { get; set; }
        public string CustomerDeliveryEMailAddress { get; set; }
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
        public string OrderTakenBy { get; set; }
        public string StorageLocation { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string Currency { get; set; }
        public DateTime? ExchangeRateDate { get; set; }
        public double? ExchangeRate { get; set; }
        public string SalesOrderStatus { get; set; }
        public string PaymentTerms { get; set; }
        public string TaxCode { get; set; }
        public double? TaxPercentage { get; set; }
        public string SalesOrderNotes { get; set; }
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
