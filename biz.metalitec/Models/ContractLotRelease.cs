using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ContractLotRelease
    {
        public ContractLotRelease()
        {
            ContractMarkPhaseLots = new HashSet<ContractMarkPhaseLot>();
        }

        public int ContractLotReleaseId { get; set; }
        public int? ContractId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual Contract Contract { get; set; }
        public virtual ICollection<ContractMarkPhaseLot> ContractMarkPhaseLots { get; set; }
    }
}
