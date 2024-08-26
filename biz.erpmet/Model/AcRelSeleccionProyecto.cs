using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcRelSeleccionProyecto
    {
        public int IdRelSeleccionProyecto { get; set; }
        public int IdProyecto { get; set; }
        public bool? Seleccionado { get; set; }

        public virtual Proyecto IdProyectoNavigation { get; set; }
    }
}
