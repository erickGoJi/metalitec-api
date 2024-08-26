using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AoSubcontratosDetCosto
    {
        public int IdSubcontratoDetCosto { get; set; }
        public int IdSubcontratoDet { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public int IdUsuario { get; set; }
        public decimal CostoAnterior { get; set; }

        public virtual AoSubcontratosDet IdSubcontratoDetNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
    }
}
