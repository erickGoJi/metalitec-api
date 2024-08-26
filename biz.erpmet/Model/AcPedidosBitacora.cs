using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcPedidosBitacora
    {
        public int IdPedidoBitacora { get; set; }
        public int Folio { get; set; }
        public int IdProyecto { get; set; }
        public int IdPedido { get; set; }
        public int IdUsuarioModifico { get; set; }
        public decimal? ImporteAnterior { get; set; }
        public decimal? ImporteFinal { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string MotivoModificacion { get; set; }

        public virtual AcPedido IdPedidoNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual SegUsuario IdUsuarioModificoNavigation { get; set; }
    }
}
