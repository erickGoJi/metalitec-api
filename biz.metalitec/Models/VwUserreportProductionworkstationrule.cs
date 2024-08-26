using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportProductionworkstationrule
    {
        public int ProductionWorkStationRuleId { get; set; }
        public int ProductionWorkStationId { get; set; }
        public string Rule { get; set; }
        public int? ProductionProcessId { get; set; }
        public string ProductionProcess { get; set; }
        public string RelatedProductionWorkStation { get; set; }
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
