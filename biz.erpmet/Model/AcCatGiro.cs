using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatGiro
    {
        public AcCatGiro()
        {
            AcProveedores = new HashSet<AcProveedore>();
        }

        public int IdGiro { get; set; }
        public string Giro { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<AcProveedore> AcProveedores { get; set; }
    }
}
