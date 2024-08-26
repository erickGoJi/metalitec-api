using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcBancosIngresosCuenta
    {
        public int IdBancoIngresoCuenta { get; set; }
        public int IdBancoIngreso { get; set; }
        public int IdCuenta { get; set; }
        public bool? EsCargo { get; set; }
        public bool? CapturarPorcentaje { get; set; }
        public decimal Porcentaje { get; set; }
        public decimal MontoPesos { get; set; }
        public decimal Monto { get; set; }
        public int SecuenciaDeCalculo { get; set; }
        public bool UtilizarParidadFactura { get; set; }

        public virtual AcBancosIngreso IdBancoIngresoNavigation { get; set; }
        public virtual CtbCuenta IdCuentaNavigation { get; set; }
    }
}
