using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportProductiontemplaterule
    {
        public int ProductionTemplateRuleId { get; set; }
        public int ProductionTemplateId { get; set; }
        public string ProductionTemplateRule { get; set; }
        public double? MinValue { get; set; }
        public double? MaxValue { get; set; }
        public string Value { get; set; }
        public bool NotAllowed { get; set; }
        public int? ItemId { get; set; }
        public string Item { get; set; }
        public string SectionType { get; set; }
        public string Grade { get; set; }
    }
}
