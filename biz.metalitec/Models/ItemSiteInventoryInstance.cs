using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemSiteInventoryInstance
    {
        public int ItemSiteInventoryInstanceId { get; set; }
        public int ItemSiteInventoryId { get; set; }
        public int? ItemReservationId { get; set; }
        public int Instance { get; set; }
        public int ItemInventoryTrackingGuidId { get; set; }
        public string TrackingNumber { get; set; }
        public int ItemClassificationId { get; set; }
        public byte Locked { get; set; }
        public int? LockItemInventoryTransId { get; set; }
        public int? ContractMarkInstanceId { get; set; }
        public int? ContractMarkItemInstanceId { get; set; }
        public int? ProductionWorkOrderContractId { get; set; }

        public virtual ContractMarkInstance ContractMarkInstance { get; set; }
        public virtual ContractMarkItemInstance ContractMarkItemInstance { get; set; }
        public virtual ItemClassification ItemClassification { get; set; }
        public virtual ItemInventoryTrackingGuid ItemInventoryTrackingGuid { get; set; }
        public virtual ItemReservation ItemReservation { get; set; }
        public virtual ItemSiteInventory ItemSiteInventory { get; set; }
        public virtual ItemInventoryTransactionLine LockItemInventoryTrans { get; set; }
        public virtual ProductionWorkOrderContract ProductionWorkOrderContract { get; set; }
    }
}
