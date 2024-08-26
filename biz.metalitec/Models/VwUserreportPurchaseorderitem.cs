using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportPurchaseorderitem
    {
        public int PurchaseOrderItemId { get; set; }
        public int PurchaseOrderId { get; set; }
        public string PurchaseOrderName { get; set; }
        public string PurchaseOrderDescription { get; set; }
        public string LineType { get; set; }
        public string PurchaseOrderItemDescription { get; set; }
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
        public DateTime DeliveryDate { get; set; }
        public string ItemLocation { get; set; }
        public string YardReference { get; set; }
        public int? RollReferenceLineId { get; set; }
        public string RollReference { get; set; }
        public DateTime? RollDate { get; set; }
        public string CostCode { get; set; }
        public string CostCentre { get; set; }
        public double OrderQuantity { get; set; }
        public double ReceivedQuantity { get; set; }
        public double QuantityOutstanding { get; set; }
        public bool ReceivedInFull { get; set; }
        public int? InvoicedQuantity { get; set; }
        public string PriceUnit { get; set; }
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
        public string Project { get; set; }
        public string Contract { get; set; }
        public string Phase { get; set; }
        public string Lot { get; set; }
        public string Mark { get; set; }
        public string Allocation { get; set; }
        public string PurchaseOrderItemNotes { get; set; }
        public bool IsDirectIssue { get; set; }
    }
}
