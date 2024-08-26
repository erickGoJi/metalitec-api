using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CtbSaldoXflujo
    {
        public int IdSaldoXflujo { get; set; }
        public int IdFlujo { get; set; }
        public int IdProyecto { get; set; }
        public int? IdCuentaBancaria { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Saldo { get; set; }
        public bool Marca { get; set; }

        public virtual AcCuentasBancaria IdCuentaBancariaNavigation { get; set; }
        public virtual AcCatFlujo IdFlujoNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
    }
}
