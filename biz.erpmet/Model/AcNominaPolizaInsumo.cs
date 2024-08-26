using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcNominaPolizaInsumo
    {
        public int IdNominaPolizaInsumo { get; set; }
        public int IdExplosionInsumos { get; set; }
        public int IdNominaPoliza { get; set; }
        public decimal Cantidad { get; set; }
        public bool EsSueldo { get; set; }
        public decimal Costo { get; set; }

        public virtual AcExplosionInsumo IdExplosionInsumosNavigation { get; set; }
        public virtual AcNominaPoliza IdNominaPolizaNavigation { get; set; }
    }
}
