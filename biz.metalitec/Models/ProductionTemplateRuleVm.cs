using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionTemplateRuleVm
    {
        public ProductionTemplateRuleVm()
        {
            ProductionTemplateRuleParameters = new HashSet<ProductionTemplateRuleParameter>();
        }

        public int ProductionTemplateRuleId { get; set; }
        public int ProductionTemplateId { get; set; }
        public int ProductionRuleId { get; set; }
        public int? ParentProductionTemplateRuleId { get; set; }
        public int SortOrder { get; set; }
        public int? TmpKey { get; set; }

        public virtual ProductionRule ProductionRule { get; set; }
        public virtual ProductionTemplate ProductionTemplate { get; set; }
        public virtual ICollection<ProductionTemplateRuleParameter> ProductionTemplateRuleParameters { get; set; }
    }
}
