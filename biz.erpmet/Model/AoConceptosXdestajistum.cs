using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AoConceptosXdestajistum
    {
        public int IdConceptoXdestajista { get; set; }
        public int IdDestajista { get; set; }
        public int IdPresupuestoControl { get; set; }

        public virtual AoCatDestajista IdDestajistaNavigation { get; set; }
        public virtual AoPresupuestoControl IdPresupuestoControlNavigation { get; set; }
    }
}
