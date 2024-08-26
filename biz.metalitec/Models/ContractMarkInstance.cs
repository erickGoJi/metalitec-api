using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ContractMarkInstance
    {
        public ContractMarkInstance()
        {
            ItemInventoryInstances = new HashSet<ItemInventoryInstance>();
            ItemInventoryTransactionLineInstances = new HashSet<ItemInventoryTransactionLineInstance>();
            ItemSiteInventoryInstances = new HashSet<ItemSiteInventoryInstance>();
            ProductionRequiredTaskInstances = new HashSet<ProductionRequiredTaskInstance>();
            SalesInvoiceItemInstances = new HashSet<SalesInvoiceItemInstance>();
        }

        public int ContractMarkInstanceId { get; set; }
        public int ContractListingId { get; set; }
        public int ContractMarkId { get; set; }
        public int? ContractMarkPhaseId { get; set; }
        public int? ContractMarkPhaseLotId { get; set; }
        public int? AssemblyMarkLotId { get; set; }
        public int? ProductionWorkOrderContractId { get; set; }
        public Guid Guid { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsManualInsert { get; set; }
        public int? ParentMarkInstanceId { get; set; }
        public int? PreviousContractMarkInstanceId { get; set; }

        public virtual ContractListing ContractListing { get; set; }
        public virtual ContractMark ContractMark { get; set; }
        public virtual ProductionWorkOrderContract ProductionWorkOrderContract { get; set; }
        public virtual ICollection<ItemInventoryInstance> ItemInventoryInstances { get; set; }
        public virtual ICollection<ItemInventoryTransactionLineInstance> ItemInventoryTransactionLineInstances { get; set; }
        public virtual ICollection<ItemSiteInventoryInstance> ItemSiteInventoryInstances { get; set; }
        public virtual ICollection<ProductionRequiredTaskInstance> ProductionRequiredTaskInstances { get; set; }
        public virtual ICollection<SalesInvoiceItemInstance> SalesInvoiceItemInstances { get; set; }
    }
}
