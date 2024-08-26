using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemClassification
    {
        public ItemClassification()
        {
            ItemInventories = new HashSet<ItemInventory>();
            ItemInventoryArchives = new HashSet<ItemInventoryArchive>();
            ItemInventoryInstances = new HashSet<ItemInventoryInstance>();
            ItemInventoryTransactionLineInstances = new HashSet<ItemInventoryTransactionLineInstance>();
            ItemInventoryTransactionLines = new HashSet<ItemInventoryTransactionLine>();
            ItemSiteInventoryInstances = new HashSet<ItemSiteInventoryInstance>();
            NestingResultSupplyLengthInstances = new HashSet<NestingResultSupplyLengthInstance>();
        }

        public int ItemClassificationId { get; set; }
        /// <summary>
        /// Name of classification
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Alternative Name of the classification
        /// </summary>
        public string AltName { get; set; }
        /// <summary>
        /// Description of the classification
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Can this item be used in stock transactions
        /// </summary>
        public byte IsUsable { get; set; }
        public string Color { get; set; }
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

        public virtual ICollection<ItemInventory> ItemInventories { get; set; }
        public virtual ICollection<ItemInventoryArchive> ItemInventoryArchives { get; set; }
        public virtual ICollection<ItemInventoryInstance> ItemInventoryInstances { get; set; }
        public virtual ICollection<ItemInventoryTransactionLineInstance> ItemInventoryTransactionLineInstances { get; set; }
        public virtual ICollection<ItemInventoryTransactionLine> ItemInventoryTransactionLines { get; set; }
        public virtual ICollection<ItemSiteInventoryInstance> ItemSiteInventoryInstances { get; set; }
        public virtual ICollection<NestingResultSupplyLengthInstance> NestingResultSupplyLengthInstances { get; set; }
    }
}
