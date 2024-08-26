using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcClientesOperadore
    {
        public AcClientesOperadore()
        {
            AcClientesRemisiones = new HashSet<AcClientesRemisione>();
        }

        public int IdClienteOperador { get; set; }
        public string Operador { get; set; }
        public string Nombre { get; set; }
        public string Licencia { get; set; }
        public bool Externo { get; set; }

        public virtual ICollection<AcClientesRemisione> AcClientesRemisiones { get; set; }
    }
}
