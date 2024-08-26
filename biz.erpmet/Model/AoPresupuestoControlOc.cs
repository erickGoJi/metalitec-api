using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AoPresupuestoControlOc
    {
        public AoPresupuestoControlOc()
        {
            AoPresupuestoControlOcdets = new HashSet<AoPresupuestoControlOcdet>();
        }

        public int IdPresupuestoControlOc { get; set; }
        public int IdProyecto { get; set; }
        public int NumeroOrdenCambio { get; set; }
        public int IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public string RazonCambio { get; set; }
        public int? IdUsuarioAutorizo { get; set; }
        public DateTime? FechaAutorizada { get; set; }
        public bool? Autorizada { get; set; }

        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<AoPresupuestoControlOcdet> AoPresupuestoControlOcdets { get; set; }
    }
}
