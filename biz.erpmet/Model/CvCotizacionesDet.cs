using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvCotizacionesDet
    {
        public int IdCotizacionDet { get; set; }
        public int IdCotizacion { get; set; }
        public int IdCredito { get; set; }
        public int NoPresupuesto { get; set; }
        public decimal InversionInicial { get; set; }
        public decimal MontoCredito { get; set; }
        public decimal AniosCredito { get; set; }
        public decimal PagoMensual { get; set; }
        public decimal AportacionPatronal { get; set; }
        public decimal PagoMensualNeto { get; set; }
        public decimal IngresoMinimo { get; set; }

        public virtual CvCotizacione IdCotizacionNavigation { get; set; }
        public virtual CvCredito IdCreditoNavigation { get; set; }
    }
}
