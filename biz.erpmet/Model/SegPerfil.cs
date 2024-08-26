using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class SegPerfil
    {
        public SegPerfil()
        {
            SegUsuariosSistemas = new HashSet<SegUsuariosSistema>();
        }

        public int IdPerfil { get; set; }
        public string Descripcion { get; set; }
        public string MascPermisos { get; set; }
        public int IdSistema { get; set; }
        public string UMascPermisos { get; set; }

        public virtual SegSistema IdSistemaNavigation { get; set; }
        public virtual ICollection<SegUsuariosSistema> SegUsuariosSistemas { get; set; }
    }
}
