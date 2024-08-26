using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcalmacenSaldosMensuale
    {
        public int IdAlmacenSaldoMensual { get; set; }
        public int IdExplosionInsumos { get; set; }
        public int Mes { get; set; }
        public decimal ExistenciaInicial { get; set; }
        public decimal ImporteInicial { get; set; }

        public virtual AcExplosionInsumo IdExplosionInsumosNavigation { get; set; }
    }
}
