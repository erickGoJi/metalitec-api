using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvAplicacionDepositosCfdi
    {
        public int IdAplicacionDepositosCfdi { get; set; }
        public int? IdAplicacionDeposito { get; set; }
        public int? IdConceptoCfdi { get; set; }
        public int? IdClienteFactura { get; set; }
        public decimal? Monto { get; set; }
        public bool Cancelado { get; set; }

        public virtual CvAplicacionDeposito IdAplicacionDepositoNavigation { get; set; }
    }
}
