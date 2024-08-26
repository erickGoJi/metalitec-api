using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvProyectosDescuento
    {
        public int IdProyectoDescuento { get; set; }
        public int IdProyectoPrototipo { get; set; }
        public int IdTipoDescuento { get; set; }
        public decimal PorcentajeDescuento { get; set; }

        public virtual CvProyectosPrototipo IdProyectoPrototipoNavigation { get; set; }
        public virtual CvTiposDescuento IdTipoDescuentoNavigation { get; set; }
    }
}
