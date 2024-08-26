using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class QscategoryRule
    {
        public QscategoryRule()
        {
            QscategoryRuleItems = new HashSet<QscategoryRuleItem>();
        }

        public int QscategoryRuleId { get; set; }
        public int QscategoryId { get; set; }
        /// <summary>
        /// The rule type
        /// </summary>
        public string RuleId { get; set; }
        /// <summary>
        /// Minimum Value for the Rule if applicable to the Rule
        /// </summary>
        public double? Minvalue { get; set; }
        /// <summary>
        /// Minimum Value for the Rule if applicable to the Rule
        /// </summary>
        public double? Maxvalue { get; set; }
        /// <summary>
        /// The Value for the Rule if applicable to the Rule
        /// </summary>
        public string Value { get; set; }
        public bool NotAllowed { get; set; }
        public int? TempKey { get; set; }
        /// <summary>
        /// Whether to apply the rule to the Mark Main Member only
        /// </summary>
        public bool? MainMember { get; set; }

        public virtual Qscategory Qscategory { get; set; }
        public virtual ICollection<QscategoryRuleItem> QscategoryRuleItems { get; set; }
    }
}
