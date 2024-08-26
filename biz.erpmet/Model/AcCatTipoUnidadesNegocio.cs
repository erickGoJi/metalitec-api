using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatTipoUnidadesNegocio
    {
        public AcCatTipoUnidadesNegocio()
        {
            AcUnidadesNegocios = new HashSet<AcUnidadesNegocio>();
        }

        public int IdTipoUnidadNegocio { get; set; }
        public string TipoUnidadNegocio { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<AcUnidadesNegocio> AcUnidadesNegocios { get; set; }
    }
}
