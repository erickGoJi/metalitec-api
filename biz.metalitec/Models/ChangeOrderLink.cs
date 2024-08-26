using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ChangeOrderLink
    {
        public int ChangeOrderLinkId { get; set; }
        public int? ChangeOrderId { get; set; }
        public int? ChangeOrderClientChangeOrderId { get; set; }

        public virtual ChangeOrder ChangeOrder { get; set; }
        public virtual ChangeOrderClientChangeOrder ChangeOrderClientChangeOrder { get; set; }
    }
}
