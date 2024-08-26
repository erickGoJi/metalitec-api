using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvProyectosAccesorio
    {
        public CvProyectosAccesorio()
        {
            CvContratosAccesorios = new HashSet<CvContratosAccesorio>();
            CvSeries = new HashSet<CvSeries>();
            CvViviendasAccesorios = new HashSet<CvViviendasAccesorio>();
        }

        public int IdProyectoAccesorio { get; set; }
        public int IdProyecto { get; set; }
        public int IdAccesorio { get; set; }
        public bool? EsSerie { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? Precio { get; set; }
        public int? IdTipoMoneda { get; set; }
        public string Partida { get; set; }

        public virtual CvAccesorio IdAccesorioNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual AcCatMoneda IdTipoMonedaNavigation { get; set; }
        public virtual ICollection<CvContratosAccesorio> CvContratosAccesorios { get; set; }
        public virtual ICollection<CvSeries> CvSeries { get; set; }
        public virtual ICollection<CvViviendasAccesorio> CvViviendasAccesorios { get; set; }
    }
}
