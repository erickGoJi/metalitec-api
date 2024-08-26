using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcAjustesPedido
    {
        public int IdAjuste { get; set; }
        public int Folio { get; set; }
        public string Comentario { get; set; }
        public DateTime Fecha { get; set; }
        public decimal MontoAjuste { get; set; }
        public bool Cancelado { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public int IdUsuario { get; set; }
        public int? IdUsuarioCancelacion { get; set; }
        public int IdPedido { get; set; }

        public virtual AcPedido IdPedidoNavigation { get; set; }
        public virtual SegUsuario IdUsuarioCancelacionNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
    }
}
