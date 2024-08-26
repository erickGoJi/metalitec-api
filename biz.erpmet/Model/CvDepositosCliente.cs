using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvDepositosCliente
    {
        public CvDepositosCliente()
        {
            CvApartados = new HashSet<CvApartado>();
            CvAplicacionDepositos = new HashSet<CvAplicacionDeposito>();
            CvComplementoPagos = new HashSet<CvComplementoPago>();
        }

        public int IdDeposito { get; set; }
        public int FolioDeposito { get; set; }
        public int IdCuentaBancaria { get; set; }
        public DateTime Fecha { get; set; }
        public string Referencia { get; set; }
        public bool Cancelado { get; set; }
        public decimal MontoTotalDeposito { get; set; }
        public int? IdPoliza { get; set; }
        public int IdProyecto { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public int? IdPolizaInversa { get; set; }
        public bool Aplicado { get; set; }
        public string DescripcionCancelacion { get; set; }
        public decimal Paridad { get; set; }
        public int TipoDeposito { get; set; }
        public string CuentaBancariaDepositante { get; set; }
        public string Rfcdepositante { get; set; }
        public string BancoExtDepositante { get; set; }
        public string BancoSatdepositante { get; set; }
        public string NumCheque { get; set; }
        public string ClaveMetodoPago { get; set; }
        public string ClaveMonedaSat { get; set; }
        public string Observaciones { get; set; }
        public int? IdComplementoPago { get; set; }
        public bool? AutomaticoDalton { get; set; }

        public virtual AcCuentasBancaria IdCuentaBancariaNavigation { get; set; }
        public virtual CtbPoliza IdPolizaInversaNavigation { get; set; }
        public virtual CtbPoliza IdPolizaNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual ICollection<CvApartado> CvApartados { get; set; }
        public virtual ICollection<CvAplicacionDeposito> CvAplicacionDepositos { get; set; }
        public virtual ICollection<CvComplementoPago> CvComplementoPagos { get; set; }
    }
}
