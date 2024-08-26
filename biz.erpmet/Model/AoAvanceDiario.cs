using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AoAvanceDiario
    {
        public int IdAvanceDiario { get; set; }
        public int IdPresupuestoControl { get; set; }
        public int IdCentro { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Cantidad { get; set; }
        public int? IdContratista { get; set; }
        public int? IdDestajista { get; set; }

        public virtual Centro IdCentroNavigation { get; set; }
        public virtual AoCatContratista IdContratistaNavigation { get; set; }
        public virtual AoCatDestajista IdDestajistaNavigation { get; set; }
        public virtual AoPresupuestoControl IdPresupuestoControlNavigation { get; set; }
    }
}
