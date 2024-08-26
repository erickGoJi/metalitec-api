using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class NeoSysCatalogosUsuarioC
    {
        public int IdCatalogoUsuarioC { get; set; }
        public int IdCatalogoUsuario { get; set; }
        public string NombreCampo { get; set; }
        public string AliasCampo { get; set; }
        public bool NeoEsLlavePrincipal { get; set; }
        public bool EsIndiceUnico { get; set; }
        public string TipoDato { get; set; }
        public int Longitud { get; set; }
        public bool? NeoObligatorio { get; set; }
        public bool UsrRequerido { get; set; }
        public bool UsrBloqueado { get; set; }
        public bool NeoEsFk { get; set; }
        public string NeoTablaRelacion { get; set; }
        public string CodigoUnicoFk { get; set; }
        public string AliasCodigoUnicoFk { get; set; }
        public string CamposAdicionalesFk { get; set; }
        public int Orden { get; set; }
        public bool TieneDefault { get; set; }

        public virtual NeoSysCatalogosUsuario IdCatalogoUsuarioNavigation { get; set; }
    }
}
