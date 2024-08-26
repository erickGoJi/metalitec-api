using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcRelRemanentesProyecto
    {
        public int IdRelRemanenteProyecto { get; set; }
        public int IdProyecto { get; set; }
        public string Desc { get; set; }
        public decimal? Cant { get; set; }

        public virtual Proyecto IdProyectoNavigation { get; set; }
    }
}
