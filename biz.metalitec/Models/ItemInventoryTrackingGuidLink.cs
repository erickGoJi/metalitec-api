using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemInventoryTrackingGuidLink
    {
        public int ItemInventoryTrackingGuidLinkId { get; set; }
        public int? ItemInventoryTrackingGuidIdOut { get; set; }
        public int? ItemInventoryTrackingGuidIdIn { get; set; }

        public virtual ItemInventoryTrackingGuid ItemInventoryTrackingGuidIdOutNavigation { get; set; }
    }
}
