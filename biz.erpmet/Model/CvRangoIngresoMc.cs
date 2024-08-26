using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvRangoIngresoMc
    {
        public CvRangoIngresoMc()
        {
            CvClientes = new HashSet<CvCliente>();
        }

        public int IdRangoIngresoMc { get; set; }
        public string RangoIngresoMc { get; set; }
        public int Orden { get; set; }

        public virtual ICollection<CvCliente> CvClientes { get; set; }
    }
}
