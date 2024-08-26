using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcComplementoPagoCfdrelac
    {
        public int IdCfdirelacionado { get; set; }
        public int IdComplementoPago { get; set; }
        public string Cfdirelacionado { get; set; }

        public virtual AcComplementoPago IdComplementoPagoNavigation { get; set; }
    }
}
