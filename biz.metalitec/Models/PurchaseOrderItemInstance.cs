using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class PurchaseOrderItemInstance
    {
        public int PurchaseOrderItemInstanceId { get; set; }
        public int PurchaseOrderItemId { get; set; }
        public int? ItemReservationId { get; set; }
        public int Instance { get; set; }
        public bool Received { get; set; }
        public int ItemInventoryTrackingGuidId { get; set; }
        /// <summary>
        /// ~The source of material specified during nesting - 0 Supplier Lengths, 1 - Cut to Length, 2 - Mills Standard Length, 3 - Entered Lengths
        /// </summary>
        public byte? MaterialSource { get; set; }

        public virtual ItemInventoryTrackingGuid ItemInventoryTrackingGuid { get; set; }
        public virtual ItemReservation ItemReservation { get; set; }
        public virtual PurchaseOrderItem PurchaseOrderItem { get; set; }
    }
}
