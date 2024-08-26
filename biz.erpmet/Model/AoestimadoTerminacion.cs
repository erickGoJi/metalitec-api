using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AoestimadoTerminacion
    {
        public AoestimadoTerminacion()
        {
            AoestimadoTerminacionDetalles = new HashSet<AoestimadoTerminacionDetalle>();
        }

        public int IdEstimado { get; set; }
        public int IdProyecto { get; set; }
        public int Vigencia { get; set; }
        public DateTime FechaDeCorte { get; set; }

        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual ICollection<AoestimadoTerminacionDetalle> AoestimadoTerminacionDetalles { get; set; }
    }
}
