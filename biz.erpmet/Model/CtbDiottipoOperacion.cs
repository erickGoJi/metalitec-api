using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CtbDiottipoOperacion
    {
        public CtbDiottipoOperacion()
        {
            AcProveedores = new HashSet<AcProveedore>();
        }

        public int IdTipoOperacion { get; set; }
        public string TipoOperacion { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<AcProveedore> AcProveedores { get; set; }
    }
}
