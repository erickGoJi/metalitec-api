using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvDocumentosCliente
    {
        public CvDocumentosCliente()
        {
            CvCetapasDets = new HashSet<CvCetapasDet>();
        }

        public int IdDocumentoCliente { get; set; }
        public string DocumentoCliente { get; set; }
        public string Texto { get; set; }

        public virtual ICollection<CvCetapasDet> CvCetapasDets { get; set; }
    }
}
