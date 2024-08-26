using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ExtraCalculationType
    {
        public ExtraCalculationType()
        {
            Extras = new HashSet<Extra>();
        }

        public int ExtraCalculationTypeId { get; set; }
        public int ExtraTypeId { get; set; }
        public string Name { get; set; }
        public string Spname { get; set; }
        public byte HasRate { get; set; }
        public byte HasQty { get; set; }
        public byte? System { get; set; }
        public byte? Sort { get; set; }
        public string Notes { get; set; }
        public string RateText { get; set; }
        public string QtyText { get; set; }

        public virtual ICollection<Extra> Extras { get; set; }
    }
}
