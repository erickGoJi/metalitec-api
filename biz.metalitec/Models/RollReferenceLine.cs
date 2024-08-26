using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class RollReferenceLine
    {
        public RollReferenceLine()
        {
            PurchaseOrderItems = new HashSet<PurchaseOrderItem>();
        }

        public int RollReferenceLineId { get; set; }
        public int RollReferenceId { get; set; }
        public string RollReference { get; set; }
        public DateTime? RollDate { get; set; }
        public int? Capacity { get; set; }

        public virtual RollReference RollReferenceNavigation { get; set; }
        public virtual ICollection<PurchaseOrderItem> PurchaseOrderItems { get; set; }
    }
}
