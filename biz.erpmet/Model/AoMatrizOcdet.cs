using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AoMatrizOcdet
    {
        public int IdMatrizOcdet { get; set; }
        public int IdMatrizOc { get; set; }
        public int IdExpXconcepto { get; set; }
        public decimal Cantidad { get; set; }

        public virtual AoExpXconcepto IdExpXconceptoNavigation { get; set; }
        public virtual AoMatrizOc IdMatrizOcNavigation { get; set; }
    }
}
