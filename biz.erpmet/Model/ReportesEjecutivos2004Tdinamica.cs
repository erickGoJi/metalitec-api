using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class ReportesEjecutivos2004Tdinamica
    {
        public int IdReporteTablaDinamica { get; set; }
        public int IdReporteAux { get; set; }
        public string Codigo { get; set; }

        public virtual ReportesEjecutivos2004 IdReporteAuxNavigation { get; set; }
    }
}
