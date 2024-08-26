using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class SalesOrderItemInstance
    {
        public int SalesOrderItemInstanceId { get; set; }
        public int SalesOrderItemId { get; set; }
        public int Instance { get; set; }
        public int? ItemInventoryTrackingGuidId { get; set; }
        public string TrackingNumber { get; set; }
        public int? ItemReservationId { get; set; }
        public double ToDeliver { get; set; }
        public double Delivered { get; set; }
        public double Invoiced { get; set; }

        public virtual ItemInventoryTrackingGuid ItemInventoryTrackingGuid { get; set; }
        public virtual ItemReservation ItemReservation { get; set; }
        public virtual SalesOrderItem SalesOrderItem { get; set; }
    }
}
