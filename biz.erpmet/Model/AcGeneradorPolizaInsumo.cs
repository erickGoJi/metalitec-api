using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcGeneradorPolizaInsumo
    {
        public int IdGeneradorPolizaInsumo { get; set; }
        public int IdGeneradorPoliza { get; set; }
        public bool EsCuenta { get; set; }
        public int? IdExplosionInsumos { get; set; }
        public int IdCuenta { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Costo { get; set; }
        public decimal Importe { get; set; }

        public virtual CtbCuenta IdCuentaNavigation { get; set; }
        public virtual AcExplosionInsumo IdExplosionInsumosNavigation { get; set; }
        public virtual AcGeneradorPoliza IdGeneradorPolizaNavigation { get; set; }
    }
}
