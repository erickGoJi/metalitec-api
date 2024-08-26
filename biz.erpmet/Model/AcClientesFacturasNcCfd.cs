using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcClientesFacturasNcCfd
    {
        public int IdClienteFacturaNcCfd { get; set; }
        public int IdClienteFacturaNc { get; set; }
        public string Xmlcfd { get; set; }
        public string Xmlpoliza { get; set; }
        public DateTime FechaHora { get; set; }
        public string XmlcfdsinAddenda { get; set; }

        public virtual AcClientesFacturasNc IdClienteFacturaNcNavigation { get; set; }
    }
}
