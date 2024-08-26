using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcBancosEstadoCuentum
    {
        public int IdEstadoCuenta { get; set; }
        public int IdCuentaBancaria { get; set; }
        public int Vigencia { get; set; }
        public DateTime Fecha { get; set; }
        public string Referencia { get; set; }
        public string Concepto { get; set; }
        public decimal Cargo { get; set; }
        public decimal Abono { get; set; }
        public decimal Saldo { get; set; }
        public short Marca { get; set; }
        public int? FolioConciliacion { get; set; }

        public virtual AcCuentasBancaria IdCuentaBancariaNavigation { get; set; }
    }
}
