using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvComplementoPagoDet
    {
        public int IdComplementoPagoDet { get; set; }
        public int IdComplementoPago { get; set; }
        public int? IdClienteFactura { get; set; }
        public int NumParcialidad { get; set; }
        public decimal SaldoAnterior { get; set; }
        public decimal ImportePagado { get; set; }
        public decimal SaldoInsoluto { get; set; }
        public int? IdXmlproveedor { get; set; }

        public virtual CvClientesFactura IdClienteFacturaNavigation { get; set; }
        public virtual CvComplementoPago IdComplementoPagoNavigation { get; set; }
        public virtual AcProveedoresXml IdXmlproveedorNavigation { get; set; }
    }
}
