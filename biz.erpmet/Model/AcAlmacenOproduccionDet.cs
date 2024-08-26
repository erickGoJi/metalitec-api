using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcAlmacenOproduccionDet
    {
        public int IdAlmacenOproduccionDet { get; set; }
        public int IdAlmacenOproduccion { get; set; }
        public int IdExplosionInsumos { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Costo { get; set; }

        public virtual AcAlmacenOproduccion IdAlmacenOproduccionNavigation { get; set; }
        public virtual AcExplosionInsumo IdExplosionInsumosNavigation { get; set; }
    }
}
