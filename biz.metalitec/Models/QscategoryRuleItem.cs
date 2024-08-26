using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class QscategoryRuleItem
    {
        public int QscategoryRuleItemId { get; set; }
        public int QscategoryRuleId { get; set; }
        /// <summary>
        /// The Item that is associated with the Category Rule
        /// </summary>
        public int? ItemId { get; set; }
        /// <summary>
        /// The SectionType that is associated with the Category Rule
        /// </summary>
        public int? SectionTypeId { get; set; }

        public virtual QscategoryRule QscategoryRule { get; set; }
    }
}
