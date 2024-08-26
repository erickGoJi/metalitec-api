using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCfditrasladoDet
    {
        public int IdCfditrasladoDet { get; set; }
        public int IdCfditraslado { get; set; }
        public int IdProyectoConcepto { get; set; }
        public int IdProductoServicioSat { get; set; }
        public int IdUnidadSat { get; set; }
        public decimal Cantidad { get; set; }
        public string DescripcionAuxiliar { get; set; }

        public virtual AcCfditraslado IdCfditrasladoNavigation { get; set; }
        public virtual AcCatProductosServicioSat IdProductoServicioSatNavigation { get; set; }
        public virtual AcProyectoConcepto IdProyectoConceptoNavigation { get; set; }
        public virtual AcCatUnidadesSat IdUnidadSatNavigation { get; set; }
    }
}
