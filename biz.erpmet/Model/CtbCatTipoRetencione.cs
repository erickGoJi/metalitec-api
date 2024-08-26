using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CtbCatTipoRetencione
    {
        public CtbCatTipoRetencione()
        {
            CtbConstanciaRetenciones = new HashSet<CtbConstanciaRetencione>();
        }

        public int IdTipoRetencion { get; set; }
        public string Clave { get; set; }
        public string Retencion { get; set; }

        public virtual ICollection<CtbConstanciaRetencione> CtbConstanciaRetenciones { get; set; }
    }
}
