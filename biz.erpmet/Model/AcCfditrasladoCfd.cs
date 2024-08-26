using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCfditrasladoCfd
    {
        public int IdCfditrasladoCfd { get; set; }
        public int IdCfditraslado { get; set; }
        public string Xmlcfd { get; set; }
        public DateTime FechaHora { get; set; }

        public virtual AcCfditraslado IdCfditrasladoNavigation { get; set; }
    }
}
