using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvAjusteCliente
    {
        public CvAjusteCliente()
        {
            CvAplicacionApartados = new HashSet<CvAplicacionApartado>();
            CvAplicacionDepositos = new HashSet<CvAplicacionDeposito>();
            CvDepositosSofolDets = new HashSet<CvDepositosSofolDet>();
            CvNotasEscrituras = new HashSet<CvNotasEscritura>();
        }

        public int IdAjusteCliente { get; set; }
        public int Folio { get; set; }
        public int IdClienteEscrituracion { get; set; }
        public int? IdPoliza { get; set; }
        public int? IdPolizaInversa { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public decimal MontoDevolucion { get; set; }
        public bool Cancelado { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public decimal MontoEscritura { get; set; }
        public string DescripcionCancelacion { get; set; }
        public decimal MontoContrato { get; set; }
        public decimal MontoNotasCargo { get; set; }
        public decimal MontoNotasCredito { get; set; }
        public decimal MontoPagado { get; set; }
        public decimal MontoDevolucionesAnteriores { get; set; }
        public decimal MontoIvaTrasladadoPorAplicar { get; set; }

        public virtual CvClienteEscrituracion IdClienteEscrituracionNavigation { get; set; }
        public virtual CtbPoliza IdPolizaInversaNavigation { get; set; }
        public virtual CtbPoliza IdPolizaNavigation { get; set; }
        public virtual ICollection<CvAplicacionApartado> CvAplicacionApartados { get; set; }
        public virtual ICollection<CvAplicacionDeposito> CvAplicacionDepositos { get; set; }
        public virtual ICollection<CvDepositosSofolDet> CvDepositosSofolDets { get; set; }
        public virtual ICollection<CvNotasEscritura> CvNotasEscrituras { get; set; }
    }
}
