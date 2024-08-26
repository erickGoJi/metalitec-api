using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AoSubContratosEstDet
    {
        public AoSubContratosEstDet()
        {
            AoSubContratosEstDetCcs = new HashSet<AoSubContratosEstDetCc>();
        }

        public int IdSubContratoEstDet { get; set; }
        public int IdSubContratoEst { get; set; }
        public int IdSubcontratoDet { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Costo { get; set; }

        public virtual AoSubContratosEst IdSubContratoEstNavigation { get; set; }
        public virtual AoSubcontratosDet IdSubcontratoDetNavigation { get; set; }
        public virtual ICollection<AoSubContratosEstDetCc> AoSubContratosEstDetCcs { get; set; }
    }
}
