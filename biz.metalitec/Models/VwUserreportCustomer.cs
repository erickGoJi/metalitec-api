using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportCustomer
    {
        public int CustomerId { get; set; }
        public string Customer { get; set; }
        public string CustomerType { get; set; }
        public string Currency { get; set; }
        public string CustomerContact { get; set; }
        public string CustomerTelephone { get; set; }
        public string CustomerFaxNumber { get; set; }
        public string CustomerMobilePhoneNumber { get; set; }
        public string CustomerEMailAddress { get; set; }
        public string ExternalReference { get; set; }
        public string TaxCode { get; set; }
        public string PaymentTerms { get; set; }
        public string EdiEMailAddress { get; set; }
        public string EdiFileFormat { get; set; }
        public string EdiReference { get; set; }
    }
}
