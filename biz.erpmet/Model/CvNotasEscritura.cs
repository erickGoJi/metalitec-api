using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvNotasEscritura
    {
        public int IdNotaEscritura { get; set; }
        public int IdClienteEscrituracion { get; set; }
        public int IdTipoNota { get; set; }
        public int? IdPoliza { get; set; }
        public int? IdPolizaInversa { get; set; }
        public int Folio { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public decimal MontoIva { get; set; }
        public bool Cancelado { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public int? IdAjusteCliente { get; set; }
        public string DescripcionCancelacion { get; set; }
        public int? IdClienteFactura { get; set; }

        public virtual CvAjusteCliente IdAjusteClienteNavigation { get; set; }
        public virtual CvClienteEscrituracion IdClienteEscrituracionNavigation { get; set; }
        public virtual CtbPoliza IdPolizaInversaNavigation { get; set; }
        public virtual CtbPoliza IdPolizaNavigation { get; set; }
        public virtual CvTiposNota IdTipoNotaNavigation { get; set; }
    }
}
