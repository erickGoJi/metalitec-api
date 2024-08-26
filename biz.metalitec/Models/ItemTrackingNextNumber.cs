using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemTrackingNextNumber
    {
        public int ItemId { get; set; }
        public int TrackingNextNumber { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int Version { get; set; }
    }
}
