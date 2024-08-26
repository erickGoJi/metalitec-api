using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcTipoMovBanco
    {
        public AcTipoMovBanco()
        {
            AcBancosEgresos = new HashSet<AcBancosEgreso>();
        }

        public int IdTipoMovBanco { get; set; }
        public string TipoMovBanco { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<AcBancosEgreso> AcBancosEgresos { get; set; }
    }
}
