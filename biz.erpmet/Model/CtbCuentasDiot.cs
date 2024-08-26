using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CtbCuentasDiot
    {
        public int IdCuentaDiot { get; set; }
        public int IdCuenta { get; set; }
        public bool? EsIvaAcreditable { get; set; }
        public bool EsIvaRetenido { get; set; }
        public bool EsIsrRetenido { get; set; }
        public short ColumnaDiot { get; set; }

        public virtual CtbCuenta IdCuentaNavigation { get; set; }
    }
}
