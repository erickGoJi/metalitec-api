using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcRelSeleccionProyectoAcum
    {
        public int IdRelSeleccionProyectoAcum { get; set; }
        public int IdProyecto { get; set; }
        public bool? Seleccionado { get; set; }

        public virtual Proyecto IdProyectoNavigation { get; set; }
    }
}
