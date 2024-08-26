using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcproveedoresInsumo
    {
        public int IdProveedorInsumo { get; set; }
        public int IdProveedor { get; set; }
        public int IdInsumo { get; set; }
        public decimal Precio { get; set; }
        public DateTime Fecha { get; set; }
        public string Observaciones { get; set; }

        public virtual AcCatInsumo IdInsumoNavigation { get; set; }
        public virtual AcProveedore IdProveedorNavigation { get; set; }
    }
}
