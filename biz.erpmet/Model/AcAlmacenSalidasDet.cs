using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcAlmacenSalidasDet
    {
        public AcAlmacenSalidasDet()
        {
            AcAlmacenSalidaDetCcs = new HashSet<AcAlmacenSalidaDetCc>();
        }

        public int IdAlmacenSalidaDet { get; set; }
        public int IdAlmacenSalida { get; set; }
        public int IdExplosionInsumos { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Recuperacion { get; set; }
        public decimal Costo { get; set; }
        public decimal NuevaRm { get; set; }

        public virtual AcAlmacenSalida IdAlmacenSalidaNavigation { get; set; }
        public virtual AcExplosionInsumo IdExplosionInsumosNavigation { get; set; }
        public virtual ICollection<AcAlmacenSalidaDetCc> AcAlmacenSalidaDetCcs { get; set; }
    }
}
