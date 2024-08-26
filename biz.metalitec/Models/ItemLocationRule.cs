using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemLocationRule
    {
        public ItemLocationRule()
        {
            ItemLocationRuleItems = new HashSet<ItemLocationRuleItem>();
        }

        public int ItemLocationRuleId { get; set; }
        public int ItemLocationId { get; set; }
        /// <summary>
        /// Link to the Routing Rule Table
        /// </summary>
        public int RuleId { get; set; }
        public double? MinValue { get; set; }
        public double? MaxValue { get; set; }
        public string Value { get; set; }
        public bool NotAllowed { get; set; }
        public int ItemLocationRuleTypeId { get; set; }
        public int? ProductionProcessId { get; set; }
        public int? TempKey { get; set; }

        public virtual ItemLocation ItemLocation { get; set; }
        public virtual ProductionProcess ProductionProcess { get; set; }
        public virtual ICollection<ItemLocationRuleItem> ItemLocationRuleItems { get; set; }
    }
}
