using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class NestingResultSupplyLengthInstanceArchive
    {
        public int NestingResultSupplyLengthInstanceId { get; set; }
        public int NestingResultSupplyLengthId { get; set; }
        public int ItemInventoryTrackingGuidid { get; set; }
        public int? ItemClassificationId { get; set; }
        public int? LockItemInventoryTransId { get; set; }
        public int? ItemReservationId { get; set; }
    }
}
