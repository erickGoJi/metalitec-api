using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcUnidadesNegocio
    {
        public AcUnidadesNegocio()
        {
            Proyectos = new HashSet<Proyecto>();
        }

        public int IdUnidadNegocio { get; set; }
        public string UnidadNegocio { get; set; }
        public string Descripcion { get; set; }
        public bool AceptaMov { get; set; }
        public int? IdTipoUnidadNegocio { get; set; }
        public string Rfc { get; set; }
        public string RazonSocial { get; set; }
        public bool PersonaMoral { get; set; }

        public virtual AcCatTipoUnidadesNegocio IdTipoUnidadNegocioNavigation { get; set; }
        public virtual ICollection<Proyecto> Proyectos { get; set; }
    }
}
