using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwTransactioninterfacePurchaseinvoice
    {
        public int Id { get; set; }
        public string PurchaseInvoiceName { get; set; }
        public int FacilityId { get; set; }
        public string Facility { get; set; }
        public int? PurchaseOrderId { get; set; }
        public string PurchaseOrder { get; set; }
        public string PurchaseOrderDescription { get; set; }
        public string PurchaseInvoiceDescription { get; set; }
        public DateTime PurchaseInvoiceDate { get; set; }
        public DateTime PurchaseInvoiceDueDate { get; set; }
        public string SupplierReference { get; set; }
        public DateTime? ExchangeRateDate { get; set; }
        public double? ExchangeRate { get; set; }
        public string PurchaseInvoiceNotes { get; set; }
        public string PurchaseInvoiceItemName { get; set; }
        public string PurchaseInvoiceItemDescription { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Weight { get; set; }
        public double Area { get; set; }
        public string SupplierPartNumber { get; set; }
        public double InvoicedQuantity { get; set; }
        public double UnitPriceForeign { get; set; }
        public double UnitPriceHome { get; set; }
        public string PriceUnit { get; set; }
        public double DiscountPercentage { get; set; }
        public double DiscountValueForeign { get; set; }
        public double DiscountValueHome { get; set; }
        public double? TaxValueForeign { get; set; }
        public double? TaxValueHome { get; set; }
        public double? ValueBeforeDiscountForeign { get; set; }
        public double? ValueBeforeDiscountHome { get; set; }
        public double? ValueAfterDiscountForeign { get; set; }
        public double? ValueAfterDiscountHome { get; set; }
        public string PurchaseInvoiceItemNotes { get; set; }
        public string Supplier { get; set; }
        public string SupplierExternalReference { get; set; }
        public string CostCodeName { get; set; }
        public string CostCentreName { get; set; }
        public string TaxCodeName { get; set; }
        public string TaxCodeDescription { get; set; }
        public string TaxCodeExternalReference { get; set; }
        public double? TaxPercentage { get; set; }
        public string ContractName { get; set; }
        public string ContractDescription { get; set; }
        public string Customer { get; set; }
        public string PaymentTerms { get; set; }
        public string Currency { get; set; }
        public string LineType { get; set; }
        public string SupplierType { get; set; }
        public string SupplierBillingAddressName { get; set; }
        public string SupplierBillingAddressLine1 { get; set; }
        public string SupplierBillingAddressLine2 { get; set; }
        public string SupplierBillingAddressLine3 { get; set; }
        public string SupplierBillingAddressLine4 { get; set; }
        public string SupplierBillingAddressPostCode { get; set; }
        public string SupplierBillingAddressCountry { get; set; }
        public string SupplierBillingAddressContact { get; set; }
        public string SupplierBillingAddressTelephone { get; set; }
        public string SupplierBillingAddressFax { get; set; }
        public string SupplierBillingAddressMobile { get; set; }
        public string SupplierBillingAddressEMail { get; set; }
        public int? ItemId { get; set; }
        public int SupplierId { get; set; }
        public int? ContractId { get; set; }
        public int? PurchaseInvoiceItemId { get; set; }
        public int? PurchaseInvoiceCreditId { get; set; }
        public int? CostCodeId { get; set; }
    }
}
