using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvCetapasDet
    {
        public CvCetapasDet()
        {
            CvFlujoClientesDets = new HashSet<CvFlujoClientesDet>();
        }

        public int IdCetapaDet { get; set; }
        public int IdCetapa { get; set; }
        public int IdDocumentoCliente { get; set; }
        public short Renglon { get; set; }

        public virtual CvCetapa IdCetapaNavigation { get; set; }
        public virtual CvDocumentosCliente IdDocumentoClienteNavigation { get; set; }
        public virtual ICollection<CvFlujoClientesDet> CvFlujoClientesDets { get; set; }
    }
}
