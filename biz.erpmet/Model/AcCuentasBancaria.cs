using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCuentasBancaria
    {
        public AcCuentasBancaria()
        {
            AcBancosEgresos = new HashSet<AcBancosEgreso>();
            AcBancosEstadoCuenta = new HashSet<AcBancosEstadoCuentum>();
            AcBancosIngresos = new HashSet<AcBancosIngreso>();
            AcBancosTraspasoIdCuentaBancariaDestinoNavigations = new HashSet<AcBancosTraspaso>();
            AcBancosTraspasoIdCuentaBancariaOrigenNavigations = new HashSet<AcBancosTraspaso>();
            AcFlujoEfectivoOtrosIngresosEgresos = new HashSet<AcFlujoEfectivoOtrosIngresosEgreso>();
            AcGastosFinancieros = new HashSet<AcGastosFinanciero>();
            CtbPolizas = new HashSet<CtbPoliza>();
            CtbSaldoXflujos = new HashSet<CtbSaldoXflujo>();
            CvDepositosClientes = new HashSet<CvDepositosCliente>();
            CvDepositosSofols = new HashSet<CvDepositosSofol>();
            CvProyectosCuentasDepClientes = new HashSet<CvProyectosCuentasDepCliente>();
            CvProyectosCuentasDepSofoles = new HashSet<CvProyectosCuentasDepSofole>();
            ProyectoIdCtaBancariaSocio1Navigations = new HashSet<Proyecto>();
            ProyectoIdCtaBancariaSocio2Navigations = new HashSet<Proyecto>();
        }

        public int IdCuentaBancaria { get; set; }
        public string Cuenta { get; set; }
        public string Banco { get; set; }
        public string Observaciones { get; set; }
        public int IdCuenta { get; set; }
        public int IdTipoMoneda { get; set; }
        public int ConsecutivoCheque { get; set; }
        public int ConsecutivoTransferencia { get; set; }
        public int ConsecutivoDeposito { get; set; }
        public int ConsecutivoFolio { get; set; }
        public string CuentaClabe { get; set; }
        public bool EsCuentaInversion { get; set; }
        public int? IdBancoSat { get; set; }
        public string BancoSat { get; set; }
        public string MonedaSat { get; set; }
        public string CuentaBancoSat { get; set; }

        public virtual AcCatBancosSat BancoSatNavigation { get; set; }
        public virtual CtbCuenta IdCuentaNavigation { get; set; }
        public virtual AcCatMoneda IdTipoMonedaNavigation { get; set; }
        public virtual CtbCatMonedasSat MonedaSatNavigation { get; set; }
        public virtual ICollection<AcBancosEgreso> AcBancosEgresos { get; set; }
        public virtual ICollection<AcBancosEstadoCuentum> AcBancosEstadoCuenta { get; set; }
        public virtual ICollection<AcBancosIngreso> AcBancosIngresos { get; set; }
        public virtual ICollection<AcBancosTraspaso> AcBancosTraspasoIdCuentaBancariaDestinoNavigations { get; set; }
        public virtual ICollection<AcBancosTraspaso> AcBancosTraspasoIdCuentaBancariaOrigenNavigations { get; set; }
        public virtual ICollection<AcFlujoEfectivoOtrosIngresosEgreso> AcFlujoEfectivoOtrosIngresosEgresos { get; set; }
        public virtual ICollection<AcGastosFinanciero> AcGastosFinancieros { get; set; }
        public virtual ICollection<CtbPoliza> CtbPolizas { get; set; }
        public virtual ICollection<CtbSaldoXflujo> CtbSaldoXflujos { get; set; }
        public virtual ICollection<CvDepositosCliente> CvDepositosClientes { get; set; }
        public virtual ICollection<CvDepositosSofol> CvDepositosSofols { get; set; }
        public virtual ICollection<CvProyectosCuentasDepCliente> CvProyectosCuentasDepClientes { get; set; }
        public virtual ICollection<CvProyectosCuentasDepSofole> CvProyectosCuentasDepSofoles { get; set; }
        public virtual ICollection<Proyecto> ProyectoIdCtaBancariaSocio1Navigations { get; set; }
        public virtual ICollection<Proyecto> ProyectoIdCtaBancariaSocio2Navigations { get; set; }
    }
}
