using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvCetapa
    {
        public CvCetapa()
        {
            CvCetapasDets = new HashSet<CvCetapasDet>();
            CvClientes = new HashSet<CvCliente>();
            CvComisionesDets = new HashSet<CvComisionesDet>();
            CvFlujoClientes = new HashSet<CvFlujoCliente>();
            CvPcecomisiones = new HashSet<CvPcecomisione>();
        }

        public int IdCetapa { get; set; }
        public int IdCredito { get; set; }
        public int IdEtapaCliente { get; set; }
        public short Renglon { get; set; }
        public short Duracion { get; set; }
        public short DiasParaTerminar { get; set; }

        public virtual CvCredito IdCreditoNavigation { get; set; }
        public virtual CvEtapasCliente IdEtapaClienteNavigation { get; set; }
        public virtual ICollection<CvCetapasDet> CvCetapasDets { get; set; }
        public virtual ICollection<CvCliente> CvClientes { get; set; }
        public virtual ICollection<CvComisionesDet> CvComisionesDets { get; set; }
        public virtual ICollection<CvFlujoCliente> CvFlujoClientes { get; set; }
        public virtual ICollection<CvPcecomisione> CvPcecomisiones { get; set; }
    }
}
