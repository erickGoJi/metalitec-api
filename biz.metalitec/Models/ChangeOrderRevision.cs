using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ChangeOrderRevision
    {
        public int ChangeOrderRevisionId { get; set; }
        public int ChangeOrderId { get; set; }
        public int? DocumentRevisionCodeId { get; set; }
        public byte? Latest { get; set; }
        public string Details { get; set; }
        public int RevisedBy { get; set; }

        public virtual ChangeOrder ChangeOrder { get; set; }
        public virtual Contact RevisedByNavigation { get; set; }
    }
}
