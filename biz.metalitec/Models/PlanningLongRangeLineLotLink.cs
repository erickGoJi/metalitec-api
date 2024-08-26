using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class PlanningLongRangeLineLotLink
    {
        public int PlanningLongRangeLineLotLinkId { get; set; }
        public int PlanningLongRangeLineId { get; set; }
        public int LotId { get; set; }
        public int? PlanningDetailId { get; set; }

        public virtual ContractLot Lot { get; set; }
        public virtual PlanningLongRangeLine PlanningLongRangeLine { get; set; }
    }
}
