using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class NeoSysCatalogosCamposOculto
    {
        public int IdCatalogoCampoOculto { get; set; }
        public int IdCatalogo { get; set; }
        public string NombreCampo { get; set; }

        public virtual NeoSysCatalogo IdCatalogoNavigation { get; set; }
    }
}
