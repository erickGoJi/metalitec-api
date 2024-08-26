using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AoSubcontratosOcdet
    {
        public int IdSubcontratoOcdet { get; set; }
        public int IdSubContratoOc { get; set; }
        public int IdSubContratoDet { get; set; }
        public decimal Cantidad { get; set; }

        public virtual AoSubcontratosDet IdSubContratoDetNavigation { get; set; }
        public virtual AoSubcontratosOc IdSubContratoOcNavigation { get; set; }
    }
}
