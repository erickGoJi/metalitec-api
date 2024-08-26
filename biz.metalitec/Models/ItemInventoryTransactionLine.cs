using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemInventoryTransactionLine
    {
        public ItemInventoryTransactionLine()
        {
            ItemInventories = new HashSet<ItemInventory>();
            ItemInventoryArchives = new HashSet<ItemInventoryArchive>();
            ItemInventoryInstances = new HashSet<ItemInventoryInstance>();
            ItemInventoryTransactionLineInstances = new HashSet<ItemInventoryTransactionLineInstance>();
            ItemInventoryTransactionLinkTransActionLineIdInNavigations = new HashSet<ItemInventoryTransactionLink>();
            ItemInventoryTransactionLinkTransActionLineIdOutNavigations = new HashSet<ItemInventoryTransactionLink>();
            ItemSiteInventoryInstances = new HashSet<ItemSiteInventoryInstance>();
            ProductionContainerItems = new HashSet<ProductionContainerItem>();
            ProductionPackageItems = new HashSet<ProductionPackageItem>();
            ProductionProposedMovementItems = new HashSet<ProductionProposedMovementItem>();
            PurchaseInvoiceItems = new HashSet<PurchaseInvoiceItem>();
            SalesInvoiceItems = new HashSet<SalesInvoiceItem>();
        }

        public int TransActionLineId { get; set; }
        public int TransactionId { get; set; }
        public int ItemTransactionTypeId { get; set; }
        /// <summary>
        /// ~0 - Outward movement, 1 - Inward Movement
        /// </summary>
        public byte Isintoinventory { get; set; }
        public int? Sequence { get; set; }
        /// <summary>
        /// ~1 - Item, 2 - Mark/Offcut/Scrapped Offcut, 3 Cutting Scrap, 4 &quot;Extra&quot; Scrap
        /// </summary>
        public int? LineTypeId { get; set; }
        public int? ItemId { get; set; }
        public int? MarkId { get; set; }
        /// <summary>
        /// ~The Mark Item ID to define the Mark where this item will be used
        /// </summary>
        public int? MarkItemId { get; set; }
        public int? ContractMarkPhaseLotId { get; set; }
        public int? ContractMarkPhaseLotItemId { get; set; }
        public int? ItemLocationId { get; set; }
        public string YardReference { get; set; }
        /// <summary>
        /// No longer used, Kept for historical data
        /// </summary>
        public int? ItemClassificationId { get; set; }
        public int? UnitId { get; set; }
        public double? Length { get; set; }
        public double? Width { get; set; }
        public double? Weight { get; set; }
        public double? Area { get; set; }
        public double UnitPrice { get; set; }
        public double Quantity { get; set; }
        public double Value { get; set; }
        public byte Complete { get; set; }
        /// <summary>
        /// For PO Receipts - The PO Line that is received
        /// </summary>
        public int? PurchaseOrderItemId { get; set; }
        /// <summary>
        /// If a PO is received in full
        /// </summary>
        public byte? ReceivedInFull { get; set; }
        /// <summary>
        /// Retain the PO ordered value if the length is not the same as the Order Length
        /// </summary>
        public byte? RetainOrderedValue { get; set; }
        public double? FreightCharge { get; set; }
        public double? Surcharge { get; set; }
        public int? ItemReservationId { get; set; }
        public int? LinkId { get; set; }
        /// <summary>
        /// Only used for Receive from workorder to track where the item came from
        /// </summary>
        public int? ProductionWorkOrderId { get; set; }
        public byte IsNonStock { get; set; }
        public byte? ReversalStatus { get; set; }
        public int? ReversalTransActionLineId { get; set; }
        public int? ProductionWorkOrderContractId { get; set; }
        /// <summary>
        /// The Source for the Sales Order Delivery
        /// </summary>
        public int? SalesOrderItemId { get; set; }
        public int? ItemInventoryShapeId { get; set; }
        public int? ItemInventoryPropertyId { get; set; }
        /// <summary>
        /// No longer used, Kept for historical data
        /// </summary>
        public int? NestingResultAllocationId { get; set; }
        /// <summary>
        /// No longer used, Kept for historical data
        /// </summary>
        public int? NestingResultItemListingId { get; set; }
        /// <summary>
        /// ~Purchase Order UnitID
        /// </summary>
        public int? TransactionUnitId { get; set; }
        /// <summary>
        /// ~Unit Price based on the Purchase Order UnitID
        /// </summary>
        public double? TransactionUnitPrice { get; set; }
        /// <summary>
        /// ~Quantity based on the Purchase Order UnitID
        /// </summary>
        public double? TransactionQuantity { get; set; }
        /// <summary>
        /// ~Purchase Order Pack Qty
        /// </summary>
        public int? TransactionOrderUnitId { get; set; }
        public int? CurrencyId { get; set; }
        public int? FacilityId { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int? CreditTransactionLineId { get; set; }
        public bool Exported { get; set; }
        public int TmpKey { get; set; }
        public int? DeliveryAddressId { get; set; }

        public virtual ContractMarkPhaseLot ContractMarkPhaseLot { get; set; }
        public virtual ContractMarkPhaseLotItem ContractMarkPhaseLotItem { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual Address DeliveryAddress { get; set; }
        public virtual Facility Facility { get; set; }
        public virtual Item Item { get; set; }
        public virtual ItemClassification ItemClassification { get; set; }
        public virtual ItemInventoryProperty ItemInventoryProperty { get; set; }
        public virtual ItemInventoryShape ItemInventoryShape { get; set; }
        public virtual ItemLocation ItemLocation { get; set; }
        public virtual ItemTransactionType ItemTransactionType { get; set; }
        public virtual ContractMark Mark { get; set; }
        public virtual ContractMarkItem MarkItem { get; set; }
        public virtual ProductionWorkOrder ProductionWorkOrder { get; set; }
        public virtual ProductionWorkOrderContract ProductionWorkOrderContract { get; set; }
        public virtual SalesOrderItem SalesOrderItem { get; set; }
        public virtual ItemInventoryTransaction Transaction { get; set; }
        public virtual Unit TransactionOrderUnit { get; set; }
        public virtual Unit TransactionUnit { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual ICollection<ItemInventory> ItemInventories { get; set; }
        public virtual ICollection<ItemInventoryArchive> ItemInventoryArchives { get; set; }
        public virtual ICollection<ItemInventoryInstance> ItemInventoryInstances { get; set; }
        public virtual ICollection<ItemInventoryTransactionLineInstance> ItemInventoryTransactionLineInstances { get; set; }
        public virtual ICollection<ItemInventoryTransactionLink> ItemInventoryTransactionLinkTransActionLineIdInNavigations { get; set; }
        public virtual ICollection<ItemInventoryTransactionLink> ItemInventoryTransactionLinkTransActionLineIdOutNavigations { get; set; }
        public virtual ICollection<ItemSiteInventoryInstance> ItemSiteInventoryInstances { get; set; }
        public virtual ICollection<ProductionContainerItem> ProductionContainerItems { get; set; }
        public virtual ICollection<ProductionPackageItem> ProductionPackageItems { get; set; }
        public virtual ICollection<ProductionProposedMovementItem> ProductionProposedMovementItems { get; set; }
        public virtual ICollection<PurchaseInvoiceItem> PurchaseInvoiceItems { get; set; }
        public virtual ICollection<SalesInvoiceItem> SalesInvoiceItems { get; set; }
    }
}
