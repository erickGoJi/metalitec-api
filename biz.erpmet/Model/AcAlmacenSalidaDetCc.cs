using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcAlmacenSalidaDetCc
    {
        public int IdAlmacenSalidaDetCc { get; set; }
        public int IdAlmacenSalidaDet { get; set; }
        public int IdCentro { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Recuperacion { get; set; }

        public virtual AcAlmacenSalidasDet IdAlmacenSalidaDetNavigation { get; set; }
        public virtual Centro IdCentroNavigation { get; set; }
    }
}
