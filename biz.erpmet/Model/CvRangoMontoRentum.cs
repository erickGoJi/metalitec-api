using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvRangoMontoRentum
    {
        public CvRangoMontoRentum()
        {
            CvClientes = new HashSet<CvCliente>();
        }

        public int IdRangoMontoRenta { get; set; }
        public string RangoMontoRenta { get; set; }
        public int Orden { get; set; }

        public virtual ICollection<CvCliente> CvClientes { get; set; }
    }
}
