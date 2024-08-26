using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class ReportesEjecutivos2004Proceso
    {
        public ReportesEjecutivos2004Proceso()
        {
            ReportesEjecutivos2004s = new HashSet<ReportesEjecutivos2004>();
        }

        public int IdProceso { get; set; }
        public int? IdProcesoAux { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<ReportesEjecutivos2004> ReportesEjecutivos2004s { get; set; }
    }
}
