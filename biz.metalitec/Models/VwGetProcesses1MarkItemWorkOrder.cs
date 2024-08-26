using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwGetProcesses1MarkItemWorkOrder
    {
        public int ProductionWorkOrderId { get; set; }
        public int? ContractId { get; set; }
        public int? ContractItemId { get; set; }
        public int? MarkId { get; set; }
        public int PhaseId { get; set; }
        public int? LotId { get; set; }
        public int StatusId { get; set; }
        public int? ContractMarkPhaseLotItemId { get; set; }
        public int? NestingResultItemListingId { get; set; }
    }
}
