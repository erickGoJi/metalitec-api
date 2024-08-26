using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CtbPolizasDetCheque
    {
        public int IdPolizaDetCheque { get; set; }
        public int IdPolizaDet { get; set; }
        public string NumeroCheque { get; set; }
        public string BancoOrigen { get; set; }
        public string CuentaOrigen { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public string Beneficiario { get; set; }
        public string Rfc { get; set; }
    }
}
