using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportSupplier
    {
        public int SupplierId { get; set; }
        public string Supplier { get; set; }
        public string SupplierType { get; set; }
        public bool SteelMillSupplier { get; set; }
        public bool ShippingAgent { get; set; }
        public string Currency { get; set; }
        public string SupplierContact { get; set; }
        public string SupplierTelephone { get; set; }
        public string SupplierFaxNumber { get; set; }
        public string SupplierMobilePhoneNumber { get; set; }
        public string SupplierEMailAddress { get; set; }
        public string ExternalReference { get; set; }
        public string TaxCode { get; set; }
        public string PaymentTerms { get; set; }
        public string EdiEMailAddress { get; set; }
        public string EdiFileFormat { get; set; }
        public string EdiReference { get; set; }
    }
}
