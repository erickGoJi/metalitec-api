using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class SegGrupoPermiso
    {
        public SegGrupoPermiso()
        {
            SegPermisos = new HashSet<SegPermiso>();
        }

        public int IdGrupoPermiso { get; set; }
        public string GrupoPermiso { get; set; }
        public int IdSistema { get; set; }

        public virtual SegSistema IdSistemaNavigation { get; set; }
        public virtual ICollection<SegPermiso> SegPermisos { get; set; }
    }
}
