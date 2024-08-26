using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcAditivasExplosion
    {
        public AcAditivasExplosion()
        {
            AcAditivasExplosionDets = new HashSet<AcAditivasExplosionDet>();
        }

        public int IdAditivaExplosion { get; set; }
        public int IdProyecto { get; set; }
        public int Folio { get; set; }
        public string Comentario { get; set; }
        public DateTime Fecha { get; set; }
        public int IdUsuario { get; set; }
        public DateTime? FechaAutorizada { get; set; }
        public int? IdUsuarioAutorizo { get; set; }
        public bool? Autorizada { get; set; }

        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<AcAditivasExplosionDet> AcAditivasExplosionDets { get; set; }
    }
}
