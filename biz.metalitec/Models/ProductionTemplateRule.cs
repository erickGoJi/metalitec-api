using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionTemplateRule
    {
        public ProductionTemplateRule()
        {
            ProductionTemplateRuleItems = new HashSet<ProductionTemplateRuleItem>();
        }

        public int ProductionTemplateRuleId { get; set; }
        public int ProductionTemplateId { get; set; }
        public byte RuleId { get; set; }
        public double? MinValue { get; set; }
        public double? MaxValue { get; set; }
        public string Value { get; set; }
        public int? Tempkey { get; set; }
        public bool NotAllowed { get; set; }

        public virtual ProductionTemplate ProductionTemplate { get; set; }
        public virtual ICollection<ProductionTemplateRuleItem> ProductionTemplateRuleItems { get; set; }
    }
}
