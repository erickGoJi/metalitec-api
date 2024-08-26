using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionTemplateRuleParameter
    {
        public int ProductionTemplateRuleParameterId { get; set; }
        public int ProductionTemplateRuleId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public virtual ProductionTemplateRuleVm ProductionTemplateRule { get; set; }
    }
}
