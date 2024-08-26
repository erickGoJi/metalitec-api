using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemFinishCoat
    {
        public int ItemFinishCoatId { get; set; }
        public int ItemFinishId { get; set; }
        public int? CoatNameId { get; set; }
        public int? DescriptionId { get; set; }
        public int? ColourId { get; set; }
        public int? Wftid { get; set; }
        public int? Dftid { get; set; }
        public int? TheoreticalCoatingId { get; set; }
        public int? MeasureId { get; set; }
        public int? ThinnerId { get; set; }
        public int? DryTimeId { get; set; }
        public double? Price { get; set; }
        public int? PackSizeId { get; set; }
        public int? UnitId { get; set; }

        public virtual ItemFinish ItemFinish { get; set; }
    }
}
