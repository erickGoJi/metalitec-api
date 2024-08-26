using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcFacturasAddendasProducto
    {
        public int IdFacturaAddendaProducto { get; set; }
        public int? IdFactura { get; set; }
        public string Producto { get; set; }
        public string Campo { get; set; }
        public string Valor { get; set; }
        public byte TipoOrigen { get; set; }
        public int? IdClienteFacturaNc { get; set; }
        public int? IdClienteFacturaCv { get; set; }
        public int? IdConstanciaRetencion { get; set; }

        public virtual CvClientesFactura IdClienteFacturaCvNavigation { get; set; }
        public virtual AcClientesFacturasNc IdClienteFacturaNcNavigation { get; set; }
        public virtual AcConstanciasRetencione IdConstanciaRetencionNavigation { get; set; }
        public virtual AcClientesFactura IdFacturaNavigation { get; set; }
    }
}
