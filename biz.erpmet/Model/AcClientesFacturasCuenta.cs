using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcClientesFacturasCuenta
    {
        public int IdClienteFacturaCuenta { get; set; }
        public int IdClienteFactura { get; set; }
        public int IdCuenta { get; set; }
        public bool EsCargo { get; set; }
        public bool? CapturarPorcentaje { get; set; }
        public decimal Porcentaje { get; set; }
        public decimal MontoPesos { get; set; }
        public decimal Monto { get; set; }
        public short SecuenciaCalculo { get; set; }
        public short BaseCalculo { get; set; }
        public string DescripcionFactura { get; set; }
        public int TipoCuenta { get; set; }
        public bool FeDescuento { get; set; }
        public bool FeDeduccionLocal { get; set; }
        public bool FeTrasladoLocal { get; set; }
        public bool FeRetencionFisr { get; set; }
        public bool FeRetencionFiva { get; set; }
        public decimal? MontoBase { get; set; }

        public virtual AcClientesFactura IdClienteFacturaNavigation { get; set; }
        public virtual CtbCuenta IdCuentaNavigation { get; set; }
    }
}
