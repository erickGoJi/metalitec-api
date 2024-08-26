using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionRuleParameterRequiredTaskProperty
    {
        public int ProductionRuleParameterId { get; set; }
        public int ProductionRequiredTaskPropertyId { get; set; }

        public virtual ProductionRequiredTaskProperty ProductionRequiredTaskProperty { get; set; }
        public virtual ProductionRuleParameter ProductionRuleParameter { get; set; }
    }
}
