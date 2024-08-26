using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ChangeOrderAttachmentLink
    {
        public int ChangeOrderAttachmentLinkId { get; set; }
        public int? AttachmentId { get; set; }
        public int? LabelId { get; set; }
        public int? GridType { get; set; }

        public virtual SystemObjectAttachment Attachment { get; set; }
    }
}
