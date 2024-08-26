using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvCatConceptosCfdi
    {
        public CvCatConceptosCfdi()
        {
            CvClientesFacturasDets = new HashSet<CvClientesFacturasDet>();
        }

        public int IdConceptoCfdi { get; set; }
        public string Concepto { get; set; }
        public string Descripcion { get; set; }
        public string Unidad { get; set; }
        public byte Tipo { get; set; }
        public int? IdProductoServicioSat { get; set; }
        public int? IdUnidadSat { get; set; }

        public virtual AcCatProductosServicioSat IdProductoServicioSatNavigation { get; set; }
        public virtual AcCatUnidadesSat IdUnidadSatNavigation { get; set; }
        public virtual ICollection<CvClientesFacturasDet> CvClientesFacturasDets { get; set; }
    }
}
