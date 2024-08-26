using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatContratosStatus
    {
        public AcCatContratosStatus()
        {
            AcContratosDatosAdicionales = new HashSet<AcContratosDatosAdicionale>();
        }

        public int IdCatStatus { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<AcContratosDatosAdicionale> AcContratosDatosAdicionales { get; set; }
    }
}
