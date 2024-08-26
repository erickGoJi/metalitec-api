using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class GruposReportesEjecutivo
    {
        public GruposReportesEjecutivo()
        {
            ReportesEjecutivos = new HashSet<ReportesEjecutivo>();
        }

        public int IdGrupo { get; set; }
        public string Codigo { get; set; }

        public virtual ICollection<ReportesEjecutivo> ReportesEjecutivos { get; set; }
    }
}
