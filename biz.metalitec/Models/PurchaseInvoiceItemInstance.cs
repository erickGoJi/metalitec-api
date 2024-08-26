using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class PurchaseInvoiceItemInstance
    {
        public int PurchaseInvoiceItemInstanceId { get; set; }
        public int PurchaseInvoiceItemId { get; set; }
        public int Instance { get; set; }
        public int? ItemInventoryTrackingGuidId { get; set; }
        public string TrackingNumber { get; set; }

        public virtual ItemInventoryTrackingGuid ItemInventoryTrackingGuid { get; set; }
        public virtual PurchaseInvoiceItem PurchaseInvoiceItem { get; set; }
    }
}
