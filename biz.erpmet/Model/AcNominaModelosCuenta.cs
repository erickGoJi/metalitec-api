using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcNominaModelosCuenta
    {
        public int IdNominaModeloCuenta { get; set; }
        public int IdNominaModelo { get; set; }
        public int IdCuenta { get; set; }
        public int IdNominaConcepto { get; set; }

        public virtual CtbCuenta IdCuentaNavigation { get; set; }
        public virtual AcNominaCatalogoConcepto IdNominaConceptoNavigation { get; set; }
        public virtual AcNominaModelo IdNominaModeloNavigation { get; set; }
    }
}
