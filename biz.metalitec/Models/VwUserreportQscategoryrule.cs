using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportQscategoryrule
    {
        public int QscategoryRuleId { get; set; }
        public int QscategoryId { get; set; }
        public string QsCategory { get; set; }
        public string Rule { get; set; }
        public double? RuleMinValue { get; set; }
        public double? RuleMaxValue { get; set; }
        public string RuleValue { get; set; }
        public bool RuleNotAllowed { get; set; }
        public string RuleItems { get; set; }
        public string RuleSectionTypes { get; set; }
    }
}
