using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvRegimenMatrimonial
    {
        public CvRegimenMatrimonial()
        {
            CvClientes = new HashSet<CvCliente>();
        }

        public byte IdRegimenMatrimonial { get; set; }
        public string RegimenMatrimonial { get; set; }

        public virtual ICollection<CvCliente> CvClientes { get; set; }
    }
}
