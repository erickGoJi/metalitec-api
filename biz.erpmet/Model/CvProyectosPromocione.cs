using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvProyectosPromocione
    {
        public int IdProyectoPromocion { get; set; }
        public int IdProyecto { get; set; }
        public int IdPromocion { get; set; }
        public int Cantidad { get; set; }
        public int Otorgadas { get; set; }

        public virtual CvPromocione IdPromocionNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
    }
}
