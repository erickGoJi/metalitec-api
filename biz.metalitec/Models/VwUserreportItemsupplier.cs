using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportItemsupplier
    {
        public int ItemSupplierId { get; set; }
        public int ItemId { get; set; }
        public string Item { get; set; }
        public string ItemDescription { get; set; }
        public string SectionType { get; set; }
        public string Grade { get; set; }
        public int SupplierId { get; set; }
        public string Supplier { get; set; }
        public string SupplierPartNumber { get; set; }
        public byte? DefaultSupplier { get; set; }
        public double UnitPrice { get; set; }
        public string PriceUnit { get; set; }
        public double MinimumOrderQuantity { get; set; }
        public double OrderInMultiplesOf { get; set; }
        public string Currency { get; set; }
        public string TaxCode { get; set; }
        public double DiscountPercentage { get; set; }
        public int? LeadTime { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierGrade { get; set; }
        public string SupplierSize { get; set; }
        public double? Length { get; set; }
        public double? Width { get; set; }
    }
}
