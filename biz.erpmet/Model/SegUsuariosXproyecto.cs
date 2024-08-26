using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class SegUsuariosXproyecto
    {
        public int IdUsuario { get; set; }
        public int IdProyecto { get; set; }
        public int IdSistema { get; set; }

        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual SegSistema IdSistemaNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
    }
}
