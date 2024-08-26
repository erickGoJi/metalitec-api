using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ContractRevision
    {
        public int ContractRevisionId { get; set; }
        public int ContractListingId { get; set; }
        public int ContractDrawingId { get; set; }
        public int? MarkId { get; set; }
        public int? ParentMarkId { get; set; }
        public int? MarkItemId { get; set; }
        public long RevisionIndex { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Notes { get; set; }
        public string RevisedBy { get; set; }
        public DateTime? RevisedOn { get; set; }

        public virtual ContractListing ContractListing { get; set; }
    }
}
