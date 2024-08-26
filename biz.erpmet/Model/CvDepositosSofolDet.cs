using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvDepositosSofolDet
    {
        public CvDepositosSofolDet()
        {
            CvComplementoPagos = new HashSet<CvComplementoPago>();
        }

        public int IdDepositoSofolDet { get; set; }
        public int IdDepositosofol { get; set; }
        public int IdCliente { get; set; }
        public int IdContrato { get; set; }
        public int IdPlanPagoDet { get; set; }
        public decimal MontoBase { get; set; }
        public decimal MontoDocumento { get; set; }
        public decimal MontoExcedente { get; set; }
        public int? IdAjusteCliente { get; set; }
        public decimal MontoComisionPuente { get; set; }
        public decimal MontoAmortizacionPuente { get; set; }
        public int? IdClienteFactura { get; set; }
        public string CuentaBancariaDepositante { get; set; }
        public string Rfcdepositante { get; set; }
        public string BancoExtDepositante { get; set; }
        public string BancoSatdepositante { get; set; }
        public string NumCheque { get; set; }
        public string ClaveMetodoPago { get; set; }
        public string ClaveMonedaSat { get; set; }
        public int? IdComplementoPago { get; set; }

        public virtual CvAjusteCliente IdAjusteClienteNavigation { get; set; }
        public virtual CvCliente IdClienteNavigation { get; set; }
        public virtual CvContrato IdContratoNavigation { get; set; }
        public virtual CvDepositosSofol IdDepositosofolNavigation { get; set; }
        public virtual CvPlanesPagosDet IdPlanPagoDetNavigation { get; set; }
        public virtual ICollection<CvComplementoPago> CvComplementoPagos { get; set; }
    }
}
