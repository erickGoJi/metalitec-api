using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class NestingResultSupplyLength
    {
        public NestingResultSupplyLength()
        {
            NestingResultAllocations = new HashSet<NestingResultAllocation>();
            NestingResultSupplyLengthInstances = new HashSet<NestingResultSupplyLengthInstance>();
            NestingResultWeldedBarBarNestingResultSupplyLengths = new HashSet<NestingResultWeldedBar>();
            NestingResultWeldedBarPartNestingResultSupplyLengths = new HashSet<NestingResultWeldedBar>();
        }

        public int NestingResultSupplyLengthId { get; set; }
        public int NestingResultSupplyId { get; set; }
        /// <summary>
        /// Not Needed???
        /// </summary>
        public int NestResultId { get; set; }
        public bool? Include { get; set; }
        /// <summary>
        /// Where the material comes from: 1 - Free Inventory, 2 - Supplier new order, 3 - Reserved Inventory, 4 - Purchase Order, 5- Work Order , 6 - Theoretical Offcuts
        /// </summary>
        public byte SourceType { get; set; }
        /// <summary>
        /// The itemID of what we are looking for (What the user wanted)
        /// </summary>
        public int UsedItemId { get; set; }
        /// <summary>
        /// THe actual ItemID (Could only be different because of grades)
        /// </summary>
        public int ItemId { get; set; }
        /// <summary>
        /// The SupplierID that will supply this bar/plate, Also used when referring to an inventory line
        /// </summary>
        public int? SupplierId { get; set; }
        /// <summary>
        /// The Purchase Order Line ID if this item is from a current purchase order.
        /// </summary>
        public int? PurchaseOrderItemId { get; set; }
        /// <summary>
        /// ~ Only used for synchronisation when saving - do not use for joining
        /// </summary>
        public int? ItemInventoryId { get; set; }
        /// <summary>
        /// Used to locate an item that is in inventory
        /// </summary>
        public int? ItemLocationId { get; set; }
        /// <summary>
        /// Used to locate an item that is in inventory
        /// </summary>
        public string YardReference { get; set; }
        /// <summary>
        /// Used to locate an item that is in inventory
        /// </summary>
        public int? ItemClassificationId { get; set; }
        public int? ItemInventoryPropertyId { get; set; }
        /// <summary>
        /// Used to locate an item that is in inventory/Price of the supplier length (could differ from NRSupply table)
        /// </summary>
        public double? UnitPrice { get; set; }
        /// <summary>
        /// Used to locate an item that is in inventory/Price Unit for a supplier length
        /// </summary>
        public int? UnitId { get; set; }
        /// <summary>
        /// Used to locate an item that is in inventory
        /// </summary>
        public int? ItemReservationId { get; set; }
        /// <summary>
        /// Used to locate an item that is in inventory
        /// </summary>
        public int? ItemInventoryShapeId { get; set; }
        /// <summary>
        /// Inv&amp;POL - Same as Length in Inv/POL, Supplier - the length that can be ordered
        /// </summary>
        public double? Length { get; set; }
        /// <summary>
        /// Inv&amp;POL - Same as Width in Inv/POL, Supplier - the width that can be ordered
        /// </summary>
        public double? Width { get; set; }
        /// <summary>
        /// Inv&amp;POL - Same as Qty in Inv/POL, Supplier - the qty that can be ordered(usually 999)
        /// </summary>
        public double? Quantity { get; set; }
        /// <summary>
        /// ~Temp key for syncing client data from other tables to this table
        /// </summary>
        public int? TempKey { get; set; }
        public int? ItemInventoryTrackingGuidid { get; set; }
        /// <summary>
        /// A link to the bar/sheet whose offcut extra Mark Items may be nested to
        /// </summary>
        public int? OffcutNestingResultAllocationId { get; set; }

        public virtual ItemInventoryProperty ItemInventoryProperty { get; set; }
        public virtual ItemInventoryShape ItemInventoryShape { get; set; }
        public virtual NestingResult NestResult { get; set; }
        public virtual NestingResultSupply NestingResultSupply { get; set; }
        public virtual PurchaseOrderItem PurchaseOrderItem { get; set; }
        public virtual ICollection<NestingResultAllocation> NestingResultAllocations { get; set; }
        public virtual ICollection<NestingResultSupplyLengthInstance> NestingResultSupplyLengthInstances { get; set; }
        public virtual ICollection<NestingResultWeldedBar> NestingResultWeldedBarBarNestingResultSupplyLengths { get; set; }
        public virtual ICollection<NestingResultWeldedBar> NestingResultWeldedBarPartNestingResultSupplyLengths { get; set; }
    }
}
