using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvSeries
    {
        public CvSeries()
        {
            CvContratosAccesorios = new HashSet<CvContratosAccesorio>();
            CvViviendasAccesorios = new HashSet<CvViviendasAccesorio>();
        }

        public int IdSerie { get; set; }
        public string Serie { get; set; }
        public int IdProyectoAccesorio { get; set; }
        public int? IdContratoAccesorio { get; set; }
        public int? IdViviendaAccesorio { get; set; }

        public virtual CvProyectosAccesorio IdProyectoAccesorioNavigation { get; set; }
        public virtual ICollection<CvContratosAccesorio> CvContratosAccesorios { get; set; }
        public virtual ICollection<CvViviendasAccesorio> CvViviendasAccesorios { get; set; }
    }
}
