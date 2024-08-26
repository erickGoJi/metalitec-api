using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvFopcCreditoVsm
    {
        public CvFopcCreditoVsm()
        {
            CvClientes = new HashSet<CvCliente>();
        }

        public byte IdFopcCreditoVsm { get; set; }
        public string FopcCreditoVsm { get; set; }

        public virtual ICollection<CvCliente> CvClientes { get; set; }
    }
}
