using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CrmAddendasCampo
    {
        public int IdAddendaCampo { get; set; }
        public string Receptor { get; set; }
        public string Campo { get; set; }
        public string Valor { get; set; }
        public string TipoArchivo { get; set; }
        public byte TipoOrigen { get; set; }
    }
}
