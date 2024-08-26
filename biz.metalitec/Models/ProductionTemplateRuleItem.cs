using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionTemplateRuleItem
    {
        public int ProductionTemplateRuleItemId { get; set; }
        public int ProductionTemplateRuleId { get; set; }
        public int? ItemId { get; set; }
        public int? SectionTypeId { get; set; }

        public virtual Item Item { get; set; }
        public virtual ProductionTemplateRule ProductionTemplateRule { get; set; }
        public virtual SectionType SectionType { get; set; }
    }
}
