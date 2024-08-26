using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvDocumento
    {
        public int IdDocumento { get; set; }
        public int IdCredito { get; set; }
        public string RutaDocumento { get; set; }
        public string Texto { get; set; }

        public virtual CvCredito IdCreditoNavigation { get; set; }
    }
}
