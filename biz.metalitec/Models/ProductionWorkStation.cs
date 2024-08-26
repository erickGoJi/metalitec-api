using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionWorkStation
    {
        public ProductionWorkStation()
        {
            PlanningDetails = new HashSet<PlanningDetail>();
            ProductionProcesses = new HashSet<ProductionProcess>();
            ProductionTemplateProcessTimings = new HashSet<ProductionTemplateProcessTiming>();
            ProductionWorkOrderProcessArchives = new HashSet<ProductionWorkOrderProcessArchive>();
            ProductionWorkOrderProcessQuantities = new HashSet<ProductionWorkOrderProcessQuantity>();
            ProductionWorkOrderProcessQuantityHistoryArchiveFromProductionWorkStations = new HashSet<ProductionWorkOrderProcessQuantityHistoryArchive>();
            ProductionWorkOrderProcessQuantityHistoryArchiveProductionWorkStations = new HashSet<ProductionWorkOrderProcessQuantityHistoryArchive>();
            ProductionWorkOrderProcessQuantityHistoryFromProductionWorkStations = new HashSet<ProductionWorkOrderProcessQuantityHistory>();
            ProductionWorkOrderProcessQuantityHistoryProductionWorkStations = new HashSet<ProductionWorkOrderProcessQuantityHistory>();
            ProductionWorkOrderProcesses = new HashSet<ProductionWorkOrderProcess>();
            ProductionWorkStationRuleProductionWorkStations = new HashSet<ProductionWorkStationRule>();
            ProductionWorkStationRuleRelatedProductionWorkstations = new HashSet<ProductionWorkStationRule>();
            ProductionWorkStationRuleVms = new HashSet<ProductionWorkStationRuleVm>();
            WorkstationProcesses = new HashSet<WorkstationProcess>();
        }

        public int ProductionWorkStationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte RoutingEnabled { get; set; }
        public int ItemLocationId { get; set; }
        public int? WorkshopAreaId { get; set; }
        /// <summary>
        /// Output paths can include runtime variables. Available variables are %Project%, %Contract%, %Phase%, %Lot%, %Drawing%, %Mark%, %MarkItem%, %MarkItemBundle%, %MarkBundle%, %CuttingPlan%, %Workstation%, %Facility%, %Location% and %BatchName%.
        /// </summary>
        public string NcfilePath { get; set; }
        /// <summary>
        /// Link to PostProcessor Lookup
        /// </summary>
        public int? PostProcessorId { get; set; }
        public string ParameterFile { get; set; }
        /// <summary>
        /// Stamp Text can include runtime variables, for example: %Project%-%Contract%-%Phase%-%Lot%-%Drawing%-%Mark%-%MarkItem%-%ProductionWorkOrderContract%-%MarkItemBundle%-%MarkBundle%-%CuttingPlan%-%Workstation%-%Facility%-%Location%-%BatchName%.
        /// </summary>
        public string StampText { get; set; }
        public byte OppositeHand { get; set; }
        public double? GripEndZone { get; set; }
        public double? SawBladeThick { get; set; }
        /// <summary>
        /// Lookup: Full List, Grouped List, Barcode Labels, Parent Bar Summary, Parent Bar List
        /// </summary>
        public int? DefaultReportId { get; set; }
        public string Emailaddress { get; set; }
        public string DefaultPrinter { get; set; }
        public double StandardHourlyRate { get; set; }
        public double OvertimeHourlyRate { get; set; }
        public string Notes { get; set; }
        /// <summary>
        /// The date of the last update.
        /// </summary>
        public DateTime UpdatedOn { get; set; }
        /// <summary>
        /// The last updater
        /// </summary>
        public string UpdatedBy { get; set; }
        /// <summary>
        /// Date the record was created.
        /// </summary>
        public DateTime CreatedOn { get; set; }
        /// <summary>
        /// The record creator
        /// </summary>
        public string CreatedBy { get; set; }
        public int Version { get; set; }
        public bool System { get; set; }
        public bool CombineConsecutiveProcessMove { get; set; }
        public bool ApplyStampLocation { get; set; }
        public int? StampXlocation { get; set; }
        public int? StampYlocation { get; set; }
        public int Sort { get; set; }
        public bool WorkstationFeedback { get; set; }
        public string FeedbackFileExtension { get; set; }
        public int? DefaultEmployeeId { get; set; }
        public string FeedbackPath { get; set; }
        public string FeedbackScript { get; set; }
        public string MappingEmployee { get; set; }
        public string MappingProcess { get; set; }
        public string MappingDuration { get; set; }
        public string MappingStarttime { get; set; }
        public string MappingStoptime { get; set; }
        public string MappingContract { get; set; }
        public string MappingMarkItem { get; set; }
        public string MappingPhase { get; set; }
        public string MappingLot { get; set; }
        public string MappingQuantity { get; set; }
        public byte CamdrawingIdentification { get; set; }
        public byte CammarkItemIdentification { get; set; }
        public string NestingMachineName { get; set; }
        public double AngleFillerGap { get; set; }
        public string MappingMarkItemGuid { get; set; }
        public int? AngleEngineId { get; set; }
        public string FenicePlusSettings { get; set; }
        public int? LinearEngineId { get; set; }
        public int? PlateEngineId { get; set; }
        public byte? PlateEngineUnits { get; set; }
        public bool? PlatePromptEditNest { get; set; }
        public bool? PlateShowApplication { get; set; }
        public double? BottomEdgeClearance { get; set; }
        public double? LeftEdgeClearance { get; set; }
        public double? RightEdgeClearance { get; set; }
        public double? TopEdgeClearance { get; set; }

        public virtual ItemLocation ItemLocation { get; set; }
        public virtual ICollection<PlanningDetail> PlanningDetails { get; set; }
        public virtual ICollection<ProductionProcess> ProductionProcesses { get; set; }
        public virtual ICollection<ProductionTemplateProcessTiming> ProductionTemplateProcessTimings { get; set; }
        public virtual ICollection<ProductionWorkOrderProcessArchive> ProductionWorkOrderProcessArchives { get; set; }
        public virtual ICollection<ProductionWorkOrderProcessQuantity> ProductionWorkOrderProcessQuantities { get; set; }
        public virtual ICollection<ProductionWorkOrderProcessQuantityHistoryArchive> ProductionWorkOrderProcessQuantityHistoryArchiveFromProductionWorkStations { get; set; }
        public virtual ICollection<ProductionWorkOrderProcessQuantityHistoryArchive> ProductionWorkOrderProcessQuantityHistoryArchiveProductionWorkStations { get; set; }
        public virtual ICollection<ProductionWorkOrderProcessQuantityHistory> ProductionWorkOrderProcessQuantityHistoryFromProductionWorkStations { get; set; }
        public virtual ICollection<ProductionWorkOrderProcessQuantityHistory> ProductionWorkOrderProcessQuantityHistoryProductionWorkStations { get; set; }
        public virtual ICollection<ProductionWorkOrderProcess> ProductionWorkOrderProcesses { get; set; }
        public virtual ICollection<ProductionWorkStationRule> ProductionWorkStationRuleProductionWorkStations { get; set; }
        public virtual ICollection<ProductionWorkStationRule> ProductionWorkStationRuleRelatedProductionWorkstations { get; set; }
        public virtual ICollection<ProductionWorkStationRuleVm> ProductionWorkStationRuleVms { get; set; }
        public virtual ICollection<WorkstationProcess> WorkstationProcesses { get; set; }
    }
}
