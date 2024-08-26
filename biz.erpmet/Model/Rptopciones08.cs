using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class Rptopciones08
    {
        public int IdReporte { get; set; }
        public int IdSistema { get; set; }
        public int IdUsuario { get; set; }
        public string Codigo { get; set; }
        public string NombreArchivo { get; set; }
        public string Valor { get; set; }

        public virtual SegUsuario IdUsuarioNavigation { get; set; }
    }
}
