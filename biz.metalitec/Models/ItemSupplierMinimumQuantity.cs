using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemSupplierMinimumQuantity
    {
        public int ItemSupplierMinimumQuantityId { get; set; }
        public int? ItemId { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public int MinQuantity { get; set; }
        public DateTime? Createdon { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
    }
}
