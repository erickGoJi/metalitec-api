using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CtbConsecutivosPolizasXme
    {
        public int IdConsecutivoPoliza { get; set; }
        public int? IdProyecto { get; set; }
        public int IdTipoPoliza { get; set; }
        public int MesPoliza { get; set; }
        public int Consecutivo { get; set; }

        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual CtbTiposPoliza IdTipoPolizaNavigation { get; set; }
    }
}
