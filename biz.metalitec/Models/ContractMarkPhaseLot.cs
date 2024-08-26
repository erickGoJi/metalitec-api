using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ContractMarkPhaseLot
    {
        public ContractMarkPhaseLot()
        {
            ContractMarkPhaseLotItems = new HashSet<ContractMarkPhaseLotItem>();
            ItemInventories = new HashSet<ItemInventory>();
            ItemInventoryArchives = new HashSet<ItemInventoryArchive>();
            ItemInventoryTransactionLines = new HashSet<ItemInventoryTransactionLine>();
            ItemSiteInventories = new HashSet<ItemSiteInventory>();
            ProductionWorkOrderContractArchives = new HashSet<ProductionWorkOrderContractArchive>();
            ProductionWorkOrderContracts = new HashSet<ProductionWorkOrderContract>();
            SalesInvoiceItemInstances = new HashSet<SalesInvoiceItemInstance>();
            SalesInvoiceItems = new HashSet<SalesInvoiceItem>();
        }

        public int ContractMarkPhaseLotId { get; set; }
        public int ContractMarkPhaseId { get; set; }
        public int LotId { get; set; }
        public double Quantity { get; set; }
        public DateTime? ReleasedOn { get; set; }
        public string ReleasedBy { get; set; }
        public int StatusId { get; set; }
        public string TransactionId { get; set; }
        public int? ContractBundleId { get; set; }
        public int? ContractLotReleaseId { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual ContractBundle ContractBundle { get; set; }
        public virtual ContractLotRelease ContractLotRelease { get; set; }
        public virtual ContractMarkPhase ContractMarkPhase { get; set; }
        public virtual ContractLot Lot { get; set; }
        public virtual ICollection<ContractMarkPhaseLotItem> ContractMarkPhaseLotItems { get; set; }
        public virtual ICollection<ItemInventory> ItemInventories { get; set; }
        public virtual ICollection<ItemInventoryArchive> ItemInventoryArchives { get; set; }
        public virtual ICollection<ItemInventoryTransactionLine> ItemInventoryTransactionLines { get; set; }
        public virtual ICollection<ItemSiteInventory> ItemSiteInventories { get; set; }
        public virtual ICollection<ProductionWorkOrderContractArchive> ProductionWorkOrderContractArchives { get; set; }
        public virtual ICollection<ProductionWorkOrderContract> ProductionWorkOrderContracts { get; set; }
        public virtual ICollection<SalesInvoiceItemInstance> SalesInvoiceItemInstances { get; set; }
        public virtual ICollection<SalesInvoiceItem> SalesInvoiceItems { get; set; }
    }
}
