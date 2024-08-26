using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvPlanesPagosDet
    {
        public CvPlanesPagosDet()
        {
            CvAplicacionApartadosDets = new HashSet<CvAplicacionApartadosDet>();
            CvAplicacionDepositosDets = new HashSet<CvAplicacionDepositosDet>();
            CvDepositosSofolDets = new HashSet<CvDepositosSofolDet>();
        }

        public int IdPlanPagoDet { get; set; }
        public short PlanPagoDet { get; set; }
        public string Concepto { get; set; }
        public int IdPlanPago { get; set; }
        public DateTime FechaPlan { get; set; }
        public decimal MontoBase { get; set; }
        public decimal SaldoPendienteBase { get; set; }
        public decimal MontoInteres { get; set; }
        public decimal SaldoPendienteInteres { get; set; }
        public decimal MontoGastosAdicionales { get; set; }
        public decimal SaldoPendienteGastosAdicionales { get; set; }
        public decimal MontoIvaDocumento { get; set; }
        public decimal SaldoPendienteIvaDocumento { get; set; }
        public decimal SaldoPendiente { get; set; }
        public decimal MontoCapitalPactado { get; set; }
        public decimal MontoCapitalAmortizado { get; set; }

        public virtual CvPlanesPago IdPlanPagoNavigation { get; set; }
        public virtual ICollection<CvAplicacionApartadosDet> CvAplicacionApartadosDets { get; set; }
        public virtual ICollection<CvAplicacionDepositosDet> CvAplicacionDepositosDets { get; set; }
        public virtual ICollection<CvDepositosSofolDet> CvDepositosSofolDets { get; set; }
    }
}
