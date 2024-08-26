using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class ProyectosAlmacenGeneral
    {
        public int IdProyectoAlmacenGeneral { get; set; }
        public int IdAlmacenGeneral { get; set; }
        public int IdAlmacenObra { get; set; }
        public int IdAlmacenTransito { get; set; }

        public virtual Proyecto IdAlmacenGeneralNavigation { get; set; }
        public virtual Proyecto IdAlmacenObraNavigation { get; set; }
        public virtual Proyecto IdAlmacenTransitoNavigation { get; set; }
    }
}
