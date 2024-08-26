using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemInventoryTrackingGuid
    {
        public ItemInventoryTrackingGuid()
        {
            Additions = new HashSet<Addition>();
            ItemInventoryTrackingGuidLinks = new HashSet<ItemInventoryTrackingGuidLink>();
            ItemInventoryTransactionLineInstances = new HashSet<ItemInventoryTransactionLineInstance>();
            NestingResultSupplyLengthInstances = new HashSet<NestingResultSupplyLengthInstance>();
            PurchaseInvoiceItemInstances = new HashSet<PurchaseInvoiceItemInstance>();
            PurchaseOrderItemInstances = new HashSet<PurchaseOrderItemInstance>();
            SalesInvoiceItemInstances = new HashSet<SalesInvoiceItemInstance>();
            SalesOrderItemInstances = new HashSet<SalesOrderItemInstance>();
        }

        public int ItemInventoryTrackingGuidId { get; set; }
        public Guid TrackingGuid { get; set; }

        public virtual ItemInventoryInstance ItemInventoryInstance { get; set; }
        public virtual ItemSiteInventoryInstance ItemSiteInventoryInstance { get; set; }
        public virtual ICollection<Addition> Additions { get; set; }
        public virtual ICollection<ItemInventoryTrackingGuidLink> ItemInventoryTrackingGuidLinks { get; set; }
        public virtual ICollection<ItemInventoryTransactionLineInstance> ItemInventoryTransactionLineInstances { get; set; }
        public virtual ICollection<NestingResultSupplyLengthInstance> NestingResultSupplyLengthInstances { get; set; }
        public virtual ICollection<PurchaseInvoiceItemInstance> PurchaseInvoiceItemInstances { get; set; }
        public virtual ICollection<PurchaseOrderItemInstance> PurchaseOrderItemInstances { get; set; }
        public virtual ICollection<SalesInvoiceItemInstance> SalesInvoiceItemInstances { get; set; }
        public virtual ICollection<SalesOrderItemInstance> SalesOrderItemInstances { get; set; }
    }
}
