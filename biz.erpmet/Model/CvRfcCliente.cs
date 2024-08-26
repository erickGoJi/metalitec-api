using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvRfcCliente
    {
        public CvRfcCliente()
        {
            CvRfcClientesDets = new HashSet<CvRfcClientesDet>();
        }

        public int IdRfcCliente { get; set; }
        public string Rfc { get; set; }

        public virtual ICollection<CvRfcClientesDet> CvRfcClientesDets { get; set; }
    }
}
