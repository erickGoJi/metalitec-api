using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AoSubContratosEstDescuento
    {
        public int IdSubContratoEstDescuento { get; set; }
        public int IdSubContratoEst { get; set; }
        public int IdDescuento { get; set; }
        public decimal Monto { get; set; }

        public virtual AoCatDescuento IdDescuentoNavigation { get; set; }
        public virtual AoSubContratosEst IdSubContratoEstNavigation { get; set; }
    }
}
