using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class ReportesEjecutivosOpcione
    {
        public int IdRepEjOpcion { get; set; }
        public int IdReporteAux { get; set; }
        public int IdUsuario { get; set; }
        public string Parametro { get; set; }
        public string Valor { get; set; }

        public virtual ReportesEjecutivos2004 IdReporteAuxNavigation { get; set; }
        public virtual RptUsuario IdUsuarioNavigation { get; set; }
    }
}
