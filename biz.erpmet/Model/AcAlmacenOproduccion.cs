using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcAlmacenOproduccion
    {
        public AcAlmacenOproduccion()
        {
            AcAlmacenOproduccionDets = new HashSet<AcAlmacenOproduccionDet>();
        }

        public int IdAlmacenOproduccion { get; set; }
        public int IdProyecto { get; set; }
        public int IdExplosionInsumos { get; set; }
        public int Folio { get; set; }
        public DateTime Fecha { get; set; }
        public int IdUsuario { get; set; }
        public int IdAutorizo { get; set; }
        public int? IdElaboro { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Importe { get; set; }
        public string Observaciones { get; set; }
        public bool Cerrado { get; set; }
        public int IdPoliza { get; set; }
        public bool Cancelado { get; set; }
        public DateTime? FechaCancelacion { get; set; }

        public virtual Acresponsable IdAutorizoNavigation { get; set; }
        public virtual Acresponsable IdElaboroNavigation { get; set; }
        public virtual AcExplosionInsumo IdExplosionInsumosNavigation { get; set; }
        public virtual CtbPoliza IdPolizaNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<AcAlmacenOproduccionDet> AcAlmacenOproduccionDets { get; set; }
    }
}
