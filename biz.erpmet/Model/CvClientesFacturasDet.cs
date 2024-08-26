using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvClientesFacturasDet
    {
        public int IdClienteFacturaDet { get; set; }
        public int IdClienteFactura { get; set; }
        public int IdConceptoCfdi { get; set; }
        public string DescripcionAuxiliar { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public int? IdProductoServicioSat { get; set; }
        public int? IdUnidadSat { get; set; }
        public decimal MontoIva { get; set; }

        public virtual CvClientesFactura IdClienteFacturaNavigation { get; set; }
        public virtual CvCatConceptosCfdi IdConceptoCfdiNavigation { get; set; }
        public virtual AcCatProductosServicioSat IdProductoServicioSatNavigation { get; set; }
        public virtual AcCatUnidadesSat IdUnidadSatNavigation { get; set; }
    }
}
