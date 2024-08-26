using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class QsanalysisCategoryRuleItem
    {
        public int QsanalysisCategoryRuleItemId { get; set; }
        public int QsanalysisCategoryRuleId { get; set; }
        /// <summary>
        /// The ItemID that belongs to the Rule
        /// </summary>
        public int? ItemId { get; set; }
        /// <summary>
        /// The SectionTypeID that belongs to the Rule
        /// </summary>
        public int? SectionTypeId { get; set; }

        public virtual QsanalysisCategoryRule QsanalysisCategoryRule { get; set; }
    }
}
