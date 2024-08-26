using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcClientesFacturasNcdetCuenta
    {
        public int IdClienteFacturaNcdetCuenta { get; set; }
        public int IdClienteFacturaNcdet { get; set; }
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
        public bool FeRetencionFiva { get; set; }
        public bool FeRetencionFisr { get; set; }
        public decimal? MontoBase { get; set; }

        public virtual AcClientesFacturasNcdet IdClienteFacturaNcdetNavigation { get; set; }
        public virtual CtbCuenta IdCuentaNavigation { get; set; }
    }
}
