using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcProveedoresXmldocRel
    {
        public int IdDoctoRelacionado { get; set; }
        public string Serie { get; set; }
        public string Folio { get; set; }
        public string IdDocumento { get; set; }
        public decimal ImportePagado { get; set; }
        public decimal ImporteSaldoAnterior { get; set; }
        public decimal ImporteSaldoInsoluto { get; set; }
        public string MetodoDePagoDr { get; set; }
        public string MonedaDr { get; set; }
        public int NumParcialidad { get; set; }
        public decimal? TipoCambioDr { get; set; }
        public int IdXmlproveedor { get; set; }

        public virtual AcProveedoresXml IdXmlproveedorNavigation { get; set; }
    }
}
