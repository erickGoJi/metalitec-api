using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcModelosPolizaCuenta
    {
        public int IdModeloPolizaCuenta { get; set; }
        public int IdPolizaModelo { get; set; }
        public int IdCuenta { get; set; }

        public virtual CtbCuenta IdCuentaNavigation { get; set; }
    }
}
