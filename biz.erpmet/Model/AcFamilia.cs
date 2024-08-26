using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcFamilia
    {
        public AcFamilia()
        {
            AcCatInsumos = new HashSet<AcCatInsumo>();
        }

        public int IdFamilia { get; set; }
        public string Familia { get; set; }
        public string Descripcion { get; set; }
        public int IdCuenta { get; set; }

        public virtual CtbCuenta IdCuentaNavigation { get; set; }
        public virtual ICollection<AcCatInsumo> AcCatInsumos { get; set; }
    }
}
