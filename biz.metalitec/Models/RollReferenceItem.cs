using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class RollReferenceItem
    {
        public int RollReferenceItemId { get; set; }
        public int RollReferenceId { get; set; }
        public int ItemSupplierId { get; set; }
        public int ItemId { get; set; }

        public virtual Item Item { get; set; }
        public virtual ItemSupplier ItemSupplier { get; set; }
        public virtual RollReference RollReference { get; set; }
    }
}
