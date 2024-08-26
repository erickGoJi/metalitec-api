using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatTipoConceptosCliente
    {
        public AcCatTipoConceptosCliente()
        {
            AcProyectoConceptos = new HashSet<AcProyectoConcepto>();
        }

        public int IdTipoConceptoCliente { get; set; }
        public string TipoConceptoCliente { get; set; }
        public string Descripcion { get; set; }
        public int IdCuentaIngreso { get; set; }
        public int IdCuentaNc { get; set; }

        public virtual CtbCuenta IdCuentaIngresoNavigation { get; set; }
        public virtual CtbCuenta IdCuentaNcNavigation { get; set; }
        public virtual ICollection<AcProyectoConcepto> AcProyectoConceptos { get; set; }
    }
}
