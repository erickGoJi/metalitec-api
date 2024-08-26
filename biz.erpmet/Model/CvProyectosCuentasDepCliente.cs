using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvProyectosCuentasDepCliente
    {
        public int IdProyectoCuentaDepCliente { get; set; }
        public int IdProyecto { get; set; }
        public int IdCuentaBancaria { get; set; }
        public int? IdCuentaDepPorIdentificar { get; set; }

        public virtual AcCuentasBancaria IdCuentaBancariaNavigation { get; set; }
        public virtual CtbCuenta IdCuentaDepPorIdentificarNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
    }
}
