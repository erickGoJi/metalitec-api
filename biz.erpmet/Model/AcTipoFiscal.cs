using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcTipoFiscal
    {
        public AcTipoFiscal()
        {
            AcContratos = new HashSet<AcContrato>();
            AcPedidos = new HashSet<AcPedido>();
        }

        public int IdTipoFiscal { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<AcContrato> AcContratos { get; set; }
        public virtual ICollection<AcPedido> AcPedidos { get; set; }
    }
}
