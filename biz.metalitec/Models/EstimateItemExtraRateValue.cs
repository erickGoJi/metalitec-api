using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class EstimateItemExtraRateValue
    {
        public int ItemId { get; set; }
        public int ItemExtraRateId { get; set; }
        public double Value { get; set; }
        public double Discount { get; set; }

        public virtual Item Item { get; set; }
        public virtual EstimateItemExtraRate ItemExtraRate { get; set; }
    }
}
