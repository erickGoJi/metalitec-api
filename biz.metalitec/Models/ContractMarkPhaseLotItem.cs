using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ContractMarkPhaseLotItem
    {
        public ContractMarkPhaseLotItem()
        {
            ItemInventories = new HashSet<ItemInventory>();
            ItemInventoryArchives = new HashSet<ItemInventoryArchive>();
            ItemInventoryTransactionLines = new HashSet<ItemInventoryTransactionLine>();
            ItemSiteInventories = new HashSet<ItemSiteInventory>();
            NestingResultItemListingArchives = new HashSet<NestingResultItemListingArchive>();
            NestingResultItemListings = new HashSet<NestingResultItemListing>();
            ProductionWorkOrderContractArchives = new HashSet<ProductionWorkOrderContractArchive>();
            ProductionWorkOrderContracts = new HashSet<ProductionWorkOrderContract>();
        }

        public int ContractMarkPhaseLotItemId { get; set; }
        public int ContractMarkPhaseLotId { get; set; }
        public int MarkItemId { get; set; }
        public double Quantity { get; set; }
        /// <summary>
        /// Quantity of items on PurchaseOrder
        /// </summary>
        public double QuantityOrdered { get; set; }
        /// <summary>
        /// Quantity of items in Inventory
        /// </summary>
        public double QuantityAllocated { get; set; }
        public double QuantityOutstanding { get; set; }
        public int Version { get; set; }
        public int ContractId { get; set; }
        public int PhaseId { get; set; }
        public int LotId { get; set; }
        public int MarkId { get; set; }
        public int ContractItemId { get; set; }
        public int? EdifileId { get; set; }
        public int? ContractBundleId { get; set; }
        /// <summary>
        /// This is a unique identifier for the mark item in the EDI file, used by SteelXML standard for linking nested bars to mark items.
        /// </summary>
        public string EdiitemUrn { get; set; }
        public bool Exported { get; set; }
        public string ExportedBy { get; set; }
        public DateTime? ExportedOn { get; set; }
        public int MarkItemTransactionId { get; set; }
        public double NestedQuantityDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual ContractBundle ContractBundle { get; set; }
        public virtual ContractItem ContractItem { get; set; }
        public virtual ContractMarkPhaseLot ContractMarkPhaseLot { get; set; }
        public virtual Edifile Edifile { get; set; }
        public virtual ContractMark Mark { get; set; }
        public virtual ContractMarkItem MarkItem { get; set; }
        public virtual ICollection<ItemInventory> ItemInventories { get; set; }
        public virtual ICollection<ItemInventoryArchive> ItemInventoryArchives { get; set; }
        public virtual ICollection<ItemInventoryTransactionLine> ItemInventoryTransactionLines { get; set; }
        public virtual ICollection<ItemSiteInventory> ItemSiteInventories { get; set; }
        public virtual ICollection<NestingResultItemListingArchive> NestingResultItemListingArchives { get; set; }
        public virtual ICollection<NestingResultItemListing> NestingResultItemListings { get; set; }
        public virtual ICollection<ProductionWorkOrderContractArchive> ProductionWorkOrderContractArchives { get; set; }
        public virtual ICollection<ProductionWorkOrderContract> ProductionWorkOrderContracts { get; set; }
    }
}
