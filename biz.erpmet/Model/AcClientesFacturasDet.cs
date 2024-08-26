using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcClientesFacturasDet
    {
        public AcClientesFacturasDet()
        {
            AcClientesFacturasDetAduanas = new HashSet<AcClientesFacturasDetAduana>();
            AcClientesFacturasDetCuenta = new HashSet<AcClientesFacturasDetCuenta>();
        }

        public int IdClienteFacturaDet { get; set; }
        public int IdClienteFactura { get; set; }
        public int IdContratoDet { get; set; }
        public string DescripcionAuxiliar { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public string CuentaPredial { get; set; }
        public decimal Descuento { get; set; }
        public decimal ImpuestosTrasladados { get; set; }
        public decimal Total { get; set; }
        public int? IdUnidadSat { get; set; }
        public decimal ImpuestosRetenidos { get; set; }
        public int? IdProductoServicioSat { get; set; }

        public virtual AcClientesFactura IdClienteFacturaNavigation { get; set; }
        public virtual AcContratosDet IdContratoDetNavigation { get; set; }
        public virtual AcCatProductosServicioSat IdProductoServicioSatNavigation { get; set; }
        public virtual AcCatUnidadesSat IdUnidadSatNavigation { get; set; }
        public virtual ICollection<AcClientesFacturasDetAduana> AcClientesFacturasDetAduanas { get; set; }
        public virtual ICollection<AcClientesFacturasDetCuenta> AcClientesFacturasDetCuenta { get; set; }
    }
}
