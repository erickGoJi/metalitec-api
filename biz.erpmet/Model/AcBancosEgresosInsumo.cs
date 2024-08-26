using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcBancosEgresosInsumo
    {
        public int IdBancoEgresoInsumo { get; set; }
        public int IdBancoEgreso { get; set; }
        public int IdProyecto { get; set; }
        public int IdExplosionInsumos { get; set; }
        public string Descripcion { get; set; }
        public decimal Importe { get; set; }

        public virtual AcBancosEgreso IdBancoEgresoNavigation { get; set; }
        public virtual AcExplosionInsumo IdExplosionInsumosNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
    }
}
