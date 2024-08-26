using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AoDestajosEstCc
    {
        public int IdDestajoEstCc { get; set; }
        public int IdDestajoDet { get; set; }
        public int IdCentro { get; set; }
        public decimal Cantidad { get; set; }

        public virtual Centro IdCentroNavigation { get; set; }
        public virtual AoDestajosEstDet IdDestajoDetNavigation { get; set; }
    }
}
