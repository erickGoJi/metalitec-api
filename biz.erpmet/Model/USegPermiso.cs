using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class USegPermiso
    {
        public int Permiso { get; set; }
        public string GrupoDescripcion { get; set; }
        public string SubGrupoDescripcion { get; set; }
        public string Descripcion { get; set; }
        public string NombrePermiso { get; set; }
        public int IdGrupoPermiso { get; set; }
        public int IdSistema { get; set; }
        public bool PermisoDinamico { get; set; }
    }
}
