using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvAccesorio
    {
        public CvAccesorio()
        {
            CvPrototiposAccesorios = new HashSet<CvPrototiposAccesorio>();
            CvProyectosAccesorios = new HashSet<CvProyectosAccesorio>();
        }

        public int IdAccesorio { get; set; }
        public string Accesorio { get; set; }
        public string Texto { get; set; }
        public string Descri { get; set; }
        public string Unidad { get; set; }
        public string Partida { get; set; }

        public virtual ICollection<CvPrototiposAccesorio> CvPrototiposAccesorios { get; set; }
        public virtual ICollection<CvProyectosAccesorio> CvProyectosAccesorios { get; set; }
    }
}
