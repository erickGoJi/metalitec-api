using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcactivoFijoFoto
    {
        public int IdActivoFoto { get; set; }
        public int IdActivoDet { get; set; }
        public string Ruta { get; set; }
        public string Descripcion { get; set; }

        public virtual AcactivoFijoDet IdActivoDetNavigation { get; set; }
    }
}
