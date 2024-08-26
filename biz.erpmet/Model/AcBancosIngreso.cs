using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcBancosIngreso
    {
        public AcBancosIngreso()
        {
            AcBancosIngresosCuenta = new HashSet<AcBancosIngresosCuenta>();
            AcBancosIngresosFacturas = new HashSet<AcBancosIngresosFactura>();
            AcComplementoPagos = new HashSet<AcComplementoPago>();
        }

        public int IdBancoIngreso { get; set; }
        public int IdCuentaBancaria { get; set; }
        public int IdCuentaAbono { get; set; }
        public int IdProyecto { get; set; }
        public int IdTipoDeposito { get; set; }
        public int? IdContratoPp { get; set; }
        public int Deposito { get; set; }
        public DateTime Fecha { get; set; }
        public bool Cancelado { get; set; }
        public decimal Monto { get; set; }
        public string Referencia { get; set; }
        public string Observaciones { get; set; }
        public string DescripcionCancelacion { get; set; }
        public int? IdPoliza { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public int? IdUsuarioCancelacion { get; set; }
        public int? IdPolizaInversa { get; set; }
        public decimal? MontoPesos { get; set; }
        public int IdUsuario { get; set; }
        public int? IdFlujo { get; set; }
        public bool EsMultiCentro { get; set; }
        public bool EsDepositoManual { get; set; }
        public bool EsMultiMoneda { get; set; }
        public decimal DividirEntre { get; set; }
        public decimal ParidadBursatil { get; set; }
        public bool Marca { get; set; }
        public string CuentaBancariaDepositante { get; set; }
        public int? IdBancoSatdepositante { get; set; }
        public string RfcDepositante { get; set; }
        public string BancoSatdepositante { get; set; }
        public string BanEmisExt { get; set; }
        public string MonedaSatdepositante { get; set; }
        public bool AutomaticoDalton { get; set; }

        public virtual CtbCuenta IdCuentaAbonoNavigation { get; set; }
        public virtual AcCuentasBancaria IdCuentaBancariaNavigation { get; set; }
        public virtual AcCatFlujo IdFlujoNavigation { get; set; }
        public virtual CtbPoliza IdPolizaInversaNavigation { get; set; }
        public virtual CtbPoliza IdPolizaNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual AcCatTipoDeposito IdTipoDepositoNavigation { get; set; }
        public virtual SegUsuario IdUsuarioCancelacionNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<AcBancosIngresosCuenta> AcBancosIngresosCuenta { get; set; }
        public virtual ICollection<AcBancosIngresosFactura> AcBancosIngresosFacturas { get; set; }
        public virtual ICollection<AcComplementoPago> AcComplementoPagos { get; set; }
    }
}
