using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionWorkOrderProcessQuantityHistory
    {
        public int ProductionWorkOrderProcessQuantityHistoryId { get; set; }
        public int FromProductionWorkOrderProcessQuantityId { get; set; }
        public int? FromProductionWorkOrderProcessId { get; set; }
        public int? FromProductionWorkOrderContractId { get; set; }
        public int FromProductionWorkStationId { get; set; }
        public int FromItemLocationId { get; set; }
        public int ProductionWorkOrderProcessQuantityId { get; set; }
        public int? ProductionWorkOrderProcessId { get; set; }
        public int? ProductionWorkOrderContractId { get; set; }
        public int ProductionWorkStationId { get; set; }
        public int ItemLocationId { get; set; }
        public double Quantity { get; set; }
        public string MovedBy { get; set; }
        public DateTime MovedOn { get; set; }
        public int? EmployeeId { get; set; }
        /// <summary>
        /// 1 = Production Control, 2 = Production Console, 3 = Bar Coding
        /// </summary>
        public int? MoveSource { get; set; }
        public int FromProductionProcessId { get; set; }
        public int ProductionProcessId { get; set; }
        public int ProductionWorkOrderId { get; set; }

        public virtual ItemLocation FromItemLocation { get; set; }
        public virtual ProductionProcess FromProductionProcess { get; set; }
        public virtual ProductionWorkOrderContract FromProductionWorkOrderContract { get; set; }
        public virtual ProductionWorkOrderProcess FromProductionWorkOrderProcess { get; set; }
        public virtual ProductionWorkStation FromProductionWorkStation { get; set; }
        public virtual ItemLocation ItemLocation { get; set; }
        public virtual ProductionProcess ProductionProcess { get; set; }
        public virtual ProductionWorkOrder ProductionWorkOrder { get; set; }
        public virtual ProductionWorkOrderContract ProductionWorkOrderContract { get; set; }
        public virtual ProductionWorkOrderProcess ProductionWorkOrderProcess { get; set; }
        public virtual ProductionWorkStation ProductionWorkStation { get; set; }
    }
}
