using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemParameter
    {
        public int ItemParameterId { get; set; }
        public int ItemId { get; set; }
        public int ShapeDimensionId { get; set; }
        public double Value { get; set; }

        public virtual Item Item { get; set; }
        public virtual ShapeDimension ShapeDimension { get; set; }
    }
}
