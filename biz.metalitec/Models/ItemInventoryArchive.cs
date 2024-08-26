using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemInventoryArchive
    {
        public int ItemInventoryId { get; set; }
        public int ContractId { get; set; }
        public int? ItemId { get; set; }
        public int? MarkId { get; set; }
        public int? MarkItemId { get; set; }
        public int? ContractMarkPhaseLotId { get; set; }
        public int? ContractMarkPhaseLotItemId { get; set; }
        public int ItemLocationId { get; set; }
        public string YardReference { get; set; }
        public int ItemClassificationId { get; set; }
        public int UnitId { get; set; }
        public byte Locked { get; set; }
        public int? LockItemInventoryTransId { get; set; }
        public double? Length { get; set; }
        public double? Width { get; set; }
        public double? Weight { get; set; }
        public double? Area { get; set; }
        public double UnitPrice { get; set; }
        public double Quantity { get; set; }
        public double Value { get; set; }
        public int? ItemReservationId { get; set; }
        public int? ItemInventoryShapeId { get; set; }
        public int ItemInventoryPropertyId { get; set; }

        public virtual ContractMarkPhaseLot ContractMarkPhaseLot { get; set; }
        public virtual ContractMarkPhaseLotItem ContractMarkPhaseLotItem { get; set; }
        public virtual Item Item { get; set; }
        public virtual ItemClassification ItemClassification { get; set; }
        public virtual ItemInventoryProperty ItemInventoryProperty { get; set; }
        public virtual ItemInventoryShape ItemInventoryShape { get; set; }
        public virtual ItemLocation ItemLocation { get; set; }
        public virtual ItemReservation ItemReservation { get; set; }
        public virtual ItemInventoryTransactionLine LockItemInventoryTrans { get; set; }
        public virtual ContractMark Mark { get; set; }
        public virtual ContractMarkItem MarkItem { get; set; }
        public virtual Unit Unit { get; set; }
    }
}
