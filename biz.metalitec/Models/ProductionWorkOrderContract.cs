using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionWorkOrderContract
    {
        public ProductionWorkOrderContract()
        {
            ContractMarkInstances = new HashSet<ContractMarkInstance>();
            ContractMarkItemInstances = new HashSet<ContractMarkItemInstance>();
            ItemInventoryInstances = new HashSet<ItemInventoryInstance>();
            ItemInventoryTransactionLineInstances = new HashSet<ItemInventoryTransactionLineInstance>();
            ItemInventoryTransactionLines = new HashSet<ItemInventoryTransactionLine>();
            ItemSiteInventoryInstances = new HashSet<ItemSiteInventoryInstance>();
            ProductionWorkOrderProcessQuantities = new HashSet<ProductionWorkOrderProcessQuantity>();
            ProductionWorkOrderProcessQuantityHistoryFromProductionWorkOrderContracts = new HashSet<ProductionWorkOrderProcessQuantityHistory>();
            ProductionWorkOrderProcessQuantityHistoryProductionWorkOrderContracts = new HashSet<ProductionWorkOrderProcessQuantityHistory>();
        }

        public int ProductionWorkOrderContractId { get; set; }
        public int ProductionWorkOrderId { get; set; }
        public int? ContractMarkPhaseLotId { get; set; }
        public int? ContractMarkPhaseLotItemId { get; set; }
        public int? ContractId { get; set; }
        public int? PhaseId { get; set; }
        public int? LotId { get; set; }
        public int? MarkId { get; set; }
        public int? MarkItemId { get; set; }
        public int? ContractItemId { get; set; }
        public int? LinkId { get; set; }
        public int? NestingResultItemListingId { get; set; }
        public double Quantity { get; set; }
        public int Instance { get; set; }

        public virtual ContractItem ContractItem { get; set; }
        public virtual ContractMarkPhaseLot ContractMarkPhaseLot { get; set; }
        public virtual ContractMarkPhaseLotItem ContractMarkPhaseLotItem { get; set; }
        public virtual ContractMark Mark { get; set; }
        public virtual ContractMarkItem MarkItem { get; set; }
        public virtual NestingResultItemListing NestingResultItemListing { get; set; }
        public virtual ProductionWorkOrder ProductionWorkOrder { get; set; }
        public virtual ICollection<ContractMarkInstance> ContractMarkInstances { get; set; }
        public virtual ICollection<ContractMarkItemInstance> ContractMarkItemInstances { get; set; }
        public virtual ICollection<ItemInventoryInstance> ItemInventoryInstances { get; set; }
        public virtual ICollection<ItemInventoryTransactionLineInstance> ItemInventoryTransactionLineInstances { get; set; }
        public virtual ICollection<ItemInventoryTransactionLine> ItemInventoryTransactionLines { get; set; }
        public virtual ICollection<ItemSiteInventoryInstance> ItemSiteInventoryInstances { get; set; }
        public virtual ICollection<ProductionWorkOrderProcessQuantity> ProductionWorkOrderProcessQuantities { get; set; }
        public virtual ICollection<ProductionWorkOrderProcessQuantityHistory> ProductionWorkOrderProcessQuantityHistoryFromProductionWorkOrderContracts { get; set; }
        public virtual ICollection<ProductionWorkOrderProcessQuantityHistory> ProductionWorkOrderProcessQuantityHistoryProductionWorkOrderContracts { get; set; }
    }
}
