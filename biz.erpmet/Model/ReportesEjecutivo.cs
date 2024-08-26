using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class ReportesEjecutivo
    {
        public ReportesEjecutivo()
        {
            ReportesEjecutivosTdinamicas = new HashSet<ReportesEjecutivosTdinamica>();
        }

        public int IdReporte { get; set; }
        public int IdGrupo { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string NombreVista { get; set; }
        public string SentenciaConsulta { get; set; }
        public string DocumentoExcel { get; set; }
        public string HojaDatos { get; set; }

        public virtual GruposReportesEjecutivo IdGrupoNavigation { get; set; }
        public virtual ICollection<ReportesEjecutivosTdinamica> ReportesEjecutivosTdinamicas { get; set; }
    }
}
