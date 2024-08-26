using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class PlanningDetail
    {
        public int PlanningDetailId { get; set; }
        public int LotId { get; set; }
        public int WorkOrderTypeId { get; set; }
        public int ProductionProcessId { get; set; }
        public int ProductionWorkStationId { get; set; }
        public int ItemLocationId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int Version { get; set; }

        public virtual ItemLocation ItemLocation { get; set; }
        public virtual ContractLot Lot { get; set; }
        public virtual ProductionProcess ProductionProcess { get; set; }
        public virtual ProductionWorkStation ProductionWorkStation { get; set; }
    }
}
