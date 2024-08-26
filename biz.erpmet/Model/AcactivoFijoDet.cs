using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcactivoFijoDet
    {
        public AcactivoFijoDet()
        {
            AcactivoFijoFotos = new HashSet<AcactivoFijoFoto>();
        }

        public int IdActivoDet { get; set; }
        public int IdActivo { get; set; }
        public int IdResponsable { get; set; }
        public DateTime Fecha { get; set; }
        public string Observaciones { get; set; }
        public bool Entregado { get; set; }
        public DateTime? FechaEntregado { get; set; }

        public virtual AcactivoFijo IdActivoNavigation { get; set; }
        public virtual Acresponsable IdResponsableNavigation { get; set; }
        public virtual ICollection<AcactivoFijoFoto> AcactivoFijoFotos { get; set; }
    }
}
