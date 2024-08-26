using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvRfcClientesDet
    {
        public int IdRfcClienteDet { get; set; }
        public int IdRfcCliente { get; set; }
        public string Descripcion { get; set; }
        public string BaseDatos { get; set; }
        public int IdCliente { get; set; }

        public virtual CvRfcCliente IdRfcClienteNavigation { get; set; }
    }
}
