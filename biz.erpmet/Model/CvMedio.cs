using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvMedio
    {
        public CvMedio()
        {
            CvClientes = new HashSet<CvCliente>();
        }

        public int IdMedio { get; set; }
        public string Medio { get; set; }
        public string Texto { get; set; }

        public virtual ICollection<CvCliente> CvClientes { get; set; }
    }
}
