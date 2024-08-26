using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcClientesFacturasNcdet
    {
        public AcClientesFacturasNcdet()
        {
            AcClientesFacturasNcdetCuenta = new HashSet<AcClientesFacturasNcdetCuenta>();
        }

        public int IdClienteFacturaNcdet { get; set; }
        public int IdClienteFacturaNc { get; set; }
        public int IdContratoDet { get; set; }
        public string DescripcionAuxiliar { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public string CuentaPredial { get; set; }
        public decimal Descuento { get; set; }
        public decimal ImpuestosTrasladados { get; set; }
        public decimal ImpuestosRetenidos { get; set; }
        public decimal Total { get; set; }
        public int? IdProductoServicioSat { get; set; }
        public int? IdUnidadSat { get; set; }
        public int? IdConceptosDetNc { get; set; }

        public virtual AcClientesFacturasNc IdClienteFacturaNcNavigation { get; set; }
        public virtual AcCatProductosServicioSat IdProductoServicioSatNavigation { get; set; }
        public virtual AcCatUnidadesSat IdUnidadSatNavigation { get; set; }
        public virtual ICollection<AcClientesFacturasNcdetCuenta> AcClientesFacturasNcdetCuenta { get; set; }
    }
}
