using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportPurchaseinvoiceitem
    {
        public int PurchaseInvoiceItemId { get; set; }
        public int PurchaseInvoiceId { get; set; }
        public string PurchaseInvoiceName { get; set; }
        public string PurchaseInvoiceDescription { get; set; }
        public string LineType { get; set; }
        public string PurchaseInvoiceItemDescription { get; set; }
        public int? ItemId { get; set; }
        public string Item { get; set; }
        public string ItemDescription { get; set; }
        public string SectionType { get; set; }
        public string Grade { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Weight { get; set; }
        public double Area { get; set; }
        public string SupplierPartNumber { get; set; }
        public double InvoicedQuantity { get; set; }
        public double UnitPriceSystemCurrency { get; set; }
        public double UnitPriceDocumentCurrency { get; set; }
        public double? DiscountPercentage { get; set; }
        public double DiscountValueSystemCurrency { get; set; }
        public double DiscountValueDocumentCurrency { get; set; }
        public string TaxCode { get; set; }
        public string TaxCodeDescription { get; set; }
        public double TaxPercentage { get; set; }
        public double TaxValueSystemCurrency { get; set; }
        public double TaxValueDocumentCurrency { get; set; }
        public double ValueBeforeDiscountSystemCurrency { get; set; }
        public double ValueBeforeDiscountDocumentCurrency { get; set; }
        public double ValueAfterDiscountSystemCurrency { get; set; }
        public double ValueAfterDiscountDocumentCurrency { get; set; }
        public double ValueAfterDiscountAndTaxSystemCurrency { get; set; }
        public double ValueAfterDiscountAndTaxDocumentCurrency { get; set; }
        public string CostCode { get; set; }
        public string CostCentre { get; set; }
        public string PriceUnit { get; set; }
        public string PurchaseInvoiceItemNotes { get; set; }
        public int? TransActionLineId { get; set; }
        public int? ContractId { get; set; }
        public string Contract { get; set; }
        public string ContractDescription { get; set; }
    }
}
