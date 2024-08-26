using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionWorkOrderProcess
    {
        public ProductionWorkOrderProcess()
        {
            EmployeeTimesheets = new HashSet<EmployeeTimesheet>();
            ProductionWorkOrderProcessPriorities = new HashSet<ProductionWorkOrderProcessPriority>();
            ProductionWorkOrderProcessQuantities = new HashSet<ProductionWorkOrderProcessQuantity>();
            ProductionWorkOrderProcessQuantityHistoryFromProductionWorkOrderProcesses = new HashSet<ProductionWorkOrderProcessQuantityHistory>();
            ProductionWorkOrderProcessQuantityHistoryProductionWorkOrderProcesses = new HashSet<ProductionWorkOrderProcessQuantityHistory>();
        }

        public int ProductionWorkOrderProcessId { get; set; }
        public int ProductionWorkOrderId { get; set; }
        public int ProductionProcessId { get; set; }
        public int ProcessNumber { get; set; }
        public int ProductionWorkStationId { get; set; }
        public int ItemLocationId { get; set; }
        /// <summary>
        /// Minutes, Hours, Days
        /// </summary>
        public byte DisplayTimeUnitId { get; set; }
        public double PerUnitMinutes { get; set; }
        public double FixedMinutes { get; set; }
        public string Notes { get; set; }
        public bool HasCuttingPlan { get; set; }
        public int Rank { get; set; }

        public virtual ItemLocation ItemLocation { get; set; }
        public virtual ProductionProcess ProductionProcess { get; set; }
        public virtual ProductionWorkOrder ProductionWorkOrder { get; set; }
        public virtual ProductionWorkStation ProductionWorkStation { get; set; }
        public virtual ICollection<EmployeeTimesheet> EmployeeTimesheets { get; set; }
        public virtual ICollection<ProductionWorkOrderProcessPriority> ProductionWorkOrderProcessPriorities { get; set; }
        public virtual ICollection<ProductionWorkOrderProcessQuantity> ProductionWorkOrderProcessQuantities { get; set; }
        public virtual ICollection<ProductionWorkOrderProcessQuantityHistory> ProductionWorkOrderProcessQuantityHistoryFromProductionWorkOrderProcesses { get; set; }
        public virtual ICollection<ProductionWorkOrderProcessQuantityHistory> ProductionWorkOrderProcessQuantityHistoryProductionWorkOrderProcesses { get; set; }
    }
}
