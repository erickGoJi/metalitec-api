using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwProductionprocessSearch
    {
        public int ProductionProcessId { get; set; }
        public int ProductionStageId { get; set; }
        public string Name { get; set; }
        public string Stage { get; set; }
        public string Description { get; set; }
        public int ItemLocationTypeId { get; set; }
        public string ItemLocationType { get; set; }
        public int DefaultItemLocationId { get; set; }
        public string ItemLocation { get; set; }
        public byte RequiresWorkstation { get; set; }
        public string DefaultWorkStation { get; set; }
        public int? EstimateProcessId { get; set; }
        public string EstimateProcess { get; set; }
        public int CostCodeId { get; set; }
        public string CostCode { get; set; }
        public double DefaultFixedMinutes { get; set; }
        public double DefaultProcessMinutes { get; set; }
        public double StandardHourlyRate { get; set; }
        public double OvertimeHourlyRate { get; set; }
        public byte DisplayTimeUnitId { get; set; }
        public string DisplayTimeUnit { get; set; }
        public bool RequiresProductionDeliveryNote { get; set; }
        public int DefaultLocationTransferReportId { get; set; }
        public string DefaultLocationTransferReport { get; set; }
        public string DefaultPrinter { get; set; }
        public bool Inspection { get; set; }
        public int Sort { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}
