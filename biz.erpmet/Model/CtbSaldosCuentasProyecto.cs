using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CtbSaldosCuentasProyecto
    {
        public int IdSaldoEjercicio { get; set; }
        public int Ejercicio { get; set; }
        public int IdProyecto { get; set; }
        public int IdCuenta { get; set; }
        public decimal Saldo { get; set; }

        public virtual CtbCuenta IdCuentaNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
    }
}
