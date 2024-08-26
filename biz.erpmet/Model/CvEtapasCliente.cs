using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvEtapasCliente
    {
        public CvEtapasCliente()
        {
            CvCetapas = new HashSet<CvCetapa>();
            CvClientes = new HashSet<CvCliente>();
        }

        public int IdEtapaCliente { get; set; }
        public string EtapaCliente { get; set; }
        public string Texto { get; set; }
        public int ColorRelleno { get; set; }

        public virtual ICollection<CvCetapa> CvCetapas { get; set; }
        public virtual ICollection<CvCliente> CvClientes { get; set; }
    }
}
