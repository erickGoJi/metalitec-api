using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcConstanciasRetencionesCfd
    {
        public int IdConstanciaRetencionCfd { get; set; }
        public int IdConstanciaRetencion { get; set; }
        public string Xmlcfd { get; set; }
        public DateTime FechaHora { get; set; }
        public string XmlcfdsinAddenda { get; set; }
        public string CadenaComplemento { get; set; }

        public virtual AcConstanciasRetencione IdConstanciaRetencionNavigation { get; set; }
    }
}
