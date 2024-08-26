using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcRelCuentaProyecto
    {
        public int IdRelCuentaProyecto { get; set; }
        public int IdCuenta { get; set; }
        public int IdProyecto { get; set; }

        public virtual CtbCuenta IdCuentaNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
    }
}
