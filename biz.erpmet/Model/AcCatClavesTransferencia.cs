using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatClavesTransferencia
    {
        public AcCatClavesTransferencia()
        {
            AcProveedores = new HashSet<AcProveedore>();
        }

        public int IdClaveTransferencia { get; set; }
        public string ClaveTransferencia { get; set; }
        public string Nombre { get; set; }
        public string NumInstitucion { get; set; }

        public virtual ICollection<AcProveedore> AcProveedores { get; set; }
    }
}
