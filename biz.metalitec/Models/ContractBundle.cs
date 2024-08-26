using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ContractBundle
    {
        public ContractBundle()
        {
            ContractMarkPhaseLotItems = new HashSet<ContractMarkPhaseLotItem>();
            ContractMarkPhaseLots = new HashSet<ContractMarkPhaseLot>();
        }

        public int ContractBundleId { get; set; }
        public int ContractId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual Contract Contract { get; set; }
        public virtual ICollection<ContractMarkPhaseLotItem> ContractMarkPhaseLotItems { get; set; }
        public virtual ICollection<ContractMarkPhaseLot> ContractMarkPhaseLots { get; set; }
    }
}
