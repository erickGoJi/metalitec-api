using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcClientesFacturasNc
    {
        public AcClientesFacturasNc()
        {
            AcClientesFacturasNcCfds = new HashSet<AcClientesFacturasNcCfd>();
            AcClientesFacturasNccuenta = new HashSet<AcClientesFacturasNccuenta>();
            AcClientesFacturasNcdets = new HashSet<AcClientesFacturasNcdet>();
            AcFacturasAddendasCampos = new HashSet<AcFacturasAddendasCampo>();
            AcFacturasAddendasProductos = new HashSet<AcFacturasAddendasProducto>();
            CrmFacturasAddendasCampos = new HashSet<CrmFacturasAddendasCampo>();
        }

        public int IdClienteFacturaNc { get; set; }
        public byte EsElectronica { get; set; }
        public string SerieFe { get; set; }
        public int? TipoNotaFe { get; set; }
        public int IdCliente { get; set; }
        public int NoNc { get; set; }
        public int? IdTipoNc { get; set; }
        public string FolioFiscalCfdi { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public int? IdPoliza { get; set; }
        public decimal Monto { get; set; }
        public decimal MontoIva { get; set; }
        public bool Cancelado { get; set; }
        public int? IdPolizaInversa { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public int IdUsuario { get; set; }
        public string DescripcionCancelacion { get; set; }
        public int? IdUsuarioCancelacion { get; set; }
        public int? IdPolizaDet { get; set; }
        public int? IdPolizaDetFactura { get; set; }
        public string NoCertificado { get; set; }
        public bool CapturarPorcentajeIva { get; set; }
        public decimal PorcentajeIva { get; set; }
        public string CodigoAddenda { get; set; }
        public string FolioFiscalCfdicapturado { get; set; }
        public byte EstatusSat { get; set; }
        public decimal MontoTotal { get; set; }
        public int? IdProyecto { get; set; }
        public byte? EsCancelable { get; set; }
        public DateTime? FechaSolicitudCancelacion { get; set; }
        public DateTime? FechaUltimaActualizacion { get; set; }
        public byte? EstatusDeCancelacion { get; set; }
        public bool? EnProcesoCancelacion { get; set; }

        public virtual AcCliente IdClienteNavigation { get; set; }
        public virtual CtbPolizasDet IdPolizaDetFacturaNavigation { get; set; }
        public virtual CtbPolizasDet IdPolizaDetNavigation { get; set; }
        public virtual CtbPoliza IdPolizaInversaNavigation { get; set; }
        public virtual CtbPoliza IdPolizaNavigation { get; set; }
        public virtual AcCatTiposNc IdTipoNcNavigation { get; set; }
        public virtual SegUsuario IdUsuarioCancelacionNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
        public virtual AcClientesFacturasNc2017 AcClientesFacturasNc2017 { get; set; }
        public virtual ICollection<AcClientesFacturasNcCfd> AcClientesFacturasNcCfds { get; set; }
        public virtual ICollection<AcClientesFacturasNccuenta> AcClientesFacturasNccuenta { get; set; }
        public virtual ICollection<AcClientesFacturasNcdet> AcClientesFacturasNcdets { get; set; }
        public virtual ICollection<AcFacturasAddendasCampo> AcFacturasAddendasCampos { get; set; }
        public virtual ICollection<AcFacturasAddendasProducto> AcFacturasAddendasProductos { get; set; }
        public virtual ICollection<CrmFacturasAddendasCampo> CrmFacturasAddendasCampos { get; set; }
    }
}
