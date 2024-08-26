using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class EstimateItemExtraRate
    {
        public EstimateItemExtraRate()
        {
            EstimateAssemblyItemExtras = new HashSet<EstimateAssemblyItemExtra>();
            EstimateExtras = new HashSet<EstimateExtra>();
            EstimateItemExtraRateValues = new HashSet<EstimateItemExtraRateValue>();
            Extras = new HashSet<Extra>();
        }

        public int ItemExtraRateId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<EstimateAssemblyItemExtra> EstimateAssemblyItemExtras { get; set; }
        public virtual ICollection<EstimateExtra> EstimateExtras { get; set; }
        public virtual ICollection<EstimateItemExtraRateValue> EstimateItemExtraRateValues { get; set; }
        public virtual ICollection<Extra> Extras { get; set; }
    }
}
