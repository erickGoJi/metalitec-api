using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class BiHistoricoDet
    {
        public int IdHistoricoDet { get; set; }
        public int IdConcepto { get; set; }
        public int IdHistorico { get; set; }

        public virtual AoCatConcepto IdConceptoNavigation { get; set; }
        public virtual BiHistorico IdHistoricoNavigation { get; set; }
    }
}
