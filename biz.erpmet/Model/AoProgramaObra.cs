using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AoProgramaObra
    {
        public int IdProgramaObra { get; set; }
        public int IdPresupuestoControl { get; set; }
        public int Periodo { get; set; }
        public decimal Volumen { get; set; }

        public virtual AoPresupuestoControl IdPresupuestoControlNavigation { get; set; }
    }
}
