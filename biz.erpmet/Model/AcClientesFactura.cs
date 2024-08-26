using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcClientesFactura
    {
        public AcClientesFactura()
        {
            AcBancosIngresosFacturas = new HashSet<AcBancosIngresosFactura>();
            AcClientesFacturas2017s = new HashSet<AcClientesFacturas2017>();
            AcClientesFacturasCfds = new HashSet<AcClientesFacturasCfd>();
            AcClientesFacturasCuenta = new HashSet<AcClientesFacturasCuenta>();
            AcClientesFacturasDets = new HashSet<AcClientesFacturasDet>();
            AcClientesRemisiones = new HashSet<AcClientesRemisione>();
            AcComplementoPagoDets = new HashSet<AcComplementoPagoDet>();
            AcFacturasAddendasCampos = new HashSet<AcFacturasAddendasCampo>();
            AcFacturasAddendasProductos = new HashSet<AcFacturasAddendasProducto>();
            CrmFacturasAddendasCampos = new HashSet<CrmFacturasAddendasCampo>();
            CtbPolizasDetClientes = new HashSet<CtbPolizasDetCliente>();
        }

        public int IdClienteFactura { get; set; }
        public byte EsElectronica { get; set; }
        public string FormaDePago { get; set; }
        public string CodigoAddenda { get; set; }
        public string FacturaSerie { get; set; }
        public int? FolioFinal { get; set; }
        public int? FolioInicial { get; set; }
        public int? IdContrato { get; set; }
        public int IdUsuario { get; set; }
        public int? IdPoliza { get; set; }
        public bool Cancelada { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public int? IdUsuarioCancelacion { get; set; }
        public int? IdPolizaInversa { get; set; }
        public string DescripcionCancelacion { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string NoExterior { get; set; }
        public string NoInterior { get; set; }
        public string Colonia { get; set; }
        public string Localidad { get; set; }
        public string Referencia { get; set; }
        public int? IdEstado { get; set; }
        public string Pais { get; set; }
        public string CodigoPostal { get; set; }
        public string Delegacion { get; set; }
        public int? IdCiudad { get; set; }
        public string Rfc { get; set; }
        public string Curp { get; set; }
        public DateTime FechaFactura { get; set; }
        public DateTime? FechaHora { get; set; }
        public DateTime FechaProbablePago { get; set; }
        public short DiasdeCredito { get; set; }
        public decimal CargoCuentaClientes { get; set; }
        public decimal CargoCuentaClientesComplementaria { get; set; }
        public decimal MontoNc { get; set; }
        public bool EsFacturaAnticipo { get; set; }
        public decimal ImporteFacturaAnticipo { get; set; }
        public string CondicionesFactura { get; set; }
        public bool Impresa { get; set; }
        public bool Emitir { get; set; }
        public string CodigoAuxiliar { get; set; }
        public bool EsCaratulaLibre { get; set; }
        public string TextoCaratula { get; set; }
        public DateTime FechaUltimoCambio { get; set; }
        public int IdUsuarioUltimoCambio { get; set; }
        public int? IdCatResponsable1 { get; set; }
        public int? IdCatResponsable2 { get; set; }
        public int? IdCatResponsable3 { get; set; }
        public int? IdCatResponsable4 { get; set; }
        public int? IdPolizaDet { get; set; }
        public int? IdMetodoPago { get; set; }
        public int? IdCondicionPago { get; set; }
        public string ConceptoFeanticipo { get; set; }
        public string Concepto { get; set; }
        public string Unidad { get; set; }
        public string Descripcion { get; set; }
        public bool ConsolidarConceptos { get; set; }
        public string NoCertificado { get; set; }
        public string FolioFiscalCfdi { get; set; }
        public bool UsarFormatoPie { get; set; }
        public string FolioFiscalOrig { get; set; }
        public decimal? MontoFolioFiscalOrig { get; set; }
        public string NumCtaPago { get; set; }
        public DateTime? FechaFolioFiscalOrig { get; set; }
        public string SerieFolioFiscalOrig { get; set; }
        public byte EstatusSat { get; set; }
        public string StrMetodosPago { get; set; }
        public bool? EnProcesoCancelacion { get; set; }
        public DateTime? FechaUltimaActualizacion { get; set; }
        public DateTime? FechaSolicitudCancelacion { get; set; }
        public byte? EstatusDeCancelacion { get; set; }
        public byte? EsCancelable { get; set; }

        public virtual Acresponsable IdCatResponsable1Navigation { get; set; }
        public virtual Acresponsable IdCatResponsable2Navigation { get; set; }
        public virtual Acresponsable IdCatResponsable3Navigation { get; set; }
        public virtual Acresponsable IdCatResponsable4Navigation { get; set; }
        public virtual AcCatCiudade IdCiudadNavigation { get; set; }
        public virtual AcCondicionesPago IdCondicionPagoNavigation { get; set; }
        public virtual AcContrato IdContratoNavigation { get; set; }
        public virtual AcCatEstado IdEstadoNavigation { get; set; }
        public virtual AcMetodoPago IdMetodoPagoNavigation { get; set; }
        public virtual CtbPolizasDet IdPolizaDetNavigation { get; set; }
        public virtual CtbPoliza IdPolizaInversaNavigation { get; set; }
        public virtual CtbPoliza IdPolizaNavigation { get; set; }
        public virtual SegUsuario IdUsuarioCancelacionNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
        public virtual SegUsuario IdUsuarioUltimoCambioNavigation { get; set; }
        public virtual ICollection<AcBancosIngresosFactura> AcBancosIngresosFacturas { get; set; }
        public virtual ICollection<AcClientesFacturas2017> AcClientesFacturas2017s { get; set; }
        public virtual ICollection<AcClientesFacturasCfd> AcClientesFacturasCfds { get; set; }
        public virtual ICollection<AcClientesFacturasCuenta> AcClientesFacturasCuenta { get; set; }
        public virtual ICollection<AcClientesFacturasDet> AcClientesFacturasDets { get; set; }
        public virtual ICollection<AcClientesRemisione> AcClientesRemisiones { get; set; }
        public virtual ICollection<AcComplementoPagoDet> AcComplementoPagoDets { get; set; }
        public virtual ICollection<AcFacturasAddendasCampo> AcFacturasAddendasCampos { get; set; }
        public virtual ICollection<AcFacturasAddendasProducto> AcFacturasAddendasProductos { get; set; }
        public virtual ICollection<CrmFacturasAddendasCampo> CrmFacturasAddendasCampos { get; set; }
        public virtual ICollection<CtbPolizasDetCliente> CtbPolizasDetClientes { get; set; }
    }
}
