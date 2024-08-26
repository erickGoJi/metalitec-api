using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatTipoClientesCuenta
    {
        public int IdTipoClienteCuenta { get; set; }
        public int IdTipoCliente { get; set; }
        public int IdCuenta { get; set; }
        public bool? EsCargo { get; set; }
        public decimal Porcentaje { get; set; }
        public short SecuenciaCalculo { get; set; }
        public short BaseCalculo { get; set; }
        public string DescripcionFactura { get; set; }
        public int ParaAnticipo { get; set; }
        public bool FeDescuento { get; set; }
        public bool FeDeduccionLocal { get; set; }
        public bool FeTrasladoLocal { get; set; }
        public bool FeRetencionFisr { get; set; }
        public bool FeRetencionFiva { get; set; }
        public bool EsParaDetalle { get; set; }

        public virtual CtbCuenta IdCuentaNavigation { get; set; }
        public virtual AcCatTiposCliente IdTipoClienteNavigation { get; set; }
    }
}
