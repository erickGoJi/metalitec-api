using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcRequisicionDet
    {
        public AcRequisicionDet()
        {
            AcPedidosDets = new HashSet<AcPedidosDet>();
        }

        public int IdRequisicionDet { get; set; }
        public int IdRequisicion { get; set; }
        public int IdExplosionInsumos { get; set; }
        public decimal Cantidad { get; set; }
        public string Observaciones { get; set; }
        public int Renglon { get; set; }
        public int? IdPartida { get; set; }

        public virtual AcExplosionInsumo IdExplosionInsumosNavigation { get; set; }
        public virtual AoPartida IdPartidaNavigation { get; set; }
        public virtual AcRequisicione IdRequisicionNavigation { get; set; }
        public virtual ICollection<AcPedidosDet> AcPedidosDets { get; set; }
    }
}
