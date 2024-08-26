using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwSupplierSearch
    {
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string SupplierType { get; set; }
        public int? SupplierTypeId { get; set; }
        public string ContactName { get; set; }
        public string ContactTelephone { get; set; }
        public string ContactFax { get; set; }
        public string ContactEmail { get; set; }
        public bool IsMill { get; set; }
        public string ExternalReference { get; set; }
        public string Currency { get; set; }
        public string PaymentTerms { get; set; }
        public string EdiFileFormat { get; set; }
        public string EdiReference { get; set; }
        public string EdiEmail { get; set; }
        public string TaxCode { get; set; }
        public string SubjectHeaderSuffix { get; set; }
        public bool ShippingAgent { get; set; }
        public string Notes { get; set; }
    }
}
