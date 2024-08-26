using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcClientesRemisione
    {
        public AcClientesRemisione()
        {
            AcClientesRemisionesDets = new HashSet<AcClientesRemisionesDet>();
        }

        public int IdClienteRemision { get; set; }
        public int IdClientePlanta { get; set; }
        public int FolioRemision { get; set; }
        public int IdContrato { get; set; }
        public int? IdClienteTransporte { get; set; }
        public int? IdClienteOperador { get; set; }
        public int? IdClienteResponsableRemision { get; set; }
        public int? IdClienteFactura { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime HoraSalida { get; set; }
        public DateTime? Horaentrada { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaUltimoCambio { get; set; }
        public int IdUsuarioUltimoCambio { get; set; }

        public virtual AcClientesFactura IdClienteFacturaNavigation { get; set; }
        public virtual AcClientesOperadore IdClienteOperadorNavigation { get; set; }
        public virtual AcClientesPlanta IdClientePlantaNavigation { get; set; }
        public virtual AcClientesResponsablesRemisione IdClienteResponsableRemisionNavigation { get; set; }
        public virtual AcClientesTransporte IdClienteTransporteNavigation { get; set; }
        public virtual AcContrato IdContratoNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
        public virtual SegUsuario IdUsuarioUltimoCambioNavigation { get; set; }
        public virtual ICollection<AcClientesRemisionesDet> AcClientesRemisionesDets { get; set; }
    }
}
