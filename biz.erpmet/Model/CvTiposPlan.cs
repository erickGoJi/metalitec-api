using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvTiposPlan
    {
        public CvTiposPlan()
        {
            CvPlanesPagos = new HashSet<CvPlanesPago>();
            CvProyectosCuentasXplans = new HashSet<CvProyectosCuentasXplan>();
        }

        public int IdTipoPlan { get; set; }
        public string TipoPlan { get; set; }
        public string Texto { get; set; }
        public int? IdFlujo { get; set; }

        public virtual AcCatFlujo IdFlujoNavigation { get; set; }
        public virtual ICollection<CvPlanesPago> CvPlanesPagos { get; set; }
        public virtual ICollection<CvProyectosCuentasXplan> CvProyectosCuentasXplans { get; set; }
    }
}
