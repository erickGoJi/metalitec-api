using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvFcreditoConyugal
    {
        public CvFcreditoConyugal()
        {
            CvClientes = new HashSet<CvCliente>();
        }

        public byte IdFcreditoConyugal { get; set; }
        public string FcreditoConyugal { get; set; }

        public virtual ICollection<CvCliente> CvClientes { get; set; }
    }
}
