using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionRequiredTaskStrategy
    {
        public ProductionRequiredTaskStrategy()
        {
            ProductionRequiredTaskStrategyProcesses = new HashSet<ProductionRequiredTaskStrategyProcess>();
        }

        /// <summary>
        /// Required Task Strategy Unique ID Number
        /// </summary>
        public int ProductionRequiredTaskStrategyId { get; set; }
        public int ProductionRequiredTaskId { get; set; }
        /// <summary>
        /// Name of the Required Task Strategy
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description of the Required Task Strategy
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The preference to use the Required Task Strategy
        /// </summary>
        public int Priority { get; set; }

        public virtual ProductionRequiredTask ProductionRequiredTask { get; set; }
        public virtual ICollection<ProductionRequiredTaskStrategyProcess> ProductionRequiredTaskStrategyProcesses { get; set; }
    }
}
