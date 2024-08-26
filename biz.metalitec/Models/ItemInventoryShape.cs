using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemInventoryShape
    {
        public ItemInventoryShape()
        {
            ItemInventories = new HashSet<ItemInventory>();
            ItemInventoryArchives = new HashSet<ItemInventoryArchive>();
            ItemInventoryTransactionLines = new HashSet<ItemInventoryTransactionLine>();
            ItemSiteInventories = new HashSet<ItemSiteInventory>();
            NestingResultAllocationArchives = new HashSet<NestingResultAllocationArchive>();
            NestingResultAllocations = new HashSet<NestingResultAllocation>();
            NestingResultSupplyLengthArchives = new HashSet<NestingResultSupplyLengthArchive>();
            NestingResultSupplyLengths = new HashSet<NestingResultSupplyLength>();
        }

        public int ItemInventoryShapeId { get; set; }
        public string Shape { get; set; }
        public int? Chksum { get; set; }

        public virtual ICollection<ItemInventory> ItemInventories { get; set; }
        public virtual ICollection<ItemInventoryArchive> ItemInventoryArchives { get; set; }
        public virtual ICollection<ItemInventoryTransactionLine> ItemInventoryTransactionLines { get; set; }
        public virtual ICollection<ItemSiteInventory> ItemSiteInventories { get; set; }
        public virtual ICollection<NestingResultAllocationArchive> NestingResultAllocationArchives { get; set; }
        public virtual ICollection<NestingResultAllocation> NestingResultAllocations { get; set; }
        public virtual ICollection<NestingResultSupplyLengthArchive> NestingResultSupplyLengthArchives { get; set; }
        public virtual ICollection<NestingResultSupplyLength> NestingResultSupplyLengths { get; set; }
    }
}
