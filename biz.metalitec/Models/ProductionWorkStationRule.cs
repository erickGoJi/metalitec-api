using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionWorkStationRule
    {
        public ProductionWorkStationRule()
        {
            ProductionWorkStationRuleItems = new HashSet<ProductionWorkStationRuleItem>();
        }

        public int ProductionWorkStationRuleId { get; set; }
        public int ProductionWorkStationId { get; set; }
        /// <summary>
        /// Link to the Routing Rule Table
        /// </summary>
        public int RuleId { get; set; }
        /// <summary>
        /// Any process specified...cutting, coping , notching, drilling, painting, treated...
        /// </summary>
        public int? ProductionProcessId { get; set; }
        /// <summary>
        /// The related workstation for send here rules
        /// </summary>
        public int? RelatedProductionWorkstationId { get; set; }
        public double? MinValue { get; set; }
        public double? MaxValue { get; set; }
        public string Value { get; set; }
        public int? TempKey { get; set; }
        public bool NotAllowed { get; set; }

        public virtual ProductionProcess ProductionProcess { get; set; }
        public virtual ProductionWorkStation ProductionWorkStation { get; set; }
        public virtual ProductionWorkStation RelatedProductionWorkstation { get; set; }
        public virtual ICollection<ProductionWorkStationRuleItem> ProductionWorkStationRuleItems { get; set; }
    }
}
