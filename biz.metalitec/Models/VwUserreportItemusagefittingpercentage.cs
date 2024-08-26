using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportItemusagefittingpercentage
    {
        public int ItemUsageId { get; set; }
        public string LabourUsage { get; set; }
        public byte Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedOn { get; set; }
        public double? ToLength { get; set; }
        public double? FittingsPercentage { get; set; }
        public double? RatePer { get; set; }
        public double? HoursPer { get; set; }
    }
}
