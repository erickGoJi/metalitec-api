using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwItemreservationStatusIitl
    {
        public int? TransactionLineId { get; set; }
        public string Project { get; set; }
        public string ContractName { get; set; }
        public string PhaseName { get; set; }
        public string LotName { get; set; }
        public string MarkName { get; set; }
        public string Allocation { get; set; }
        public int? ReservationType { get; set; }
    }
}
