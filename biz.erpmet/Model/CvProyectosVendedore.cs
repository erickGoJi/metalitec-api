using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvProyectosVendedore
    {
        public int IdProyectoVendedor { get; set; }
        public int IdProyecto { get; set; }
        public int IdVendedor { get; set; }

        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual CvVendedore IdVendedorNavigation { get; set; }
    }
}
