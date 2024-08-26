using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvIdentificacionesOficiale
    {
        public CvIdentificacionesOficiale()
        {
            CvClientes = new HashSet<CvCliente>();
        }

        public int IdIdentificacionOficial { get; set; }
        public string IdentificacionOficial { get; set; }
        public string Texto { get; set; }

        public virtual ICollection<CvCliente> CvClientes { get; set; }
    }
}
