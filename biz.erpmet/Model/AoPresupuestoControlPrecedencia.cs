using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AoPresupuestoControlPrecedencia
    {
        public int IdPresupuestocontroltPrecedencia { get; set; }
        public int IdPresupuestoControlPadre { get; set; }
        public int IdPresupuestoControlHijo { get; set; }

        public virtual AoPresupuestoControl IdPresupuestoControlHijoNavigation { get; set; }
        public virtual AoPresupuestoControl IdPresupuestoControlPadreNavigation { get; set; }
    }
}
