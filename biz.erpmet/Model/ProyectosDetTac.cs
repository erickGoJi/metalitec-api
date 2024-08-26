using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class ProyectosDetTac
    {
        public int IdProyectoDetTac { get; set; }
        public int IdProyecto { get; set; }
        public int IdCtaCostoTac { get; set; }
        public decimal CostoInicial { get; set; }

        public virtual CtbCuenta IdCtaCostoTacNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
    }
}
