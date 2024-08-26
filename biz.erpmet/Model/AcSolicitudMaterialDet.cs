using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcSolicitudMaterialDet
    {
        public int IdSolicitudMaterialDet { get; set; }
        public int IdSolicitudMaterial { get; set; }
        public int IdExplosionInsumos { get; set; }
        public decimal Cantidad { get; set; }
        public int Renglon { get; set; }
        public decimal CantidadRequerida { get; set; }
        public decimal CantidadTraspazada { get; set; }
        public decimal CantidadTransito { get; set; }

        public virtual AcExplosionInsumo IdExplosionInsumosNavigation { get; set; }
        public virtual AcSolicitudMaterial IdSolicitudMaterialNavigation { get; set; }
    }
}
