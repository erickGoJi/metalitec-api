using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatTiposRetencione
    {
        public AcCatTiposRetencione()
        {
            AcConstanciasRetenciones = new HashSet<AcConstanciasRetencione>();
        }

        public int IdTipoRetencion { get; set; }
        public string ClaveRetencion { get; set; }
        public string DescripcionRetencion { get; set; }

        public virtual ICollection<AcConstanciasRetencione> AcConstanciasRetenciones { get; set; }
    }
}
