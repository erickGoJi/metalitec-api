using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportContractrevision
    {
        public int ContractRevisionId { get; set; }
        public int ContractId { get; set; }
        public string Contract { get; set; }
        public string Drawing { get; set; }
        public int? ContractMarkId { get; set; }
        public string Mark { get; set; }
        public string ParentMark { get; set; }
        public int? ContractMarkItemId { get; set; }
        public string MarkItem { get; set; }
        public long RevisionIndex { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public string RevisionNotes { get; set; }
        public string RevisedBy { get; set; }
        public DateTime? RevisedOn { get; set; }
    }
}
