using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcContratosOcdet
    {
        public int IdContratoOcdet { get; set; }
        public int IdContratoOc { get; set; }
        public int IdContratoDet { get; set; }
        public decimal Cantidad { get; set; }

        public virtual AcContratosDet IdContratoDetNavigation { get; set; }
        public virtual AcContratosOc IdContratoOcNavigation { get; set; }
    }
}
