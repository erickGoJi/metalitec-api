using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AoPresupuestoControlOcdet
    {
        public int IdPresupuestoControlOcdet { get; set; }
        public int IdPresupuestoControlOc { get; set; }
        public int IdPresupuestoControl { get; set; }
        public decimal Cantidad { get; set; }

        public virtual AoPresupuestoControl IdPresupuestoControlNavigation { get; set; }
        public virtual AoPresupuestoControlOc IdPresupuestoControlOcNavigation { get; set; }
    }
}
