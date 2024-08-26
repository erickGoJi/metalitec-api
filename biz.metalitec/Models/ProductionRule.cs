using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionRule
    {
        public ProductionRule()
        {
            ItemLocationRuleVms = new HashSet<ItemLocationRuleVm>();
            ProductionRuleParameters = new HashSet<ProductionRuleParameter>();
            ProductionTemplateRuleVms = new HashSet<ProductionTemplateRuleVm>();
            ProductionWorkStationRuleVms = new HashSet<ProductionWorkStationRuleVm>();
        }

        /// <summary>
        /// Rule Unique ID Number
        /// </summary>
        public int ProductionRuleId { get; set; }
        /// <summary>
        /// Name of the Rule
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description of the Rule
        /// </summary>
        public string Description { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public int Version { get; set; }
        /// <summary>
        /// The Processor used to execute the Rule
        /// </summary>
        public int ProductionRuleProcessorId { get; set; }
        public bool System { get; set; }

        public virtual ProductionRuleProcessor ProductionRuleProcessor { get; set; }
        public virtual ICollection<ItemLocationRuleVm> ItemLocationRuleVms { get; set; }
        public virtual ICollection<ProductionRuleParameter> ProductionRuleParameters { get; set; }
        public virtual ICollection<ProductionTemplateRuleVm> ProductionTemplateRuleVms { get; set; }
        public virtual ICollection<ProductionWorkStationRuleVm> ProductionWorkStationRuleVms { get; set; }
    }
}
