using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvContratosAccesorio
    {
        public int IdContratoAccesorio { get; set; }
        public int IdContrato { get; set; }
        public int IdProyectoAccesorio { get; set; }
        public int? IdSerie { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public int IdTipoMoneda { get; set; }
        public int IdPlanPago { get; set; }

        public virtual CvContrato IdContratoNavigation { get; set; }
        public virtual CvPlanesPago IdPlanPagoNavigation { get; set; }
        public virtual CvProyectosAccesorio IdProyectoAccesorioNavigation { get; set; }
        public virtual CvSeries IdSerieNavigation { get; set; }
        public virtual AcCatMoneda IdTipoMonedaNavigation { get; set; }
    }
}
