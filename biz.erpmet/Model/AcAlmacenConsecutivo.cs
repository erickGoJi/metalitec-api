using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcAlmacenConsecutivo
    {
        public int IdAlmacenConsecutivo { get; set; }
        public int IdProyecto { get; set; }
        public int? IdTipDocAlmacen { get; set; }
        public int Consecutivo { get; set; }

        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual AcTipDocAlmacen IdTipDocAlmacenNavigation { get; set; }
    }
}
