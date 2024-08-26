using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcClientesTransporte
    {
        public AcClientesTransporte()
        {
            AcClientesRemisiones = new HashSet<AcClientesRemisione>();
        }

        public int IdClienteTransporte { get; set; }
        public string Transporte { get; set; }
        public string Descripcion { get; set; }
        public string Placas { get; set; }
        public string NumSerie { get; set; }
        public string Capacidad { get; set; }
        public bool Externo { get; set; }

        public virtual ICollection<AcClientesRemisione> AcClientesRemisiones { get; set; }
    }
}
