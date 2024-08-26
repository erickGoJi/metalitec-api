using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CtbPolizasDetCliente
    {
        public int IdPolizaDetCliente { get; set; }
        public int IdPolizaDet { get; set; }
        public int IdClienteFactura { get; set; }

        public virtual AcClientesFactura IdClienteFacturaNavigation { get; set; }
        public virtual CtbPolizasDet IdPolizaDetNavigation { get; set; }
    }
}
