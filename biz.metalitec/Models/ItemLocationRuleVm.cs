using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemLocationRuleVm
    {
        public ItemLocationRuleVm()
        {
            ItemLocationRuleParameters = new HashSet<ItemLocationRuleParameter>();
        }

        public int ItemLocationRuleId { get; set; }
        public int ItemLocationId { get; set; }
        public int ProductionRuleId { get; set; }
        public int? ParentItemLocationRuleId { get; set; }
        public int SortOrder { get; set; }
        public int? TmpKey { get; set; }

        public virtual ItemLocation ItemLocation { get; set; }
        public virtual ProductionRule ProductionRule { get; set; }
        public virtual ICollection<ItemLocationRuleParameter> ItemLocationRuleParameters { get; set; }
    }
}
