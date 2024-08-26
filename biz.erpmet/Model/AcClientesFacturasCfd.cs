using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcClientesFacturasCfd
    {
        public int IdClienteFacturaCfd { get; set; }
        public int IdClienteFactura { get; set; }
        public string Xmlcfd { get; set; }
        public string Xmlpoliza { get; set; }
        public DateTime FechaHora { get; set; }
        public string NombreXlsx { get; set; }
        public byte[] Xlsx { get; set; }
        public string XmlcfdsinAddenda { get; set; }

        public virtual AcClientesFactura IdClienteFacturaNavigation { get; set; }
    }
}
