using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvViviendasAccesorio
    {
        public int IdViviendaAccesorio { get; set; }
        public int IdVivienda { get; set; }
        public int IdProyectoAccesorio { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public int? IdSerie { get; set; }
        public int IdTipoMoneda { get; set; }

        public virtual CvProyectosAccesorio IdProyectoAccesorioNavigation { get; set; }
        public virtual CvSeries IdSerieNavigation { get; set; }
        public virtual AcCatMoneda IdTipoMonedaNavigation { get; set; }
    }
}
