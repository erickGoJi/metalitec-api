using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcComplementoPago
    {
        public AcComplementoPago()
        {
            AcComplementoPagoCfdrelacs = new HashSet<AcComplementoPagoCfdrelac>();
            AcComplementoPagoCfds = new HashSet<AcComplementoPagoCfd>();
            AcComplementoPagoDets = new HashSet<AcComplementoPagoDet>();
        }

        public int IdComplementoPago { get; set; }
        public int FolioComplementoPago { get; set; }
        public string SerieComplementoPago { get; set; }
        public int? IdBancoIngreso { get; set; }
        public int? IdProyecto { get; set; }
        public int IdUsuario { get; set; }
        public int IdFormaPagoSat { get; set; }
        public DateTime FechaHoraComplemento { get; set; }
        public string FolioFiscalCfdi { get; set; }
        public byte EstatusSat { get; set; }
        public string NumRegisIdentidadFis { get; set; }
        public string ResidenciaFiscal { get; set; }
        public string RfcbancoEmisor { get; set; }
        public string NumOperacion { get; set; }
        public string TipoCadPago { get; set; }
        public string CertificadoPago { get; set; }
        public string CadenaPago { get; set; }
        public string SelloPago { get; set; }
        public DateTime HoraDeposito { get; set; }
        public string Confirmacion { get; set; }
        public bool Cancelada { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public int? IdUsuarioCancelacion { get; set; }
        public string DescripcionCancelacion { get; set; }
        public string RfcbancoCliente { get; set; }
        public decimal? MontoPago { get; set; }
        public int? IdCliente { get; set; }
        public decimal? ParidadOficial { get; set; }
        public int? IdBancoSatEmisor { get; set; }
        public string CuentaBancariaEmisor { get; set; }
        public int? IdBancoSatCliente { get; set; }
        public byte? EstatusDeCancelacion { get; set; }
        public byte? EsCancelable { get; set; }
        public DateTime? FechaUltimaActualizacion { get; set; }
        public string CuentaBancariaCliente { get; set; }
        public DateTime? FechaSolicitudCancelacion { get; set; }
        public decimal? TipoCambio { get; set; }
        public int? IdCatMonedasSat { get; set; }
        public string NombreBancoExt { get; set; }
        public int? IdCodigoPostalSat { get; set; }
        public bool? EnProcesoCancelacion { get; set; }
        public string Observaciones { get; set; }

        public virtual AcBancosIngreso IdBancoIngresoNavigation { get; set; }
        public virtual CtbCatMonedasSat IdCatMonedasSatNavigation { get; set; }
        public virtual AcCliente IdClienteNavigation { get; set; }
        public virtual AcCatFormasPagoSat IdFormaPagoSatNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual SegUsuario IdUsuarioCancelacionNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<AcComplementoPagoCfdrelac> AcComplementoPagoCfdrelacs { get; set; }
        public virtual ICollection<AcComplementoPagoCfd> AcComplementoPagoCfds { get; set; }
        public virtual ICollection<AcComplementoPagoDet> AcComplementoPagoDets { get; set; }
    }
}
