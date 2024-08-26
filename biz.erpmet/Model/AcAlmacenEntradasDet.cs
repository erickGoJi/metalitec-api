using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcAlmacenEntradasDet
    {
        public int IdAlmacenEntradaDet { get; set; }
        public int IdAlmacenEntrada { get; set; }
        public int IdExplosionInsumos { get; set; }
        public int? IdPedidoDet { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Devolucion { get; set; }
        public decimal Costo { get; set; }

        public virtual AcAlmacenEntrada IdAlmacenEntradaNavigation { get; set; }
        public virtual AcExplosionInsumo IdExplosionInsumosNavigation { get; set; }
        public virtual AcPedidosDet IdPedidoDetNavigation { get; set; }
    }
}
