using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class Unit
    {
        public Unit()
        {
            AdditionTemplates = new HashSet<AdditionTemplate>();
            Additions = new HashSet<Addition>();
            ItemCustomers = new HashSet<ItemCustomer>();
            ItemDefaultCostUnits = new HashSet<Item>();
            ItemDefaultInventoryUnits = new HashSet<Item>();
            ItemDefaultSellUnits = new HashSet<Item>();
            ItemInventories = new HashSet<ItemInventory>();
            ItemInventoryArchives = new HashSet<ItemInventoryArchive>();
            ItemInventoryTransactionLineTransactionOrderUnits = new HashSet<ItemInventoryTransactionLine>();
            ItemInventoryTransactionLineTransactionUnits = new HashSet<ItemInventoryTransactionLine>();
            ItemInventoryTransactionLineUnits = new HashSet<ItemInventoryTransactionLine>();
            ItemInventoryTransactions = new HashSet<ItemInventoryTransaction>();
            ItemListings = new HashSet<ItemListing>();
            ItemSiteInventories = new HashSet<ItemSiteInventory>();
            ItemSuppliers = new HashSet<ItemSupplier>();
            PurchaseOrderItemOrderUnits = new HashSet<PurchaseOrderItem>();
            PurchaseOrderItemUnits = new HashSet<PurchaseOrderItem>();
        }

        public int UnitId { get; set; }
        public string Name { get; set; }
        public int? BaseUnitId { get; set; }
        public double? Conversion { get; set; }
        /// <summary>
        /// The record creator
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// Date the record was created.
        /// </summary>
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// The last updater
        /// </summary>
        public string UpdatedBy { get; set; }
        /// <summary>
        /// The date of the last update.
        /// </summary>
        public DateTime? UpdatedOn { get; set; }
        public int Version { get; set; }
        public int System { get; set; }
        public string EdiunitCode { get; set; }

        public virtual ICollection<AdditionTemplate> AdditionTemplates { get; set; }
        public virtual ICollection<Addition> Additions { get; set; }
        public virtual ICollection<ItemCustomer> ItemCustomers { get; set; }
        public virtual ICollection<Item> ItemDefaultCostUnits { get; set; }
        public virtual ICollection<Item> ItemDefaultInventoryUnits { get; set; }
        public virtual ICollection<Item> ItemDefaultSellUnits { get; set; }
        public virtual ICollection<ItemInventory> ItemInventories { get; set; }
        public virtual ICollection<ItemInventoryArchive> ItemInventoryArchives { get; set; }
        public virtual ICollection<ItemInventoryTransactionLine> ItemInventoryTransactionLineTransactionOrderUnits { get; set; }
        public virtual ICollection<ItemInventoryTransactionLine> ItemInventoryTransactionLineTransactionUnits { get; set; }
        public virtual ICollection<ItemInventoryTransactionLine> ItemInventoryTransactionLineUnits { get; set; }
        public virtual ICollection<ItemInventoryTransaction> ItemInventoryTransactions { get; set; }
        public virtual ICollection<ItemListing> ItemListings { get; set; }
        public virtual ICollection<ItemSiteInventory> ItemSiteInventories { get; set; }
        public virtual ICollection<ItemSupplier> ItemSuppliers { get; set; }
        public virtual ICollection<PurchaseOrderItem> PurchaseOrderItemOrderUnits { get; set; }
        public virtual ICollection<PurchaseOrderItem> PurchaseOrderItemUnits { get; set; }
    }
}
