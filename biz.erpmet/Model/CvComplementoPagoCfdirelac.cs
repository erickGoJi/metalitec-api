using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvComplementoPagoCfdirelac
    {
        public int IdCfdirelacionado { get; set; }
        public int IdComplementoPago { get; set; }
        public string Cfdirelacionado { get; set; }

        public virtual CvComplementoPago IdComplementoPagoNavigation { get; set; }
    }
}
