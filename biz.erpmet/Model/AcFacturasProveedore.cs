using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcFacturasProveedore
    {
        public AcFacturasProveedore()
        {
            AcAlmacenEntrada = new HashSet<AcAlmacenEntrada>();
            AcFacturasProveedoresCuenta = new HashSet<AcFacturasProveedoresCuenta>();
            AcFacturasProveedoresDets = new HashSet<AcFacturasProveedoresDet>();
        }

        public int IdFacturaProveedor { get; set; }
        public int IdProyecto { get; set; }
        public int IdProveedor { get; set; }
        public string Factura { get; set; }
        public int? IdPedido { get; set; }
        public int? IdSubContrato { get; set; }
        public int? IdSubContratoEst { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaFactura { get; set; }
        public DateTime FechaPoliza { get; set; }
        public DateTime FechaProbablePago { get; set; }
        public int DiasCredito { get; set; }
        public string DescripcionFactura { get; set; }
        public short TipoFactura { get; set; }
        public int? Contrarecibo { get; set; }
        public int? IdPoliza { get; set; }
        public bool Cancelada { get; set; }
        public int? IdPolizaInversa { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public decimal AbonoCuentaProveedor { get; set; }
        public decimal AbonoCuentaProveedorComplementaria { get; set; }
        public string DescripcionCancelacion { get; set; }
        public int? IdUsuarioCancelacion { get; set; }
        public int? IdPolizaDet { get; set; }
        public decimal ImporteFacturaAnticipo { get; set; }
        public bool EntradaRegistrada { get; set; }
        public int? IdTipoProveedor { get; set; }
        public bool EsInventariable { get; set; }
        public DateTime? FechaFacturaNueva { get; set; }
        public int? IdXmlproveedor { get; set; }
        public DateTime? FechaImportacionDaltonDin { get; set; }
        public bool ImportadoDaltonDin { get; set; }
        public int? IntInmfacturaProveedorKey { get; set; }

        public virtual AcPedido IdPedidoNavigation { get; set; }
        public virtual CtbPolizasDet IdPolizaDetNavigation { get; set; }
        public virtual CtbPoliza IdPolizaInversaNavigation { get; set; }
        public virtual CtbPoliza IdPolizaNavigation { get; set; }
        public virtual AcProveedore IdProveedorNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual AoSubContratosEst IdSubContratoEstNavigation { get; set; }
        public virtual AoSubContrato IdSubContratoNavigation { get; set; }
        public virtual AcCatTipoProveedor IdTipoProveedorNavigation { get; set; }
        public virtual SegUsuario IdUsuarioCancelacionNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
        public virtual AcProveedoresXml IdXmlproveedorNavigation { get; set; }
        public virtual ICollection<AcAlmacenEntrada> AcAlmacenEntrada { get; set; }
        public virtual ICollection<AcFacturasProveedoresCuenta> AcFacturasProveedoresCuenta { get; set; }
        public virtual ICollection<AcFacturasProveedoresDet> AcFacturasProveedoresDets { get; set; }
    }
}
