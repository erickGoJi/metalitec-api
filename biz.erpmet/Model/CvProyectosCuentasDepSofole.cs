using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvProyectosCuentasDepSofole
    {
        public int IdProyectoCuentaDepSofol { get; set; }
        public int IdProyecto { get; set; }
        public int IdCuentaBancaria { get; set; }

        public virtual AcCuentasBancaria IdCuentaBancariaNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
    }
}
