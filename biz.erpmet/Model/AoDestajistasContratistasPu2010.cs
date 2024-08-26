using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AoDestajistasContratistasPu2010
    {
        public int IdDestajistaContratistaPu2010 { get; set; }
        public int IdProyecto { get; set; }
        public int IdDestajista { get; set; }
        public int IdContratistaPu2010 { get; set; }

        public virtual AoCatDestajista IdDestajistaNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
    }
}
