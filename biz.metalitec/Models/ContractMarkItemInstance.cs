using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ContractMarkItemInstance
    {
        public ContractMarkItemInstance()
        {
            ItemInventoryInstances = new HashSet<ItemInventoryInstance>();
            ItemSiteInventoryInstances = new HashSet<ItemSiteInventoryInstance>();
            ProductionRequiredTaskInstances = new HashSet<ProductionRequiredTaskInstance>();
        }

        public int ContractMarkItemInstanceId { get; set; }
        public int ContractListingId { get; set; }
        public int ContractMarkInstanceId { get; set; }
        public int ContractMarkItemId { get; set; }
        public int? ContractMarkPhaseLotItemId { get; set; }
        public int? ProductionWorkOrderContractId { get; set; }
        public Guid Guid { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsManualInsert { get; set; }
        public int? PreviousContractMarkItemInstanceId { get; set; }

        public virtual ContractListing ContractListing { get; set; }
        public virtual ContractMarkItem ContractMarkItem { get; set; }
        public virtual ProductionWorkOrderContract ProductionWorkOrderContract { get; set; }
        public virtual ICollection<ItemInventoryInstance> ItemInventoryInstances { get; set; }
        public virtual ICollection<ItemSiteInventoryInstance> ItemSiteInventoryInstances { get; set; }
        public virtual ICollection<ProductionRequiredTaskInstance> ProductionRequiredTaskInstances { get; set; }
    }
}
