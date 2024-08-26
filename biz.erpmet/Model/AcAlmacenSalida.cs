using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcAlmacenSalida
    {
        public AcAlmacenSalida()
        {
            AcAlmacenEntrada = new HashSet<AcAlmacenEntrada>();
            AcAlmacenSalidasDets = new HashSet<AcAlmacenSalidasDet>();
        }

        public int IdAlmacenSalida { get; set; }
        public int IdTipDocAlmacen { get; set; }
        public int Folio { get; set; }
        public int IdProyecto { get; set; }
        public int IdCentro { get; set; }
        public int IdProyectoDestino { get; set; }
        public int? IdOrdenProduccion { get; set; }
        public int IdDestajista { get; set; }
        public int IdPresupuestoControl { get; set; }
        public int? IdAutorizo { get; set; }
        public int IdResponsable { get; set; }
        public int IdUsuario { get; set; }
        public decimal Importe { get; set; }
        public DateTime Fecha { get; set; }
        public string Observaciones { get; set; }
        public int? IdPoliza { get; set; }
        public bool Cancelada { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public bool Surtida { get; set; }
        public bool EsSalidaPorKit { get; set; }
        public int? IdUsuarioRecuperacion { get; set; }
        public DateTime? FechaRecuperacion { get; set; }
        public bool RegenerarPoliza { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? IdUsuarioModificacion { get; set; }
        public int? IdPolizaInversa { get; set; }

        public virtual Acresponsable IdAutorizoNavigation { get; set; }
        public virtual Centro IdCentroNavigation { get; set; }
        public virtual AoCatDestajista IdDestajistaNavigation { get; set; }
        public virtual AcOrdenProduccion IdOrdenProduccionNavigation { get; set; }
        public virtual CtbPoliza IdPolizaInversaNavigation { get; set; }
        public virtual CtbPoliza IdPolizaNavigation { get; set; }
        public virtual AoPresupuestoControl IdPresupuestoControlNavigation { get; set; }
        public virtual Proyecto IdProyectoDestinoNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual Acresponsable IdResponsableNavigation { get; set; }
        public virtual AcTipDocAlmacen IdTipDocAlmacenNavigation { get; set; }
        public virtual SegUsuario IdUsuarioModificacionNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
        public virtual SegUsuario IdUsuarioRecuperacionNavigation { get; set; }
        public virtual ICollection<AcAlmacenEntrada> AcAlmacenEntrada { get; set; }
        public virtual ICollection<AcAlmacenSalidasDet> AcAlmacenSalidasDets { get; set; }
    }
}
