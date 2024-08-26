using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemReservation
    {
        public ItemReservation()
        {
            ItemInventories = new HashSet<ItemInventory>();
            ItemInventoryArchives = new HashSet<ItemInventoryArchive>();
            ItemInventoryInstances = new HashSet<ItemInventoryInstance>();
            ItemInventoryTransactionLineInstances = new HashSet<ItemInventoryTransactionLineInstance>();
            ItemReservationContracts = new HashSet<ItemReservationContract>();
            ItemSiteInventoryInstances = new HashSet<ItemSiteInventoryInstance>();
            NestResultsStockListings = new HashSet<NestResultsStockListing>();
            NestingResultAllocationArchives = new HashSet<NestingResultAllocationArchive>();
            NestingResultAllocations = new HashSet<NestingResultAllocation>();
            NestingResultSupplyLengthInstances = new HashSet<NestingResultSupplyLengthInstance>();
            PurchaseOrderItemInstances = new HashSet<PurchaseOrderItemInstance>();
            PurchaseOrderItems = new HashSet<PurchaseOrderItem>();
            SalesOrderItemInstances = new HashSet<SalesOrderItemInstance>();
            SalesOrderItems = new HashSet<SalesOrderItem>();
        }

        public int ItemReservationId { get; set; }
        /// <summary>
        /// ~0 MANUAL, 1 PRELIM, 2 DETAIL, 3 EDI, 4 CUSTOMER LISTING, 5 FREE
        /// </summary>
        public byte ReservationType { get; set; }
        public int QtyOnOrder { get; set; }
        public int QtyOnHand { get; set; }
        /// <summary>
        /// Obsolete
        /// </summary>
        public int QtyOrigOrdered { get; set; }
        public double QtyPrelimOrdered { get; set; }
        public double QtyDetailOrdered { get; set; }
        /// <summary>
        /// For Manual Allocations, the Link to the Contract
        /// </summary>
        public int? ContractId { get; set; }
        /// <summary>
        /// For Manual Allocations, the link to the Phase
        /// </summary>
        public int? PhaseId { get; set; }
        public string Phases { get; set; }
        public string Marks { get; set; }
        /// <summary>
        /// ~0 MANUAL, 1 PRELIM, 2 DETAIL, 3 EDI, 4 CUSTOMER LISTING, 5 FREE
        /// </summary>
        public byte? OriginalReservationType { get; set; }
        /// <summary>
        /// The quantity that is produced by welding other items
        /// </summary>
        public int QtyWelded { get; set; }
        public double QtyFromFreeOrder { get; set; }
        public double QtyManualOrdered { get; set; }
        public string Allocation { get; set; }
        public bool MultiContract { get; set; }
        public int? ContractPrelimBatchId { get; set; }
        public int TmpKey { get; set; }
        public string Contracts { get; set; }
        public string Lots { get; set; }

        public virtual Contract Contract { get; set; }
        public virtual ContractPhase Phase { get; set; }
        public virtual ICollection<ItemInventory> ItemInventories { get; set; }
        public virtual ICollection<ItemInventoryArchive> ItemInventoryArchives { get; set; }
        public virtual ICollection<ItemInventoryInstance> ItemInventoryInstances { get; set; }
        public virtual ICollection<ItemInventoryTransactionLineInstance> ItemInventoryTransactionLineInstances { get; set; }
        public virtual ICollection<ItemReservationContract> ItemReservationContracts { get; set; }
        public virtual ICollection<ItemSiteInventoryInstance> ItemSiteInventoryInstances { get; set; }
        public virtual ICollection<NestResultsStockListing> NestResultsStockListings { get; set; }
        public virtual ICollection<NestingResultAllocationArchive> NestingResultAllocationArchives { get; set; }
        public virtual ICollection<NestingResultAllocation> NestingResultAllocations { get; set; }
        public virtual ICollection<NestingResultSupplyLengthInstance> NestingResultSupplyLengthInstances { get; set; }
        public virtual ICollection<PurchaseOrderItemInstance> PurchaseOrderItemInstances { get; set; }
        public virtual ICollection<PurchaseOrderItem> PurchaseOrderItems { get; set; }
        public virtual ICollection<SalesOrderItemInstance> SalesOrderItemInstances { get; set; }
        public virtual ICollection<SalesOrderItem> SalesOrderItems { get; set; }
    }
}
