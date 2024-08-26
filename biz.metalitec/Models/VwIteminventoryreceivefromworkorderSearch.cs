using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwIteminventoryreceivefromworkorderSearch
    {
        public int TransactionId { get; set; }
        public string Name { get; set; }
        public DateTime DateRequired { get; set; }
        public byte Complete { get; set; }
        public double? TotalQuantity { get; set; }
        public double? TotalValue { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
