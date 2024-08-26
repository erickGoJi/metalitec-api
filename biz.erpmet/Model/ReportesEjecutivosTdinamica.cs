using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class ReportesEjecutivosTdinamica
    {
        public int IdReporteTablaDinamica { get; set; }
        public int IdReporte { get; set; }
        public string Codigo { get; set; }

        public virtual ReportesEjecutivo IdReporteNavigation { get; set; }
    }
}
