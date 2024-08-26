using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AoCatDescuento
    {
        public AoCatDescuento()
        {
            AoSubContratosEstDescuentos = new HashSet<AoSubContratosEstDescuento>();
        }

        public int IdDescuento { get; set; }
        public string Descuento { get; set; }
        public string Descripcion { get; set; }
        public int? IdCuenta { get; set; }

        public virtual CtbCuenta IdCuentaNavigation { get; set; }
        public virtual ICollection<AoSubContratosEstDescuento> AoSubContratosEstDescuentos { get; set; }
    }
}
