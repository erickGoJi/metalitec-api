using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcClientesAntilavadoDet
    {
        public int IdClienteAntilavadoDet { get; set; }
        public int IdClienteAntilavado { get; set; }
        public string NombreDocumento { get; set; }
        public byte[] Documento { get; set; }

        public virtual AcClientesAntilavado IdClienteAntilavadoNavigation { get; set; }
    }
}
