using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionWorkStationRuleParameter
    {
        public int ProductionWorkStationRuleParameterId { get; set; }
        public int ProductionWorkStationRuleId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public virtual ProductionWorkStationRuleVm ProductionWorkStationRule { get; set; }
    }
}
