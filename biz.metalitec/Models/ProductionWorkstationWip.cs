using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionWorkstationWip
    {
        public int ProductionWorkstationWipid { get; set; }
        public Guid Wipbatch { get; set; }
        public int ProductionWorkOrderProcessQuantityId { get; set; }
        public int EmployeeId { get; set; }
        public double Quantity { get; set; }
        /// <summary>
        /// The total duration that the task took
        /// </summary>
        public double TotalDuration { get; set; }
        /// <summary>
        /// ~1 - Started, 2 - Completed, 0 - Paused
        /// </summary>
        public byte Status { get; set; }
        /// <summary>
        /// The date the transaction was started - populated when the work is started
        /// </summary>
        public DateTime Starttime { get; set; }
        /// <summary>
        /// The date the transaction was finished, paused
        /// </summary>
        public DateTime? Endtime { get; set; }
        public bool DisplayInstances { get; set; }
    }
}
