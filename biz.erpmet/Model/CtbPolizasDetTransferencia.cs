using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CtbPolizasDetTransferencia
    {
        public int IdPolizaDetTransferencia { get; set; }
        public int IdPolizaDet { get; set; }
        public string CuentaOrigen { get; set; }
        public string BancoOrigen { get; set; }
        public decimal Monto { get; set; }
        public string CuentaDestino { get; set; }
        public string BancoDestino { get; set; }
        public DateTime Fecha { get; set; }
        public string Beneficiario { get; set; }
        public string Rfc { get; set; }
    }
}
