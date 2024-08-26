using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportItemusage
    {
        public int ItemUsageId { get; set; }
        public string LabourUsage { get; set; }
        public byte Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedOn { get; set; }
        public int? ItemId { get; set; }
        public string Item { get; set; }
        public string SectionType { get; set; }
        public string Grade { get; set; }
    }
}
