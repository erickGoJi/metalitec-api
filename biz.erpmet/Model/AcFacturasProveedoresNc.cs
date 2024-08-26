using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcFacturasProveedoresNc
    {
        public int IdFacturaProveedorNc { get; set; }
        public int IdProveedor { get; set; }
        public string NoNc { get; set; }
        public int IdTipoNc { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public int IdPoliza { get; set; }
        public decimal Monto { get; set; }
        public decimal MontoIva { get; set; }
        public bool Cancelado { get; set; }
        public int? IdPolizaInversa { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public int IdUsuario { get; set; }
        public string DescripcionCancelacion { get; set; }
        public int? IdUsuarioCancelacion { get; set; }
        public int? IdPolizaDet { get; set; }
        public int? IdXmlProveedor { get; set; }
        public int? IdSubContratoEst { get; set; }
        public bool EsEgresoPorAmortizacion { get; set; }

        public virtual CtbPolizasDet IdPolizaDetNavigation { get; set; }
        public virtual CtbPoliza IdPolizaInversaNavigation { get; set; }
        public virtual CtbPoliza IdPolizaNavigation { get; set; }
        public virtual AcProveedore IdProveedorNavigation { get; set; }
        public virtual AoSubContratosEst IdSubContratoEstNavigation { get; set; }
        public virtual AcCatTiposNc IdTipoNcNavigation { get; set; }
        public virtual SegUsuario IdUsuarioCancelacionNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
        public virtual AcProveedoresXml IdXmlProveedorNavigation { get; set; }
    }
}
