using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class NeoSysCatalogo
    {
        public NeoSysCatalogo()
        {
            NeoSysCatalogosCamposOcultos = new HashSet<NeoSysCatalogosCamposOculto>();
            NeoSysCatalogosUsuarios = new HashSet<NeoSysCatalogosUsuario>();
        }

        public int IdCatalogo { get; set; }
        public string NombreCatalogo { get; set; }
        public bool SoloEditarCamposDeUsuario { get; set; }

        public virtual ICollection<NeoSysCatalogosCamposOculto> NeoSysCatalogosCamposOcultos { get; set; }
        public virtual ICollection<NeoSysCatalogosUsuario> NeoSysCatalogosUsuarios { get; set; }
    }
}
