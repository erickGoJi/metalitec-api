using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemInventoryGroupProperty
    {
        public int ItemInventoryGroupPropertyId { get; set; }
        public int? ItemInventoryId { get; set; }
        public string TrackingNumbers { get; set; }
        public string Allocations { get; set; }
        public string Contracts { get; set; }
        public string Phases { get; set; }
        public string Lots { get; set; }
        public string Classifications { get; set; }
        public string ContractIds { get; set; }
        public string ReservationTypes { get; set; }
        public int? ItemSiteInventoryId { get; set; }
        public string ContractBatch { get; set; }

        public virtual ItemInventory ItemInventory { get; set; }
    }
}
