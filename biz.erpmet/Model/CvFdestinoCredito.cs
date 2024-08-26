using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvFdestinoCredito
    {
        public CvFdestinoCredito()
        {
            CvClientes = new HashSet<CvCliente>();
        }

        public int IdFdestinoCredito { get; set; }
        public string FdestinoCredito { get; set; }

        public virtual ICollection<CvCliente> CvClientes { get; set; }
    }
}
