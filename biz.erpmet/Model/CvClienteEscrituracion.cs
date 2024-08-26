using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvClienteEscrituracion
    {
        public CvClienteEscrituracion()
        {
            CvAjusteClientes = new HashSet<CvAjusteCliente>();
            CvNotasEscrituras = new HashSet<CvNotasEscritura>();
        }

        public int IdClienteEscrituracion { get; set; }
        public int IdCliente { get; set; }
        public int Folio { get; set; }
        public string FolioEscritura { get; set; }
        public DateTime FechaAplicacion { get; set; }
        public decimal MontoEscritura { get; set; }
        public decimal MontoIvaescritura { get; set; }
        public decimal MontoAnticipos { get; set; }
        public decimal MontoIvaanticipos { get; set; }
        public decimal MontoCostoVivienda { get; set; }
        public decimal MontoCostoTerreno { get; set; }
        public bool Cancelado { get; set; }
        public int? IdNotaria { get; set; }
        public int IdPoliza { get; set; }
        public int? IdPolizaInversa { get; set; }
        public int MontoTerreno { get; set; }
        public int MontoConstruccion { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public string DescripcionCancelacion { get; set; }
        public bool EscrituraReal { get; set; }
        public DateTime? FechaEscrituraReal { get; set; }
        public decimal Paridad { get; set; }
        public int? IdClienteFactura { get; set; }

        public virtual CvCliente IdClienteNavigation { get; set; }
        public virtual CtbPoliza IdPolizaInversaNavigation { get; set; }
        public virtual CtbPoliza IdPolizaNavigation { get; set; }
        public virtual ICollection<CvAjusteCliente> CvAjusteClientes { get; set; }
        public virtual ICollection<CvNotasEscritura> CvNotasEscrituras { get; set; }
    }
}
