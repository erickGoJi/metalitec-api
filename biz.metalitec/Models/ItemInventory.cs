using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemInventory
    {
        public ItemInventory()
        {
            ItemInventoryGroupProperties = new HashSet<ItemInventoryGroupProperty>();
            ItemInventoryInstances = new HashSet<ItemInventoryInstance>();
        }

        /// <summary>
        /// Unique ID for the inventory record
        /// </summary>
        public int ItemInventoryId { get; set; }
        /// <summary>
        /// The Item ID of the inventory item
        /// </summary>
        public int? ItemId { get; set; }
        public int? MarkId { get; set; }
        /// <summary>
        /// ~The Mark Item ID to define the Mark where this item will be used
        /// </summary>
        public int? MarkItemId { get; set; }
        public int? ContractMarkPhaseLotId { get; set; }
        public int? ContractMarkPhaseLotItemId { get; set; }
        /// <summary>
        /// The location where the item is held
        /// </summary>
        public int ItemLocationId { get; set; }
        /// <summary>
        /// The yard reference of the inventory
        /// </summary>
        public string YardReference { get; set; }
        /// <summary>
        /// No longer used, Kept for historical data
        /// </summary>
        public int? ItemClassificationId { get; set; }
        /// <summary>
        /// The unit for the inventory item
        /// </summary>
        public int UnitId { get; set; }
        /// <summary>
        /// No longer used, Kept for historical data
        /// </summary>
        public byte Locked { get; set; }
        /// <summary>
        /// No longer used, Kept for historical data
        /// </summary>
        public int? LockItemInventoryTransId { get; set; }
        /// <summary>
        /// The length of the bar held in inventory
        /// </summary>
        public double? Length { get; set; }
        /// <summary>
        /// The width of the item held in inventory
        /// </summary>
        public double? Width { get; set; }
        /// <summary>
        /// The weight of the item held in inventory
        /// </summary>
        public double? Weight { get; set; }
        /// <summary>
        /// The area of the item held in inventory
        /// </summary>
        public double? Area { get; set; }
        /// <summary>
        /// The unit price of the item
        /// </summary>
        public double UnitPrice { get; set; }
        /// <summary>
        /// The quantity that is kept for this inventory record
        /// </summary>
        public double Quantity { get; set; }
        /// <summary>
        /// The value of the item in the system currency
        /// </summary>
        public double Value { get; set; }
        public int? ItemReservationId { get; set; }
        public int? ItemInventoryShapeId { get; set; }
        public int ItemInventoryPropertyId { get; set; }
        public int? CurrencyId { get; set; }
        public int? FacilityId { get; set; }
        public string TmpKey { get; set; }

        public virtual ContractMarkPhaseLot ContractMarkPhaseLot { get; set; }
        public virtual ContractMarkPhaseLotItem ContractMarkPhaseLotItem { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual Facility Facility { get; set; }
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
        public virtual ICollection<ItemInventoryGroupProperty> ItemInventoryGroupProperties { get; set; }
        public virtual ICollection<ItemInventoryInstance> ItemInventoryInstances { get; set; }
    }
}
