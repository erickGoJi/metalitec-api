using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwAdditionSearch
    {
        public int AdditionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Reference { get; set; }
        public double UnitPrice { get; set; }
        public DateTime ExchangeRateDate { get; set; }
        public double? ExchangeRate { get; set; }
        public bool WillAddToInventoryValue { get; set; }
        public int ParentId { get; set; }
        public int ParentTypeId { get; set; }
        public int? Instance { get; set; }
        public int? ItemInventoryTrackingGuidId { get; set; }
        public int UnitId { get; set; }
        public string Unit { get; set; }
        public double? Value { get; set; }
        public int SupplierId { get; set; }
        public string Supplier { get; set; }
        public int? AddressId { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string Line4 { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public int? TaxCodeId { get; set; }
        public string TaxCode { get; set; }
        public double? TaxPercent { get; set; }
        public int CostCodeId { get; set; }
        public string CostCode { get; set; }
        public string CostCodeDescription { get; set; }
        public int CurrencyId { get; set; }
        public string Currency { get; set; }
        public int? PaymentTermsId { get; set; }
        public string PaymentTerms { get; set; }
        public int? AdditionTemplateId { get; set; }
        public string AdditionTemplateName { get; set; }
        public int? AdditionTemplateFacilityId { get; set; }
    }
}
