using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvEconomium
    {
        public CvEconomium()
        {
            CvClientes = new HashSet<CvCliente>();
        }

        public byte IdEconomia { get; set; }
        public string Economia { get; set; }

        public virtual ICollection<CvCliente> CvClientes { get; set; }
    }
}
