using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcPedidosDet
    {
        public AcPedidosDet()
        {
            AcAlmacenEntradasDets = new HashSet<AcAlmacenEntradasDet>();
            AcFacturasProveedoresDets = new HashSet<AcFacturasProveedoresDet>();
        }

        public int IdPedidoDet { get; set; }
        public int IdPedido { get; set; }
        public int IdRequisicionDet { get; set; }
        public int Renglon { get; set; }
        public string DescripcionLarga { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Costo { get; set; }
        public decimal PorcentajeDescuento { get; set; }
        public decimal CostoNeto { get; set; }
        public string Observaciones { get; set; }
        public string ObservacionesAlmacen { get; set; }
        public decimal PrecioConIvaGuatemala { get; set; }
        public decimal PrecioCigneto { get; set; }
        public DateTime? FechaProbableDeEntrega { get; set; }

        public virtual AcPedido IdPedidoNavigation { get; set; }
        public virtual AcRequisicionDet IdRequisicionDetNavigation { get; set; }
        public virtual ICollection<AcAlmacenEntradasDet> AcAlmacenEntradasDets { get; set; }
        public virtual ICollection<AcFacturasProveedoresDet> AcFacturasProveedoresDets { get; set; }
    }
}
