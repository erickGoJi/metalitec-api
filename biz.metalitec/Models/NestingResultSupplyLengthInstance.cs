using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class NestingResultSupplyLengthInstance
    {
        public int NestingResultSupplyLengthInstanceId { get; set; }
        public int NestingResultSupplyLengthId { get; set; }
        public int ItemInventoryTrackingGuidid { get; set; }
        public int? ItemClassificationId { get; set; }
        public int? LockItemInventoryTransId { get; set; }
        public int? ItemReservationId { get; set; }

        public virtual ItemClassification ItemClassification { get; set; }
        public virtual ItemInventoryTrackingGuid ItemInventoryTrackingGuid { get; set; }
        public virtual ItemReservation ItemReservation { get; set; }
        public virtual NestingResultSupplyLength NestingResultSupplyLength { get; set; }
    }
}
