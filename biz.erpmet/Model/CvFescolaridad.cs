using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvFescolaridad
    {
        public CvFescolaridad()
        {
            CvClientes = new HashSet<CvCliente>();
            CvConyuges = new HashSet<CvConyuge>();
        }

        public byte IdFescolaridad { get; set; }
        public string Fescolaridad { get; set; }

        public virtual ICollection<CvCliente> CvClientes { get; set; }
        public virtual ICollection<CvConyuge> CvConyuges { get; set; }
    }
}
