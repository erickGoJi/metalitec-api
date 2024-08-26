using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcRelAforoProyecto
    {
        public int IdRelAforoProyecto { get; set; }
        public int IdProyecto { get; set; }
        public string Desc { get; set; }
        public decimal? Cant { get; set; }

        public virtual Proyecto IdProyectoNavigation { get; set; }
    }
}
