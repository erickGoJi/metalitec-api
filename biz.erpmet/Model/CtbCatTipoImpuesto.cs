using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CtbCatTipoImpuesto
    {
        public CtbCatTipoImpuesto()
        {
            CtbConstanciaRetencionDets = new HashSet<CtbConstanciaRetencionDet>();
        }

        public int IdTipoImpuesto { get; set; }
        public string Clave { get; set; }
        public string TipoImpuesto { get; set; }

        public virtual ICollection<CtbConstanciaRetencionDet> CtbConstanciaRetencionDets { get; set; }
    }
}
