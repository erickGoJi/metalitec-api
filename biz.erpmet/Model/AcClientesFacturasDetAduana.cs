using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcClientesFacturasDetAduana
    {
        public int IdClienteFacturaDetAduana { get; set; }
        public int IdClienteFacturaDet { get; set; }
        public string Nombre { get; set; }
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Aduana { get; set; }

        public virtual AcClientesFacturasDet IdClienteFacturaDetNavigation { get; set; }
    }
}
