using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwProductionworkstationSearch
    {
        public int ProductionWorkStationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte RoutingEnabled { get; set; }
        public string Facility { get; set; }
        public int? FacilityId { get; set; }
        public int ItemLocationId { get; set; }
        public string ItemLocation { get; set; }
        public int? WorkshopAreaId { get; set; }
        public string WorkshopArea { get; set; }
        public string NcfilePath { get; set; }
        public string PostProcessor { get; set; }
        public string ParameterFile { get; set; }
        public byte OppositeHand { get; set; }
        public double? GripEndZone { get; set; }
        public double? SawBladeThickness { get; set; }
        public double AngleFillerGap { get; set; }
        public string AngleNestingEngine { get; set; }
        public string LinearNestingEngine { get; set; }
        public string PlateNestingEngine { get; set; }
        public int? DefaultReportId { get; set; }
        public string DefaultReport { get; set; }
        public string EmailAddress { get; set; }
        public string DefaultPrinter { get; set; }
        public double StandardHourlyRate { get; set; }
        public double OvertimeHourlyRate { get; set; }
        public bool CombineConsecutiveProcesses { get; set; }
        public bool WorkstationFeedback { get; set; }
        public string FeedbackPath { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public bool System { get; set; }
    }
}
