using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class GruposReportesEjecutivos2004
    {
        public GruposReportesEjecutivos2004()
        {
            ReportesEjecutivos2004s = new HashSet<ReportesEjecutivos2004>();
        }

        public int IdGrupo { get; set; }
        public int IdGrupoAux { get; set; }
        public string Codigo { get; set; }
        public bool Neodata { get; set; }

        public virtual ICollection<ReportesEjecutivos2004> ReportesEjecutivos2004s { get; set; }
    }
}
