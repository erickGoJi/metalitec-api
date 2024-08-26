using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcGeneradorPolizaCuenta
    {
        public int IdGeneradorPolizaCuenta { get; set; }
        public int IdGeneradorPoliza { get; set; }
        public int IdCuenta { get; set; }
        public decimal Importe { get; set; }

        public virtual CtbCuenta IdCuentaNavigation { get; set; }
        public virtual AcGeneradorPoliza IdGeneradorPolizaNavigation { get; set; }
    }
}
