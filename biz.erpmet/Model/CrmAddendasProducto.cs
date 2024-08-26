using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CrmAddendasProducto
    {
        public int IdAddendaProducto { get; set; }
        public string Campo { get; set; }
        public string Valor { get; set; }
        public int IdContratoDet { get; set; }
        public byte TipoOrigen { get; set; }
    }
}
