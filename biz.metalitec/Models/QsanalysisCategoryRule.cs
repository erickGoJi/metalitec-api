using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class QsanalysisCategoryRule
    {
        public QsanalysisCategoryRule()
        {
            QsanalysisCategoryRuleItems = new HashSet<QsanalysisCategoryRuleItem>();
        }

        public int QsanalysisCategoryRuleId { get; set; }
        public int QsanalysisCategoryId { get; set; }
        /// <summary>
        /// The Rule
        /// </summary>
        public int RuleId { get; set; }
        /// <summary>
        /// Lower Constraint Value for Rule Type
        /// </summary>
        public double? Minvalue { get; set; }
        /// <summary>
        /// Upper Constraint Value for Rule Type - Zero is no limit
        /// </summary>
        public double? Maxvalue { get; set; }
        public string Value { get; set; }
        public bool NotAllowed { get; set; }
        public int? TempKey { get; set; }
        /// <summary>
        /// Whether to apply the rule to the Mark Main Member only
        /// </summary>
        public bool? MainMember { get; set; }

        public virtual QsanalysisCategory QsanalysisCategory { get; set; }
        public virtual ICollection<QsanalysisCategoryRuleItem> QsanalysisCategoryRuleItems { get; set; }
    }
}
