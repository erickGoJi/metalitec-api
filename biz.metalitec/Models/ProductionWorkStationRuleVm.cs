using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionWorkStationRuleVm
    {
        public ProductionWorkStationRuleVm()
        {
            ProductionWorkStationRuleParameters = new HashSet<ProductionWorkStationRuleParameter>();
        }

        public int ProductionWorkStationRuleId { get; set; }
        public int ProductionWorkStationId { get; set; }
        public int ProductionRuleId { get; set; }
        public int? ParentProductionWorkStationRuleId { get; set; }
        public int SortOrder { get; set; }
        public int? TmpKey { get; set; }

        public virtual ProductionRule ProductionRule { get; set; }
        public virtual ProductionWorkStation ProductionWorkStation { get; set; }
        public virtual ICollection<ProductionWorkStationRuleParameter> ProductionWorkStationRuleParameters { get; set; }
    }
}
