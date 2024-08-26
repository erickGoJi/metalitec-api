using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ApplicationForPaymentCorrespondence
    {
        public int ApplicationForPaymentCorrespondenceId { get; set; }
        public int? ApplicationForPaymentId { get; set; }
        public int? DocumentId { get; set; }
        public int? DocumentTransmittalId { get; set; }
        public int? AttachmentId { get; set; }
        public int GridType { get; set; }

        public virtual ApplicationForPayment ApplicationForPayment { get; set; }
        public virtual SystemObjectAttachment Attachment { get; set; }
        public virtual Document Document { get; set; }
        public virtual DocumentTransmittal DocumentTransmittal { get; set; }
    }
}
