using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcComplementoPagoCfd
    {
        public int IdComplementoPagoCfd { get; set; }
        public int IdComplementoPago { get; set; }
        public string Xmlcfd { get; set; }
        public DateTime FechaHora { get; set; }

        public virtual AcComplementoPago IdComplementoPagoNavigation { get; set; }
    }
}
