using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcFacturasProveedoresDet
    {
        public int IdFacturaProveedorDet { get; set; }
        public int IdFacturaProveedor { get; set; }
        public int IdExplosionInsumos { get; set; }
        public int? IdPedidoDet { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Costo { get; set; }
        public int? IdCuenta { get; set; }
        public string Observaciones { get; set; }
        public int? IdSubcontratoDet { get; set; }

        public virtual CtbCuenta IdCuentaNavigation { get; set; }
        public virtual AcExplosionInsumo IdExplosionInsumosNavigation { get; set; }
        public virtual AcFacturasProveedore IdFacturaProveedorNavigation { get; set; }
        public virtual AcPedidosDet IdPedidoDetNavigation { get; set; }
    }
}
