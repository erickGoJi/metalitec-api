using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcNominaPolizaCuenta
    {
        public int IdNominaPolizaCuenta { get; set; }
        public int IdCuenta { get; set; }
        public int IdNominaPoliza { get; set; }
        public decimal Cantidad { get; set; }

        public virtual CtbCuenta IdCuentaNavigation { get; set; }
        public virtual AcNominaPoliza IdNominaPolizaNavigation { get; set; }
    }
}
