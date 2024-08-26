using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AccategoriaActivoFijo
    {
        public AccategoriaActivoFijo()
        {
            AcactivoFijos = new HashSet<AcactivoFijo>();
        }

        public int IdCategoriaActivo { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Porcentaje { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<AcactivoFijo> AcactivoFijos { get; set; }
    }
}
