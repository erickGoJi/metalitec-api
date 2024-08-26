using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ContractLotUserDate
    {
        public ContractLotUserDate()
        {
            ContractLotUserDateProcesses = new HashSet<ContractLotUserDateProcess>();
            ContractLotUserDateValues = new HashSet<ContractLotUserDateValue>();
        }

        public int ContractLotUserDateId { get; set; }
        public string Name { get; set; }
        public byte DateTypeId { get; set; }

        public virtual ICollection<ContractLotUserDateProcess> ContractLotUserDateProcesses { get; set; }
        public virtual ICollection<ContractLotUserDateValue> ContractLotUserDateValues { get; set; }
    }
}
