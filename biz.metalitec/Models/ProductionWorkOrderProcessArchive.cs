using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionWorkOrderProcessArchive
    {
        public int? ContractId { get; set; }
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

        public virtual ItemLocation ItemLocation { get; set; }
        public virtual ProductionProcess ProductionProcess { get; set; }
        public virtual ProductionWorkStation ProductionWorkStation { get; set; }
    }
}
