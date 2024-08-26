using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvProyectosCuentasXplan
    {
        public int IdProyectoCuentasXplan { get; set; }
        public int IdProyecto { get; set; }
        public int IdTipoPlan { get; set; }
        public int IdCuentaSinEscritura { get; set; }
        public int IdCuentaConEscritura { get; set; }
        public bool? ConsiderarEnEscritura { get; set; }
        public bool PermiteDevolucion { get; set; }

        public virtual CtbCuenta IdCuentaConEscrituraNavigation { get; set; }
        public virtual CtbCuenta IdCuentaSinEscrituraNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual CvTiposPlan IdTipoPlanNavigation { get; set; }
    }
}
