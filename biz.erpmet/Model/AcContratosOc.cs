using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcContratosOc
    {
        public AcContratosOc()
        {
            AcContratosOcdets = new HashSet<AcContratosOcdet>();
        }

        public int IdContratoOc { get; set; }
        public int IdContrato { get; set; }
        public int NumeroOrdenCambio { get; set; }
        public int IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public string RazonCambio { get; set; }

        public virtual AcContrato IdContratoNavigation { get; set; }
        public virtual ICollection<AcContratosOcdet> AcContratosOcdets { get; set; }
    }
}
