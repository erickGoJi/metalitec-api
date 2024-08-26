using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class ReportesEjecutivos2004
    {
        public ReportesEjecutivos2004()
        {
            ReportesEjecutivos2004Tdinamicas = new HashSet<ReportesEjecutivos2004Tdinamica>();
            ReportesEjecutivosOpciones = new HashSet<ReportesEjecutivosOpcione>();
        }

        public int IdReporte { get; set; }
        public int IdReporteAux { get; set; }
        public string Descripcion { get; set; }
        public int IdGrupoAux { get; set; }
        public int? IdProcesoAux { get; set; }
        public string NombreVista { get; set; }
        public string DocumentoExcel { get; set; }
        public string HojaDatos { get; set; }
        public bool Proceso { get; set; }
        public bool Neodata { get; set; }

        public virtual GruposReportesEjecutivos2004 IdGrupoAuxNavigation { get; set; }
        public virtual ReportesEjecutivos2004Proceso IdProcesoAuxNavigation { get; set; }
        public virtual ICollection<ReportesEjecutivos2004Tdinamica> ReportesEjecutivos2004Tdinamicas { get; set; }
        public virtual ICollection<ReportesEjecutivosOpcione> ReportesEjecutivosOpciones { get; set; }
    }
}
