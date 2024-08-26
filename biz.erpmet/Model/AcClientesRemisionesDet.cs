using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcClientesRemisionesDet
    {
        public int IdCienteRemisionDet { get; set; }
        public int IdClienteRemision { get; set; }
        public int IdContratoDet { get; set; }
        public decimal Cantidad { get; set; }

        public virtual AcClientesRemisione IdClienteRemisionNavigation { get; set; }
        public virtual AcContratosDet IdContratoDetNavigation { get; set; }
    }
}
