using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AoDestajosEstDet
    {
        public AoDestajosEstDet()
        {
            AoDestajosEstCcs = new HashSet<AoDestajosEstCc>();
        }

        public int IdDestajoDet { get; set; }
        public int IdDestajoEst { get; set; }
        public int IdPresupuestoControl { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Costo { get; set; }
        public decimal Importe { get; set; }

        public virtual AoDestajosEst IdDestajoEstNavigation { get; set; }
        public virtual AoPresupuestoControl IdPresupuestoControlNavigation { get; set; }
        public virtual ICollection<AoDestajosEstCc> AoDestajosEstCcs { get; set; }
    }
}
