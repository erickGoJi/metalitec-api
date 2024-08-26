using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcComplementoPagoDet
    {
        public int IdComplementoPagoDet { get; set; }
        public int IdComplementoPago { get; set; }
        public int? IdClienteFactura { get; set; }
        public int? IdPolizaDet { get; set; }
        public int NumParcialidad { get; set; }
        public decimal SaldoAnterior { get; set; }
        public decimal ImportePagado { get; set; }
        public decimal SaldoInsoluto { get; set; }
        public int? IdXmlproveedor { get; set; }

        public virtual AcClientesFactura IdClienteFacturaNavigation { get; set; }
        public virtual AcComplementoPago IdComplementoPagoNavigation { get; set; }
        public virtual CtbPolizasDet IdPolizaDetNavigation { get; set; }
        public virtual AcProveedoresXml IdXmlproveedorNavigation { get; set; }
    }
}
