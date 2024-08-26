using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCfditrasladoRelac
    {
        public int IdCfditrasladoRelac { get; set; }
        public int IdCfditraslado { get; set; }
        public string Uuid { get; set; }

        public virtual AcCfditraslado IdCfditrasladoNavigation { get; set; }
    }
}
