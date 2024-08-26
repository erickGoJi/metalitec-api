using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class PurchaseOrderItemExchange
    {
        public int PurchaseOrderItemExchangeId { get; set; }
        public int ItemInventoryTransactionId { get; set; }
        public int PurchaseOrderItemId { get; set; }
        public double? Quantity { get; set; }
        public double? Length { get; set; }
        public double? Width { get; set; }
        public int? OriginalReservationId { get; set; }
        public int? ItemInventoryTrackingGuidId { get; set; }
    }
}
