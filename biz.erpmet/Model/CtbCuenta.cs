using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CtbCuenta
    {
        public CtbCuenta()
        {
            AcBancosEgresosCuenta = new HashSet<AcBancosEgresosCuenta>();
            AcBancosEgresosDets = new HashSet<AcBancosEgresosDet>();
            AcBancosIngresos = new HashSet<AcBancosIngreso>();
            AcBancosIngresosCuenta = new HashSet<AcBancosIngresosCuenta>();
            AcCatAcreedores = new HashSet<AcCatAcreedore>();
            AcCatCategoriasProrrateoIdCuentaAbonoNavigations = new HashSet<AcCatCategoriasProrrateo>();
            AcCatCategoriasProrrateoIdCuentaCargoNavigations = new HashSet<AcCatCategoriasProrrateo>();
            AcCatDeudores = new HashSet<AcCatDeudore>();
            AcCatInsumos = new HashSet<AcCatInsumo>();
            AcCatTipoClientesCuenta = new HashSet<AcCatTipoClientesCuenta>();
            AcCatTipoConceptosClienteIdCuentaIngresoNavigations = new HashSet<AcCatTipoConceptosCliente>();
            AcCatTipoConceptosClienteIdCuentaNcNavigations = new HashSet<AcCatTipoConceptosCliente>();
            AcCatTipoDepositosDets = new HashSet<AcCatTipoDepositosDet>();
            AcCatTipoProveedorCuenta = new HashSet<AcCatTipoProveedorCuenta>();
            AcCatTipoProveedorIdCuentaAnticipoNavigations = new HashSet<AcCatTipoProveedor>();
            AcCatTipoProveedorIdCuentaFonGarNavigations = new HashSet<AcCatTipoProveedor>();
            AcCatTipoProveedorIdCuentaOtrasRetencionesNavigations = new HashSet<AcCatTipoProveedor>();
            AcCatTipoProveedorIdCuentaPagoEnEspecieNavigations = new HashSet<AcCatTipoProveedor>();
            AcCatTipoProveedorIdCuentaProveedorNavigations = new HashSet<AcCatTipoProveedor>();
            AcCatTiposClienteIdCuentaAnticipoNavigations = new HashSet<AcCatTiposCliente>();
            AcCatTiposClienteIdCuentaClienteNavigations = new HashSet<AcCatTiposCliente>();
            AcCatTiposClienteIdCuentaFonGarNavigations = new HashSet<AcCatTiposCliente>();
            AcCatTiposNcIdCuentaDescuentoNavigations = new HashSet<AcCatTiposNc>();
            AcCatTiposNcIdCuentaIvaNavigations = new HashSet<AcCatTiposNc>();
            AcClienteIdCuentaAnticipoNavigations = new HashSet<AcCliente>();
            AcClienteIdCuentaFongarNavigations = new HashSet<AcCliente>();
            AcClientesFacturasCuenta = new HashSet<AcClientesFacturasCuenta>();
            AcClientesFacturasDetCuenta = new HashSet<AcClientesFacturasDetCuenta>();
            AcClientesFacturasNccuenta = new HashSet<AcClientesFacturasNccuenta>();
            AcClientesFacturasNcdetCuenta = new HashSet<AcClientesFacturasNcdetCuenta>();
            AcCuentasBancaria = new HashSet<AcCuentasBancaria>();
            AcFacturasProveedoresCuenta = new HashSet<AcFacturasProveedoresCuenta>();
            AcFacturasProveedoresDets = new HashSet<AcFacturasProveedoresDet>();
            AcFamilia = new HashSet<AcFamilia>();
            AcGastosFinancierosDets = new HashSet<AcGastosFinancierosDet>();
            AcGastosXcomprobarDets = new HashSet<AcGastosXcomprobarDet>();
            AcGastosXcomprobars = new HashSet<AcGastosXcomprobar>();
            AcGeneradorPolizaCuenta = new HashSet<AcGeneradorPolizaCuenta>();
            AcGeneradorPolizaInsumos = new HashSet<AcGeneradorPolizaInsumo>();
            AcModelosPolizaCuenta = new HashSet<AcModelosPolizaCuenta>();
            AcModelosPolizaInsumos = new HashSet<AcModelosPolizaInsumo>();
            AcNominaModelosCuenta = new HashSet<AcNominaModelosCuenta>();
            AcNominaPolizaCuenta = new HashSet<AcNominaPolizaCuenta>();
            AcProveedoreIdCuentaAnticipoNavigations = new HashSet<AcProveedore>();
            AcProveedoreIdCuentaDeudorNavigations = new HashSet<AcProveedore>();
            AcProveedoreIdCuentaFonGarNavigations = new HashSet<AcProveedore>();
            AcProveedoreIdCuentaOtrasRetencionesNavigations = new HashSet<AcProveedore>();
            AcProveedoreIdCuentaPagoEnEspecieNavigations = new HashSet<AcProveedore>();
            AcRelCuentaProyectoDets = new HashSet<AcRelCuentaProyectoDet>();
            AcRelCuentaProyectos = new HashSet<AcRelCuentaProyecto>();
            AgaCmes = new HashSet<AgaCme>();
            AoCatDescuentos = new HashSet<AoCatDescuento>();
            AoCatDestajistaIdCuentaAcreedorNavigations = new HashSet<AoCatDestajista>();
            AoCatDestajistaIdCuentaAnticipoNavigations = new HashSet<AoCatDestajista>();
            AoCatDestajistaIdCuentaViaticosNavigations = new HashSet<AoCatDestajista>();
            CtbPolizasDetPps = new HashSet<CtbPolizasDetPp>();
            CtbPolizasDets = new HashSet<CtbPolizasDet>();
            CtbPolizasDiots = new HashSet<CtbPolizasDiot>();
            CtbSaldosCuentasProyectos = new HashSet<CtbSaldosCuentasProyecto>();
            CvClienteIdCuentaApartadosNavigations = new HashSet<CvCliente>();
            CvClienteIdCuentaGastosAdicionalesNavigations = new HashSet<CvCliente>();
            CvClienteIdCuentaInteresesNavigations = new HashSet<CvCliente>();
            CvClienteIdCuentaMoratoriosNavigations = new HashSet<CvCliente>();
            CvClienteIdCuentaPasivoNavigations = new HashSet<CvCliente>();
            CvClienteIdCuentaPasivoSaldoFavorNavigations = new HashSet<CvCliente>();
            CvDepositosSofolCta = new HashSet<CvDepositosSofolCta>();
            CvPagoLiberacionViviendaIdCuentaCargoNavigations = new HashSet<CvPagoLiberacionVivienda>();
            CvPagoLiberacionViviendaIdCuentaPasivoNavigations = new HashSet<CvPagoLiberacionVivienda>();
            CvPlanesPagoIdCuentaCeNavigations = new HashSet<CvPlanesPago>();
            CvPlanesPagoIdCuentaSeNavigations = new HashSet<CvPlanesPago>();
            CvProyectosCuentasDepClientes = new HashSet<CvProyectosCuentasDepCliente>();
            CvProyectosCuentasNota = new HashSet<CvProyectosCuentasNota>();
            CvProyectosCuentasXplanIdCuentaConEscrituraNavigations = new HashSet<CvProyectosCuentasXplan>();
            CvProyectosCuentasXplanIdCuentaSinEscrituraNavigations = new HashSet<CvProyectosCuentasXplan>();
            InverseIdCtaCostoTacNavigation = new HashSet<CtbCuenta>();
            InverseIdCuentaComplementariaNavigation = new HashSet<CtbCuenta>();
            ProyectoCuentaInterCentroNavigations = new HashSet<Proyecto>();
            ProyectoCvCtaAnticiposClientesNavigations = new HashSet<Proyecto>();
            ProyectoCvCtaApartadosNavigations = new HashSet<Proyecto>();
            ProyectoCvCtaCancelacionIngresosClientesNavigations = new HashSet<Proyecto>();
            ProyectoCvCtaClientesNavigations = new HashSet<Proyecto>();
            ProyectoCvCtaCostoPorCasasNavigations = new HashSet<Proyecto>();
            ProyectoCvCtaCostoPorTerrenosNavigations = new HashSet<Proyecto>();
            ProyectoCvCtaDepPorIdentificarNavigations = new HashSet<Proyecto>();
            ProyectoCvCtaDevolucionesClientesNavigations = new HashSet<Proyecto>();
            ProyectoCvCtaDevolucionesClientesSaldoFavorNavigations = new HashSet<Proyecto>();
            ProyectoCvCtaGastosAdicionalesNavigations = new HashSet<Proyecto>();
            ProyectoCvCtaIngresosPorCancelacionesNavigations = new HashSet<Proyecto>();
            ProyectoCvCtaIngresosPorVentasCasasNavigations = new HashSet<Proyecto>();
            ProyectoCvCtaIngresosPorVentasTerrenosNavigations = new HashSet<Proyecto>();
            ProyectoCvCtaInteresesNavigations = new HashSet<Proyecto>();
            ProyectoCvCtaIvaTrasladadoNavigations = new HashSet<Proyecto>();
            ProyectoCvCtaIvaTrasladadoPorAplicarNavigations = new HashSet<Proyecto>();
            ProyectoCvCtaMoratoriosNavigations = new HashSet<Proyecto>();
            ProyectoCvCtaTraspasoCostoPorCasasNavigations = new HashSet<Proyecto>();
            ProyectoCvCtaTraspasoCostoPorTerrenosNavigations = new HashSet<Proyecto>();
            ProyectoIdCuentaAlmacenNavigations = new HashSet<Proyecto>();
            ProyectoIdCuentaIvaalmacenNavigations = new HashSet<Proyecto>();
            ProyectosDetTacs = new HashSet<ProyectosDetTac>();
            ProyectosPorcenAportSocios = new HashSet<ProyectosPorcenAportSocio>();
        }

        public int IdCuenta { get; set; }
        public string Cuenta { get; set; }
        public string Descripcion { get; set; }
        public int IdTipoCuenta { get; set; }
        public bool? AceptaMov { get; set; }
        public bool EsProveedor { get; set; }
        public bool EsCliente { get; set; }
        public bool? ToparChequeVsSaldo { get; set; }
        public bool EmisionCheque { get; set; }
        public int? IdCuentaComplementaria { get; set; }
        public bool EsDolares { get; set; }
        public int IdTipoMoneda { get; set; }
        public bool PermitirDeposito { get; set; }
        public bool EsDeudor { get; set; }
        public decimal SaldoLimiteDeudor { get; set; }
        public bool EsAcreedor { get; set; }
        public bool EsCuentaIva { get; set; }
        public int? IdConceptoDiot { get; set; }
        public bool PermitirProgramarPago { get; set; }
        public int? IdAgaCatIva { get; set; }
        public int? IdCtaCostoTac { get; set; }
        public int? IdAgrupadorSat { get; set; }
        public string Agrupador { get; set; }

        public virtual AgaCatIva IdAgaCatIvaNavigation { get; set; }
        public virtual CtbConceptosDiot IdConceptoDiotNavigation { get; set; }
        public virtual CtbCuenta IdCtaCostoTacNavigation { get; set; }
        public virtual CtbCuenta IdCuentaComplementariaNavigation { get; set; }
        public virtual CtbTiposCuentum IdTipoCuentaNavigation { get; set; }
        public virtual AcCatMoneda IdTipoMonedaNavigation { get; set; }
        public virtual AcCliente AcClienteIdCuentaNavigation { get; set; }
        public virtual AcProveedore AcProveedoreIdCuentaProveedorNavigation { get; set; }
        public virtual CtbCuentasDiot CtbCuentasDiot { get; set; }
        public virtual ParametrosCtasAntiLavado ParametrosCtasAntiLavado { get; set; }
        public virtual ICollection<AcBancosEgresosCuenta> AcBancosEgresosCuenta { get; set; }
        public virtual ICollection<AcBancosEgresosDet> AcBancosEgresosDets { get; set; }
        public virtual ICollection<AcBancosIngreso> AcBancosIngresos { get; set; }
        public virtual ICollection<AcBancosIngresosCuenta> AcBancosIngresosCuenta { get; set; }
        public virtual ICollection<AcCatAcreedore> AcCatAcreedores { get; set; }
        public virtual ICollection<AcCatCategoriasProrrateo> AcCatCategoriasProrrateoIdCuentaAbonoNavigations { get; set; }
        public virtual ICollection<AcCatCategoriasProrrateo> AcCatCategoriasProrrateoIdCuentaCargoNavigations { get; set; }
        public virtual ICollection<AcCatDeudore> AcCatDeudores { get; set; }
        public virtual ICollection<AcCatInsumo> AcCatInsumos { get; set; }
        public virtual ICollection<AcCatTipoClientesCuenta> AcCatTipoClientesCuenta { get; set; }
        public virtual ICollection<AcCatTipoConceptosCliente> AcCatTipoConceptosClienteIdCuentaIngresoNavigations { get; set; }
        public virtual ICollection<AcCatTipoConceptosCliente> AcCatTipoConceptosClienteIdCuentaNcNavigations { get; set; }
        public virtual ICollection<AcCatTipoDepositosDet> AcCatTipoDepositosDets { get; set; }
        public virtual ICollection<AcCatTipoProveedorCuenta> AcCatTipoProveedorCuenta { get; set; }
        public virtual ICollection<AcCatTipoProveedor> AcCatTipoProveedorIdCuentaAnticipoNavigations { get; set; }
        public virtual ICollection<AcCatTipoProveedor> AcCatTipoProveedorIdCuentaFonGarNavigations { get; set; }
        public virtual ICollection<AcCatTipoProveedor> AcCatTipoProveedorIdCuentaOtrasRetencionesNavigations { get; set; }
        public virtual ICollection<AcCatTipoProveedor> AcCatTipoProveedorIdCuentaPagoEnEspecieNavigations { get; set; }
        public virtual ICollection<AcCatTipoProveedor> AcCatTipoProveedorIdCuentaProveedorNavigations { get; set; }
        public virtual ICollection<AcCatTiposCliente> AcCatTiposClienteIdCuentaAnticipoNavigations { get; set; }
        public virtual ICollection<AcCatTiposCliente> AcCatTiposClienteIdCuentaClienteNavigations { get; set; }
        public virtual ICollection<AcCatTiposCliente> AcCatTiposClienteIdCuentaFonGarNavigations { get; set; }
        public virtual ICollection<AcCatTiposNc> AcCatTiposNcIdCuentaDescuentoNavigations { get; set; }
        public virtual ICollection<AcCatTiposNc> AcCatTiposNcIdCuentaIvaNavigations { get; set; }
        public virtual ICollection<AcCliente> AcClienteIdCuentaAnticipoNavigations { get; set; }
        public virtual ICollection<AcCliente> AcClienteIdCuentaFongarNavigations { get; set; }
        public virtual ICollection<AcClientesFacturasCuenta> AcClientesFacturasCuenta { get; set; }
        public virtual ICollection<AcClientesFacturasDetCuenta> AcClientesFacturasDetCuenta { get; set; }
        public virtual ICollection<AcClientesFacturasNccuenta> AcClientesFacturasNccuenta { get; set; }
        public virtual ICollection<AcClientesFacturasNcdetCuenta> AcClientesFacturasNcdetCuenta { get; set; }
        public virtual ICollection<AcCuentasBancaria> AcCuentasBancaria { get; set; }
        public virtual ICollection<AcFacturasProveedoresCuenta> AcFacturasProveedoresCuenta { get; set; }
        public virtual ICollection<AcFacturasProveedoresDet> AcFacturasProveedoresDets { get; set; }
        public virtual ICollection<AcFamilia> AcFamilia { get; set; }
        public virtual ICollection<AcGastosFinancierosDet> AcGastosFinancierosDets { get; set; }
        public virtual ICollection<AcGastosXcomprobarDet> AcGastosXcomprobarDets { get; set; }
        public virtual ICollection<AcGastosXcomprobar> AcGastosXcomprobars { get; set; }
        public virtual ICollection<AcGeneradorPolizaCuenta> AcGeneradorPolizaCuenta { get; set; }
        public virtual ICollection<AcGeneradorPolizaInsumo> AcGeneradorPolizaInsumos { get; set; }
        public virtual ICollection<AcModelosPolizaCuenta> AcModelosPolizaCuenta { get; set; }
        public virtual ICollection<AcModelosPolizaInsumo> AcModelosPolizaInsumos { get; set; }
        public virtual ICollection<AcNominaModelosCuenta> AcNominaModelosCuenta { get; set; }
        public virtual ICollection<AcNominaPolizaCuenta> AcNominaPolizaCuenta { get; set; }
        public virtual ICollection<AcProveedore> AcProveedoreIdCuentaAnticipoNavigations { get; set; }
        public virtual ICollection<AcProveedore> AcProveedoreIdCuentaDeudorNavigations { get; set; }
        public virtual ICollection<AcProveedore> AcProveedoreIdCuentaFonGarNavigations { get; set; }
        public virtual ICollection<AcProveedore> AcProveedoreIdCuentaOtrasRetencionesNavigations { get; set; }
        public virtual ICollection<AcProveedore> AcProveedoreIdCuentaPagoEnEspecieNavigations { get; set; }
        public virtual ICollection<AcRelCuentaProyectoDet> AcRelCuentaProyectoDets { get; set; }
        public virtual ICollection<AcRelCuentaProyecto> AcRelCuentaProyectos { get; set; }
        public virtual ICollection<AgaCme> AgaCmes { get; set; }
        public virtual ICollection<AoCatDescuento> AoCatDescuentos { get; set; }
        public virtual ICollection<AoCatDestajista> AoCatDestajistaIdCuentaAcreedorNavigations { get; set; }
        public virtual ICollection<AoCatDestajista> AoCatDestajistaIdCuentaAnticipoNavigations { get; set; }
        public virtual ICollection<AoCatDestajista> AoCatDestajistaIdCuentaViaticosNavigations { get; set; }
        public virtual ICollection<CtbPolizasDetPp> CtbPolizasDetPps { get; set; }
        public virtual ICollection<CtbPolizasDet> CtbPolizasDets { get; set; }
        public virtual ICollection<CtbPolizasDiot> CtbPolizasDiots { get; set; }
        public virtual ICollection<CtbSaldosCuentasProyecto> CtbSaldosCuentasProyectos { get; set; }
        public virtual ICollection<CvCliente> CvClienteIdCuentaApartadosNavigations { get; set; }
        public virtual ICollection<CvCliente> CvClienteIdCuentaGastosAdicionalesNavigations { get; set; }
        public virtual ICollection<CvCliente> CvClienteIdCuentaInteresesNavigations { get; set; }
        public virtual ICollection<CvCliente> CvClienteIdCuentaMoratoriosNavigations { get; set; }
        public virtual ICollection<CvCliente> CvClienteIdCuentaPasivoNavigations { get; set; }
        public virtual ICollection<CvCliente> CvClienteIdCuentaPasivoSaldoFavorNavigations { get; set; }
        public virtual ICollection<CvDepositosSofolCta> CvDepositosSofolCta { get; set; }
        public virtual ICollection<CvPagoLiberacionVivienda> CvPagoLiberacionViviendaIdCuentaCargoNavigations { get; set; }
        public virtual ICollection<CvPagoLiberacionVivienda> CvPagoLiberacionViviendaIdCuentaPasivoNavigations { get; set; }
        public virtual ICollection<CvPlanesPago> CvPlanesPagoIdCuentaCeNavigations { get; set; }
        public virtual ICollection<CvPlanesPago> CvPlanesPagoIdCuentaSeNavigations { get; set; }
        public virtual ICollection<CvProyectosCuentasDepCliente> CvProyectosCuentasDepClientes { get; set; }
        public virtual ICollection<CvProyectosCuentasNota> CvProyectosCuentasNota { get; set; }
        public virtual ICollection<CvProyectosCuentasXplan> CvProyectosCuentasXplanIdCuentaConEscrituraNavigations { get; set; }
        public virtual ICollection<CvProyectosCuentasXplan> CvProyectosCuentasXplanIdCuentaSinEscrituraNavigations { get; set; }
        public virtual ICollection<CtbCuenta> InverseIdCtaCostoTacNavigation { get; set; }
        public virtual ICollection<CtbCuenta> InverseIdCuentaComplementariaNavigation { get; set; }
        public virtual ICollection<Proyecto> ProyectoCuentaInterCentroNavigations { get; set; }
        public virtual ICollection<Proyecto> ProyectoCvCtaAnticiposClientesNavigations { get; set; }
        public virtual ICollection<Proyecto> ProyectoCvCtaApartadosNavigations { get; set; }
        public virtual ICollection<Proyecto> ProyectoCvCtaCancelacionIngresosClientesNavigations { get; set; }
        public virtual ICollection<Proyecto> ProyectoCvCtaClientesNavigations { get; set; }
        public virtual ICollection<Proyecto> ProyectoCvCtaCostoPorCasasNavigations { get; set; }
        public virtual ICollection<Proyecto> ProyectoCvCtaCostoPorTerrenosNavigations { get; set; }
        public virtual ICollection<Proyecto> ProyectoCvCtaDepPorIdentificarNavigations { get; set; }
        public virtual ICollection<Proyecto> ProyectoCvCtaDevolucionesClientesNavigations { get; set; }
        public virtual ICollection<Proyecto> ProyectoCvCtaDevolucionesClientesSaldoFavorNavigations { get; set; }
        public virtual ICollection<Proyecto> ProyectoCvCtaGastosAdicionalesNavigations { get; set; }
        public virtual ICollection<Proyecto> ProyectoCvCtaIngresosPorCancelacionesNavigations { get; set; }
        public virtual ICollection<Proyecto> ProyectoCvCtaIngresosPorVentasCasasNavigations { get; set; }
        public virtual ICollection<Proyecto> ProyectoCvCtaIngresosPorVentasTerrenosNavigations { get; set; }
        public virtual ICollection<Proyecto> ProyectoCvCtaInteresesNavigations { get; set; }
        public virtual ICollection<Proyecto> ProyectoCvCtaIvaTrasladadoNavigations { get; set; }
        public virtual ICollection<Proyecto> ProyectoCvCtaIvaTrasladadoPorAplicarNavigations { get; set; }
        public virtual ICollection<Proyecto> ProyectoCvCtaMoratoriosNavigations { get; set; }
        public virtual ICollection<Proyecto> ProyectoCvCtaTraspasoCostoPorCasasNavigations { get; set; }
        public virtual ICollection<Proyecto> ProyectoCvCtaTraspasoCostoPorTerrenosNavigations { get; set; }
        public virtual ICollection<Proyecto> ProyectoIdCuentaAlmacenNavigations { get; set; }
        public virtual ICollection<Proyecto> ProyectoIdCuentaIvaalmacenNavigations { get; set; }
        public virtual ICollection<ProyectosDetTac> ProyectosDetTacs { get; set; }
        public virtual ICollection<ProyectosPorcenAportSocio> ProyectosPorcenAportSocios { get; set; }
    }
}
