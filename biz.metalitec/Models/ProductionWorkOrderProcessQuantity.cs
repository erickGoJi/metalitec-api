using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionWorkOrderProcessQuantity
    {
        public int ProductionWorkOrderProcessQuantityId { get; set; }
        public int ProductionWorkOrderProcessId { get; set; }
        public int? ProductionWorkOrderContractId { get; set; }
        public int? ProductionWorkStationId { get; set; }
        public int ItemLocationId { get; set; }
        public double Quantity { get; set; }
        public double QuantityComplete { get; set; }
        public double QuantityScrapped { get; set; }
        public double QuantityLocked { get; set; }
        public DateTime EnteredDate { get; set; }

        public virtual ItemLocation ItemLocation { get; set; }
        public virtual ProductionWorkOrderContract ProductionWorkOrderContract { get; set; }
        public virtual ProductionWorkOrderProcess ProductionWorkOrderProcess { get; set; }
        public virtual ProductionWorkStation ProductionWorkStation { get; set; }
    }
}
