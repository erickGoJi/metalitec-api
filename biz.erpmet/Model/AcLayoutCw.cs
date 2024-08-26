using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcLayoutCw
    {
        public AcLayoutCw()
        {
            AcLayoutCwdets = new HashSet<AcLayoutCwdet>();
        }

        public int IdLayoutCw { get; set; }
        public string LayoutCw { get; set; }
        public string Descripcion { get; set; }
        public string Separador { get; set; }

        public virtual ICollection<AcLayoutCwdet> AcLayoutCwdets { get; set; }
    }
}
