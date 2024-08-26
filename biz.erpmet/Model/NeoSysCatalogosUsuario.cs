using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class NeoSysCatalogosUsuario
    {
        public NeoSysCatalogosUsuario()
        {
            NeoSysCatalogosUsuarioCs = new HashSet<NeoSysCatalogosUsuarioC>();
        }

        public int IdCatalogoUsuario { get; set; }
        public int IdCatalogo { get; set; }
        public string Alias { get; set; }
        public bool SoloLectura { get; set; }
        public bool NoElimiarRegistros { get; set; }
        public int IdUsuario { get; set; }
        public bool NoInsertar { get; set; }
        public bool NoBorrar { get; set; }
        public string AliasNeodata { get; set; }

        public virtual NeoSysCatalogo IdCatalogoNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<NeoSysCatalogosUsuarioC> NeoSysCatalogosUsuarioCs { get; set; }
    }
}
