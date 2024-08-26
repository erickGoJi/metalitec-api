using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class TempNestingResultLength
    {
        public string SessionId { get; set; }
        public int ItemId { get; set; }
        public double Quantity { get; set; }
        public double Length { get; set; }
        public double? Width { get; set; }
        public int? SupplierId { get; set; }
        public int? ItemInventoryId { get; set; }
        public int? GradeRating { get; set; }
        public int? LinkId { get; set; }
        public double? Waste { get; set; }
        public int? StockId { get; set; }
        public bool? Active { get; set; }
        public int? PurchaseOrderItemId { get; set; }
    }
}
