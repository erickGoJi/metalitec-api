using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class Feregimene
    {
        public int IdRegimen { get; set; }
        public string Regimen { get; set; }
        public int? IdCatRegimen { get; set; }

        public virtual AcCatRegimenesFiscalesSat IdCatRegimenNavigation { get; set; }
    }
}
