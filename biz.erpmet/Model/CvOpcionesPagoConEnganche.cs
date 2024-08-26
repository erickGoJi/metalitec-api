using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvOpcionesPagoConEnganche
    {
        public int IdOpcionPagoConEnganche { get; set; }
        public string OpcionPagoConEnganche { get; set; }
        public decimal PorcentajeEnganche { get; set; }
        public int NoPagosEnganche { get; set; }
        public decimal TasaIntAnualEnganche { get; set; }
        public int NoPagosCredito { get; set; }
        public decimal TasaIntAnualCredito { get; set; }
    }
}
