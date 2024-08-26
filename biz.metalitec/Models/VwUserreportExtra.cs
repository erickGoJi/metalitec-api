using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportExtra
    {
        public int ExtraId { get; set; }
        public string Extra { get; set; }
        public string ExtraDescription { get; set; }
        public string EstimateType { get; set; }
        public string ExtraType { get; set; }
        public byte? Addition { get; set; }
        public string RecalculateSectionRollType { get; set; }
        public string CostCode { get; set; }
        public string CostCentre { get; set; }
        public string SectionRollType { get; set; }
        public string CalculationType { get; set; }
        public double? Quantity { get; set; }
        public double? UnitPrice { get; set; }
    }
}
