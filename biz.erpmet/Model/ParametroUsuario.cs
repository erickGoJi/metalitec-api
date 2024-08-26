using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class ParametroUsuario
    {
        public int IdParametroUsuario { get; set; }
        public int IdUsuario { get; set; }
        public int MesContable { get; set; }
        public int IdSistema { get; set; }

        public virtual SegSistema IdSistemaNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
    }
}
