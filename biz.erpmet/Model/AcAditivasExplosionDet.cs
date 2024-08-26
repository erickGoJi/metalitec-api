using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcAditivasExplosionDet
    {
        public int IdAditivaExplosionDet { get; set; }
        public int IdAditivaExplosion { get; set; }
        public int IdExplosionInsumos { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Costo { get; set; }
        public int? IdPartida { get; set; }

        public virtual AcAditivasExplosion IdAditivaExplosionNavigation { get; set; }
        public virtual AcExplosionInsumo IdExplosionInsumosNavigation { get; set; }
        public virtual AoPartida IdPartidaNavigation { get; set; }
    }
}
