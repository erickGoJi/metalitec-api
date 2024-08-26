using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcProveedoresXml
    {
        public AcProveedoresXml()
        {
            AcComplementoPagoDets = new HashSet<AcComplementoPagoDet>();
            AcFacturasProveedores = new HashSet<AcFacturasProveedore>();
            AcFacturasProveedoresNcs = new HashSet<AcFacturasProveedoresNc>();
            AcGastosXcomprobarDets = new HashSet<AcGastosXcomprobarDet>();
            AcProveedoresXmldocRels = new HashSet<AcProveedoresXmldocRel>();
            CvComplementoPagoDets = new HashSet<CvComplementoPagoDet>();
        }

        public int IdXmlproveedor { get; set; }
        public string Rfcemisor { get; set; }
        public string RazonSocialEmisor { get; set; }
        public string Rfcreceptor { get; set; }
        public string Folio { get; set; }
        public string Serie { get; set; }
        public string TipoComprobante { get; set; }
        public decimal Total { get; set; }
        public decimal SubTotal { get; set; }
        public string Moneda { get; set; }
        public decimal? TipoCambio { get; set; }
        public decimal Descuento { get; set; }
        public decimal? Iva { get; set; }
        public DateTime? FechaComprobante { get; set; }
        public DateTime? FechaTimbrado { get; set; }
        public string Uuid { get; set; }
        public string Xmlproveedor { get; set; }
        public bool Validado { get; set; }
        public bool YaRelacionado { get; set; }
        public decimal Isrretenido { get; set; }
        public decimal Ivaretenido { get; set; }
        public bool PendienteAlta { get; set; }
        public bool? EsProveedor { get; set; }
        public bool NoValido { get; set; }
        public string MensajeValidacion { get; set; }
        public bool EsGxC { get; set; }
        public byte EstatusSat { get; set; }
        public string StrMetodosPago { get; set; }
        public string DocumentosRelacionados { get; set; }
        public byte? EsCancelable { get; set; }
        public byte? EstatusDeCancelacion { get; set; }
        public DateTime? FechaUltimaActualizacion { get; set; }

        public virtual ICollection<AcComplementoPagoDet> AcComplementoPagoDets { get; set; }
        public virtual ICollection<AcFacturasProveedore> AcFacturasProveedores { get; set; }
        public virtual ICollection<AcFacturasProveedoresNc> AcFacturasProveedoresNcs { get; set; }
        public virtual ICollection<AcGastosXcomprobarDet> AcGastosXcomprobarDets { get; set; }
        public virtual ICollection<AcProveedoresXmldocRel> AcProveedoresXmldocRels { get; set; }
        public virtual ICollection<CvComplementoPagoDet> CvComplementoPagoDets { get; set; }
    }
}
