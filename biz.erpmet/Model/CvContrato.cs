using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvContrato
    {
        public CvContrato()
        {
            CvAplicacionApartados = new HashSet<CvAplicacionApartado>();
            CvAplicacionDepositos = new HashSet<CvAplicacionDeposito>();
            CvCancelaciones = new HashSet<CvCancelacione>();
            CvContratosAccesorios = new HashSet<CvContratosAccesorio>();
            CvDepositosSofolDets = new HashSet<CvDepositosSofolDet>();
            CvPlanesPagos = new HashSet<CvPlanesPago>();
        }

        public int IdContrato { get; set; }
        public string Contrato { get; set; }
        public int IdCliente { get; set; }
        public int? IdVivienda { get; set; }
        public int IdProyecto { get; set; }
        public int IdCredito { get; set; }
        public DateTime Fecha { get; set; }
        public string Observaciones { get; set; }
        public bool Cancelado { get; set; }
        public decimal BaseCalculoComisiones { get; set; }
        public int? IdPlantillaContrato { get; set; }
        public decimal MontoAjuste { get; set; }
        public bool ContratoCerrado { get; set; }
        public byte PorCancelacion { get; set; }
        public int FolioContrato { get; set; }
        public bool Firmado { get; set; }
        public bool? EsViviendaTerreno { get; set; }
        public DateTime? FechaFirma { get; set; }

        public virtual CvCliente IdClienteNavigation { get; set; }
        public virtual CvPlantillasContrato IdPlantillaContratoNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual ICollection<CvAplicacionApartado> CvAplicacionApartados { get; set; }
        public virtual ICollection<CvAplicacionDeposito> CvAplicacionDepositos { get; set; }
        public virtual ICollection<CvCancelacione> CvCancelaciones { get; set; }
        public virtual ICollection<CvContratosAccesorio> CvContratosAccesorios { get; set; }
        public virtual ICollection<CvDepositosSofolDet> CvDepositosSofolDets { get; set; }
        public virtual ICollection<CvPlanesPago> CvPlanesPagos { get; set; }
    }
}
