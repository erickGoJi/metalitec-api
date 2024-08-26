using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CtbPolizasDetComprobante
    {
        public int IdPolizaDetComprobante { get; set; }
        public int IdPolizaDet { get; set; }
        public string Uuid { get; set; }
        public decimal Monto { get; set; }
        public string Rfc { get; set; }
    }
}
