using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ShapeDimension
    {
        public ShapeDimension()
        {
            ItemParameters = new HashSet<ItemParameter>();
        }

        public int ShapeDimensionId { get; set; }
        public string Name { get; set; }
        public int ShapeId { get; set; }
        /// <summary>
        /// ~Length=0, Profile Height=1, Flange Width = 2, Flange Thickness = 3, Web Thickness = 4, Radius = 5
        /// </summary>
        public int? DstvdimensionId { get; set; }
        public byte? System { get; set; }
        public bool Required { get; set; }
        public double DefaultValue { get; set; }

        public virtual Shape1 Shape { get; set; }
        public virtual ICollection<ItemParameter> ItemParameters { get; set; }
    }
}
