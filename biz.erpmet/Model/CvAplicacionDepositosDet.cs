using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvAplicacionDepositosDet
    {
        public int IdAplicacionDepositoDet { get; set; }
        public int IdAplicacionDeposito { get; set; }
        public int IdPlanPagoDet { get; set; }
        public decimal MontoBase { get; set; }
        public decimal MontoDocumento { get; set; }
        public decimal MontoAbonoCapitalBase { get; set; }
        public decimal MontoAbonoCapital { get; set; }
        public decimal MontoIvaDocumentoBase { get; set; }
        public decimal MontoIvadocumento { get; set; }
        public decimal MontoInteresBase { get; set; }
        public decimal MontoInteres { get; set; }
        public decimal MontoGastosAdicionalesBase { get; set; }
        public decimal MontoGastosAdicionales { get; set; }
        public decimal MontoMoratorio { get; set; }
        public decimal MontoIvamoratorio { get; set; }

        public virtual CvAplicacionDeposito IdAplicacionDepositoNavigation { get; set; }
        public virtual CvPlanesPagosDet IdPlanPagoDetNavigation { get; set; }
    }
}
