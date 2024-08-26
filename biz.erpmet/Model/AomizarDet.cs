using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AomizarDet
    {
        public int IdMizarDet { get; set; }
        public int IdMizar { get; set; }
        public string CentrodeCosto { get; set; }
        public decimal Monto { get; set; }

        public virtual Aomizar IdMizarNavigation { get; set; }
    }
}
