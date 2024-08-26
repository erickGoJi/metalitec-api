using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class DocumentPackageRecipient
    {
        public int DocumentPackageRecipientId { get; set; }
        public int DocumentPackageId { get; set; }
        public int ContactId { get; set; }
        public byte? TeamLeader { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual DocumentPackage DocumentPackage { get; set; }
    }
}
