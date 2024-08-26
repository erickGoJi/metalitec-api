using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvSindicato
    {
        public CvSindicato()
        {
            CvEmpresas = new HashSet<CvEmpresa>();
        }

        public int IdSindicato { get; set; }
        public string Sindicato { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<CvEmpresa> CvEmpresas { get; set; }
    }
}
