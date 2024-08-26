using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvRangoIngresoMnc
    {
        public CvRangoIngresoMnc()
        {
            CvClientes = new HashSet<CvCliente>();
        }

        public int IdRangoIngresoMnc { get; set; }
        public string RangoIngresoMnc { get; set; }
        public int Orden { get; set; }

        public virtual ICollection<CvCliente> CvClientes { get; set; }
    }
}
