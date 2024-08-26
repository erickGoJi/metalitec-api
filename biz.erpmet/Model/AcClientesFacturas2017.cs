using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcClientesFacturas2017
    {
        public AcClientesFacturas2017()
        {
            AcClientesFacturasCfdirelacs = new HashSet<AcClientesFacturasCfdirelac>();
        }

        public int IdClienteFactura2017 { get; set; }
        public int IdClienteFactura { get; set; }
        public DateTime? FechaTimbrado { get; set; }
        public decimal SubTotal { get; set; }
        public decimal? Descuento { get; set; }
        public decimal TipoCambio { get; set; }
        public string ClaveConfirmacion { get; set; }
        public string NumRegIdTribReceptor { get; set; }
        public int? IdProductoServicioSat { get; set; }
        public int? IdUnidadSat { get; set; }
        public int IdCatMonedasSat { get; set; }
        public int IdTipoComprobanteSat { get; set; }
        public int? IdFormaPagoSat { get; set; }
        public int? IdMetodoPagoSat { get; set; }
        public int? IdTipoRelacionSat { get; set; }
        public int? IdPaisReceptor { get; set; }
        public int IdUsoCfdiSat { get; set; }
        public bool ConsiderarFgcomoDescuento { get; set; }
        public string Observaciones { get; set; }

        public virtual CtbCatMonedasSat IdCatMonedasSatNavigation { get; set; }
        public virtual AcClientesFactura IdClienteFacturaNavigation { get; set; }
        public virtual AcCatFormasPagoSat IdFormaPagoSatNavigation { get; set; }
        public virtual AcCatMetodosPagoSat IdMetodoPagoSatNavigation { get; set; }
        public virtual AcCatPaise IdPaisReceptorNavigation { get; set; }
        public virtual AcCatProductosServicioSat IdProductoServicioSatNavigation { get; set; }
        public virtual AcCatTiposComprobanteSat IdTipoComprobanteSatNavigation { get; set; }
        public virtual AcCatTiposRelacionSat IdTipoRelacionSatNavigation { get; set; }
        public virtual AcCatUnidadesSat IdUnidadSatNavigation { get; set; }
        public virtual AcCatUsosCfdisat IdUsoCfdiSatNavigation { get; set; }
        public virtual ICollection<AcClientesFacturasCfdirelac> AcClientesFacturasCfdirelacs { get; set; }
    }
}
