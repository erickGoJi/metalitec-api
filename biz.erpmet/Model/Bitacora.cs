using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class Bitacora
    {
        public int IdBitacora { get; set; }
        public int IdSistema { get; set; }
        public int IdModulo { get; set; }
        public int IdProceso { get; set; }
        public int? IdOperacion { get; set; }
        public int IdUsuario { get; set; }
        public int? IdTabla { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }

        public virtual BiCatModulo IdModuloNavigation { get; set; }
        public virtual BiCatProceso IdProcesoNavigation { get; set; }
        public virtual SegSistema IdSistemaNavigation { get; set; }
        public virtual BiTabla IdTablaNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
    }
}
