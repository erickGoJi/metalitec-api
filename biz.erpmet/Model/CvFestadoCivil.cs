using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvFestadoCivil
    {
        public CvFestadoCivil()
        {
            CvClientes = new HashSet<CvCliente>();
        }

        public byte IdFestadoCivil { get; set; }
        public string FestadoCivil { get; set; }

        public virtual ICollection<CvCliente> CvClientes { get; set; }
    }
}
