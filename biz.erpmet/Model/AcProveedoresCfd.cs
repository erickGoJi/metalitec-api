using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcProveedoresCfd
    {
        public int IdCfd { get; set; }
        public int? IdProveedor { get; set; }
        public int? IdPoliza { get; set; }
        public string Rfcemisor { get; set; }
        public string TipoDeComprobante { get; set; }
        public string Serie { get; set; }
        public int Folio { get; set; }
        public bool FolioValido { get; set; }
        public DateTime FechaEmision { get; set; }
        public string NoCertificado { get; set; }
        public bool NoCertificadoVigenciaValida { get; set; }
        public bool? SinCertificado { get; set; }
        public bool SelloValido { get; set; }
        public string MetodoEncripcion { get; set; }
        public string Observaciones { get; set; }
        public string RazonSocial { get; set; }
        public decimal Subtotal { get; set; }
        public string IvatrasladadoTxt { get; set; }
        public decimal? Ivatrasladado { get; set; }
        public decimal Isrretenido { get; set; }
        public decimal Ivaretenido { get; set; }
        public decimal Total { get; set; }
        public string Rfcreceptor { get; set; }
        public string NomArchivoOriginal { get; set; }
        public string Xmlcfd { get; set; }

        public virtual CtbPoliza IdPolizaNavigation { get; set; }
        public virtual AcProveedore IdProveedorNavigation { get; set; }
    }
}
