using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvPlaza
    {
        public int IdPlaza { get; set; }
        public string Plaza { get; set; }
        public int IdEstado { get; set; }
        public string Texto { get; set; }

        public virtual AcCatEstado IdEstadoNavigation { get; set; }
    }
}
