using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AoPresupuestoControlPeriodo
    {
        public int IdPresupuestocontrolPeriodo { get; set; }
        public int IdPresupuestoControl { get; set; }
        public int Periodo { get; set; }
        public decimal CantidadSubcontrato { get; set; }
        public decimal CantidadDestajo { get; set; }

        public virtual AoPresupuestoControl IdPresupuestoControlNavigation { get; set; }
    }
}
