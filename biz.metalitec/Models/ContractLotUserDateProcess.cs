using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ContractLotUserDateProcess
    {
        public int ContractLotUserDateProcessId { get; set; }
        public int ContractLotUserDateId { get; set; }
        public int ProductionProcessId { get; set; }

        public virtual ContractLotUserDate ContractLotUserDate { get; set; }
        public virtual ProductionProcess ProductionProcess { get; set; }
    }
}
