using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionRuleParameter
    {
        public ProductionRuleParameter()
        {
            ProductionRuleParameterRequiredTaskProperties = new HashSet<ProductionRuleParameterRequiredTaskProperty>();
        }

        public int ProductionRuleParameterId { get; set; }
        public int ProductionRuleId { get; set; }
        public string Name { get; set; }
        public int ParameterType { get; set; }

        public virtual ProductionRule ProductionRule { get; set; }
        public virtual ICollection<ProductionRuleParameterRequiredTaskProperty> ProductionRuleParameterRequiredTaskProperties { get; set; }
    }
}
