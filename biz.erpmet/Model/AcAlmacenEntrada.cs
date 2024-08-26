using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcAlmacenEntrada
    {
        public AcAlmacenEntrada()
        {
            AcAlmacenEntradasDets = new HashSet<AcAlmacenEntradasDet>();
        }

        public int IdAlmacenEntrada { get; set; }
        public int IdTipDocAlmacen { get; set; }
        public int Folio { get; set; }
        public int IdProyecto { get; set; }
        public int? IdProveedor { get; set; }
        public int? IdAutorizo { get; set; }
        public int IdResponsable { get; set; }
        public int IdUsuario { get; set; }
        public decimal Importe { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public int? IdPedido { get; set; }
        public string NumRemision { get; set; }
        public int? IdFacturaProveedor { get; set; }
        public string Observaciones { get; set; }
        public int? IdPoliza { get; set; }
        public bool Cancelado { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public bool? ConPedido { get; set; }
        public DateTime FechaCaptura { get; set; }
        public int? IdUsuarioDevolucion { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? IdUsuarioModificacion { get; set; }
        public int? IdPolizaInversa { get; set; }
        public int? IdAlmacenSalida { get; set; }
        public int? FolioSalida { get; set; }
        public bool PorRm { get; set; }
        public string RutaDocumento { get; set; }

        public virtual AcAlmacenSalida IdAlmacenSalidaNavigation { get; set; }
        public virtual Acresponsable IdAutorizoNavigation { get; set; }
        public virtual AcFacturasProveedore IdFacturaProveedorNavigation { get; set; }
        public virtual AcPedido IdPedidoNavigation { get; set; }
        public virtual CtbPoliza IdPolizaInversaNavigation { get; set; }
        public virtual CtbPoliza IdPolizaNavigation { get; set; }
        public virtual AcProveedore IdProveedorNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual Acresponsable IdResponsableNavigation { get; set; }
        public virtual AcTipDocAlmacen IdTipDocAlmacenNavigation { get; set; }
        public virtual SegUsuario IdUsuarioDevolucionNavigation { get; set; }
        public virtual SegUsuario IdUsuarioModificacionNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<AcAlmacenEntradasDet> AcAlmacenEntradasDets { get; set; }
    }
}
