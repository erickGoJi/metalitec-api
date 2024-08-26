using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportProductionprocess
    {
        public int ProductionProcessId { get; set; }
        public string ProductionStage { get; set; }
        public string ProductionProcess { get; set; }
        public string ProductionProcessDescription { get; set; }
        public string LocationType { get; set; }
        public string DefaultItemLocation { get; set; }
        public byte RequiresWorkStation { get; set; }
        public int ProductionWorkStationId { get; set; }
        public string ProductionWorkStation { get; set; }
        public string EstimateProcess { get; set; }
        public string FittingProcess { get; set; }
        public string CostCode { get; set; }
        public string CostCentre { get; set; }
        public double DefaultFixedTime { get; set; }
        public double DefaultProcessTime { get; set; }
        public double StandardHourlyRate { get; set; }
        public double OvertimeHourlyRate { get; set; }
        public string DisplayTimeUnit { get; set; }
        public string DefaultLocationTransferReport { get; set; }
        public string DefaultPrinter { get; set; }
        public string ProductionProcessNotes { get; set; }
        public int Sort { get; set; }
    }
}
