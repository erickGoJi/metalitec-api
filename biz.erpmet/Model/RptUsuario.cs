using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class RptUsuario
    {
        public RptUsuario()
        {
            ReportesEjecutivosOpciones = new HashSet<ReportesEjecutivosOpcione>();
        }

        public int IdUsuario { get; set; }
        public byte IdSistema { get; set; }
        public string Usuario { get; set; }

        public virtual ICollection<ReportesEjecutivosOpcione> ReportesEjecutivosOpciones { get; set; }
    }
}
