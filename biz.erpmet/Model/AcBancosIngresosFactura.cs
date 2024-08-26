using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcBancosIngresosFactura
    {
        public int IdBancoIngresoFacturas { get; set; }
        public int IdBancoIngreso { get; set; }
        public int IdClienteFactura { get; set; }
        public decimal Monto { get; set; }
        public decimal MontoDls { get; set; }

        public virtual AcBancosIngreso IdBancoIngresoNavigation { get; set; }
        public virtual AcClientesFactura IdClienteFacturaNavigation { get; set; }
    }
}
