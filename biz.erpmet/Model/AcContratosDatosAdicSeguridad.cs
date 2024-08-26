using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcContratosDatosAdicSeguridad
    {
        public int IdContratoSeguridad { get; set; }
        public int IdUsuario { get; set; }
        public string NumeroContrato { get; set; }
        public string ClienteFiscal { get; set; }
        public string ClienteSitio { get; set; }
        public string Descripcion { get; set; }
        public string Asignado { get; set; }
        public string Status { get; set; }
        public string Proyecto { get; set; }
        public string FechaRecepcionPedido { get; set; }
        public string FechaSolicitadaCliente { get; set; }
        public string FechaDisponibilidadComprometida { get; set; }
        public string FechaDisponibilidadEstimada { get; set; }
        public string FechaDisponibilidadFinal { get; set; }
        public string FechaComprometida { get; set; }
        public string FechaProgramadaTerminar { get; set; }
        public string DiasEstandar { get; set; }
        public string FechaRealizada { get; set; }
        public string FechaDocumentacionCompleta { get; set; }
        public string FechaFactura { get; set; }
        public string TipoDeMoneda { get; set; }
        public string ValorContrato { get; set; }
        public string ValorFacturado { get; set; }
        public string PendientePorFacturar { get; set; }
        public string ValorCobrado { get; set; }
        public string FechaCierreContable { get; set; }
        public string ComentariosCompras { get; set; }
        public string ComentariosServicios { get; set; }
        public string ComentariosPlaneacion { get; set; }
        public string Vendedor { get; set; }
        public string Calidad { get; set; }
        public string ComentarioAdicional1 { get; set; }
        public string ComentarioAdicional2 { get; set; }
        public string ComentarioAdicional3 { get; set; }
        public string FechaContrato { get; set; }
        public string Autorizado { get; set; }
        public string Cancelado { get; set; }
        public string PorcenPresupuestado { get; set; }
        public string PorcenRendimiento { get; set; }
        public string PeriodoTecnico { get; set; }
        public string AdmCuenta { get; set; }
        public string PorcenMargen { get; set; }
        public string PorcenTasa { get; set; }
        public string PeriodoAdmon { get; set; }
        public string GasolinaPpto { get; set; }
        public string ComidaAppto { get; set; }
        public string CasetasEfectivoPpto { get; set; }
        public string HospedajePpto { get; set; }
        public string ConsumiblesPpto { get; set; }
        public string TransporteTerrestrePpto { get; set; }
        public string TransporteAereoPpto { get; set; }
        public string ComidaBppto { get; set; }
        public string GasolinaLiberado { get; set; }
        public string ComidaAliberado { get; set; }
        public string CasetasEfectivoLiberado { get; set; }
        public string HospedajeLiberado { get; set; }
        public string ConsumiblesLiberado { get; set; }
        public string TransporteTerrestreLiberado { get; set; }
        public string TransporteAereoLiberado { get; set; }
        public string ComidaBliberado { get; set; }
        public string FolioFactura { get; set; }
        public string SaldoPesosFactura { get; set; }
        public string Libre1 { get; set; }
        public string Libre2 { get; set; }
        public string Libre3 { get; set; }
        public string Libre4 { get; set; }
        public string Libre5 { get; set; }
        public string FechaProgramadaIniciar { get; set; }

        public virtual SegUsuario IdUsuarioNavigation { get; set; }
    }
}
