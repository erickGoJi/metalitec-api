using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemTracking
    {
        public int ItemId { get; set; }
        public string TrackingNumber { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int Version { get; set; }
        public int ItemTrackingNumberId { get; set; }
        public byte[] TrackingNumberHash { get; set; }

        public virtual Item Item { get; set; }
    }
}
