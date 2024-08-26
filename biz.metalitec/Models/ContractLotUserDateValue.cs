using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ContractLotUserDateValue
    {
        public int ContractLotUserDateValueId { get; set; }
        public int ContractLotUserDateId { get; set; }
        public int LotId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual ContractLotUserDate ContractLotUserDate { get; set; }
        public virtual ContractLot Lot { get; set; }
    }
}
