using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionRequiredTaskStrategyProcess
    {
        /// <summary>
        /// Required Task Strategy Unique ID Number
        /// </summary>
        public int ProductionRequiredTaskStrategyId { get; set; }
        /// <summary>
        /// Production Process Unique ID Number
        /// </summary>
        public int ProductionProcessId { get; set; }
        /// <summary>
        /// The order in which the Processes are performed to achieve the Strategy
        /// </summary>
        public int Rank { get; set; }

        public virtual ProductionProcess ProductionProcess { get; set; }
        public virtual ProductionRequiredTaskStrategy ProductionRequiredTaskStrategy { get; set; }
    }
}
