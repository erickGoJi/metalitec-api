using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvFplazosCredito
    {
        public CvFplazosCredito()
        {
            CvClientes = new HashSet<CvCliente>();
        }

        public byte IdFplazoCredito { get; set; }
        public string FplazoCredito { get; set; }

        public virtual ICollection<CvCliente> CvClientes { get; set; }
    }
}
