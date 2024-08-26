using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcOrdenProduccionDet
    {
        public int IdOrdenProduccionDet { get; set; }
        public int IdOrdenProduccion { get; set; }
        public int IdExplosionInsumos { get; set; }
        public decimal Cantidad { get; set; }
        public decimal CantidadRequerida { get; set; }

        public virtual AcExplosionInsumo IdExplosionInsumosNavigation { get; set; }
        public virtual AcOrdenProduccion IdOrdenProduccionNavigation { get; set; }
    }
}
