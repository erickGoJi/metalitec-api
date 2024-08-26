using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class SystemObjectAttachment
    {
        public SystemObjectAttachment()
        {
            ApplicationForPaymentCorrespondences = new HashSet<ApplicationForPaymentCorrespondence>();
            ChangeOrderAttachmentLinks = new HashSet<ChangeOrderAttachmentLink>();
        }

        public int AttachmentId { get; set; }
        public int SystemObjectId { get; set; }
        public int SystemObjectKey { get; set; }
        public string Name { get; set; }
        public string FileImage { get; set; }
        public int System { get; set; }
        public string FilePath { get; set; }

        public virtual SystemObject SystemObject { get; set; }
        public virtual ICollection<ApplicationForPaymentCorrespondence> ApplicationForPaymentCorrespondences { get; set; }
        public virtual ICollection<ChangeOrderAttachmentLink> ChangeOrderAttachmentLinks { get; set; }
    }
}
