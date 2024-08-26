using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportItemusagefitting
    {
        public int ItemUsageId { get; set; }
        public string LabourUsage { get; set; }
        public byte Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedOn { get; set; }
        public string FittingItemType { get; set; }
        public int? FittingId { get; set; }
        public int? FittingQuantity { get; set; }
        public string UnitType { get; set; }
        public double? PerUnitQuantity { get; set; }
        public double? UpToSize { get; set; }
        public string FittingNotes { get; set; }
    }
}
