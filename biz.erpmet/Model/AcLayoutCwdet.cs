using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcLayoutCwdet
    {
        public int IdLayoutCwdet { get; set; }
        public int IdLayoutCw { get; set; }
        public string NombreCampo { get; set; }
        public short Orden { get; set; }
        public short Longitud { get; set; }
        public string Justificado { get; set; }
        public string Relleno { get; set; }
        public string DataField { get; set; }

        public virtual AcLayoutCw IdLayoutCwNavigation { get; set; }
    }
}
