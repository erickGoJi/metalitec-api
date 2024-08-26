using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionWorkStationRuleItem
    {
        public int ProductionWorkStationRuleItemId { get; set; }
        public int ProductionWorkStationRuleId { get; set; }
        public int? ItemId { get; set; }
        public int? SectionTypeId { get; set; }

        public virtual Item Item { get; set; }
        public virtual ProductionWorkStationRule ProductionWorkStationRule { get; set; }
        public virtual SectionType SectionType { get; set; }
    }
}
