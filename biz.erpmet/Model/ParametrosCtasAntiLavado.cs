using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class ParametrosCtasAntiLavado
    {
        public int IdParametroCtaAl { get; set; }
        public int IdCtaAntilavado { get; set; }

        public virtual CtbCuenta IdCtaAntilavadoNavigation { get; set; }
    }
}
