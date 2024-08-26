using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportProductionworkstation
    {
        public int ProductionWorkStationId { get; set; }
        public string WorkStation { get; set; }
        public string WorkStationDescription { get; set; }
        public byte RoutingEnabled { get; set; }
        public string ItemLocation { get; set; }
        public string WorkshopArea { get; set; }
        public string OutputPath { get; set; }
        public string PostProcessor { get; set; }
        public string ParameterFile { get; set; }
        public string StampText { get; set; }
        public byte OppositeHand { get; set; }
        public double? GripEndZone { get; set; }
        public double? SawBladeThickness { get; set; }
        public string DefaultReport { get; set; }
        public bool CombineConsecutiveProcesses { get; set; }
        public string DefaultPrinter { get; set; }
        public double StandardHourlyRate { get; set; }
        public double OvertimeHourlyRate { get; set; }
        public int Sort { get; set; }
        public string WorkStationNotes { get; set; }
    }
}
