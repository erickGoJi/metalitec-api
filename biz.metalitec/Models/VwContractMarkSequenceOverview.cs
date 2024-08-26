using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwContractMarkSequenceOverview
    {
        public int ContractId { get; set; }
        public int ContractListingId { get; set; }
        public int ContractDrawingId { get; set; }
        public int MarkId { get; set; }
        public string Mark { get; set; }
        public string MarkDescription { get; set; }
        public int PhaseId { get; set; }
        public int? ContractMarkPhaseLotId { get; set; }
        public int? LotId { get; set; }
        public int? ContractMarkPhaseLotItemId { get; set; }
        public int? MarkItemId { get; set; }
        public string MarkItem { get; set; }
    }
}
