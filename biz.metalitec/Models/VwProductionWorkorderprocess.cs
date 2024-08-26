using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwProductionWorkorderprocess
    {
        public int ProductionWorkOrderProcessId { get; set; }
        public int ProductionWorkOrderId { get; set; }
        public int ProductionProcessId { get; set; }
        public int ProcessNumber { get; set; }
        public int ProductionWorkStationId { get; set; }
        public int ItemLocationId { get; set; }
        public byte DisplayTimeUnitId { get; set; }
        public double PerUnitMinutes { get; set; }
        public double FixedMinutes { get; set; }
        public string Notes { get; set; }
        public bool HasCuttingPlan { get; set; }
        public int Rank { get; set; }
        public int? ProductionWorkOrderContractId { get; set; }
        public int? ContractMarkPhaseLotId { get; set; }
        public int? ContractMarkPhaseLotItemId { get; set; }
        public int? ContractId { get; set; }
        public int? PhaseId { get; set; }
        public int? LotId { get; set; }
        public int? MarkId { get; set; }
        public int? MarkItemId { get; set; }
        public int? ContractItemId { get; set; }
        public double Quantity { get; set; }
    }
}
