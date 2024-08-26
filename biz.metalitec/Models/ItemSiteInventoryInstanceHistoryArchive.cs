using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemSiteInventoryInstanceHistoryArchive
    {
        public int? ItemSiteInventoryInstanceHistoryId { get; set; }
        public int ItemSiteInventoryHistoryId { get; set; }
        public int ItemSiteInventoryInstanceId { get; set; }
        public int ItemSiteInventoryId { get; set; }
        public int? ItemReservationId { get; set; }
        public int ItemInventoryTrackingGuidId { get; set; }
        public int? ItemTrackingNumberId { get; set; }
        public int ItemClassificationId { get; set; }
        public int? ContractMarkInstanceId { get; set; }
        public int? ContractMarkItemInstanceId { get; set; }
        public int? ProductionWorkOrderContractId { get; set; }
        public string Allocation { get; set; }
        public int? ReservationType { get; set; }
        public bool MultiContract { get; set; }
        public DateTime DateLogged { get; set; }
        public string ItemTrackingNumber { get; set; }

        public virtual ItemSiteInventoryHistoryArchive ItemSiteInventoryHistory { get; set; }
    }
}
