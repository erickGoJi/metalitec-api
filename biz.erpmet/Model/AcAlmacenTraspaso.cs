using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcAlmacenTraspaso
    {
        public AcAlmacenTraspaso()
        {
            AcAlmacenTraspasosDets = new HashSet<AcAlmacenTraspasosDet>();
            AcSolicitudMaterialIdTraspasoObraNavigations = new HashSet<AcSolicitudMaterial>();
            AcSolicitudMaterialIdTraspasoTransitoNavigations = new HashSet<AcSolicitudMaterial>();
        }

        public int IdAlmacenTraspaso { get; set; }
        public int IdProyectoOrigen { get; set; }
        public int IdProyectoDestino { get; set; }
        public int Folio { get; set; }
        public DateTime Fecha { get; set; }
        public int IdUsuario { get; set; }
        public int? IdAutorizo { get; set; }
        public int IdResponsable { get; set; }
        public decimal Importe { get; set; }
        public string Observaciones { get; set; }
        public int? IdPoliza { get; set; }
        public bool Cancelado { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public bool RegenerarPoliza { get; set; }
        public int? IdUsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? IdPolizaInversa { get; set; }

        public virtual Acresponsable IdAutorizoNavigation { get; set; }
        public virtual CtbPoliza IdPolizaInversaNavigation { get; set; }
        public virtual CtbPoliza IdPolizaNavigation { get; set; }
        public virtual Proyecto IdProyectoDestinoNavigation { get; set; }
        public virtual Proyecto IdProyectoOrigenNavigation { get; set; }
        public virtual Acresponsable IdResponsableNavigation { get; set; }
        public virtual SegUsuario IdUsuarioModificacionNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<AcAlmacenTraspasosDet> AcAlmacenTraspasosDets { get; set; }
        public virtual ICollection<AcSolicitudMaterial> AcSolicitudMaterialIdTraspasoObraNavigations { get; set; }
        public virtual ICollection<AcSolicitudMaterial> AcSolicitudMaterialIdTraspasoTransitoNavigations { get; set; }
    }
}
