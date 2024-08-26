using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ContractMarkItem
    {
        public ContractMarkItem()
        {
            CombinedMarkItems = new HashSet<CombinedMarkItem>();
            ContractMarkItemInstances = new HashSet<ContractMarkItemInstance>();
            ContractMarkPhaseLotItems = new HashSet<ContractMarkPhaseLotItem>();
            ItemInventories = new HashSet<ItemInventory>();
            ItemInventoryArchives = new HashSet<ItemInventoryArchive>();
            ItemInventoryTransactionLines = new HashSet<ItemInventoryTransactionLine>();
            ItemSiteInventories = new HashSet<ItemSiteInventory>();
            ProductionRequiredTaskInstances = new HashSet<ProductionRequiredTaskInstance>();
            ProductionWorkOrderContractArchives = new HashSet<ProductionWorkOrderContractArchive>();
            ProductionWorkOrderContracts = new HashSet<ProductionWorkOrderContract>();
            SplitMarkItems = new HashSet<SplitMarkItem>();
        }

        public int MarkItemId { get; set; }
        public int MarkId { get; set; }
        public int ContractItemId { get; set; }
        public bool MainMember { get; set; }
        public double Quantity { get; set; }
        public double Weight { get; set; }
        public double Area { get; set; }
        public bool IgnoreForProcurement { get; set; }
        public string PrelimMark { get; set; }
        public string PaintFinish { get; set; }
        public bool OnHold { get; set; }
        public string OnHoldNotes { get; set; }
        public int Version { get; set; }
        public string Notes { get; set; }
        public string RevisedBy { get; set; }
        public double UnitWeight { get; set; }
        public double UnitArea { get; set; }
        public bool? CreateProductionWorkOrder { get; set; }
        public bool? BackFlush { get; set; }
        public string Reference { get; set; }

        public virtual ContractItem ContractItem { get; set; }
        public virtual ContractMark Mark { get; set; }
        public virtual ICollection<CombinedMarkItem> CombinedMarkItems { get; set; }
        public virtual ICollection<ContractMarkItemInstance> ContractMarkItemInstances { get; set; }
        public virtual ICollection<ContractMarkPhaseLotItem> ContractMarkPhaseLotItems { get; set; }
        public virtual ICollection<ItemInventory> ItemInventories { get; set; }
        public virtual ICollection<ItemInventoryArchive> ItemInventoryArchives { get; set; }
        public virtual ICollection<ItemInventoryTransactionLine> ItemInventoryTransactionLines { get; set; }
        public virtual ICollection<ItemSiteInventory> ItemSiteInventories { get; set; }
        public virtual ICollection<ProductionRequiredTaskInstance> ProductionRequiredTaskInstances { get; set; }
        public virtual ICollection<ProductionWorkOrderContractArchive> ProductionWorkOrderContractArchives { get; set; }
        public virtual ICollection<ProductionWorkOrderContract> ProductionWorkOrderContracts { get; set; }
        public virtual ICollection<SplitMarkItem> SplitMarkItems { get; set; }
    }
}
