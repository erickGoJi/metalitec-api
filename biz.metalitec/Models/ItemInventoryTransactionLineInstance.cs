using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemInventoryTransactionLineInstance
    {
        public int TransactionLineInstanceId { get; set; }
        public int TransactionLineId { get; set; }
        public int? ItemReservationId { get; set; }
        public int Instance { get; set; }
        public int ItemInventoryTrackingGuidId { get; set; }
        public string TrackingNumber { get; set; }
        public byte? ReversalStatus { get; set; }
        public byte? ReversalTransActionLineId { get; set; }
        public int? ItemClassificationId { get; set; }
        public int? NestingResultAllocationId { get; set; }
        public int? NestingResultItemListingId { get; set; }
        public int? ParentMarkInstanceId { get; set; }
        public int? ContractMarkInstanceId { get; set; }
        public int? ContractMarkItemInstanceId { get; set; }
        public int? ProductionWorkOrderContractId { get; set; }
        public int? UncutContractMarkItemInstanceId { get; set; }

        public virtual ItemClassification ItemClassification { get; set; }
        public virtual ItemInventoryTrackingGuid ItemInventoryTrackingGuid { get; set; }
        public virtual ItemReservation ItemReservation { get; set; }
        public virtual ContractMarkInstance ParentMarkInstance { get; set; }
        public virtual ProductionWorkOrderContract ProductionWorkOrderContract { get; set; }
        public virtual ItemInventoryTransactionLine TransactionLine { get; set; }
    }
}
