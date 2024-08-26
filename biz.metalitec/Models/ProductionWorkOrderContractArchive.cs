using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionWorkOrderContractArchive
    {
        public int ProductionWorkOrderContractId { get; set; }
        public int ProductionWorkOrderId { get; set; }
        public int? ContractMarkPhaseLotId { get; set; }
        public int? ContractMarkPhaseLotItemId { get; set; }
        public int? ContractId { get; set; }
        public int? PhaseId { get; set; }
        public int? LotId { get; set; }
        public int? MarkId { get; set; }
        public int? MarkItemId { get; set; }
        public int? ContractItemId { get; set; }
        public int? LinkId { get; set; }
        public int? NestingResultItemListingId { get; set; }
        public double Quantity { get; set; }
        public int Instance { get; set; }

        public virtual ContractItem ContractItem { get; set; }
        public virtual ContractMarkPhaseLot ContractMarkPhaseLot { get; set; }
        public virtual ContractMarkPhaseLotItem ContractMarkPhaseLotItem { get; set; }
        public virtual ContractMark Mark { get; set; }
        public virtual ContractMarkItem MarkItem { get; set; }
    }
}
