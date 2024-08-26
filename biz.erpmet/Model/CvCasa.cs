using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvCasa
    {
        public CvCasa()
        {
            CvClientes = new HashSet<CvCliente>();
        }

        public byte IdCasa { get; set; }
        public string Casa { get; set; }

        public virtual ICollection<CvCliente> CvClientes { get; set; }
    }
}
