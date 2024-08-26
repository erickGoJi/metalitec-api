using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcClientesResponsablesRemisione
    {
        public AcClientesResponsablesRemisione()
        {
            AcClientesRemisiones = new HashSet<AcClientesRemisione>();
        }

        public int IdClienteResponsableRemision { get; set; }
        public string ResponsableRemision { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<AcClientesRemisione> AcClientesRemisiones { get; set; }
    }
}
