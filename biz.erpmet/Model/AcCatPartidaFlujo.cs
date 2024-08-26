using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatPartidaFlujo
    {
        public AcCatPartidaFlujo()
        {
            AcBancosEgresos = new HashSet<AcBancosEgreso>();
        }

        public int IdPartidaFlujo { get; set; }
        public string PartidaFlujo { get; set; }
        public string Descripcion { get; set; }
        public bool? AceptaMov { get; set; }
        public decimal MontoPresupuesto { get; set; }

        public virtual ICollection<AcBancosEgreso> AcBancosEgresos { get; set; }
    }
}
