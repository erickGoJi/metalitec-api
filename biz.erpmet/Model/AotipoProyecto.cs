using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AotipoProyecto
    {
        public AotipoProyecto()
        {
            Proyectos = new HashSet<Proyecto>();
        }

        public int IdTipoProyecto { get; set; }
        public int TipoProyecto { get; set; }
        public string Texto { get; set; }

        public virtual ICollection<Proyecto> Proyectos { get; set; }
    }
}
