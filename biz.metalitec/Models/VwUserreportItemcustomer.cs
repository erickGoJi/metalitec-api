using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportItemcustomer
    {
        public int ItemCustomerId { get; set; }
        public int ItemId { get; set; }
        public string Item { get; set; }
        public string ItemDescription { get; set; }
        public string SectionType { get; set; }
        public string Grade { get; set; }
        public int CustomerId { get; set; }
        public string Customer { get; set; }
        public string CustomerPartNumber { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerGrade { get; set; }
        public string CustomerSize { get; set; }
        public double UnitPrice { get; set; }
        public string PriceUnit { get; set; }
        public string Currency { get; set; }
        public string TaxCode { get; set; }
        public double DiscountPercentage { get; set; }
    }
}
