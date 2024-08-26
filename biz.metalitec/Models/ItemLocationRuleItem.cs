using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemLocationRuleItem
    {
        public int ItemLocationRuleItemId { get; set; }
        public int ItemLocationRuleId { get; set; }
        public int? ItemId { get; set; }
        public int? SectionTypeId { get; set; }

        public virtual Item Item { get; set; }
        public virtual ItemLocationRule ItemLocationRule { get; set; }
        public virtual SectionType SectionType { get; set; }
    }
}
