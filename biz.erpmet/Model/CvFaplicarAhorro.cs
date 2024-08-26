using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvFaplicarAhorro
    {
        public CvFaplicarAhorro()
        {
            CvClientes = new HashSet<CvCliente>();
        }

        public byte IdFaplicarAhorro { get; set; }
        public string FaplicarAhorro { get; set; }

        public virtual ICollection<CvCliente> CvClientes { get; set; }
    }
}
