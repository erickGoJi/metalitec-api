using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvSubtiposTerreno
    {
        public CvSubtiposTerreno()
        {
            CvProyectosPreciosLista = new HashSet<CvProyectosPreciosLista>();
        }

        public int IdSubtipoTerreno { get; set; }
        public string SubtipoTerreno { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<CvProyectosPreciosLista> CvProyectosPreciosLista { get; set; }
    }
}
