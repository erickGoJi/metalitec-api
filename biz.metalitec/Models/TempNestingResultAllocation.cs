using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class TempNestingResultAllocation
    {
        public string SessionId { get; set; }
        public int NestingResultAllocationId { get; set; }
        public int NestResultId { get; set; }
        public int ItemId { get; set; }
        public double Quantity { get; set; }
        public int? StockId { get; set; }
        public double Length { get; set; }
        public double Waste { get; set; }
        public int? PurchaseOrderItemId { get; set; }
        public int? SupplierId { get; set; }
        public int? ItemInventoryId { get; set; }
        public int? ItemReservationId { get; set; }
        public int? LinkId { get; set; }
        public double? Width { get; set; }
        public int? AlternateItemId { get; set; }
    }
}
