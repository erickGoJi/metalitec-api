using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatTiposImpuesto
    {
        public AcCatTiposImpuesto()
        {
            AcConstanciasRetencionesDets = new HashSet<AcConstanciasRetencionesDet>();
        }

        public int IdTipoImpuesto { get; set; }
        public string ClaveImpuesto { get; set; }
        public string DescripcionImpuesto { get; set; }
        public bool EsRetencion { get; set; }
        public string LocalFederal { get; set; }
        public string Entidad { get; set; }
        public bool EsTraslado { get; set; }
        public string Version { get; set; }

        public virtual ICollection<AcConstanciasRetencionesDet> AcConstanciasRetencionesDets { get; set; }
    }
}
