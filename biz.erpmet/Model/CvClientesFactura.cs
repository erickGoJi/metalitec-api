using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvClientesFactura
    {
        public CvClientesFactura()
        {
            AcFacturasAddendasCampos = new HashSet<AcFacturasAddendasCampo>();
            AcFacturasAddendasProductos = new HashSet<AcFacturasAddendasProducto>();
            CrmFacturasAddendasCampos = new HashSet<CrmFacturasAddendasCampo>();
            CvClientesFacturas2017s = new HashSet<CvClientesFacturas2017>();
            CvClientesFacturasCfds = new HashSet<CvClientesFacturasCfd>();
            CvClientesFacturasDets = new HashSet<CvClientesFacturasDet>();
            CvComplementoPagoDets = new HashSet<CvComplementoPagoDet>();
        }

        public int IdClienteFactura { get; set; }
        public int IdProyecto { get; set; }
        public int? IdEstado { get; set; }
        public int? IdCiudad { get; set; }
        public int? IdMetodoPago { get; set; }
        public int? IdCondicionPago { get; set; }
        public int IdTipoMoneda { get; set; }
        public int? IdMovimiento { get; set; }
        public int IdUsuario { get; set; }
        public int IdUsuarioUltimoCambio { get; set; }
        public int? IdUsuarioCancelacion { get; set; }
        public int TipoFactura { get; set; }
        public int TipoMovimiento { get; set; }
        public int? FolioInicial { get; set; }
        public int? FolioFinal { get; set; }
        public string FacturaSerie { get; set; }
        public string FormaDePago { get; set; }
        public string FolioFiscalCfdi { get; set; }
        public string NoCertificado { get; set; }
        public bool Cancelado { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public string DescripcionCancelacion { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string NoExterior { get; set; }
        public string NoInterior { get; set; }
        public string Colonia { get; set; }
        public string Localidad { get; set; }
        public string Referencia { get; set; }
        public string Pais { get; set; }
        public string CodigoPostal { get; set; }
        public string Delegacion { get; set; }
        public string Rfc { get; set; }
        public string Curp { get; set; }
        public DateTime FechaFactura { get; set; }
        public DateTime? FechaHora { get; set; }
        public DateTime? FechaMovimiento { get; set; }
        public string CondicionesFactura { get; set; }
        public string CodigoAuxiliar { get; set; }
        public DateTime FechaUltimoCambio { get; set; }
        public string NumCtaPago { get; set; }
        public decimal MontoFiscal { get; set; }
        public string FolioFiscalOrig { get; set; }
        public string SerieFolioFiscalOrig { get; set; }
        public DateTime? FechaFolioFiscalOrig { get; set; }
        public decimal? MontoFolioFiscalOrig { get; set; }
        public int FolioMovimiento { get; set; }
        public decimal MontoIvafiscal { get; set; }
        public byte EstatusSat { get; set; }
        public string CodigoAddenda { get; set; }
        public string StrMetodosPago { get; set; }
        public bool EsXmlImportado { get; set; }
        public byte? EsCancelable { get; set; }
        public byte? EstatusDeCancelacion { get; set; }
        public DateTime? FechaUltimaActualizacion { get; set; }
        public bool? EnProcesoCancelacion { get; set; }
        public DateTime? FechaSolicitudCancelacion { get; set; }

        public virtual AcCatCiudade IdCiudadNavigation { get; set; }
        public virtual AcCondicionesPago IdCondicionPagoNavigation { get; set; }
        public virtual AcCatEstado IdEstadoNavigation { get; set; }
        public virtual AcMetodoPago IdMetodoPagoNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual AcCatMoneda IdTipoMonedaNavigation { get; set; }
        public virtual SegUsuario IdUsuarioCancelacionNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
        public virtual SegUsuario IdUsuarioUltimoCambioNavigation { get; set; }
        public virtual ICollection<AcFacturasAddendasCampo> AcFacturasAddendasCampos { get; set; }
        public virtual ICollection<AcFacturasAddendasProducto> AcFacturasAddendasProductos { get; set; }
        public virtual ICollection<CrmFacturasAddendasCampo> CrmFacturasAddendasCampos { get; set; }
        public virtual ICollection<CvClientesFacturas2017> CvClientesFacturas2017s { get; set; }
        public virtual ICollection<CvClientesFacturasCfd> CvClientesFacturasCfds { get; set; }
        public virtual ICollection<CvClientesFacturasDet> CvClientesFacturasDets { get; set; }
        public virtual ICollection<CvComplementoPagoDet> CvComplementoPagoDets { get; set; }
    }
}
