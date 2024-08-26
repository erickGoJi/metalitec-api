using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatFlujoEfectivoOtrosIngresosEgreso
    {
        public AcCatFlujoEfectivoOtrosIngresosEgreso()
        {
            AcFlujoEfectivoOtrosIngresosEgresos = new HashSet<AcFlujoEfectivoOtrosIngresosEgreso>();
        }

        public int IdTipoOtroIngresoEgreso { get; set; }
        public string TipoOtroIngresoEgreso { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<AcFlujoEfectivoOtrosIngresosEgreso> AcFlujoEfectivoOtrosIngresosEgresos { get; set; }
    }
}
