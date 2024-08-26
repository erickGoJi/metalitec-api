using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ChangeOrderClientDocumentLink
    {
        public int ChangeOrderClientDocumentLinkId { get; set; }
        public int DocumentId { get; set; }
        public int ChangeOrderClientChangeOrderId { get; set; }

        public virtual ChangeOrderClientChangeOrder ChangeOrderClientChangeOrder { get; set; }
        public virtual Document Document { get; set; }
    }
}
