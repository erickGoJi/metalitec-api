using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionRequiredTaskInstanceProperty
    {
        public int ProductionRequiredTaskInstancePropertyId { get; set; }
        public int ProductionRequiredTaskInstanceId { get; set; }
        public int ProductionRequiredTaskPropertyId { get; set; }
        public string Value { get; set; }

        public virtual ProductionRequiredTaskInstance ProductionRequiredTaskInstance { get; set; }
        public virtual ProductionRequiredTaskProperty ProductionRequiredTaskProperty { get; set; }
    }
}
