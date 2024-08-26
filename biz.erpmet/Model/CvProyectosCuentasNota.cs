using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvProyectosCuentasNota
    {
        public int IdProyectoCuentaNota { get; set; }
        public int IdProyecto { get; set; }
        public int IdTipoNota { get; set; }
        public int IdCuenta { get; set; }
        public bool GenerarCuentas { get; set; }

        public virtual CtbCuenta IdCuentaNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual CvTiposNota IdTipoNotaNavigation { get; set; }
    }
}
