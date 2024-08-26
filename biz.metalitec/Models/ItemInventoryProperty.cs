using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemInventoryProperty
    {
        public ItemInventoryProperty()
        {
            ItemInventories = new HashSet<ItemInventory>();
            ItemInventoryArchives = new HashSet<ItemInventoryArchive>();
            ItemInventoryTransactionLines = new HashSet<ItemInventoryTransactionLine>();
            ItemSiteInventories = new HashSet<ItemSiteInventory>();
            NestingResultSupplyLengthArchives = new HashSet<NestingResultSupplyLengthArchive>();
            NestingResultSupplyLengths = new HashSet<NestingResultSupplyLength>();
        }

        public int ItemInventoryPropertyId { get; set; }
        public int? CostCodeId { get; set; }
        public int? SupplierId { get; set; }
        public string PurchaseOrder { get; set; }
        public string Receipt { get; set; }
        public string CastReference { get; set; }
        public string TrackingNumber { get; set; }
        public string Cemark { get; set; }
        public string CountryOfOrigin { get; set; }
        public bool IsOffcut { get; set; }
        public bool HistoricalData { get; set; }
        public string MillOrigin { get; set; }
        public bool? CadweightArea { get; set; }
        public string ReceivedFromMark { get; set; }
        public double? Cambering { get; set; }
        public double? Radius { get; set; }

        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<ItemInventory> ItemInventories { get; set; }
        public virtual ICollection<ItemInventoryArchive> ItemInventoryArchives { get; set; }
        public virtual ICollection<ItemInventoryTransactionLine> ItemInventoryTransactionLines { get; set; }
        public virtual ICollection<ItemSiteInventory> ItemSiteInventories { get; set; }
        public virtual ICollection<NestingResultSupplyLengthArchive> NestingResultSupplyLengthArchives { get; set; }
        public virtual ICollection<NestingResultSupplyLength> NestingResultSupplyLengths { get; set; }
    }
}
