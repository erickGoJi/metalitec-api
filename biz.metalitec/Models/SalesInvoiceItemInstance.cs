using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class SalesInvoiceItemInstance
    {
        public int SalesInvoiceItemInstanceId { get; set; }
        public int SalesInvoiceItemId { get; set; }
        public int Instance { get; set; }
        public int? ItemInventoryTrackingGuidId { get; set; }
        public string TrackingNumber { get; set; }
        public int? ContractMarkPhaseLotId { get; set; }
        public int? ContractMarkInstanceId { get; set; }

        public virtual ContractMarkInstance ContractMarkInstance { get; set; }
        public virtual ContractMarkPhaseLot ContractMarkPhaseLot { get; set; }
        public virtual ItemInventoryTrackingGuid ItemInventoryTrackingGuid { get; set; }
        public virtual SalesInvoiceItem SalesInvoiceItem { get; set; }
    }
}
