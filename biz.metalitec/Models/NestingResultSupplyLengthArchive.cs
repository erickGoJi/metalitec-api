using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class NestingResultSupplyLengthArchive
    {
        public int NestingResultSupplyLengthId { get; set; }
        public int NestingResultSupplyId { get; set; }
        public int NestResultId { get; set; }
        public bool Include { get; set; }
        public byte SourceType { get; set; }
        public int UsedItemId { get; set; }
        public int ItemId { get; set; }
        public int? SupplierId { get; set; }
        public int? PurchaseOrderItemId { get; set; }
        public int? ItemInventoryId { get; set; }
        public int? ItemLocationId { get; set; }
        public string YardReference { get; set; }
        public int? ItemClassificationId { get; set; }
        public int? ItemInventoryPropertyId { get; set; }
        public double? UnitPrice { get; set; }
        public int? UnitId { get; set; }
        public int? ItemReservationId { get; set; }
        public int? ItemInventoryShapeId { get; set; }
        public double? Length { get; set; }
        public double? Width { get; set; }
        public double? Quantity { get; set; }
        public int? TempKey { get; set; }
        public int? ItemInventoryTrackingGuidid { get; set; }
        public int? OffcutNestingResultAllocationId { get; set; }

        public virtual ItemInventoryProperty ItemInventoryProperty { get; set; }
        public virtual ItemInventoryShape ItemInventoryShape { get; set; }
        public virtual PurchaseOrderItem PurchaseOrderItem { get; set; }
    }
}
