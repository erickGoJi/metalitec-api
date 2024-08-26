using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class Qsunit
    {
        public int UnitId { get; set; }
        public string Name { get; set; }
        public bool? Enabled { get; set; }
        public bool? HasRate { get; set; }
        public bool? HasQty { get; set; }
        public int? Sort { get; set; }
        public string Notes { get; set; }
        public string RateText { get; set; }
        public string QtyText { get; set; }
        public bool? System { get; set; }
    }
}
