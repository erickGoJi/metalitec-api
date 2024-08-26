using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcClientesFacturasCfdirelac
    {
        public int IdCfdirelacionado { get; set; }
        public int IdClienteFactura2017 { get; set; }
        public string Uuid { get; set; }

        public virtual AcClientesFacturas2017 IdClienteFactura2017Navigation { get; set; }
    }
}
