using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvFformaCredito
    {
        public CvFformaCredito()
        {
            CvClientes = new HashSet<CvCliente>();
        }

        public byte IdFformaCredito { get; set; }
        public string FformaCredito { get; set; }

        public virtual ICollection<CvCliente> CvClientes { get; set; }
    }
}
