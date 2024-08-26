using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcProyectosNominaModelo
    {
        public int IdProyectoNominaModelo { get; set; }
        public int IdProyecto { get; set; }
        public int IdNominaTipo { get; set; }
        public int IdNominaModelo { get; set; }

        public virtual AcNominaModelo IdNominaModeloNavigation { get; set; }
        public virtual AcNominaTipo IdNominaTipoNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
    }
}
