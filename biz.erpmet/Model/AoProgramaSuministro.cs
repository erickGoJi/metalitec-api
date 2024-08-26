using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AoProgramaSuministro
    {
        public int IdProgramaSuministros { get; set; }
        public int IdExplosionInsumos { get; set; }
        public int Periodo { get; set; }
        public decimal Volumen { get; set; }

        public virtual AcExplosionInsumo IdExplosionInsumosNavigation { get; set; }
    }
}
