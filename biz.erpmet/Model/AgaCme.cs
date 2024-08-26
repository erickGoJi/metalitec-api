using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AgaCme
    {
        public int IdAgaCme { get; set; }
        public string Cme { get; set; }
        public string Descripcion { get; set; }
        public int IdCuenta { get; set; }

        public virtual CtbCuenta IdCuentaNavigation { get; set; }
    }
}
