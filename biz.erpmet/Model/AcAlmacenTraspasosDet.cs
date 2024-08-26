using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcAlmacenTraspasosDet
    {
        public int IdAlmacenTraspasoDet { get; set; }
        public int IdAlmacenTraspaso { get; set; }
        public int IdExplosionInsumosOrigen { get; set; }
        public int IdExplosionInsumosDestino { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Costo { get; set; }

        public virtual AcAlmacenTraspaso IdAlmacenTraspasoNavigation { get; set; }
        public virtual AcExplosionInsumo IdExplosionInsumosDestinoNavigation { get; set; }
        public virtual AcExplosionInsumo IdExplosionInsumosOrigenNavigation { get; set; }
    }
}
