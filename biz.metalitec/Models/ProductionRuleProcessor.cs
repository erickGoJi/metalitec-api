using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionRuleProcessor
    {
        public ProductionRuleProcessor()
        {
            ProductionRules = new HashSet<ProductionRule>();
        }

        /// <summary>
        /// RuleProcessor Unique ID Number
        /// </summary>
        public int ProductionRuleProcessorId { get; set; }
        /// <summary>
        /// Name of the Rule Processor
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description of the Rule Processor
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Whether the Rule Processor can be used for Production Templates
        /// </summary>
        public bool? IsTemplateRule { get; set; }
        /// <summary>
        /// Whether the Rule Processor can be used for Production Workstations
        /// </summary>
        public bool IsWorkStationRule { get; set; }
        /// <summary>
        /// Whether the Rule Processor can be used for Locations
        /// </summary>
        public bool IsLocationRule { get; set; }
        /// <summary>
        /// Whether the Rule Processor is available for use
        /// </summary>
        public bool Active { get; set; }
        public int CodeBaseId { get; set; }
        public string Script { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public int Version { get; set; }
        public bool System { get; set; }

        public virtual ICollection<ProductionRule> ProductionRules { get; set; }
    }
}
