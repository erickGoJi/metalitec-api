using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvDisponibilidadCasaDeseadum
    {
        public CvDisponibilidadCasaDeseadum()
        {
            CvClientes = new HashSet<CvCliente>();
        }

        public int IdDisponibilidadCasaDeseada { get; set; }
        public string DisponibilidadCasaDeseada { get; set; }

        public virtual ICollection<CvCliente> CvClientes { get; set; }
    }
}
