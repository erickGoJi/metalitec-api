using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CtbDiottipoTercero
    {
        public CtbDiottipoTercero()
        {
            AcProveedores = new HashSet<AcProveedore>();
        }

        public int IdTipoTerceros { get; set; }
        public string TipoTerceros { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<AcProveedore> AcProveedores { get; set; }
    }
}
