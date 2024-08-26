using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcConstanciasRetencione
    {
        public AcConstanciasRetencione()
        {
            AcConstanciasRetencionesCfds = new HashSet<AcConstanciasRetencionesCfd>();
            AcConstanciasRetencionesDets = new HashSet<AcConstanciasRetencionesDet>();
            AcFacturasAddendasCampos = new HashSet<AcFacturasAddendasCampo>();
            AcFacturasAddendasProductos = new HashSet<AcFacturasAddendasProducto>();
            CrmFacturasAddendasCampos = new HashSet<CrmFacturasAddendasCampo>();
        }

        public int IdConstanciaRetencion { get; set; }
        public int? FolioConstancia { get; set; }
        public string FolioAuxConstancia { get; set; }
        public int Ejercicio { get; set; }
        public int MesInicial { get; set; }
        public int MesFinal { get; set; }
        public int IdUsuario { get; set; }
        public bool Cancelada { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public int? IdUsuarioCancelacion { get; set; }
        public string DescripcionCancelacion { get; set; }
        public string RazonSocial { get; set; }
        public string Rfc { get; set; }
        public string Curp { get; set; }
        public DateTime FechaConstancia { get; set; }
        public bool EsExtranjero { get; set; }
        public DateTime FechaUltimoCambio { get; set; }
        public int IdUsuarioUltimoCambio { get; set; }
        public string DescripcionConstancia { get; set; }
        public string CodigoComplemento { get; set; }
        public string CodigoAddenda { get; set; }
        public int IdTipoRetencion { get; set; }
        public string NoCertificado { get; set; }
        public string FolioFiscalCfdi { get; set; }
        public byte EstatusSat { get; set; }
        public string NumRegIdFiscal { get; set; }
        public decimal MontoTotalOperacion { get; set; }
        public decimal MontoTotalGravado { get; set; }
        public decimal MontoTotalExento { get; set; }
        public decimal MontoTotalRetenido { get; set; }
        public int? IdProveedor { get; set; }
        public int? IdProyecto { get; set; }

        public virtual AcCatTiposRetencione IdTipoRetencionNavigation { get; set; }
        public virtual SegUsuario IdUsuarioCancelacionNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
        public virtual SegUsuario IdUsuarioUltimoCambioNavigation { get; set; }
        public virtual ICollection<AcConstanciasRetencionesCfd> AcConstanciasRetencionesCfds { get; set; }
        public virtual ICollection<AcConstanciasRetencionesDet> AcConstanciasRetencionesDets { get; set; }
        public virtual ICollection<AcFacturasAddendasCampo> AcFacturasAddendasCampos { get; set; }
        public virtual ICollection<AcFacturasAddendasProducto> AcFacturasAddendasProductos { get; set; }
        public virtual ICollection<CrmFacturasAddendasCampo> CrmFacturasAddendasCampos { get; set; }
    }
}
