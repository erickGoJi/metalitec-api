using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvTiposDescuento
    {
        public CvTiposDescuento()
        {
            CvProyectosDescuentos = new HashSet<CvProyectosDescuento>();
        }

        public int IdTipoDescuento { get; set; }
        public string TipoDescuento { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<CvProyectosDescuento> CvProyectosDescuentos { get; set; }
    }
}
