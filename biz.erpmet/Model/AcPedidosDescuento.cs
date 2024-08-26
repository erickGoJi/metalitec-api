using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcPedidosDescuento
    {
        public int IdPedidoDescuento { get; set; }
        public int IdPedido { get; set; }
        public short Tipo { get; set; }
        public bool? CapturarPorcentaje { get; set; }
        public decimal Porcentaje { get; set; }
        public decimal Monto { get; set; }
        public short Renglon { get; set; }
        public string Descripcion { get; set; }
        public decimal MontoCig { get; set; }

        public virtual AcPedido IdPedidoNavigation { get; set; }
    }
}
