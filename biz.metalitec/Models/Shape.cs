using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class Shape
    {
        public int ShapeId { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// ~1 - POLYGON, 2 - CIRCLE
        /// </summary>
        public byte ShapeType { get; set; }
        public string RawContents { get; set; }
        public string SurfaceAreaFormula { get; set; }
    }
}
