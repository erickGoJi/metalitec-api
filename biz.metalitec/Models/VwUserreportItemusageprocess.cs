using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportItemusageprocess
    {
        public int ItemUsageId { get; set; }
        public string LabourUsage { get; set; }
        public byte Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedOn { get; set; }
        public string Process { get; set; }
        public string ProcessDescription { get; set; }
        public double? HourlyRate { get; set; }
        public string CostCode { get; set; }
        public string CostCentre { get; set; }
        public int? Quantity { get; set; }
        public string ProcessUnitType { get; set; }
        public double? PerUnitQuantity { get; set; }
        public double? UpToSize { get; set; }
        public double? SetupTime { get; set; }
        public double? UnitTimeMins { get; set; }
        public string ProcessNotes { get; set; }
    }
}
