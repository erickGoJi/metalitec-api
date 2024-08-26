using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CtbPolizasIetuconcepto
    {
        public int IdPolizaIetuconcepto { get; set; }
        public int IdPolizaDet { get; set; }
        public int IdConceptoIetu { get; set; }
        public decimal Monto { get; set; }

        public virtual AcCatConceptosIetu IdConceptoIetuNavigation { get; set; }
        public virtual CtbPolizasDet IdPolizaDetNavigation { get; set; }
    }
}
