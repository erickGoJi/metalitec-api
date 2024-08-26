using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCostosXproyecto
    {
        public AcCostosXproyecto()
        {
            AoExpXconceptos = new HashSet<AoExpXconcepto>();
        }

        public int IdCostoXproyecto { get; set; }
        public int IdProyecto { get; set; }
        public int IdInsumo { get; set; }
        public decimal Costo { get; set; }
        public bool Participa { get; set; }
        public decimal CostoOriginal { get; set; }

        public virtual AcCatInsumo IdInsumoNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual ICollection<AoExpXconcepto> AoExpXconceptos { get; set; }
    }
}
