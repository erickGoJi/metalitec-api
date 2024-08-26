using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class NestingResultWeldedBarArchive
    {
        public int NestingResultWeldedBarId { get; set; }
        public int BarNestingResultSupplyLengthId { get; set; }
        public int PartNestingResultSupplyLengthId { get; set; }
        public int Quantity { get; set; }
        public double? PartLength { get; set; }
        public double? PartWidth { get; set; }
    }
}
