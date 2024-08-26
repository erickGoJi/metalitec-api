using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class SegUsuariosSistema
    {
        public int IdSistema { get; set; }
        public int IdUsuario { get; set; }
        public int? IdPerfil { get; set; }
        public string MascPermisos { get; set; }
        public string UMascPermisos { get; set; }

        public virtual SegPerfil IdPerfilNavigation { get; set; }
        public virtual SegSistema IdSistemaNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
    }
}
