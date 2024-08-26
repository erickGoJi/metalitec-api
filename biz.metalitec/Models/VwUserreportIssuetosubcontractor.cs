using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportIssuetosubcontractor
    {
        public int IssueToSubContractorId { get; set; }
        public string IssueToSubContractor { get; set; }
        public string IssueToSubContractorDescription { get; set; }
        public DateTime IssueToSubContractorDate { get; set; }
        public byte Complete { get; set; }
        public string Reference { get; set; }
        public string ItemLocation { get; set; }
        public string ShippingAgent { get; set; }
        public string IssueToSubContractorNotes { get; set; }
    }
}
