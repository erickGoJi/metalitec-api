using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class Shape1
    {
        public Shape1()
        {
            ShapeDimensions = new HashSet<ShapeDimension>();
        }

        public int ShapeId { get; set; }
        public string Name { get; set; }
        public string Dstvcode { get; set; }
        public string DimensionImage { get; set; }
        public byte? System { get; set; }
        public bool CanRotateForNestingX { get; set; }
        public bool CanRotateForNestingY { get; set; }
        public bool CanRotateForNestingZ { get; set; }

        public virtual ICollection<ShapeDimension> ShapeDimensions { get; set; }
    }
}
