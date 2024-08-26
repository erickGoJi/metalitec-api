using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvPrototiposAdjunto
    {
        public int IdAdjunto { get; set; }
        public int IdPrototipo { get; set; }
        public string Texto { get; set; }
        public string Ruta { get; set; }

        public virtual CvPrototipo IdPrototipoNavigation { get; set; }
    }
}
