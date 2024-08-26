using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvPrototiposAccesorio
    {
        public int IdPrototipoAccesorio { get; set; }
        public int IdProyecto { get; set; }
        public int IdPrototipo { get; set; }
        public int IdAccesorio { get; set; }
        public decimal Cantidad { get; set; }

        public virtual CvAccesorio IdAccesorioNavigation { get; set; }
        public virtual CvPrototipo IdPrototipoNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
    }
}
