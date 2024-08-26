using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AoPrototiposDet
    {
        public AoPrototiposDet()
        {
            Centros = new HashSet<Centro>();
        }

        public int IdPrototipoDet { get; set; }
        public int IdPrototipo { get; set; }
        public int IdPresupuestoControl { get; set; }
        public decimal Cantidad { get; set; }
        public bool? FraccionaTope { get; set; }
        public bool? EstimaDecimal { get; set; }

        public virtual AoPresupuestoControl IdPresupuestoControlNavigation { get; set; }
        public virtual AoPrototipo IdPrototipoNavigation { get; set; }
        public virtual ICollection<Centro> Centros { get; set; }
    }
}
