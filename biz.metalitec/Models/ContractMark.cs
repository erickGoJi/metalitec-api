using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ContractMark
    {
        public ContractMark()
        {
            ContractMarkInstances = new HashSet<ContractMarkInstance>();
            ContractMarkItems = new HashSet<ContractMarkItem>();
            ContractMarkPhaseLotItems = new HashSet<ContractMarkPhaseLotItem>();
            ContractMarkPhases = new HashSet<ContractMarkPhase>();
            ItemInventories = new HashSet<ItemInventory>();
            ItemInventoryArchives = new HashSet<ItemInventoryArchive>();
            ItemInventoryTransactionLines = new HashSet<ItemInventoryTransactionLine>();
            ItemSiteInventories = new HashSet<ItemSiteInventory>();
            ProductionRequiredTaskInstances = new HashSet<ProductionRequiredTaskInstance>();
            ProductionWorkOrderContractArchives = new HashSet<ProductionWorkOrderContractArchive>();
            ProductionWorkOrderContracts = new HashSet<ProductionWorkOrderContract>();
        }

        public int MarkId { get; set; }
        public int ContractDrawingId { get; set; }
        public bool IsAssemblyMark { get; set; }
        public bool SiteAssembled { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string MainMemberItemName { get; set; }
        public double Quantity { get; set; }
        public int? ParentMarkId { get; set; }
        public double Weight { get; set; }
        public double Area { get; set; }
        public string PaintFinish { get; set; }
        public string CadFile { get; set; }
        public bool OnHold { get; set; }
        public string OnHoldNotes { get; set; }
        public string Notes { get; set; }
        public int? TempKey { get; set; }
        public int Version { get; set; }
        public string RevisedBy { get; set; }
        public int? MainMemberItemId { get; set; }
        public double? MainMemberLength { get; set; }
        public double? MainMemberWidth { get; set; }
        public double UnitWeight { get; set; }
        public double UnitArea { get; set; }
        public int? MainMemberMarkItemId { get; set; }
        public bool? CreateProductionWorkOrder { get; set; }
        public bool CanReceiveInToInventory { get; set; }
        public int? ReceivableItemId { get; set; }
        public double? CoverageFactor { get; set; }
        public int? ExecutionClassId { get; set; }
        /// <summary>
        /// Store the first itemID that was used on the mark
        /// </summary>
        public int? FirstItemId { get; set; }
        public bool? IsPhaseGroup { get; set; }

        public virtual ContractDrawing ContractDrawing { get; set; }
        public virtual ICollection<ContractMarkInstance> ContractMarkInstances { get; set; }
        public virtual ICollection<ContractMarkItem> ContractMarkItems { get; set; }
        public virtual ICollection<ContractMarkPhaseLotItem> ContractMarkPhaseLotItems { get; set; }
        public virtual ICollection<ContractMarkPhase> ContractMarkPhases { get; set; }
        public virtual ICollection<ItemInventory> ItemInventories { get; set; }
        public virtual ICollection<ItemInventoryArchive> ItemInventoryArchives { get; set; }
        public virtual ICollection<ItemInventoryTransactionLine> ItemInventoryTransactionLines { get; set; }
        public virtual ICollection<ItemSiteInventory> ItemSiteInventories { get; set; }
        public virtual ICollection<ProductionRequiredTaskInstance> ProductionRequiredTaskInstances { get; set; }
        public virtual ICollection<ProductionWorkOrderContractArchive> ProductionWorkOrderContractArchives { get; set; }
        public virtual ICollection<ProductionWorkOrderContract> ProductionWorkOrderContracts { get; set; }
    }
}
