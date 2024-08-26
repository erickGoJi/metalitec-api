using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemLocationRuleParameter
    {
        public int ItemLocationRuleParameterId { get; set; }
        public int ItemLocationRuleId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public virtual ItemLocationRuleVm ItemLocationRule { get; set; }
    }
}
