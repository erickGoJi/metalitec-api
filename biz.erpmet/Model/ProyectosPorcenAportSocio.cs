using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class ProyectosPorcenAportSocio
    {
        public int IdProyecto { get; set; }
        public int IdCuenta { get; set; }
        public decimal Porcentaje { get; set; }

        public virtual CtbCuenta IdCuentaNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
    }
}
