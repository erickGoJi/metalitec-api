using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AoSubContratosEstDetCc
    {
        public int IdSubContratoEstDetCc { get; set; }
        public int IdSubContratoEstDet { get; set; }
        public int IdCentro { get; set; }
        public decimal Cantidad { get; set; }

        public virtual Centro IdCentroNavigation { get; set; }
        public virtual AoSubContratosEstDet IdSubContratoEstDetNavigation { get; set; }
    }
}
