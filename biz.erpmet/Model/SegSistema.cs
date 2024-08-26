using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class SegSistema
    {
        public SegSistema()
        {
            Bitacoras = new HashSet<Bitacora>();
            ParametroUsuarios = new HashSet<ParametroUsuario>();
            SegGrupoPermisos = new HashSet<SegGrupoPermiso>();
            SegPerfils = new HashSet<SegPerfil>();
            SegPermisos = new HashSet<SegPermiso>();
            SegUsuariosSistemas = new HashSet<SegUsuariosSistema>();
            SegUsuariosXproyectos = new HashSet<SegUsuariosXproyecto>();
        }

        public int IdSistema { get; set; }
        public string Nombre { get; set; }
        public string Texto { get; set; }

        public virtual ICollection<Bitacora> Bitacoras { get; set; }
        public virtual ICollection<ParametroUsuario> ParametroUsuarios { get; set; }
        public virtual ICollection<SegGrupoPermiso> SegGrupoPermisos { get; set; }
        public virtual ICollection<SegPerfil> SegPerfils { get; set; }
        public virtual ICollection<SegPermiso> SegPermisos { get; set; }
        public virtual ICollection<SegUsuariosSistema> SegUsuariosSistemas { get; set; }
        public virtual ICollection<SegUsuariosXproyecto> SegUsuariosXproyectos { get; set; }
    }
}
