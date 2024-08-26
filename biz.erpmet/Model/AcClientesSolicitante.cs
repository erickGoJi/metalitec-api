using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcClientesSolicitante
    {
        public int IdClienteSolicitante { get; set; }
        public int IdCliente { get; set; }
        public string Solicitante { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string Mail { get; set; }

        public virtual AcCliente IdClienteNavigation { get; set; }
    }
}
