using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CtbPolizasDiot
    {
        public int IdPolizaDiot { get; set; }
        public int IdPoliza { get; set; }
        public int IdCuentaProveedor { get; set; }
        public int IdConceptoDiot { get; set; }
        public decimal Monto { get; set; }
        public int? IdPolizaDetAbono { get; set; }
        public decimal MontoIva { get; set; }
        public bool EsComprobacion { get; set; }

        public virtual CtbConceptosDiot IdConceptoDiotNavigation { get; set; }
        public virtual CtbCuenta IdCuentaProveedorNavigation { get; set; }
        public virtual CtbPoliza IdPolizaNavigation { get; set; }
    }
}
