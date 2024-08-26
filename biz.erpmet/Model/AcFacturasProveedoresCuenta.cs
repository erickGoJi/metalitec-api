using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcFacturasProveedoresCuenta
    {
        public int IdFacturaProveedorCuenta { get; set; }
        public int IdFacturaProveedor { get; set; }
        public int IdCuenta { get; set; }
        public bool EsCargo { get; set; }
        public bool? CapturarPorcentaje { get; set; }
        public decimal Porcentaje { get; set; }
        public decimal MontoPesos { get; set; }
        public decimal Monto { get; set; }
        public int SecuenciaDeCalculo { get; set; }
        public string DescripcionFactura { get; set; }
        public int TipoCuenta { get; set; }

        public virtual CtbCuenta IdCuentaNavigation { get; set; }
        public virtual AcFacturasProveedore IdFacturaProveedorNavigation { get; set; }
    }
}
