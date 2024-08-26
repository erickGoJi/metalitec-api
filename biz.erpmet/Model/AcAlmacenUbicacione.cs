using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcAlmacenUbicacione
    {
        public AcAlmacenUbicacione()
        {
            Proyectos = new HashSet<Proyecto>();
        }

        public int IdUbicacionAlmacen { get; set; }
        public string UbicacionAlmacen { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Proyecto> Proyectos { get; set; }
    }
}
