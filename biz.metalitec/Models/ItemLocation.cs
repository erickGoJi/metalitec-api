using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemLocation
    {
        public ItemLocation()
        {
            ContractLocations = new HashSet<Contract>();
            ContractOffSiteItemLocations = new HashSet<Contract>();
            Facilities = new HashSet<Facility>();
            FacilityProcessWeeklyCapacities = new HashSet<FacilityProcessWeeklyCapacity>();
            FacilityTaskWeeklyCapacities = new HashSet<FacilityTaskWeeklyCapacity>();
            ItemInventories = new HashSet<ItemInventory>();
            ItemInventoryArchives = new HashSet<ItemInventoryArchive>();
            ItemInventoryTransactionLines = new HashSet<ItemInventoryTransactionLine>();
            ItemLocationRuleVms = new HashSet<ItemLocationRuleVm>();
            ItemLocationRules = new HashSet<ItemLocationRule>();
            ItemSiteInventories = new HashSet<ItemSiteInventory>();
            PlanningDetails = new HashSet<PlanningDetail>();
            ProductionContainers = new HashSet<ProductionContainer>();
            ProductionPackages = new HashSet<ProductionPackage>();
            ProductionProcesses = new HashSet<ProductionProcess>();
            ProductionProposedMovements = new HashSet<ProductionProposedMovement>();
            ProductionTemplateProcessTimings = new HashSet<ProductionTemplateProcessTiming>();
            ProductionWorkOrderProcessArchives = new HashSet<ProductionWorkOrderProcessArchive>();
            ProductionWorkOrderProcessQuantities = new HashSet<ProductionWorkOrderProcessQuantity>();
            ProductionWorkOrderProcessQuantityHistoryArchiveFromItemLocations = new HashSet<ProductionWorkOrderProcessQuantityHistoryArchive>();
            ProductionWorkOrderProcessQuantityHistoryArchiveItemLocations = new HashSet<ProductionWorkOrderProcessQuantityHistoryArchive>();
            ProductionWorkOrderProcessQuantityHistoryFromItemLocations = new HashSet<ProductionWorkOrderProcessQuantityHistory>();
            ProductionWorkOrderProcessQuantityHistoryItemLocations = new HashSet<ProductionWorkOrderProcessQuantityHistory>();
            ProductionWorkOrderProcesses = new HashSet<ProductionWorkOrderProcess>();
            ProductionWorkStations = new HashSet<ProductionWorkStation>();
            PurchaseOrderItems = new HashSet<PurchaseOrderItem>();
        }

        /// <summary>
        /// The unique location ID number generated automatically.
        /// </summary>
        public int ItemLocationId { get; set; }
        /// <summary>
        /// Enter the location name. 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Enter the location description. 
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// ~The type of location: 1 - Storage; 2 - Workshop; 3 - Subcontractor; 4 - Erection Site;5 - Off-Site; 6 - Port
        /// </summary>
        public int ItemLocationTypeId { get; set; }
        /// <summary>
        /// The record creator  
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// Date the record was created. 
        /// </summary>
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// The last updater
        /// </summary>
        public string UpdatedBy { get; set; }
        /// <summary>
        /// The date of the last update.
        /// </summary>
        public DateTime? UpdatedOn { get; set; }
        public int Version { get; set; }
        public bool System { get; set; }
        public int FacilityId { get; set; }
        public string Notes { get; set; }

        public virtual Facility Facility { get; set; }
        public virtual ICollection<Contract> ContractLocations { get; set; }
        public virtual ICollection<Contract> ContractOffSiteItemLocations { get; set; }
        public virtual ICollection<Facility> Facilities { get; set; }
        public virtual ICollection<FacilityProcessWeeklyCapacity> FacilityProcessWeeklyCapacities { get; set; }
        public virtual ICollection<FacilityTaskWeeklyCapacity> FacilityTaskWeeklyCapacities { get; set; }
        public virtual ICollection<ItemInventory> ItemInventories { get; set; }
        public virtual ICollection<ItemInventoryArchive> ItemInventoryArchives { get; set; }
        public virtual ICollection<ItemInventoryTransactionLine> ItemInventoryTransactionLines { get; set; }
        public virtual ICollection<ItemLocationRuleVm> ItemLocationRuleVms { get; set; }
        public virtual ICollection<ItemLocationRule> ItemLocationRules { get; set; }
        public virtual ICollection<ItemSiteInventory> ItemSiteInventories { get; set; }
        public virtual ICollection<PlanningDetail> PlanningDetails { get; set; }
        public virtual ICollection<ProductionContainer> ProductionContainers { get; set; }
        public virtual ICollection<ProductionPackage> ProductionPackages { get; set; }
        public virtual ICollection<ProductionProcess> ProductionProcesses { get; set; }
        public virtual ICollection<ProductionProposedMovement> ProductionProposedMovements { get; set; }
        public virtual ICollection<ProductionTemplateProcessTiming> ProductionTemplateProcessTimings { get; set; }
        public virtual ICollection<ProductionWorkOrderProcessArchive> ProductionWorkOrderProcessArchives { get; set; }
        public virtual ICollection<ProductionWorkOrderProcessQuantity> ProductionWorkOrderProcessQuantities { get; set; }
        public virtual ICollection<ProductionWorkOrderProcessQuantityHistoryArchive> ProductionWorkOrderProcessQuantityHistoryArchiveFromItemLocations { get; set; }
        public virtual ICollection<ProductionWorkOrderProcessQuantityHistoryArchive> ProductionWorkOrderProcessQuantityHistoryArchiveItemLocations { get; set; }
        public virtual ICollection<ProductionWorkOrderProcessQuantityHistory> ProductionWorkOrderProcessQuantityHistoryFromItemLocations { get; set; }
        public virtual ICollection<ProductionWorkOrderProcessQuantityHistory> ProductionWorkOrderProcessQuantityHistoryItemLocations { get; set; }
        public virtual ICollection<ProductionWorkOrderProcess> ProductionWorkOrderProcesses { get; set; }
        public virtual ICollection<ProductionWorkStation> ProductionWorkStations { get; set; }
        public virtual ICollection<PurchaseOrderItem> PurchaseOrderItems { get; set; }
    }
}
