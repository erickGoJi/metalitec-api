using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class FefoliosCfdxRfc
    {
        public int IdFolioCfd { get; set; }
        public string Rfc { get; set; }
        public string NoAprobacion { get; set; }
        public string AnoAprobacion { get; set; }
        public string Serie { get; set; }
        public int FolioInicial { get; set; }
        public int FolioFinal { get; set; }
        public DateTime FechaProceso { get; set; }
        public int IdUsuario { get; set; }

        public virtual SegUsuario IdUsuarioNavigation { get; set; }
    }
}
