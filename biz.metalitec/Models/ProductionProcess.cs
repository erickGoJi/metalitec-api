using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionProcess
    {
        public ProductionProcess()
        {
            ContractLotUserDateProcesses = new HashSet<ContractLotUserDateProcess>();
            EmployeeProcesses = new HashSet<EmployeeProcess>();
            FacilityProcessWeeklyCapacities = new HashSet<FacilityProcessWeeklyCapacity>();
            ItemLocationRules = new HashSet<ItemLocationRule>();
            PlanningDetails = new HashSet<PlanningDetail>();
            ProductionContainerItemArchiveFromProductionProcesses = new HashSet<ProductionContainerItemArchive>();
            ProductionContainerItemArchiveToProductionProcesses = new HashSet<ProductionContainerItemArchive>();
            ProductionContainerItemFromProductionProcesses = new HashSet<ProductionContainerItem>();
            ProductionContainerItemToProductionProcesses = new HashSet<ProductionContainerItem>();
            ProductionPackageItemArchiveFromProductionProcesses = new HashSet<ProductionPackageItemArchive>();
            ProductionPackageItemArchiveToProductionProcesses = new HashSet<ProductionPackageItemArchive>();
            ProductionPackageItemFromProductionProcesses = new HashSet<ProductionPackageItem>();
            ProductionPackageItemToProductionProcesses = new HashSet<ProductionPackageItem>();
            ProductionProcessCamcrossReferences = new HashSet<ProductionProcessCamcrossReference>();
            ProductionProcessRoles = new HashSet<ProductionProcessRole>();
            ProductionProcessSequenceNextProductionProcesses = new HashSet<ProductionProcessSequence>();
            ProductionProcessSequenceProductionProcesses = new HashSet<ProductionProcessSequence>();
            ProductionProposedMovementItemArchiveFromProductionProcesses = new HashSet<ProductionProposedMovementItemArchive>();
            ProductionProposedMovementItemArchiveToProductionProcesses = new HashSet<ProductionProposedMovementItemArchive>();
            ProductionProposedMovementItemFromProductionProcesses = new HashSet<ProductionProposedMovementItem>();
            ProductionProposedMovementItemToProductionProcesses = new HashSet<ProductionProposedMovementItem>();
            ProductionRequiredTaskStrategyProcesses = new HashSet<ProductionRequiredTaskStrategyProcess>();
            ProductionTemplateProcesses = new HashSet<ProductionTemplateProcess>();
            ProductionWorkOrderProcessArchives = new HashSet<ProductionWorkOrderProcessArchive>();
            ProductionWorkOrderProcessQuantityHistoryArchiveFromProductionProcesses = new HashSet<ProductionWorkOrderProcessQuantityHistoryArchive>();
            ProductionWorkOrderProcessQuantityHistoryArchiveProductionProcesses = new HashSet<ProductionWorkOrderProcessQuantityHistoryArchive>();
            ProductionWorkOrderProcessQuantityHistoryFromProductionProcesses = new HashSet<ProductionWorkOrderProcessQuantityHistory>();
            ProductionWorkOrderProcessQuantityHistoryProductionProcesses = new HashSet<ProductionWorkOrderProcessQuantityHistory>();
            ProductionWorkOrderProcesses = new HashSet<ProductionWorkOrderProcess>();
            ProductionWorkStationRules = new HashSet<ProductionWorkStationRule>();
            WorkstationProcesses = new HashSet<WorkstationProcess>();
        }

        public int ProductionProcessId { get; set; }
        public int ProductionStageId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ItemLocationTypeId { get; set; }
        public int DefaultItemLocationId { get; set; }
        public byte RequiresWorkstation { get; set; }
        public int DefaultWorkStationId { get; set; }
        public int? EstimateProcessId { get; set; }
        public int? FittingProcessId { get; set; }
        public int CostCodeId { get; set; }
        public double DefaultFixedMinutes { get; set; }
        public double DefaultProcessMinutes { get; set; }
        public double StandardHourlyRate { get; set; }
        public double OvertimeHourlyRate { get; set; }
        /// <summary>
        /// Minutes, Hours, Days
        /// </summary>
        public byte DisplayTimeUnitId { get; set; }
        public int? DefaultLocationTransferReportId { get; set; }
        public string DefaultPrinter { get; set; }
        public string Notes { get; set; }
        public int? CamProcessId { get; set; }
        public bool RequiresProposedMovement { get; set; }
        /// <summary>
        /// Used to define order that Process is displayed the Production Control tree
        /// </summary>
        public int Sort { get; set; }
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
        public byte System { get; set; }
        public string Color { get; set; }
        /// <summary>
        /// Used by RF Barcoding to indicate that the material needs inspecting.
        /// </summary>
        public bool Inspection { get; set; }

        public virtual CostCode CostCode { get; set; }
        public virtual ItemLocation DefaultItemLocation { get; set; }
        public virtual ProductionWorkStation DefaultWorkStation { get; set; }
        public virtual ProductionStage ProductionStage { get; set; }
        public virtual ICollection<ContractLotUserDateProcess> ContractLotUserDateProcesses { get; set; }
        public virtual ICollection<EmployeeProcess> EmployeeProcesses { get; set; }
        public virtual ICollection<FacilityProcessWeeklyCapacity> FacilityProcessWeeklyCapacities { get; set; }
        public virtual ICollection<ItemLocationRule> ItemLocationRules { get; set; }
        public virtual ICollection<PlanningDetail> PlanningDetails { get; set; }
        public virtual ICollection<ProductionContainerItemArchive> ProductionContainerItemArchiveFromProductionProcesses { get; set; }
        public virtual ICollection<ProductionContainerItemArchive> ProductionContainerItemArchiveToProductionProcesses { get; set; }
        public virtual ICollection<ProductionContainerItem> ProductionContainerItemFromProductionProcesses { get; set; }
        public virtual ICollection<ProductionContainerItem> ProductionContainerItemToProductionProcesses { get; set; }
        public virtual ICollection<ProductionPackageItemArchive> ProductionPackageItemArchiveFromProductionProcesses { get; set; }
        public virtual ICollection<ProductionPackageItemArchive> ProductionPackageItemArchiveToProductionProcesses { get; set; }
        public virtual ICollection<ProductionPackageItem> ProductionPackageItemFromProductionProcesses { get; set; }
        public virtual ICollection<ProductionPackageItem> ProductionPackageItemToProductionProcesses { get; set; }
        public virtual ICollection<ProductionProcessCamcrossReference> ProductionProcessCamcrossReferences { get; set; }
        public virtual ICollection<ProductionProcessRole> ProductionProcessRoles { get; set; }
        public virtual ICollection<ProductionProcessSequence> ProductionProcessSequenceNextProductionProcesses { get; set; }
        public virtual ICollection<ProductionProcessSequence> ProductionProcessSequenceProductionProcesses { get; set; }
        public virtual ICollection<ProductionProposedMovementItemArchive> ProductionProposedMovementItemArchiveFromProductionProcesses { get; set; }
        public virtual ICollection<ProductionProposedMovementItemArchive> ProductionProposedMovementItemArchiveToProductionProcesses { get; set; }
        public virtual ICollection<ProductionProposedMovementItem> ProductionProposedMovementItemFromProductionProcesses { get; set; }
        public virtual ICollection<ProductionProposedMovementItem> ProductionProposedMovementItemToProductionProcesses { get; set; }
        public virtual ICollection<ProductionRequiredTaskStrategyProcess> ProductionRequiredTaskStrategyProcesses { get; set; }
        public virtual ICollection<ProductionTemplateProcess> ProductionTemplateProcesses { get; set; }
        public virtual ICollection<ProductionWorkOrderProcessArchive> ProductionWorkOrderProcessArchives { get; set; }
        public virtual ICollection<ProductionWorkOrderProcessQuantityHistoryArchive> ProductionWorkOrderProcessQuantityHistoryArchiveFromProductionProcesses { get; set; }
        public virtual ICollection<ProductionWorkOrderProcessQuantityHistoryArchive> ProductionWorkOrderProcessQuantityHistoryArchiveProductionProcesses { get; set; }
        public virtual ICollection<ProductionWorkOrderProcessQuantityHistory> ProductionWorkOrderProcessQuantityHistoryFromProductionProcesses { get; set; }
        public virtual ICollection<ProductionWorkOrderProcessQuantityHistory> ProductionWorkOrderProcessQuantityHistoryProductionProcesses { get; set; }
        public virtual ICollection<ProductionWorkOrderProcess> ProductionWorkOrderProcesses { get; set; }
        public virtual ICollection<ProductionWorkStationRule> ProductionWorkStationRules { get; set; }
        public virtual ICollection<WorkstationProcess> WorkstationProcesses { get; set; }
    }
}
