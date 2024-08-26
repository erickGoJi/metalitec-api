using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatConceptosIetu
    {
        public AcCatConceptosIetu()
        {
            AcCatFlujos = new HashSet<AcCatFlujo>();
            CtbPolizasIetuconceptos = new HashSet<CtbPolizasIetuconcepto>();
        }

        public int IdConceptoIetu { get; set; }
        public string ConceptoIetu { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<AcCatFlujo> AcCatFlujos { get; set; }
        public virtual ICollection<CtbPolizasIetuconcepto> CtbPolizasIetuconceptos { get; set; }
    }
}
