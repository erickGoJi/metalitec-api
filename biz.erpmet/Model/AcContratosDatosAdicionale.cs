using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcContratosDatosAdicionale
    {
        public int IdContratoAdicional { get; set; }
        public int IdContrato { get; set; }
        public int IdCatStatus { get; set; }
        public DateTime? FechaSolicitudCliente { get; set; }
        public DateTime? FechaDisponibilidadComprometida { get; set; }
        public DateTime? FechaDisponibilidadEstimada { get; set; }
        public DateTime? FechaDisponibilidadFinal { get; set; }
        public DateTime? FechaComprometidaFtech { get; set; }
        public DateTime? FechaProgramadaDeTerminacion { get; set; }
        public string DiasStandar { get; set; }
        public DateTime? FechaRealizada { get; set; }
        public DateTime? FechaDocumentacionCompleta { get; set; }
        public DateTime? FechaCierreContable { get; set; }
        public string ComentariosCompras { get; set; }
        public string ComentariosServicios { get; set; }
        public string ComentariosPlaneacion { get; set; }
        public string Vendedor { get; set; }
        public string Calidad { get; set; }
        public string ComentarioAdicional1 { get; set; }
        public string ComentarioAdicional2 { get; set; }
        public string ComentarioAdicional3 { get; set; }
        public DateTime? FechaRecepcionPedido { get; set; }
        public string ClienteSitio { get; set; }
        public decimal? PorcenRendimiento { get; set; }
        public string PeriodoTecnico { get; set; }
        public string AdmCuenta { get; set; }
        public decimal? PorcenMargen { get; set; }
        public decimal? PorcenTasa { get; set; }
        public string PeriodoAdmon { get; set; }
        public decimal? GasolinaPpto { get; set; }
        public decimal? ComidaAppto { get; set; }
        public decimal? CasetasEfectivoPpto { get; set; }
        public decimal? HospedajePpto { get; set; }
        public decimal? ConsumiblesPpto { get; set; }
        public decimal? TransporteTerrestrePpto { get; set; }
        public decimal? TransporteAereoPpto { get; set; }
        public decimal? ComidaBppto { get; set; }
        public decimal? GasolinaLiberado { get; set; }
        public decimal? ComidaAliberado { get; set; }
        public decimal? CasetasEfectivoLiberado { get; set; }
        public decimal? HospedajeLiberado { get; set; }
        public decimal? ConsumiblesLiberado { get; set; }
        public decimal? TransporteTerrestreLiberado { get; set; }
        public decimal? TransporteAereoLiberado { get; set; }
        public decimal? ComidaBliberado { get; set; }
        public string PorcenPresupuestado { get; set; }
        public string Libre1 { get; set; }
        public string Libre2 { get; set; }
        public string Libre3 { get; set; }
        public string Libre4 { get; set; }
        public string Libre5 { get; set; }
        public DateTime? FechaProgramadaIniciar { get; set; }

        public virtual AcCatContratosStatus IdCatStatusNavigation { get; set; }
        public virtual AcContrato IdContratoNavigation { get; set; }
    }
}
