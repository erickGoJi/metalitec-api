using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcClientesFacturasNccfdirelac
    {
        public int IdCfdirelacionado { get; set; }
        public int IdClienteFacturaNc2017 { get; set; }
        public string Uuid { get; set; }

        public virtual AcClientesFacturasNc2017 IdClienteFacturaNc2017Navigation { get; set; }
    }
}
