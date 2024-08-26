using System;
using biz.erpmet.Entities;
using biz.erpmet.Model;
using dal.erpmet.Repository.FinancialReport;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
namespace dal.erpmet.DBContext
{
    public partial class ERPMETContext : DbContext
    {
        public ERPMETContext()
        {
        }

        public ERPMETContext(DbContextOptions<ERPMETContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AcAceptaRechazaCancelacionHist> AcAceptaRechazaCancelacionHists { get; set; }
        public virtual DbSet<AcAddendasCampo> AcAddendasCampos { get; set; }
        public virtual DbSet<AcAddendasProducto> AcAddendasProductos { get; set; }
        public virtual DbSet<AcAditivasExplosion> AcAditivasExplosions { get; set; }
        public virtual DbSet<AcAditivasExplosionDet> AcAditivasExplosionDets { get; set; }
        public virtual DbSet<AcAjustesPedido> AcAjustesPedidos { get; set; }
        public virtual DbSet<AcAlmacenConsecutivo> AcAlmacenConsecutivos { get; set; }
        public virtual DbSet<AcAlmacenEntrada> AcAlmacenEntradas { get; set; }
        public virtual DbSet<AcAlmacenEntradasDet> AcAlmacenEntradasDets { get; set; }
        public virtual DbSet<AcAlmacenOproduccion> AcAlmacenOproduccions { get; set; }
        public virtual DbSet<AcAlmacenOproduccionDet> AcAlmacenOproduccionDets { get; set; }
        public virtual DbSet<AcAlmacenSalida> AcAlmacenSalidas { get; set; }
        public virtual DbSet<AcAlmacenSalidaDetCc> AcAlmacenSalidaDetCcs { get; set; }
        public virtual DbSet<AcAlmacenSalidasDet> AcAlmacenSalidasDets { get; set; }
        public virtual DbSet<AcAlmacenTraspaso> AcAlmacenTraspasos { get; set; }
        public virtual DbSet<AcAlmacenTraspasosDet> AcAlmacenTraspasosDets { get; set; }
        public virtual DbSet<AcAlmacenUbicacione> AcAlmacenUbicaciones { get; set; }
        public virtual DbSet<AcBancosEgreso> AcBancosEgresos { get; set; }
        public virtual DbSet<AcBancosEgresosCuenta> AcBancosEgresosCuentas { get; set; }
        public virtual DbSet<AcBancosEgresosDet> AcBancosEgresosDets { get; set; }
        public virtual DbSet<AcBancosEgresosInsumo> AcBancosEgresosInsumos { get; set; }
        public virtual DbSet<AcBancosEstadoCuentum> AcBancosEstadoCuenta { get; set; }
        public virtual DbSet<AcBancosIngreso> AcBancosIngresos { get; set; }
        public virtual DbSet<AcBancosIngresosCuenta> AcBancosIngresosCuentas { get; set; }
        public virtual DbSet<AcBancosIngresosFactura> AcBancosIngresosFacturas { get; set; }
        public virtual DbSet<AcBancosTraspaso> AcBancosTraspasos { get; set; }
        public virtual DbSet<AcCatAcreedore> AcCatAcreedores { get; set; }
        public virtual DbSet<AcCatAduanasSat> AcCatAduanasSats { get; set; }
        public virtual DbSet<AcCatBancosSat> AcCatBancosSats { get; set; }
        public virtual DbSet<AcCatCategoriasProrrateo> AcCatCategoriasProrrateos { get; set; }
        public virtual DbSet<AcCatCiudade> AcCatCiudades { get; set; }
        public virtual DbSet<AcCatClavesTransferencia> AcCatClavesTransferencias { get; set; }
        public virtual DbSet<AcCatCodigosPostalesSat> AcCatCodigosPostalesSats { get; set; }
        public virtual DbSet<AcCatConceptosIetu> AcCatConceptosIetus { get; set; }
        public virtual DbSet<AcCatContratosStatus> AcCatContratosStatuses { get; set; }
        public virtual DbSet<AcCatDeudore> AcCatDeudores { get; set; }
        public virtual DbSet<AcCatEstado> AcCatEstados { get; set; }
        public virtual DbSet<AcCatFlujo> AcCatFlujos { get; set; }
        public virtual DbSet<AcCatFlujoEfectivoOtrosIngresosEgreso> AcCatFlujoEfectivoOtrosIngresosEgresos { get; set; }
        public virtual DbSet<AcCatFormasPagoSat> AcCatFormasPagoSats { get; set; }
        public virtual DbSet<AcCatGiro> AcCatGiros { get; set; }
        public virtual DbSet<AcCatInsumo> AcCatInsumos { get; set; }
        public virtual DbSet<AcCatInsumosProrrateo> AcCatInsumosProrrateos { get; set; }
        public virtual DbSet<AcCatMetodosPagoSat> AcCatMetodosPagoSats { get; set; }
        public virtual DbSet<AcCatMoneda> AcCatMonedas { get; set; }
        public virtual DbSet<AcCatMonedasDet> AcCatMonedasDets { get; set; }
        public virtual DbSet<AcCatNumsPedimentoAdSat> AcCatNumsPedimentoAdSats { get; set; }
        public virtual DbSet<AcCatPaise> AcCatPaises { get; set; }
        public virtual DbSet<AcCatPartidaFlujo> AcCatPartidaFlujos { get; set; }
        public virtual DbSet<AcCatPatentesAduanalesSat> AcCatPatentesAduanalesSats { get; set; }
        public virtual DbSet<AcCatPlantillasCorreo> AcCatPlantillasCorreos { get; set; }
        public virtual DbSet<AcCatProductosServicioSat> AcCatProductosServicioSats { get; set; }
        public virtual DbSet<AcCatRegimenesFiscalesSat> AcCatRegimenesFiscalesSats { get; set; }
        public virtual DbSet<AcCatTasaOcuotaSat> AcCatTasaOcuotaSats { get; set; }
        public virtual DbSet<AcCatTipoCheque> AcCatTipoCheques { get; set; }
        public virtual DbSet<AcCatTipoChequeDet> AcCatTipoChequeDets { get; set; }
        public virtual DbSet<AcCatTipoClientesCuenta> AcCatTipoClientesCuentas { get; set; }
        public virtual DbSet<AcCatTipoConceptosCliente> AcCatTipoConceptosClientes { get; set; }
        public virtual DbSet<AcCatTipoDeposito> AcCatTipoDepositos { get; set; }
        public virtual DbSet<AcCatTipoDepositosDet> AcCatTipoDepositosDets { get; set; }
        public virtual DbSet<AcCatTipoProveedor> AcCatTipoProveedors { get; set; }
        public virtual DbSet<AcCatTipoProveedorCuenta> AcCatTipoProveedorCuentas { get; set; }
        public virtual DbSet<AcCatTipoUnidadesNegocio> AcCatTipoUnidadesNegocios { get; set; }
        public virtual DbSet<AcCatTiposCliente> AcCatTiposClientes { get; set; }
        public virtual DbSet<AcCatTiposComprobanteSat> AcCatTiposComprobanteSats { get; set; }
        public virtual DbSet<AcCatTiposFactorSat> AcCatTiposFactorSats { get; set; }
        public virtual DbSet<AcCatTiposImpuesto> AcCatTiposImpuestos { get; set; }
        public virtual DbSet<AcCatTiposNc> AcCatTiposNcs { get; set; }
        public virtual DbSet<AcCatTiposRelacionSat> AcCatTiposRelacionSats { get; set; }
        public virtual DbSet<AcCatTiposRetencione> AcCatTiposRetenciones { get; set; }
        public virtual DbSet<AcCatUnidade> AcCatUnidades { get; set; }
        public virtual DbSet<AcCatUnidadesSat> AcCatUnidadesSats { get; set; }
        public virtual DbSet<AcCatUsosCfdisat> AcCatUsosCfdisats { get; set; }
        public virtual DbSet<AcCfditraslado> AcCfditraslados { get; set; }
        public virtual DbSet<AcCfditrasladoCfd> AcCfditrasladoCfds { get; set; }
        public virtual DbSet<AcCfditrasladoDet> AcCfditrasladoDets { get; set; }
        public virtual DbSet<AcCfditrasladoDireccione> AcCfditrasladoDirecciones { get; set; }
        public virtual DbSet<AcCfditrasladoRelac> AcCfditrasladoRelacs { get; set; }
        public virtual DbSet<AcCliente> AcClientes { get; set; }
        public virtual DbSet<AcClientesAddenda> AcClientesAddendas { get; set; }
        public virtual DbSet<AcClientesAntilavado> AcClientesAntilavados { get; set; }
        public virtual DbSet<AcClientesAntilavadoDet> AcClientesAntilavadoDets { get; set; }
        public virtual DbSet<AcClientesConsecutivo> AcClientesConsecutivos { get; set; }
        public virtual DbSet<AcClientesFactura> AcClientesFacturas { get; set; }
        public virtual DbSet<AcClientesFacturas2017> AcClientesFacturas2017s { get; set; }
        public virtual DbSet<AcClientesFacturasCfd> AcClientesFacturasCfds { get; set; }
        public virtual DbSet<AcClientesFacturasCfdirelac> AcClientesFacturasCfdirelacs { get; set; }
        public virtual DbSet<AcClientesFacturasCuenta> AcClientesFacturasCuentas { get; set; }
        public virtual DbSet<AcClientesFacturasDet> AcClientesFacturasDets { get; set; }
        public virtual DbSet<AcClientesFacturasDetAduana> AcClientesFacturasDetAduanas { get; set; }
        public virtual DbSet<AcClientesFacturasDetCuenta> AcClientesFacturasDetCuentas { get; set; }
        public virtual DbSet<AcClientesFacturasNc> AcClientesFacturasNcs { get; set; }
        public virtual DbSet<AcClientesFacturasNc2017> AcClientesFacturasNc2017s { get; set; }
        public virtual DbSet<AcClientesFacturasNcCfd> AcClientesFacturasNcCfds { get; set; }
        public virtual DbSet<AcClientesFacturasNccfdirelac> AcClientesFacturasNccfdirelacs { get; set; }
        public virtual DbSet<AcClientesFacturasNccuenta> AcClientesFacturasNccuentas { get; set; }
        public virtual DbSet<AcClientesFacturasNcdet> AcClientesFacturasNcdets { get; set; }
        public virtual DbSet<AcClientesFacturasNcdetCuenta> AcClientesFacturasNcdetCuentas { get; set; }
        public virtual DbSet<AcClientesObra> AcClientesObras { get; set; }
        public virtual DbSet<AcClientesOperadore> AcClientesOperadores { get; set; }
        public virtual DbSet<AcClientesPlanta> AcClientesPlantas { get; set; }
        public virtual DbSet<AcClientesRemisione> AcClientesRemisiones { get; set; }
        public virtual DbSet<AcClientesRemisionesDet> AcClientesRemisionesDets { get; set; }
        public virtual DbSet<AcClientesResponsablesRemisione> AcClientesResponsablesRemisiones { get; set; }
        public virtual DbSet<AcClientesSolicitante> AcClientesSolicitantes { get; set; }
        public virtual DbSet<AcClientesTransporte> AcClientesTransportes { get; set; }
        public virtual DbSet<AcComplementoPago> AcComplementoPagos { get; set; }
        public virtual DbSet<AcComplementoPagoCfd> AcComplementoPagoCfds { get; set; }
        public virtual DbSet<AcComplementoPagoCfdrelac> AcComplementoPagoCfdrelacs { get; set; }
        public virtual DbSet<AcComplementoPagoDet> AcComplementoPagoDets { get; set; }
        public virtual DbSet<AcConceptosDetNc> AcConceptosDetNcs { get; set; }
        public virtual DbSet<AcCondicionesPago> AcCondicionesPagos { get; set; }
        public virtual DbSet<AcConsecutivosCuenta> AcConsecutivosCuentas { get; set; }
        public virtual DbSet<AcConstanciasRetencione> AcConstanciasRetenciones { get; set; }
        public virtual DbSet<AcConstanciasRetencionesCfd> AcConstanciasRetencionesCfds { get; set; }
        public virtual DbSet<AcConstanciasRetencionesDet> AcConstanciasRetencionesDets { get; set; }
        public virtual DbSet<AcContrato> AcContratos { get; set; }
        public virtual DbSet<AcContratosDatosAdicSeguridad> AcContratosDatosAdicSeguridads { get; set; }
        public virtual DbSet<AcContratosDatosAdicionale> AcContratosDatosAdicionales { get; set; }
        public virtual DbSet<AcContratosDet> AcContratosDets { get; set; }
        public virtual DbSet<AcContratosOc> AcContratosOcs { get; set; }
        public virtual DbSet<AcContratosOcdet> AcContratosOcdets { get; set; }
        public virtual DbSet<AcCostosXproyecto> AcCostosXproyectos { get; set; }
        public virtual DbSet<AcCuentasBancaria> AcCuentasBancarias { get; set; }
        public virtual DbSet<AcExplosionInsumo> AcExplosionInsumos { get; set; }
        public virtual DbSet<AcFacturasAddendasCampo> AcFacturasAddendasCampos { get; set; }
        public virtual DbSet<AcFacturasAddendasProducto> AcFacturasAddendasProductos { get; set; }
        public virtual DbSet<AcFacturasProveedore> AcFacturasProveedores { get; set; }
        public virtual DbSet<AcFacturasProveedoresCuenta> AcFacturasProveedoresCuentas { get; set; }
        public virtual DbSet<AcFacturasProveedoresDet> AcFacturasProveedoresDets { get; set; }
        public virtual DbSet<AcFacturasProveedoresNc> AcFacturasProveedoresNcs { get; set; }
        public virtual DbSet<AcFacturasSeries> AcFacturasSeries { get; set; }
        public virtual DbSet<AcFamilia> AcFamilias { get; set; }
        public virtual DbSet<AcFlujoEfectivoOtrosIngresosEgreso> AcFlujoEfectivoOtrosIngresosEgresos { get; set; }
        public virtual DbSet<AcGastosFinanciero> AcGastosFinancieros { get; set; }
        public virtual DbSet<AcGastosFinancierosDet> AcGastosFinancierosDets { get; set; }
        public virtual DbSet<AcGastosXcomprobar> AcGastosXcomprobars { get; set; }
        public virtual DbSet<AcGastosXcomprobarDet> AcGastosXcomprobarDets { get; set; }
        public virtual DbSet<AcGastosXcomprobarDetDiot> AcGastosXcomprobarDetDiots { get; set; }
        public virtual DbSet<AcGeneradorPoliza> AcGeneradorPolizas { get; set; }
        public virtual DbSet<AcGeneradorPolizaCuenta> AcGeneradorPolizaCuentas { get; set; }
        public virtual DbSet<AcGeneradorPolizaInsumo> AcGeneradorPolizaInsumos { get; set; }
        public virtual DbSet<AcLayoutCw> AcLayoutCws { get; set; }
        public virtual DbSet<AcLayoutCwdet> AcLayoutCwdets { get; set; }
        public virtual DbSet<AcMetodoPago> AcMetodoPagos { get; set; }
        public virtual DbSet<AcModelosPoliza> AcModelosPolizas { get; set; }
        public virtual DbSet<AcModelosPolizaCuenta> AcModelosPolizaCuentas { get; set; }
        public virtual DbSet<AcModelosPolizaInsumo> AcModelosPolizaInsumos { get; set; }
        public virtual DbSet<AcNominaCatalogoConcepto> AcNominaCatalogoConceptos { get; set; }
        public virtual DbSet<AcNominaModelo> AcNominaModelos { get; set; }
        public virtual DbSet<AcNominaModelosCuenta> AcNominaModelosCuentas { get; set; }
        public virtual DbSet<AcNominaModelosInsumo> AcNominaModelosInsumos { get; set; }
        public virtual DbSet<AcNominaPoliza> AcNominaPolizas { get; set; }
        public virtual DbSet<AcNominaPolizaCuenta> AcNominaPolizaCuentas { get; set; }
        public virtual DbSet<AcNominaPolizaInsumo> AcNominaPolizaInsumos { get; set; }
        public virtual DbSet<AcNominaTipo> AcNominaTipos { get; set; }
        public virtual DbSet<AcOrdenProduccion> AcOrdenProduccions { get; set; }
        public virtual DbSet<AcOrdenProduccionDet> AcOrdenProduccionDets { get; set; }
        public virtual DbSet<AcPedido> AcPedidos { get; set; }
        public virtual DbSet<AcPedidosBitacora> AcPedidosBitacoras { get; set; }
        public virtual DbSet<AcPedidosDescuento> AcPedidosDescuentos { get; set; }
        public virtual DbSet<AcPedidosDet> AcPedidosDets { get; set; }
        public virtual DbSet<AcProrrateoCosto> AcProrrateoCostos { get; set; }
        public virtual DbSet<AcProrrateoCostosDet> AcProrrateoCostosDets { get; set; }
        public virtual DbSet<AcProveedore> AcProveedores { get; set; }
        public virtual DbSet<AcProveedoresCertificado> AcProveedoresCertificados { get; set; }
        public virtual DbSet<AcProveedoresCfd> AcProveedoresCfds { get; set; }
        public virtual DbSet<AcProveedoresXml> AcProveedoresXmls { get; set; }
        public virtual DbSet<AcProveedoresXmldocRel> AcProveedoresXmldocRels { get; set; }
        public virtual DbSet<AcProyectoConcepto> AcProyectoConceptos { get; set; }
        public virtual DbSet<AcProyectoPartida> AcProyectoPartidas { get; set; }
        public virtual DbSet<AcProyectosConsecutivo> AcProyectosConsecutivos { get; set; }
        public virtual DbSet<AcProyectosNominaModelo> AcProyectosNominaModelos { get; set; }
        public virtual DbSet<AcRelAforoProyecto> AcRelAforoProyectos { get; set; }
        public virtual DbSet<AcRelClienteCfdiEgreso> AcRelClienteCfdiEgresos { get; set; }
        public virtual DbSet<AcRelCuentaProyecto> AcRelCuentaProyectos { get; set; }
        public virtual DbSet<AcRelCuentaProyectoDet> AcRelCuentaProyectoDets { get; set; }
        public virtual DbSet<AcRelInterestaProyecto> AcRelInterestaProyectos { get; set; }
        public virtual DbSet<AcRelRemanentesProyecto> AcRelRemanentesProyectos { get; set; }
        public virtual DbSet<AcRelSeleccionProyecto> AcRelSeleccionProyectos { get; set; }
        public virtual DbSet<AcRelSeleccionProyectoAcum> AcRelSeleccionProyectoAcums { get; set; }
        public virtual DbSet<AcRequisicionBitacora> AcRequisicionBitacoras { get; set; }
        public virtual DbSet<AcRequisicionDet> AcRequisicionDets { get; set; }
        public virtual DbSet<AcRequisicione> AcRequisiciones { get; set; }
        public virtual DbSet<AcSolicitudMaterial> AcSolicitudMaterials { get; set; }
        public virtual DbSet<AcSolicitudMaterialDet> AcSolicitudMaterialDets { get; set; }
        public virtual DbSet<AcTipDocAlmacen> AcTipDocAlmacens { get; set; }
        public virtual DbSet<AcTipoFiscal> AcTipoFiscals { get; set; }
        public virtual DbSet<AcTipoMovBanco> AcTipoMovBancos { get; set; }
        public virtual DbSet<AcTiposCuadrillaNomina> AcTiposCuadrillaNominas { get; set; }
        public virtual DbSet<AcTiposInsumo> AcTiposInsumos { get; set; }
        public virtual DbSet<AcUnidadesNegocio> AcUnidadesNegocios { get; set; }
        public virtual DbSet<AcactivoFijo> AcactivoFijos { get; set; }
        public virtual DbSet<AcactivoFijoDet> AcactivoFijoDets { get; set; }
        public virtual DbSet<AcactivoFijoFoto> AcactivoFijoFotos { get; set; }
        public virtual DbSet<AcalmacenSaldosMensuale> AcalmacenSaldosMensuales { get; set; }
        public virtual DbSet<AccategoriaActivoFijo> AccategoriaActivoFijos { get; set; }
        public virtual DbSet<AcproveedoresInsumo> AcproveedoresInsumos { get; set; }
        public virtual DbSet<Acresponsable> Acresponsables { get; set; }
        public virtual DbSet<AgaCatAcreedore> AgaCatAcreedores { get; set; }
        public virtual DbSet<AgaCatIva> AgaCatIvas { get; set; }
        public virtual DbSet<AgaCme> AgaCmes { get; set; }
        public virtual DbSet<AoAnticiposDestajista> AoAnticiposDestajistas { get; set; }
        public virtual DbSet<AoAvanceDiario> AoAvanceDiarios { get; set; }
        public virtual DbSet<AoCatConcepto> AoCatConceptos { get; set; }
        public virtual DbSet<AoCatContratista> AoCatContratistas { get; set; }
        public virtual DbSet<AoCatDescuento> AoCatDescuentos { get; set; }
        public virtual DbSet<AoCatDestajista> AoCatDestajistas { get; set; }
        public virtual DbSet<AoConceptosXdestajistum> AoConceptosXdestajista { get; set; }
        public virtual DbSet<AoDestajistasContratistasPu2010> AoDestajistasContratistasPu2010s { get; set; }
        public virtual DbSet<AoDestajosEst> AoDestajosEsts { get; set; }
        public virtual DbSet<AoDestajosEstCc> AoDestajosEstCcs { get; set; }
        public virtual DbSet<AoDestajosEstDet> AoDestajosEstDets { get; set; }
        public virtual DbSet<AoDestajosFolio> AoDestajosFolios { get; set; }
        public virtual DbSet<AoExpXconcepto> AoExpXconceptos { get; set; }
        public virtual DbSet<AoExpXpartidum> AoExpXpartida { get; set; }
        public virtual DbSet<AoMatrizOc> AoMatrizOcs { get; set; }
        public virtual DbSet<AoMatrizOcdet> AoMatrizOcdets { get; set; }
        public virtual DbSet<AoPartida> AoPartidas { get; set; }
        public virtual DbSet<AoPartidasAvanceFisico> AoPartidasAvanceFisicos { get; set; }
        public virtual DbSet<AoPartidasAvanceFisicoDet> AoPartidasAvanceFisicoDets { get; set; }
        public virtual DbSet<AoPresupuestoControl> AoPresupuestoControls { get; set; }
        public virtual DbSet<AoPresupuestoControlOc> AoPresupuestoControlOcs { get; set; }
        public virtual DbSet<AoPresupuestoControlOcdet> AoPresupuestoControlOcdets { get; set; }
        public virtual DbSet<AoPresupuestoControlPeriodo> AoPresupuestoControlPeriodos { get; set; }
        public virtual DbSet<AoPresupuestoControlPrecedencia> AoPresupuestoControlPrecedencias { get; set; }
        public virtual DbSet<AoProgramaObra> AoProgramaObras { get; set; }
        public virtual DbSet<AoProgramaSuministro> AoProgramaSuministros { get; set; }
        public virtual DbSet<AoPrototipo> AoPrototipos { get; set; }
        public virtual DbSet<AoPrototiposDet> AoPrototiposDets { get; set; }
        public virtual DbSet<AoSubContrato> AoSubContratos { get; set; }
        public virtual DbSet<AoSubContratosEst> AoSubContratosEsts { get; set; }
        public virtual DbSet<AoSubContratosEstDescuento> AoSubContratosEstDescuentos { get; set; }
        public virtual DbSet<AoSubContratosEstDet> AoSubContratosEstDets { get; set; }
        public virtual DbSet<AoSubContratosEstDetCc> AoSubContratosEstDetCcs { get; set; }
        public virtual DbSet<AoSubcontratosDet> AoSubcontratosDets { get; set; }
        public virtual DbSet<AoSubcontratosDetCosto> AoSubcontratosDetCostos { get; set; }
        public virtual DbSet<AoSubcontratosOc> AoSubcontratosOcs { get; set; }
        public virtual DbSet<AoSubcontratosOcdet> AoSubcontratosOcdets { get; set; }
        public virtual DbSet<AoestimadoTerminacion> AoestimadoTerminacions { get; set; }
        public virtual DbSet<AoestimadoTerminacionDetalle> AoestimadoTerminacionDetalles { get; set; }
        public virtual DbSet<Aomizar> Aomizars { get; set; }
        public virtual DbSet<AomizarDet> AomizarDets { get; set; }
        public virtual DbSet<AoplantillasContrato> AoplantillasContratos { get; set; }
        public virtual DbSet<AotipoProyecto> AotipoProyectos { get; set; }
        public virtual DbSet<AounidadNegociogeo> AounidadNegociogeos { get; set; }
        public virtual DbSet<BiCatModulo> BiCatModulos { get; set; }
        public virtual DbSet<BiCatProceso> BiCatProcesos { get; set; }
        public virtual DbSet<BiHistorico> BiHistoricos { get; set; }
        public virtual DbSet<BiHistoricoDet> BiHistoricoDets { get; set; }
        public virtual DbSet<BiTabla> BiTablas { get; set; }
        public virtual DbSet<Bitacora> Bitacoras { get; set; }
        public virtual DbSet<Centro> Centros { get; set; }
        public virtual DbSet<CrmAddendasCampo> CrmAddendasCampos { get; set; }
        public virtual DbSet<CrmAddendasProducto> CrmAddendasProductos { get; set; }
        public virtual DbSet<CrmFacturasAddendasCampo> CrmFacturasAddendasCampos { get; set; }
        public virtual DbSet<CtbAgrupadorSat> CtbAgrupadorSats { get; set; }
        public virtual DbSet<CtbAgrupadorSatn> CtbAgrupadorSatns { get; set; }
        public virtual DbSet<CtbCatMetodosPagoSat> CtbCatMetodosPagoSats { get; set; }
        public virtual DbSet<CtbCatMonedasSat> CtbCatMonedasSats { get; set; }
        public virtual DbSet<CtbCatTipoImpuesto> CtbCatTipoImpuestos { get; set; }
        public virtual DbSet<CtbCatTipoRetencione> CtbCatTipoRetenciones { get; set; }
        public virtual DbSet<CtbCatTiposPolizaSat> CtbCatTiposPolizaSats { get; set; }
        public virtual DbSet<CtbConceptosDiot> CtbConceptosDiots { get; set; }
        public virtual DbSet<CtbConsecutivosPolizasXanio> CtbConsecutivosPolizasXanios { get; set; }
        public virtual DbSet<CtbConsecutivosPolizasXme> CtbConsecutivosPolizasXmes { get; set; }
        public virtual DbSet<CtbConstanciaRetencionDet> CtbConstanciaRetencionDets { get; set; }
        public virtual DbSet<CtbConstanciaRetencione> CtbConstanciaRetenciones { get; set; }
        public virtual DbSet<CtbCuenta> CtbCuentas { get; set; }
        public virtual DbSet<CtbCuentasDiot> CtbCuentasDiots { get; set; }
        public virtual DbSet<CtbDiottipoOperacion> CtbDiottipoOperacions { get; set; }
        public virtual DbSet<CtbDiottipoTercero> CtbDiottipoTerceros { get; set; }
        public virtual DbSet<CtbPoliza> CtbPolizas { get; set; }
        public virtual DbSet<CtbPolizasDet> CtbPolizasDets { get; set; }
        public virtual DbSet<CtbPolizasDetAp> CtbPolizasDetAps { get; set; }
        public virtual DbSet<CtbPolizasDetCheque> CtbPolizasDetCheques { get; set; }
        public virtual DbSet<CtbPolizasDetCliente> CtbPolizasDetClientes { get; set; }
        public virtual DbSet<CtbPolizasDetCompExt> CtbPolizasDetCompExts { get; set; }
        public virtual DbSet<CtbPolizasDetCompNal> CtbPolizasDetCompNals { get; set; }
        public virtual DbSet<CtbPolizasDetCompNalOtr> CtbPolizasDetCompNalOtrs { get; set; }
        public virtual DbSet<CtbPolizasDetComprobante> CtbPolizasDetComprobantes { get; set; }
        public virtual DbSet<CtbPolizasDetDc> CtbPolizasDetDcs { get; set; }
        public virtual DbSet<CtbPolizasDetNodoCheque> CtbPolizasDetNodoCheques { get; set; }
        public virtual DbSet<CtbPolizasDetNodoOtrMetodosPago> CtbPolizasDetNodoOtrMetodosPagos { get; set; }
        public virtual DbSet<CtbPolizasDetNodoTransferencia> CtbPolizasDetNodoTransferencias { get; set; }
        public virtual DbSet<CtbPolizasDetPp> CtbPolizasDetPps { get; set; }
        public virtual DbSet<CtbPolizasDetTransferencia> CtbPolizasDetTransferencias { get; set; }
        public virtual DbSet<CtbPolizasDiot> CtbPolizasDiots { get; set; }
        public virtual DbSet<CtbPolizasIetu> CtbPolizasIetus { get; set; }
        public virtual DbSet<CtbPolizasIetuconcepto> CtbPolizasIetuconceptos { get; set; }
        public virtual DbSet<CtbPrefijo> CtbPrefijos { get; set; }
        public virtual DbSet<CtbSaldoXflujo> CtbSaldoXflujos { get; set; }
        public virtual DbSet<CtbSaldosCuentasProyecto> CtbSaldosCuentasProyectos { get; set; }
        public virtual DbSet<CtbTiposCuentum> CtbTiposCuenta { get; set; }
        public virtual DbSet<CtbTiposPoliza> CtbTiposPolizas { get; set; }
        public virtual DbSet<CvAccesorio> CvAccesorios { get; set; }
        public virtual DbSet<CvAjusteCliente> CvAjusteClientes { get; set; }
        public virtual DbSet<CvApartado> CvApartados { get; set; }
        public virtual DbSet<CvAplicacionApartado> CvAplicacionApartados { get; set; }
        public virtual DbSet<CvAplicacionApartadosDet> CvAplicacionApartadosDets { get; set; }
        public virtual DbSet<CvAplicacionDeposito> CvAplicacionDepositos { get; set; }
        public virtual DbSet<CvAplicacionDepositosCfdi> CvAplicacionDepositosCfdis { get; set; }
        public virtual DbSet<CvAplicacionDepositosDet> CvAplicacionDepositosDets { get; set; }
        public virtual DbSet<CvAvale> CvAvales { get; set; }
        public virtual DbSet<CvBeneficiario> CvBeneficiarios { get; set; }
        public virtual DbSet<CvCamposRequerido> CvCamposRequeridos { get; set; }
        public virtual DbSet<CvCancelacione> CvCancelaciones { get; set; }
        public virtual DbSet<CvCasa> CvCasas { get; set; }
        public virtual DbSet<CvCatConceptosCfdi> CvCatConceptosCfdis { get; set; }
        public virtual DbSet<CvCetapa> CvCetapas { get; set; }
        public virtual DbSet<CvCetapasDet> CvCetapasDets { get; set; }
        public virtual DbSet<CvCliente> CvClientes { get; set; }
        public virtual DbSet<CvClienteEscrituracion> CvClienteEscrituracions { get; set; }
        public virtual DbSet<CvClientesFactura> CvClientesFacturas { get; set; }
        public virtual DbSet<CvClientesFacturas2017> CvClientesFacturas2017s { get; set; }
        public virtual DbSet<CvClientesFacturasCfd> CvClientesFacturasCfds { get; set; }
        public virtual DbSet<CvClientesFacturasCfdirelac> CvClientesFacturasCfdirelacs { get; set; }
        public virtual DbSet<CvClientesFacturasDet> CvClientesFacturasDets { get; set; }
        public virtual DbSet<CvClientesVistum> CvClientesVista { get; set; }
        public virtual DbSet<CvComisione> CvComisiones { get; set; }
        public virtual DbSet<CvComisionesDet> CvComisionesDets { get; set; }
        public virtual DbSet<CvComplementoPago> CvComplementoPagos { get; set; }
        public virtual DbSet<CvComplementoPagoCfd> CvComplementoPagoCfds { get; set; }
        public virtual DbSet<CvComplementoPagoCfdirelac> CvComplementoPagoCfdirelacs { get; set; }
        public virtual DbSet<CvComplementoPagoDet> CvComplementoPagoDets { get; set; }
        public virtual DbSet<CvConstructora> CvConstructoras { get; set; }
        public virtual DbSet<CvContrato> CvContratos { get; set; }
        public virtual DbSet<CvContratosAccesorio> CvContratosAccesorios { get; set; }
        public virtual DbSet<CvConyuge> CvConyuges { get; set; }
        public virtual DbSet<CvCotizacione> CvCotizaciones { get; set; }
        public virtual DbSet<CvCotizacionesDet> CvCotizacionesDets { get; set; }
        public virtual DbSet<CvCredito> CvCreditos { get; set; }
        public virtual DbSet<CvDepositosCliente> CvDepositosClientes { get; set; }
        public virtual DbSet<CvDepositosSofol> CvDepositosSofols { get; set; }
        public virtual DbSet<CvDepositosSofolCta> CvDepositosSofolCtas { get; set; }
        public virtual DbSet<CvDepositosSofolDet> CvDepositosSofolDets { get; set; }
        public virtual DbSet<CvDesarrollo> CvDesarrollos { get; set; }
        public virtual DbSet<CvDisponibilidadCasaDeseadum> CvDisponibilidadCasaDeseada { get; set; }
        public virtual DbSet<CvDocumento> CvDocumentos { get; set; }
        public virtual DbSet<CvDocumentosCliente> CvDocumentosClientes { get; set; }
        public virtual DbSet<CvEconomium> CvEconomia { get; set; }
        public virtual DbSet<CvEmpresa> CvEmpresas { get; set; }
        public virtual DbSet<CvEtapa> CvEtapas { get; set; }
        public virtual DbSet<CvEtapasCliente> CvEtapasClientes { get; set; }
        public virtual DbSet<CvEtapasVivienda> CvEtapasViviendas { get; set; }
        public virtual DbSet<CvFaplicarAhorro> CvFaplicarAhorros { get; set; }
        public virtual DbSet<CvFcreditoConyugal> CvFcreditoConyugals { get; set; }
        public virtual DbSet<CvFdestinoCredito> CvFdestinoCreditos { get; set; }
        public virtual DbSet<CvFescolaridad> CvFescolaridads { get; set; }
        public virtual DbSet<CvFestadoCivil> CvFestadoCivils { get; set; }
        public virtual DbSet<CvFestadoViviendum> CvFestadoVivienda { get; set; }
        public virtual DbSet<CvFformaCredito> CvFformaCreditos { get; set; }
        public virtual DbSet<CvFlineaCredito> CvFlineaCreditos { get; set; }
        public virtual DbSet<CvFlujoCliente> CvFlujoClientes { get; set; }
        public virtual DbSet<CvFlujoClientesDet> CvFlujoClientesDets { get; set; }
        public virtual DbSet<CvFlujoVivienda> CvFlujoViviendas { get; set; }
        public virtual DbSet<CvFopcCreditoVsm> CvFopcCreditoVsms { get; set; }
        public virtual DbSet<CvFplazosCredito> CvFplazosCreditos { get; set; }
        public virtual DbSet<CvFproducto> CvFproductos { get; set; }
        public virtual DbSet<CvFtipoCompra> CvFtipoCompras { get; set; }
        public virtual DbSet<CvFtipoDiscapacidad> CvFtipoDiscapacidads { get; set; }
        public virtual DbSet<CvFtipoMercado> CvFtipoMercados { get; set; }
        public virtual DbSet<CvFtipoOfertacion> CvFtipoOfertacions { get; set; }
        public virtual DbSet<CvGravamene> CvGravamenes { get; set; }
        public virtual DbSet<CvIdentificacionesOficiale> CvIdentificacionesOficiales { get; set; }
        public virtual DbSet<CvInmobiliaria> CvInmobiliarias { get; set; }
        public virtual DbSet<CvManzana> CvManzanas { get; set; }
        public virtual DbSet<CvMedio> CvMedios { get; set; }
        public virtual DbSet<CvNotaria> CvNotarias { get; set; }
        public virtual DbSet<CvNotasEscritura> CvNotasEscrituras { get; set; }
        public virtual DbSet<CvOpcionesPagoConEnganche> CvOpcionesPagoConEnganches { get; set; }
        public virtual DbSet<CvPagoLiberacionVivienda> CvPagoLiberacionViviendas { get; set; }
        public virtual DbSet<CvPagoLiberacionViviendasDet> CvPagoLiberacionViviendasDets { get; set; }
        public virtual DbSet<CvPaquetesInstitucione> CvPaquetesInstituciones { get; set; }
        public virtual DbSet<CvParametro> CvParametros { get; set; }
        public virtual DbSet<CvPcecomisione> CvPcecomisiones { get; set; }
        public virtual DbSet<CvPetapa> CvPetapas { get; set; }
        public virtual DbSet<CvPlanesPago> CvPlanesPagos { get; set; }
        public virtual DbSet<CvPlanesPagosDet> CvPlanesPagosDets { get; set; }
        public virtual DbSet<CvPlantillasContrato> CvPlantillasContratos { get; set; }
        public virtual DbSet<CvPlaza> CvPlazas { get; set; }
        public virtual DbSet<CvPpecosto> CvPpecostos { get; set; }
        public virtual DbSet<CvPppresupuesto> CvPppresupuestos { get; set; }
        public virtual DbSet<CvPromocione> CvPromociones { get; set; }
        public virtual DbSet<CvPromotora> CvPromotoras { get; set; }
        public virtual DbSet<CvPropietario> CvPropietarios { get; set; }
        public virtual DbSet<CvPrototipo> CvPrototipos { get; set; }
        public virtual DbSet<CvPrototiposAccesorio> CvPrototiposAccesorios { get; set; }
        public virtual DbSet<CvPrototiposAdjunto> CvPrototiposAdjuntos { get; set; }
        public virtual DbSet<CvProyectosAccesorio> CvProyectosAccesorios { get; set; }
        public virtual DbSet<CvProyectosCredito> CvProyectosCreditos { get; set; }
        public virtual DbSet<CvProyectosCuentasDepCliente> CvProyectosCuentasDepClientes { get; set; }
        public virtual DbSet<CvProyectosCuentasDepSofole> CvProyectosCuentasDepSofoles { get; set; }
        public virtual DbSet<CvProyectosCuentasNota> CvProyectosCuentasNotas { get; set; }
        public virtual DbSet<CvProyectosCuentasXplan> CvProyectosCuentasXplans { get; set; }
        public virtual DbSet<CvProyectosDescuento> CvProyectosDescuentos { get; set; }
        public virtual DbSet<CvProyectosPaquete> CvProyectosPaquetes { get; set; }
        public virtual DbSet<CvProyectosPreciosLista> CvProyectosPreciosListas { get; set; }
        public virtual DbSet<CvProyectosPromocione> CvProyectosPromociones { get; set; }
        public virtual DbSet<CvProyectosPrototipo> CvProyectosPrototipos { get; set; }
        public virtual DbSet<CvProyectosVendedore> CvProyectosVendedores { get; set; }
        public virtual DbSet<CvRangoIngresoMc> CvRangoIngresoMcs { get; set; }
        public virtual DbSet<CvRangoIngresoMnc> CvRangoIngresoMncs { get; set; }
        public virtual DbSet<CvRangoMontoRentum> CvRangoMontoRenta { get; set; }
        public virtual DbSet<CvRangoPersonasHabitanCasa> CvRangoPersonasHabitanCasas { get; set; }
        public virtual DbSet<CvReferencia> CvReferencias { get; set; }
        public virtual DbSet<CvRegimenMatrimonial> CvRegimenMatrimonials { get; set; }
        public virtual DbSet<CvResumenFlujoCliente> CvResumenFlujoClientes { get; set; }
        public virtual DbSet<CvResumenFlujoVivienda> CvResumenFlujoViviendas { get; set; }
        public virtual DbSet<CvResumenPago> CvResumenPagos { get; set; }
        public virtual DbSet<CvReubicacionesVivienda> CvReubicacionesViviendas { get; set; }
        public virtual DbSet<CvRfcCliente> CvRfcClientes { get; set; }
        public virtual DbSet<CvRfcClientesDet> CvRfcClientesDets { get; set; }
        public virtual DbSet<CvSeries> CvSeries { get; set; }
        public virtual DbSet<CvSindicato> CvSindicatos { get; set; }
        public virtual DbSet<CvSofole> CvSofoles { get; set; }
        public virtual DbSet<CvSubtiposTerreno> CvSubtiposTerrenos { get; set; }
        public virtual DbSet<CvSucursale> CvSucursales { get; set; }
        public virtual DbSet<CvTipoLote> CvTipoLotes { get; set; }
        public virtual DbSet<CvTipoViviendum> CvTipoVivienda { get; set; }
        public virtual DbSet<CvTiposDescuento> CvTiposDescuentos { get; set; }
        public virtual DbSet<CvTiposFalla> CvTiposFallas { get; set; }
        public virtual DbSet<CvTiposGravamenesFinanciero> CvTiposGravamenesFinancieros { get; set; }
        public virtual DbSet<CvTiposNota> CvTiposNotas { get; set; }
        public virtual DbSet<CvTiposPlan> CvTiposPlans { get; set; }
        public virtual DbSet<CvVendedore> CvVendedores { get; set; }
        public virtual DbSet<CvVivienda> CvViviendas { get; set; }
        public virtual DbSet<CvViviendasAccesorio> CvViviendasAccesorios { get; set; }
        public virtual DbSet<CvViviendasVistum> CvViviendasVista { get; set; }
        public virtual DbSet<FefoliosCfdxRfc> FefoliosCfdxRfcs { get; set; }
        public virtual DbSet<FeneodataCertificado> FeneodataCertificados { get; set; }
        public virtual DbSet<FeneodataFolio> FeneodataFolios { get; set; }
        public virtual DbSet<FeneodataMatrizSucursale> FeneodataMatrizSucursales { get; set; }
        public virtual DbSet<Feregimene> Feregimenes { get; set; }
        public virtual DbSet<FeseriesDigitalesXrfc> FeseriesDigitalesXrfcs { get; set; }
        public virtual DbSet<GruposReportesEjecutivo> GruposReportesEjecutivos { get; set; }
        public virtual DbSet<GruposReportesEjecutivos2004> GruposReportesEjecutivos2004s { get; set; }
        public virtual DbSet<NeoSysCatalogo> NeoSysCatalogos { get; set; }
        public virtual DbSet<NeoSysCatalogosCamposOculto> NeoSysCatalogosCamposOcultos { get; set; }
        public virtual DbSet<NeoSysCatalogosUsuario> NeoSysCatalogosUsuarios { get; set; }
        public virtual DbSet<NeoSysCatalogosUsuarioC> NeoSysCatalogosUsuarioCs { get; set; }
        public virtual DbSet<NumerosConsecutivo> NumerosConsecutivos { get; set; }
        public virtual DbSet<Parametro> Parametros { get; set; }
        public virtual DbSet<ParametroUsuario> ParametroUsuarios { get; set; }
        public virtual DbSet<ParametrosCtasAntiLavado> ParametrosCtasAntiLavados { get; set; }
        public virtual DbSet<PermisosErp2008> PermisosErp2008s { get; set; }
        public virtual DbSet<Proyecto> Proyectos { get; set; }
        public virtual DbSet<ProyectosAlmacenGeneral> ProyectosAlmacenGenerals { get; set; }
        public virtual DbSet<ProyectosDetTac> ProyectosDetTacs { get; set; }
        public virtual DbSet<ProyectosPorcenAportSocio> ProyectosPorcenAportSocios { get; set; }
        public virtual DbSet<PuUnidade> PuUnidades { get; set; }
        public virtual DbSet<ReCvApartado> ReCvApartados { get; set; }
        public virtual DbSet<ReCvCancelacione> ReCvCancelaciones { get; set; }
        public virtual DbSet<ReCvClientesXcredito> ReCvClientesXcreditos { get; set; }
        public virtual DbSet<ReCvEfectividadMedio> ReCvEfectividadMedios { get; set; }
        public virtual DbSet<ReCvFirmada> ReCvFirmadas { get; set; }
        public virtual DbSet<ReCvFlujoCliente> ReCvFlujoClientes { get; set; }
        public virtual DbSet<ReCvFlujoVivienda> ReCvFlujoViviendas { get; set; }
        public virtual DbSet<ReCvIngresosEsperado> ReCvIngresosEsperados { get; set; }
        public virtual DbSet<ReCvVentasXejecutivo> ReCvVentasXejecutivos { get; set; }
        public virtual DbSet<ReCvVivienda> ReCvViviendas { get; set; }
        public virtual DbSet<RepDestajoNomina> RepDestajoNominas { get; set; }
        public virtual DbSet<RepFinanciero> RepFinancieros { get; set; }
        public virtual DbSet<ReportesEjecutivo> ReportesEjecutivos { get; set; }
        public virtual DbSet<ReportesEjecutivos2004> ReportesEjecutivos2004s { get; set; }
        public virtual DbSet<ReportesEjecutivos2004Proceso> ReportesEjecutivos2004Procesos { get; set; }
        public virtual DbSet<ReportesEjecutivos2004Tdinamica> ReportesEjecutivos2004Tdinamicas { get; set; }
        public virtual DbSet<ReportesEjecutivosOpcione> ReportesEjecutivosOpciones { get; set; }
        public virtual DbSet<ReportesEjecutivosTdinamica> ReportesEjecutivosTdinamicas { get; set; }
        public virtual DbSet<RptControle> RptControles { get; set; }
        public virtual DbSet<RptUsuario> RptUsuarios { get; set; }
        public virtual DbSet<RptcadenaSql08> RptcadenaSql08s { get; set; }
        public virtual DbSet<Rptopciones08> Rptopciones08s { get; set; }
        public virtual DbSet<RutaReporte> RutaReportes { get; set; }
        public virtual DbSet<SegGrupoPermiso> SegGrupoPermisos { get; set; }
        public virtual DbSet<SegPerfil> SegPerfils { get; set; }
        public virtual DbSet<SegPermiso> SegPermisos { get; set; }
        public virtual DbSet<SegScriptsEjecutado> SegScriptsEjecutados { get; set; }
        public virtual DbSet<SegSistema> SegSistemas { get; set; }
        public virtual DbSet<SegUsuario> SegUsuarios { get; set; }
        public virtual DbSet<SegUsuariosSistema> SegUsuariosSistemas { get; set; }
        public virtual DbSet<SegUsuariosXproyecto> SegUsuariosXproyectos { get; set; }
        public virtual DbSet<SegUsuariosXproyectoRemesa> SegUsuariosXproyectoRemesas { get; set; }
        public virtual DbSet<UCmbpermisoGrabado> UCmbpermisoGrabados { get; set; }
        public virtual DbSet<USegGrupoPermiso> USegGrupoPermisos { get; set; }
        public virtual DbSet<USegPermiso> USegPermisos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<biz.erpmet.Model.Version> Versions { get; set; }
        public virtual DbSet<dal.erpmet.Repository.FinancialReport.FinancialReportRepository.MainAccountEvaluation> MainAccountEvaluations { get; set; }
        public virtual DbSet<dal.erpmet.Repository.FinancialReport.FinancialReportRepository.BalanceSheetSummary> BalanceSheetSummaries { get; set; }
        public virtual DbSet<dal.erpmet.Repository.FinancialReport.FinancialReportRepository.FundingInvestmentOperation> FundingInvestmentOperations { get; set; }
        public virtual DbSet<biz.erpmet.Entities.SaldoInicial2021> SaldoInicial2021s { get; set; }
        public virtual DbSet<biz.erpmet.Entities.FamilyMaterial> FamilyMaterials { get; set; }
        public virtual DbSet<biz.erpmet.Entities.PurchaseHistory> PurchaseHistories { get; set; }
        public virtual DbSet<biz.erpmet.Entities.PriceTrend> PriceTrends { get; set; }
        public virtual DbSet<biz.erpmet.Entities.TopProveedor> TopProveedors { get; set; }
        public virtual DbSet<biz.erpmet.Entities.OperatingResultsSummary> OperatingResultsSummaries { get; set; }
        public virtual DbSet<biz.erpmet.Entities.Top5KilosMounting> Top5KilosMountings { get; set; }
        public virtual DbSet<biz.erpmet.Entities.CashFlow> CashFlows { get; set; }
        public virtual DbSet<biz.erpmet.Entities.IncomeStatement> IncomeStatements { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=38.123.205.126,1387;Initial Catalog=ERPMET;Integrated Security=false;User Id=sa;Password=Metalitec16#;MultipleActiveResultSets=True;Connection Timeout=120000",
                    builder =>
                    {
                        builder.UseNetTopologySuite();
                        builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
                    });
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<AcAceptaRechazaCancelacionHist>(entity =>
            {
                entity.HasKey(e => e.IdAceptaRechazaCancelacionHist)
                    .HasName("PK_AcAcepRechCancelacionHist");

                entity.ToTable("AcAceptaRechazaCancelacionHist");

                entity.Property(e => e.EstatusUuid)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EstatusUUID");

                entity.Property(e => e.FechaRespuesta).HasColumnType("datetime");

                entity.Property(e => e.Respuesta)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RfcEmisor)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SolicitudEnviada)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Uuid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UUID");
            });

            modelBuilder.Entity<AcAddendasCampo>(entity =>
            {
                entity.HasKey(e => e.IdAddendaCampo)
                    .HasName("PK_AcCamposAddendas");

                entity.Property(e => e.Campo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Receptor)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TipoArchivo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AcAddendasProducto>(entity =>
            {
                entity.HasKey(e => e.IdAddendaProducto);

                entity.Property(e => e.Campo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AcAditivasExplosion>(entity =>
            {
                entity.HasKey(e => e.IdAditivaExplosion)
                    .HasName("aaaaaMtoAfectaExplosion_PK")
                    .IsClustered(false);

                entity.ToTable("AcAditivasExplosion");

                entity.HasIndex(e => new { e.IdProyecto, e.Folio }, "IxUnico")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdAditivaExplosion).HasColumnName("idAditivaExplosion");

                entity.Property(e => e.Autorizada)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Comentario)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaAutorizada).HasColumnType("datetime");

                entity.Property(e => e.IdProyecto).HasColumnName("idProyecto");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AcAditivasExplosions)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAditivasExplosion_Proyectos");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AcAditivasExplosions)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAditivasExplosion_SegUsuarios");
            });

            modelBuilder.Entity<AcAditivasExplosionDet>(entity =>
            {
                entity.HasKey(e => e.IdAditivaExplosionDet);

                entity.ToTable("AcAditivasExplosionDet");

                entity.HasIndex(e => new { e.IdAditivaExplosion, e.IdExplosionInsumos }, "IX_AcAditivasExplosionDet")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdAditivaExplosionDet).HasColumnName("idAditivaExplosionDet");

                entity.Property(e => e.Cantidad).HasColumnType("money");

                entity.Property(e => e.Costo).HasColumnType("money");

                entity.Property(e => e.IdAditivaExplosion).HasColumnName("idAditivaExplosion");

                entity.Property(e => e.IdExplosionInsumos).HasColumnName("idExplosionInsumos");

                entity.HasOne(d => d.IdAditivaExplosionNavigation)
                    .WithMany(p => p.AcAditivasExplosionDets)
                    .HasForeignKey(d => d.IdAditivaExplosion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAditivasExplosionDet_AcAditivasExplosion");

                entity.HasOne(d => d.IdExplosionInsumosNavigation)
                    .WithMany(p => p.AcAditivasExplosionDets)
                    .HasForeignKey(d => d.IdExplosionInsumos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAditivasExplosionDet_AcExplosionInsumos");

                entity.HasOne(d => d.IdPartidaNavigation)
                    .WithMany(p => p.AcAditivasExplosionDets)
                    .HasForeignKey(d => d.IdPartida)
                    .HasConstraintName("FK_AcAditivasExplosionDet_AoPartidas");
            });

            modelBuilder.Entity<AcAjustesPedido>(entity =>
            {
                entity.HasKey(e => e.IdAjuste)
                    .HasName("PK_AcAjustesOC");

                entity.HasIndex(e => e.Folio, "IX_Folio")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Comentario)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaCancelacion).HasColumnType("smalldatetime");

                entity.Property(e => e.IdPedido).HasColumnName("idPedido");

                entity.Property(e => e.MontoAjuste).HasColumnType("money");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.AcAjustesPedidos)
                    .HasForeignKey(d => d.IdPedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAjustesOC_AcPedidos");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AcAjustesPedidoIdUsuarioNavigations)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAjustesOC_SegUsuarios");

                entity.HasOne(d => d.IdUsuarioCancelacionNavigation)
                    .WithMany(p => p.AcAjustesPedidoIdUsuarioCancelacionNavigations)
                    .HasForeignKey(d => d.IdUsuarioCancelacion)
                    .HasConstraintName("FK_AcAjustesOC_SegUsuarios1");
            });

            modelBuilder.Entity<AcAlmacenConsecutivo>(entity =>
            {
                entity.HasKey(e => e.IdAlmacenConsecutivo);

                entity.ToTable("AcAlmacenConsecutivo");

                entity.HasIndex(e => new { e.IdProyecto, e.IdTipDocAlmacen }, "IX_AcAlmacenConsecutivo")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdAlmacenConsecutivo).HasColumnName("idAlmacenConsecutivo");

                entity.Property(e => e.IdProyecto).HasColumnName("idProyecto");

                entity.Property(e => e.IdTipDocAlmacen).HasColumnName("idTipDocAlmacen");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AcAlmacenConsecutivos)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAlmacenConsecutivo_Proyectos");

                entity.HasOne(d => d.IdTipDocAlmacenNavigation)
                    .WithMany(p => p.AcAlmacenConsecutivos)
                    .HasForeignKey(d => d.IdTipDocAlmacen)
                    .HasConstraintName("FK_AcAlmacenConsecutivo_AcTipDocAlmacen");
            });

            modelBuilder.Entity<AcAlmacenEntrada>(entity =>
            {
                entity.HasKey(e => e.IdAlmacenEntrada);

                entity.HasIndex(e => new { e.IdProyecto, e.IdTipDocAlmacen, e.Folio }, "IX_AcAlmacenEntradas")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.IdAlmacenEntrada, e.IdPedido }, "IX_AcAlmacenEntradas_1")
                    .HasFillFactor(90);

                entity.Property(e => e.IdAlmacenEntrada).HasColumnName("idAlmacenEntrada");

                entity.Property(e => e.ConPedido)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaCancelacion).HasColumnType("datetime");

                entity.Property(e => e.FechaCaptura).HasColumnType("datetime");

                entity.Property(e => e.FechaDevolucion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaMovimiento).HasColumnType("datetime");

                entity.Property(e => e.IdAutorizo).HasColumnName("idAutorizo");

                entity.Property(e => e.IdFacturaProveedor).HasColumnName("idFacturaProveedor");

                entity.Property(e => e.IdPedido).HasColumnName("idPedido");

                entity.Property(e => e.IdPoliza).HasColumnName("idPoliza");

                entity.Property(e => e.IdPolizaInversa).HasColumnName("idPolizaInversa");

                entity.Property(e => e.IdProveedor).HasColumnName("idProveedor");

                entity.Property(e => e.IdProyecto).HasColumnName("idProyecto");

                entity.Property(e => e.IdResponsable).HasColumnName("idResponsable");

                entity.Property(e => e.IdTipDocAlmacen).HasColumnName("idTipDocAlmacen");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.IdUsuarioModificacion).HasColumnName("idUsuarioModificacion");

                entity.Property(e => e.Importe).HasColumnType("money");

                entity.Property(e => e.NumRemision)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PorRm).HasColumnName("PorRM");

                entity.Property(e => e.RutaDocumento).IsUnicode(false);

                entity.HasOne(d => d.IdAlmacenSalidaNavigation)
                    .WithMany(p => p.AcAlmacenEntrada)
                    .HasForeignKey(d => d.IdAlmacenSalida)
                    .HasConstraintName("FK_AcAlmacenEntradas_AcAlmacenSalidas");

                entity.HasOne(d => d.IdAutorizoNavigation)
                    .WithMany(p => p.AcAlmacenEntradaIdAutorizoNavigations)
                    .HasForeignKey(d => d.IdAutorizo)
                    .HasConstraintName("FK_AcAlmacenEntradas_ACResponsables");

                entity.HasOne(d => d.IdFacturaProveedorNavigation)
                    .WithMany(p => p.AcAlmacenEntrada)
                    .HasForeignKey(d => d.IdFacturaProveedor)
                    .HasConstraintName("FK_AcAlmacenEntradas_AcFacturasProveedores");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.AcAlmacenEntrada)
                    .HasForeignKey(d => d.IdPedido)
                    .HasConstraintName("FK_AcAlmacenEntradas_AcPedidos");

                entity.HasOne(d => d.IdPolizaNavigation)
                    .WithMany(p => p.AcAlmacenEntradaIdPolizaNavigations)
                    .HasForeignKey(d => d.IdPoliza)
                    .HasConstraintName("FK_AcAlmacenEntradas_CtbPolizas");

                entity.HasOne(d => d.IdPolizaInversaNavigation)
                    .WithMany(p => p.AcAlmacenEntradaIdPolizaInversaNavigations)
                    .HasForeignKey(d => d.IdPolizaInversa)
                    .HasConstraintName("FK_AcAlmacenEntradas_CtbPolizas1");

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.AcAlmacenEntrada)
                    .HasForeignKey(d => d.IdProveedor)
                    .HasConstraintName("FK_AcAlmacenEntradas_AcProveedores");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AcAlmacenEntrada)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAlmacenEntradas_Proyectos");

                entity.HasOne(d => d.IdResponsableNavigation)
                    .WithMany(p => p.AcAlmacenEntradaIdResponsableNavigations)
                    .HasForeignKey(d => d.IdResponsable)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAlmacenEntradas_ACResponsables1");

                entity.HasOne(d => d.IdTipDocAlmacenNavigation)
                    .WithMany(p => p.AcAlmacenEntrada)
                    .HasForeignKey(d => d.IdTipDocAlmacen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAlmacenEntradas_AcTipDocAlmacen");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AcAlmacenEntradaIdUsuarioNavigations)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAlmacenEntradas_SegUsuarios");

                entity.HasOne(d => d.IdUsuarioDevolucionNavigation)
                    .WithMany(p => p.AcAlmacenEntradaIdUsuarioDevolucionNavigations)
                    .HasForeignKey(d => d.IdUsuarioDevolucion)
                    .HasConstraintName("FK_AcAlmacenEntradas_SegUsuarios1");

                entity.HasOne(d => d.IdUsuarioModificacionNavigation)
                    .WithMany(p => p.AcAlmacenEntradaIdUsuarioModificacionNavigations)
                    .HasForeignKey(d => d.IdUsuarioModificacion)
                    .HasConstraintName("FK_AcAlmacenEntradas_SegUsuarios2");
            });

            modelBuilder.Entity<AcAlmacenEntradasDet>(entity =>
            {
                entity.HasKey(e => e.IdAlmacenEntradaDet);

                entity.ToTable("AcAlmacenEntradasDet");

                entity.HasIndex(e => new { e.IdAlmacenEntrada, e.IdExplosionInsumos }, "IX_AcAlmacenEntradasDet")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.IdAlmacenEntrada, e.IdExplosionInsumos }, "IX_AcAlmacenEntradasDet_1");

                entity.Property(e => e.IdAlmacenEntradaDet).HasColumnName("idAlmacenEntradaDet");

                entity.Property(e => e.Cantidad).HasColumnType("money");

                entity.Property(e => e.Costo).HasColumnType("money");

                entity.Property(e => e.Devolucion).HasColumnType("money");

                entity.Property(e => e.IdAlmacenEntrada).HasColumnName("idAlmacenEntrada");

                entity.Property(e => e.IdExplosionInsumos).HasColumnName("idExplosionInsumos");

                entity.HasOne(d => d.IdAlmacenEntradaNavigation)
                    .WithMany(p => p.AcAlmacenEntradasDets)
                    .HasForeignKey(d => d.IdAlmacenEntrada)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAlmacenEntradasDet_AcAlmacenEntradas");

                entity.HasOne(d => d.IdExplosionInsumosNavigation)
                    .WithMany(p => p.AcAlmacenEntradasDets)
                    .HasForeignKey(d => d.IdExplosionInsumos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAlmacenEntradasDet_AcExplosionInsumos");

                entity.HasOne(d => d.IdPedidoDetNavigation)
                    .WithMany(p => p.AcAlmacenEntradasDets)
                    .HasForeignKey(d => d.IdPedidoDet)
                    .HasConstraintName("FK_AcAlmacenEntradasDet_AcPedidosDet");
            });

            modelBuilder.Entity<AcAlmacenOproduccion>(entity =>
            {
                entity.HasKey(e => e.IdAlmacenOproduccion);

                entity.ToTable("AcAlmacenOProduccion");

                entity.HasIndex(e => new { e.IdProyecto, e.Folio }, "IX_AcAlmacenOProduccion")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdAlmacenOproduccion).HasColumnName("IdAlmacenOProduccion");

                entity.Property(e => e.Cantidad).HasColumnType("money");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaCancelacion).HasColumnType("datetime");

                entity.Property(e => e.IdAutorizo).HasColumnName("idAutorizo");

                entity.Property(e => e.IdElaboro).HasColumnName("idElaboro");

                entity.Property(e => e.IdExplosionInsumos).HasColumnName("idExplosionInsumos");

                entity.Property(e => e.IdPoliza).HasColumnName("idPoliza");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Importe).HasColumnType("money");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAutorizoNavigation)
                    .WithMany(p => p.AcAlmacenOproduccionIdAutorizoNavigations)
                    .HasForeignKey(d => d.IdAutorizo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAlmacenOProduccion_ACResponsables");

                entity.HasOne(d => d.IdElaboroNavigation)
                    .WithMany(p => p.AcAlmacenOproduccionIdElaboroNavigations)
                    .HasForeignKey(d => d.IdElaboro)
                    .HasConstraintName("FK_AcAlmacenOProduccion_ACResponsables1");

                entity.HasOne(d => d.IdExplosionInsumosNavigation)
                    .WithMany(p => p.AcAlmacenOproduccions)
                    .HasForeignKey(d => d.IdExplosionInsumos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAlmacenOProduccion_AcExplosionInsumos");

                entity.HasOne(d => d.IdPolizaNavigation)
                    .WithMany(p => p.AcAlmacenOproduccions)
                    .HasForeignKey(d => d.IdPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAlmacenOProduccion_CtbPolizas");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AcAlmacenOproduccions)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAlmacenOProduccion_Proyectos");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AcAlmacenOproduccions)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAlmacenOProduccion_SegUsuarios");
            });

            modelBuilder.Entity<AcAlmacenOproduccionDet>(entity =>
            {
                entity.HasKey(e => e.IdAlmacenOproduccionDet);

                entity.ToTable("AcAlmacenOProduccionDet");

                entity.HasIndex(e => new { e.IdAlmacenOproduccion, e.IdExplosionInsumos }, "IX_AcAlmacenOProduccionDet")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdAlmacenOproduccionDet).HasColumnName("idAlmacenOProduccionDet");

                entity.Property(e => e.Cantidad).HasColumnType("money");

                entity.Property(e => e.Costo).HasColumnType("money");

                entity.Property(e => e.IdAlmacenOproduccion).HasColumnName("IdAlmacenOProduccion");

                entity.Property(e => e.IdExplosionInsumos).HasColumnName("idExplosionInsumos");

                entity.HasOne(d => d.IdAlmacenOproduccionNavigation)
                    .WithMany(p => p.AcAlmacenOproduccionDets)
                    .HasForeignKey(d => d.IdAlmacenOproduccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAlmacenOProduccionDet_AcAlmacenOProduccion");

                entity.HasOne(d => d.IdExplosionInsumosNavigation)
                    .WithMany(p => p.AcAlmacenOproduccionDets)
                    .HasForeignKey(d => d.IdExplosionInsumos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAlmacenOProduccionDet_AcExplosionInsumos");
            });

            modelBuilder.Entity<AcAlmacenSalida>(entity =>
            {
                entity.HasKey(e => e.IdAlmacenSalida);

                entity.HasIndex(e => new { e.IdProyecto, e.IdTipDocAlmacen, e.Folio }, "IX_AcAlmacenSalidas")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdAlmacenSalida).HasColumnName("idAlmacenSalida");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaCancelacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaRecuperacion).HasColumnType("datetime");

                entity.Property(e => e.IdAutorizo).HasColumnName("idAutorizo");

                entity.Property(e => e.IdCentro).HasColumnName("idCentro");

                entity.Property(e => e.IdDestajista).HasColumnName("idDestajista");

                entity.Property(e => e.IdPoliza).HasColumnName("idPoliza");

                entity.Property(e => e.IdPolizaInversa).HasColumnName("idPolizaInversa");

                entity.Property(e => e.IdProyecto).HasColumnName("idProyecto");

                entity.Property(e => e.IdProyectoDestino).HasColumnName("idProyectoDestino");

                entity.Property(e => e.IdResponsable).HasColumnName("idResponsable");

                entity.Property(e => e.IdTipDocAlmacen).HasColumnName("idTipDocAlmacen");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.IdUsuarioModificacion).HasColumnName("idUsuarioModificacion");

                entity.Property(e => e.Importe).HasColumnType("money");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAutorizoNavigation)
                    .WithMany(p => p.AcAlmacenSalidaIdAutorizoNavigations)
                    .HasForeignKey(d => d.IdAutorizo)
                    .HasConstraintName("FK_AcAlmacenSalidas_ACResponsables");

                entity.HasOne(d => d.IdCentroNavigation)
                    .WithMany(p => p.AcAlmacenSalida)
                    .HasForeignKey(d => d.IdCentro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAlmacenSalidas_Centros");

                entity.HasOne(d => d.IdDestajistaNavigation)
                    .WithMany(p => p.AcAlmacenSalida)
                    .HasForeignKey(d => d.IdDestajista)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAlmacenSalidas_AoCatDestajistas");

                entity.HasOne(d => d.IdOrdenProduccionNavigation)
                    .WithMany(p => p.AcAlmacenSalida)
                    .HasForeignKey(d => d.IdOrdenProduccion)
                    .HasConstraintName("FK_AcAlmacenSalidas_AcOrdenProduccion");

                entity.HasOne(d => d.IdPolizaNavigation)
                    .WithMany(p => p.AcAlmacenSalidaIdPolizaNavigations)
                    .HasForeignKey(d => d.IdPoliza)
                    .HasConstraintName("FK_AcAlmacenSalidas_CtbPolizas");

                entity.HasOne(d => d.IdPolizaInversaNavigation)
                    .WithMany(p => p.AcAlmacenSalidaIdPolizaInversaNavigations)
                    .HasForeignKey(d => d.IdPolizaInversa)
                    .HasConstraintName("FK_AcAlmacenSalidas_CtbPolizas1");

                entity.HasOne(d => d.IdPresupuestoControlNavigation)
                    .WithMany(p => p.AcAlmacenSalida)
                    .HasForeignKey(d => d.IdPresupuestoControl)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAlmacenSalidas_AoPresupuestoControl");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AcAlmacenSalidaIdProyectoNavigations)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAlmacenSalidas_Proyectos");

                entity.HasOne(d => d.IdProyectoDestinoNavigation)
                    .WithMany(p => p.AcAlmacenSalidaIdProyectoDestinoNavigations)
                    .HasForeignKey(d => d.IdProyectoDestino)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAlmacenSalidas_Proyectos1");

                entity.HasOne(d => d.IdResponsableNavigation)
                    .WithMany(p => p.AcAlmacenSalidaIdResponsableNavigations)
                    .HasForeignKey(d => d.IdResponsable)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAlmacenSalidas_ACResponsables1");

                entity.HasOne(d => d.IdTipDocAlmacenNavigation)
                    .WithMany(p => p.AcAlmacenSalida)
                    .HasForeignKey(d => d.IdTipDocAlmacen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAlmacenSalidas_AcTipDocAlmacen");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AcAlmacenSalidaIdUsuarioNavigations)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAlmacenSalidas_SegUsuarios");

                entity.HasOne(d => d.IdUsuarioModificacionNavigation)
                    .WithMany(p => p.AcAlmacenSalidaIdUsuarioModificacionNavigations)
                    .HasForeignKey(d => d.IdUsuarioModificacion)
                    .HasConstraintName("FK_AcAlmacenSalidas_SegUsuarios2");

                entity.HasOne(d => d.IdUsuarioRecuperacionNavigation)
                    .WithMany(p => p.AcAlmacenSalidaIdUsuarioRecuperacionNavigations)
                    .HasForeignKey(d => d.IdUsuarioRecuperacion)
                    .HasConstraintName("FK_AcAlmacenSalidas_SegUsuarios1");
            });

            modelBuilder.Entity<AcAlmacenSalidaDetCc>(entity =>
            {
                entity.HasKey(e => e.IdAlmacenSalidaDetCc);

                entity.ToTable("AcAlmacenSalidaDetCC");

                entity.HasIndex(e => new { e.IdAlmacenSalidaDet, e.IdCentro }, "IX_AcAlmacenSalidaDetCC");

                entity.Property(e => e.IdAlmacenSalidaDetCc).HasColumnName("IdAlmacenSalidaDetCC");

                entity.Property(e => e.Cantidad).HasColumnType("money");

                entity.Property(e => e.Recuperacion).HasColumnType("money");

                entity.HasOne(d => d.IdAlmacenSalidaDetNavigation)
                    .WithMany(p => p.AcAlmacenSalidaDetCcs)
                    .HasForeignKey(d => d.IdAlmacenSalidaDet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAlmacenSalidaDetCC_AcAlmacenSalidasDet");

                entity.HasOne(d => d.IdCentroNavigation)
                    .WithMany(p => p.AcAlmacenSalidaDetCcs)
                    .HasForeignKey(d => d.IdCentro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAlmacenSalidaDetCC_Centros");
            });

            modelBuilder.Entity<AcAlmacenSalidasDet>(entity =>
            {
                entity.HasKey(e => e.IdAlmacenSalidaDet);

                entity.ToTable("AcAlmacenSalidasDet");

                entity.HasIndex(e => new { e.IdAlmacenSalida, e.IdExplosionInsumos }, "IX_AcAlmacenSalidasDet");

                entity.Property(e => e.IdAlmacenSalidaDet).HasColumnName("idAlmacenSalidaDet");

                entity.Property(e => e.Cantidad).HasColumnType("money");

                entity.Property(e => e.Costo).HasColumnType("money");

                entity.Property(e => e.IdAlmacenSalida).HasColumnName("idAlmacenSalida");

                entity.Property(e => e.IdExplosionInsumos).HasColumnName("idExplosionInsumos");

                entity.Property(e => e.NuevaRm)
                    .HasColumnType("money")
                    .HasColumnName("NuevaRM");

                entity.Property(e => e.Recuperacion).HasColumnType("money");

                entity.HasOne(d => d.IdAlmacenSalidaNavigation)
                    .WithMany(p => p.AcAlmacenSalidasDets)
                    .HasForeignKey(d => d.IdAlmacenSalida)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAlmacenSalidasDet_AcAlmacenSalidas");

                entity.HasOne(d => d.IdExplosionInsumosNavigation)
                    .WithMany(p => p.AcAlmacenSalidasDets)
                    .HasForeignKey(d => d.IdExplosionInsumos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAlmacenSalidasDet_AcExplosionInsumos");
            });

            modelBuilder.Entity<AcAlmacenTraspaso>(entity =>
            {
                entity.HasKey(e => e.IdAlmacenTraspaso);

                entity.HasIndex(e => new { e.IdProyectoOrigen, e.Folio }, "IX_AcAlmacenTraspasos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdAlmacenTraspaso).HasColumnName("idAlmacenTraspaso");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaCancelacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("smalldatetime");

                entity.Property(e => e.IdAutorizo).HasColumnName("idAutorizo");

                entity.Property(e => e.IdPoliza).HasColumnName("idPoliza");

                entity.Property(e => e.IdPolizaInversa).HasColumnName("idPolizaInversa");

                entity.Property(e => e.IdProyectoDestino).HasColumnName("idProyectoDestino");

                entity.Property(e => e.IdProyectoOrigen).HasColumnName("idProyectoOrigen");

                entity.Property(e => e.IdResponsable).HasColumnName("idResponsable");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.IdUsuarioModificacion).HasColumnName("idUsuarioModificacion");

                entity.Property(e => e.Importe).HasColumnType("money");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAutorizoNavigation)
                    .WithMany(p => p.AcAlmacenTraspasoIdAutorizoNavigations)
                    .HasForeignKey(d => d.IdAutorizo)
                    .HasConstraintName("FK_AcAlmacenTraspasos_ACResponsables");

                entity.HasOne(d => d.IdPolizaNavigation)
                    .WithMany(p => p.AcAlmacenTraspasoIdPolizaNavigations)
                    .HasForeignKey(d => d.IdPoliza)
                    .HasConstraintName("FK_AcAlmacenTraspasos_CtbPolizas");

                entity.HasOne(d => d.IdPolizaInversaNavigation)
                    .WithMany(p => p.AcAlmacenTraspasoIdPolizaInversaNavigations)
                    .HasForeignKey(d => d.IdPolizaInversa)
                    .HasConstraintName("FK_AcAlmacenTraspasos_CtbPolizas1");

                entity.HasOne(d => d.IdProyectoDestinoNavigation)
                    .WithMany(p => p.AcAlmacenTraspasoIdProyectoDestinoNavigations)
                    .HasForeignKey(d => d.IdProyectoDestino)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAlmacenTraspasos_Proyectos1");

                entity.HasOne(d => d.IdProyectoOrigenNavigation)
                    .WithMany(p => p.AcAlmacenTraspasoIdProyectoOrigenNavigations)
                    .HasForeignKey(d => d.IdProyectoOrigen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAlmacenTraspasos_Proyectos");

                entity.HasOne(d => d.IdResponsableNavigation)
                    .WithMany(p => p.AcAlmacenTraspasoIdResponsableNavigations)
                    .HasForeignKey(d => d.IdResponsable)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAlmacenTraspasos_ACResponsables1");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AcAlmacenTraspasoIdUsuarioNavigations)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAlmacenTraspasos_SegUsuarios");

                entity.HasOne(d => d.IdUsuarioModificacionNavigation)
                    .WithMany(p => p.AcAlmacenTraspasoIdUsuarioModificacionNavigations)
                    .HasForeignKey(d => d.IdUsuarioModificacion)
                    .HasConstraintName("FK_AcAlmacenTraspasos_SegUsuarios1");
            });

            modelBuilder.Entity<AcAlmacenTraspasosDet>(entity =>
            {
                entity.HasKey(e => e.IdAlmacenTraspasoDet);

                entity.ToTable("AcAlmacenTraspasosDet");

                entity.HasIndex(e => new { e.IdAlmacenTraspaso, e.IdExplosionInsumosOrigen }, "IX_AcAlmacenTraspasosDet")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.IdAlmacenTraspaso, e.IdExplosionInsumosOrigen }, "IX_AcAlmacenTraspasosDet_1");

                entity.Property(e => e.IdAlmacenTraspasoDet).HasColumnName("idAlmacenTraspasoDet");

                entity.Property(e => e.Cantidad).HasColumnType("money");

                entity.Property(e => e.Costo).HasColumnType("money");

                entity.Property(e => e.IdAlmacenTraspaso).HasColumnName("idAlmacenTraspaso");

                entity.Property(e => e.IdExplosionInsumosDestino).HasColumnName("idExplosionInsumosDestino");

                entity.Property(e => e.IdExplosionInsumosOrigen).HasColumnName("idExplosionInsumosOrigen");

                entity.HasOne(d => d.IdAlmacenTraspasoNavigation)
                    .WithMany(p => p.AcAlmacenTraspasosDets)
                    .HasForeignKey(d => d.IdAlmacenTraspaso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAlmacenTraspasosDet_AcAlmacenTraspasos");

                entity.HasOne(d => d.IdExplosionInsumosDestinoNavigation)
                    .WithMany(p => p.AcAlmacenTraspasosDetIdExplosionInsumosDestinoNavigations)
                    .HasForeignKey(d => d.IdExplosionInsumosDestino)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAlmacenTraspasosDet_AcExplosionInsumos1");

                entity.HasOne(d => d.IdExplosionInsumosOrigenNavigation)
                    .WithMany(p => p.AcAlmacenTraspasosDetIdExplosionInsumosOrigenNavigations)
                    .HasForeignKey(d => d.IdExplosionInsumosOrigen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcAlmacenTraspasosDet_AcExplosionInsumos");
            });

            modelBuilder.Entity<AcAlmacenUbicacione>(entity =>
            {
                entity.HasKey(e => e.IdUbicacionAlmacen);

                entity.HasIndex(e => e.UbicacionAlmacen, "IX_AcAlmacenUbicaciones")
                    .IsUnique();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UbicacionAlmacen)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AcBancosEgreso>(entity =>
            {
                entity.HasKey(e => e.IdBancoEgreso)
                    .HasName("aaaaaMtoBancos_PK")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.IdCuentaBancaria, e.EsCheque, e.Folio }, "IX_AcBancosEgresos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdBancoEgreso).HasColumnName("idBancoEgreso");

                entity.Property(e => e.AutomaticoCaabsa).HasColumnName("AutomaticoCAABSA");

                entity.Property(e => e.BanEmisExt)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BancoSatbeneficiario)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BancoSATBeneficiario");

                entity.Property(e => e.Beneficiario)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClaveTransferencia)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ConceptoCiecash)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ConceptoCIECASH");

                entity.Property(e => e.ConvenioCiecash)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("ConvenioCIECASH");

                entity.Property(e => e.CuentaBancariaBeneficiario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CvsC).HasColumnName("CVsC");

                entity.Property(e => e.DescripcionCancelacion)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DividirEntre).HasColumnType("decimal(19, 16)");

                entity.Property(e => e.EnviadoaAscii).HasColumnName("EnviadoaASCII");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaCancelacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.FechaGeneracion).HasColumnType("datetime");

                entity.Property(e => e.FechaProbablePagoCash)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FechaProbablePagoCASH");

                entity.Property(e => e.FolioFacturaCash)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("FolioFacturaCASH");

                entity.Property(e => e.IdBancoSatbeneficiario).HasColumnName("IdBancoSATBeneficiario");

                entity.Property(e => e.IdCuentaBancaria).HasColumnName("idCuentaBancaria");

                entity.Property(e => e.IdPoliza).HasColumnName("idPoliza");

                entity.Property(e => e.IdPolizaInversa).HasColumnName("idPolizaInversa");

                entity.Property(e => e.IdTipoMovBanco).HasColumnName("idTipoMovBanco");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.ImprimeLeyenda)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MonedaSatbeneficiario)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MonedaSATBeneficiario");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.MontoPesos).HasColumnType("money");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Paridad)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ParidadBursatil)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ParidadPasivo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PlazaBanxico)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Referencia)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenciaCiecash)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ReferenciaCIECASH");

                entity.Property(e => e.ReferenciaNumericaCash)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("ReferenciaNumericaCASH");

                entity.Property(e => e.RfcBeneficiario)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Sucursal)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDeCuentaCash)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TipoDeCuentaCASH");

                entity.HasOne(d => d.IdCuentaBancariaNavigation)
                    .WithMany(p => p.AcBancosEgresos)
                    .HasForeignKey(d => d.IdCuentaBancaria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcBancosEgresos_AcCuentasBancarias");

                entity.HasOne(d => d.IdFlujoNavigation)
                    .WithMany(p => p.AcBancosEgresos)
                    .HasForeignKey(d => d.IdFlujo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MtoBancos_AcCatFlujos");

                entity.HasOne(d => d.IdPartidaFlujoNavigation)
                    .WithMany(p => p.AcBancosEgresos)
                    .HasForeignKey(d => d.IdPartidaFlujo)
                    .HasConstraintName("FK_AcBancosEgresos_AcCatPartidaFlujo");

                entity.HasOne(d => d.IdPolizaNavigation)
                    .WithMany(p => p.AcBancosEgresoIdPolizaNavigations)
                    .HasForeignKey(d => d.IdPoliza)
                    .HasConstraintName("FK_AcBancosEgresos_CtbPolizas");

                entity.HasOne(d => d.IdPolizaInversaNavigation)
                    .WithMany(p => p.AcBancosEgresoIdPolizaInversaNavigations)
                    .HasForeignKey(d => d.IdPolizaInversa)
                    .HasConstraintName("FK_AcBancosEgresos_CtbPolizas1");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AcBancosEgresos)
                    .HasForeignKey(d => d.IdProyecto)
                    .HasConstraintName("FK_AcBancosEgresos_Proyectos");

                entity.HasOne(d => d.IdTipoChequeNavigation)
                    .WithMany(p => p.AcBancosEgresos)
                    .HasForeignKey(d => d.IdTipoCheque)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcBancosEgresos_AcCatTipoCheques");

                entity.HasOne(d => d.IdTipoMovBancoNavigation)
                    .WithMany(p => p.AcBancosEgresos)
                    .HasForeignKey(d => d.IdTipoMovBanco)
                    .HasConstraintName("FK_AcBancosEgresos_AcTipoMovBancos");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AcBancosEgresoIdUsuarioNavigations)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcBancosEgresos_SegUsuarios");

                entity.HasOne(d => d.IdUsuarioCancelacionNavigation)
                    .WithMany(p => p.AcBancosEgresoIdUsuarioCancelacionNavigations)
                    .HasForeignKey(d => d.IdUsuarioCancelacion)
                    .HasConstraintName("FK_AcBancosEgresos_SegUsuarios1");
            });

            modelBuilder.Entity<AcBancosEgresosCuenta>(entity =>
            {
                entity.HasKey(e => e.IdBancoEgresoCuenta);

                entity.HasIndex(e => e.IdCuenta, "IX_AcBancosEgresosCuentas")
                    .HasFillFactor(90);

                entity.Property(e => e.IdBancoEgresoCuenta).HasColumnName("idBancoEgresoCuenta");

                entity.Property(e => e.CapturarPorcentaje)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdBancoEgreso).HasColumnName("idBancoEgreso");

                entity.Property(e => e.IdCuenta).HasColumnName("idCuenta");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.MontoPesos).HasColumnType("money");

                entity.Property(e => e.Porcentaje).HasColumnType("money");

                entity.HasOne(d => d.IdBancoEgresoNavigation)
                    .WithMany(p => p.AcBancosEgresosCuenta)
                    .HasForeignKey(d => d.IdBancoEgreso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcBancosEgresosCuentas_AcBancosEgresos");

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithMany(p => p.AcBancosEgresosCuenta)
                    .HasForeignKey(d => d.IdCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcBancosEgresosCuentas_CtbCuentas");
            });

            modelBuilder.Entity<AcBancosEgresosDet>(entity =>
            {
                entity.HasKey(e => e.IdBancoEgresoDet);

                entity.ToTable("AcBancosEgresosDet");

                entity.HasIndex(e => e.IdCuentaCargo, "IX_AcBancosEgresosDet")
                    .HasFillFactor(90);

                entity.Property(e => e.IdBancoEgresoDet).HasColumnName("idBancoEgresoDet");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.IdBancoEgreso).HasColumnName("idBancoEgreso");

                entity.Property(e => e.IdCuentaCargo).HasColumnName("idCuentaCargo");

                entity.Property(e => e.IdProyecto).HasColumnName("idProyecto");

                entity.Property(e => e.Importe).HasColumnType("money");

                entity.HasOne(d => d.IdBancoEgresoNavigation)
                    .WithMany(p => p.AcBancosEgresosDets)
                    .HasForeignKey(d => d.IdBancoEgreso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcBancosEgresosDet_AcBancosEgresos");

                entity.HasOne(d => d.IdCuentaCargoNavigation)
                    .WithMany(p => p.AcBancosEgresosDets)
                    .HasForeignKey(d => d.IdCuentaCargo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcBancosEgresosDet_CtbCuentas");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AcBancosEgresosDets)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcBancosEgresosDet_Proyectos");
            });

            modelBuilder.Entity<AcBancosEgresosInsumo>(entity =>
            {
                entity.HasKey(e => e.IdBancoEgresoInsumo);

                entity.HasIndex(e => new { e.IdBancoEgreso, e.IdProyecto, e.IdExplosionInsumos }, "IX_AcBancosEgresosInsumos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdBancoEgresoInsumo).HasColumnName("idBancoEgresoInsumo");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.IdBancoEgreso).HasColumnName("idBancoEgreso");

                entity.Property(e => e.IdExplosionInsumos).HasColumnName("idExplosionInsumos");

                entity.Property(e => e.IdProyecto).HasColumnName("idProyecto");

                entity.Property(e => e.Importe).HasColumnType("money");

                entity.HasOne(d => d.IdBancoEgresoNavigation)
                    .WithMany(p => p.AcBancosEgresosInsumos)
                    .HasForeignKey(d => d.IdBancoEgreso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcBancosEgresosInsumos_AcBancosEgresos");

                entity.HasOne(d => d.IdExplosionInsumosNavigation)
                    .WithMany(p => p.AcBancosEgresosInsumos)
                    .HasForeignKey(d => d.IdExplosionInsumos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcBancosEgresosInsumos_AcExplosionInsumos");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AcBancosEgresosInsumos)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcBancosEgresosInsumos_Proyectos");
            });

            modelBuilder.Entity<AcBancosEstadoCuentum>(entity =>
            {
                entity.HasKey(e => e.IdEstadoCuenta);

                entity.Property(e => e.Abono).HasColumnType("money");

                entity.Property(e => e.Cargo).HasColumnType("money");

                entity.Property(e => e.Concepto)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .UseCollation("Traditional_Spanish_CI_AS");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Referencia)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Saldo).HasColumnType("money");

                entity.HasOne(d => d.IdCuentaBancariaNavigation)
                    .WithMany(p => p.AcBancosEstadoCuenta)
                    .HasForeignKey(d => d.IdCuentaBancaria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcBancosEstadoCuenta_AcCuentasBancarias");
            });

            modelBuilder.Entity<AcBancosIngreso>(entity =>
            {
                entity.HasKey(e => e.IdBancoIngreso);

                entity.HasIndex(e => new { e.IdCuentaBancaria, e.Deposito }, "IX_AcBancosIngresos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuentaAbono, "IX_AcBancosIngresos_1")
                    .HasFillFactor(90);

                entity.Property(e => e.IdBancoIngreso).HasColumnName("idBancoIngreso");

                entity.Property(e => e.BanEmisExt)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BancoSatdepositante)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BancoSATDepositante");

                entity.Property(e => e.CuentaBancariaDepositante)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionCancelacion)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DividirEntre)
                    .HasColumnType("decimal(19, 16)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaCancelacion).HasColumnType("datetime");

                entity.Property(e => e.IdBancoSatdepositante).HasColumnName("IdBancoSATDepositante");

                entity.Property(e => e.IdContratoPp).HasColumnName("IdContratoPP");

                entity.Property(e => e.IdCuentaBancaria).HasColumnName("idCuentaBancaria");

                entity.Property(e => e.IdTipoDeposito).HasColumnName("idTipoDeposito");

                entity.Property(e => e.MonedaSatdepositante)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MonedaSATDepositante");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.MontoPesos)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.ParidadBursatil).HasColumnType("money");

                entity.Property(e => e.Referencia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RfcDepositante)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCuentaAbonoNavigation)
                    .WithMany(p => p.AcBancosIngresos)
                    .HasForeignKey(d => d.IdCuentaAbono)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcBancosIngresos_CtbCuentas");

                entity.HasOne(d => d.IdCuentaBancariaNavigation)
                    .WithMany(p => p.AcBancosIngresos)
                    .HasForeignKey(d => d.IdCuentaBancaria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcBancosIngresos_AcCuentasBancarias");

                entity.HasOne(d => d.IdFlujoNavigation)
                    .WithMany(p => p.AcBancosIngresos)
                    .HasForeignKey(d => d.IdFlujo)
                    .HasConstraintName("FK_AcBancosIngresos_AcCatFlujos");

                entity.HasOne(d => d.IdPolizaNavigation)
                    .WithMany(p => p.AcBancosIngresoIdPolizaNavigations)
                    .HasForeignKey(d => d.IdPoliza)
                    .HasConstraintName("FK_AcBancosIngresos_CtbPolizas");

                entity.HasOne(d => d.IdPolizaInversaNavigation)
                    .WithMany(p => p.AcBancosIngresoIdPolizaInversaNavigations)
                    .HasForeignKey(d => d.IdPolizaInversa)
                    .HasConstraintName("FK_AcBancosIngresos_CtbPolizas1");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AcBancosIngresos)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcBancosIngresos_Proyectos");

                entity.HasOne(d => d.IdTipoDepositoNavigation)
                    .WithMany(p => p.AcBancosIngresos)
                    .HasForeignKey(d => d.IdTipoDeposito)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcBancosIngresos_AcCatTipoDepositos");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AcBancosIngresoIdUsuarioNavigations)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcBancosIngresos_SegUsuarios");

                entity.HasOne(d => d.IdUsuarioCancelacionNavigation)
                    .WithMany(p => p.AcBancosIngresoIdUsuarioCancelacionNavigations)
                    .HasForeignKey(d => d.IdUsuarioCancelacion)
                    .HasConstraintName("FK_AcBancosIngresos_SegUsuarios1");
            });

            modelBuilder.Entity<AcBancosIngresosCuenta>(entity =>
            {
                entity.HasKey(e => e.IdBancoIngresoCuenta);

                entity.HasIndex(e => e.IdCuenta, "IX_AcBancosIngresosCuentas")
                    .HasFillFactor(90);

                entity.Property(e => e.CapturarPorcentaje)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EsCargo)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdBancoIngreso).HasColumnName("idBancoIngreso");

                entity.Property(e => e.IdCuenta).HasColumnName("idCuenta");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.MontoPesos).HasColumnType("money");

                entity.Property(e => e.Porcentaje).HasColumnType("money");

                entity.HasOne(d => d.IdBancoIngresoNavigation)
                    .WithMany(p => p.AcBancosIngresosCuenta)
                    .HasForeignKey(d => d.IdBancoIngreso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcBancosIngresosCuentas_AcBancosIngresos");

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithMany(p => p.AcBancosIngresosCuenta)
                    .HasForeignKey(d => d.IdCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcBancosIngresosCuentas_CtbCuentas");
            });

            modelBuilder.Entity<AcBancosIngresosFactura>(entity =>
            {
                entity.HasKey(e => e.IdBancoIngresoFacturas);

                entity.HasIndex(e => new { e.IdBancoIngreso, e.IdClienteFactura }, "IX_AcBancosIngresosFacturas")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdBancoIngreso).HasColumnName("idBancoIngreso");

                entity.Property(e => e.IdClienteFactura).HasColumnName("idClienteFactura");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.MontoDls).HasColumnType("money");

                entity.HasOne(d => d.IdBancoIngresoNavigation)
                    .WithMany(p => p.AcBancosIngresosFacturas)
                    .HasForeignKey(d => d.IdBancoIngreso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcBancosIngresosFacturas_AcBancosIngresos");

                entity.HasOne(d => d.IdClienteFacturaNavigation)
                    .WithMany(p => p.AcBancosIngresosFacturas)
                    .HasForeignKey(d => d.IdClienteFactura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcBancosIngresosFacturas_AcClientesFacturas");
            });

            modelBuilder.Entity<AcBancosTraspaso>(entity =>
            {
                entity.HasKey(e => e.IdBancoTraspaso);

                entity.HasIndex(e => new { e.Folio, e.TipoMovimiento }, "IX_AcBancosTraspasos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.BanEmisExt)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BancoSatmovimiento)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BancoSATMovimiento");

                entity.Property(e => e.CuentaBancariaMovimiento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaCancelacion).HasColumnType("datetime");

                entity.Property(e => e.IdBancoSatmovimiento).HasColumnName("IdBancoSATMovimiento");

                entity.Property(e => e.MonedaSatmovimiento)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MonedaSATMovimiento");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.MontoIsr)
                    .HasColumnType("money")
                    .HasColumnName("MontoISR");

                entity.Property(e => e.PorcentajeIsr)
                    .HasColumnType("money")
                    .HasColumnName("PorcentajeISR");

                entity.Property(e => e.ProductoFinanciero).HasColumnType("money");

                entity.Property(e => e.Referencia)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.RfcMovimiento)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TipoMovimiento).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdCuentaBancariaDestinoNavigation)
                    .WithMany(p => p.AcBancosTraspasoIdCuentaBancariaDestinoNavigations)
                    .HasForeignKey(d => d.IdCuentaBancariaDestino)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcBancosTraspasos_AcCuentasBancarias1");

                entity.HasOne(d => d.IdCuentaBancariaOrigenNavigation)
                    .WithMany(p => p.AcBancosTraspasoIdCuentaBancariaOrigenNavigations)
                    .HasForeignKey(d => d.IdCuentaBancariaOrigen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcBancosTraspasos_AcCuentasBancarias");

                entity.HasOne(d => d.IdPolizaNavigation)
                    .WithMany(p => p.AcBancosTraspasoIdPolizaNavigations)
                    .HasForeignKey(d => d.IdPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcBancosTraspasos_CtbPolizas");

                entity.HasOne(d => d.IdPolizaInversaNavigation)
                    .WithMany(p => p.AcBancosTraspasoIdPolizaInversaNavigations)
                    .HasForeignKey(d => d.IdPolizaInversa)
                    .HasConstraintName("FK_AcBancosTraspasos_CtbPolizas1");

                entity.HasOne(d => d.IdProyectoDestinoNavigation)
                    .WithMany(p => p.AcBancosTraspasoIdProyectoDestinoNavigations)
                    .HasForeignKey(d => d.IdProyectoDestino)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcBancosTraspasos_Proyectos1");

                entity.HasOne(d => d.IdProyectoOrigenNavigation)
                    .WithMany(p => p.AcBancosTraspasoIdProyectoOrigenNavigations)
                    .HasForeignKey(d => d.IdProyectoOrigen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcBancosTraspasos_Proyectos");

                entity.HasOne(d => d.IdTipoPolizaNavigation)
                    .WithMany(p => p.AcBancosTraspasos)
                    .HasForeignKey(d => d.IdTipoPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcBancosTraspasos_CtbTiposPoliza");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AcBancosTraspasoIdUsuarioNavigations)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcBancosTraspasos_SegUsuarios");

                entity.HasOne(d => d.IdUsuarioCancelacionNavigation)
                    .WithMany(p => p.AcBancosTraspasoIdUsuarioCancelacionNavigations)
                    .HasForeignKey(d => d.IdUsuarioCancelacion)
                    .HasConstraintName("FK_AcBancosTraspasos_SegUsuarios1");
            });

            modelBuilder.Entity<AcCatAcreedore>(entity =>
            {
                entity.HasKey(e => e.IdAcreedor);

                entity.HasIndex(e => e.Rfc, "IX_AcCatAcreedores")
                    .IsUnique();

                entity.Property(e => e.IdAcreedor).HasColumnName("idAcreedor");

                entity.Property(e => e.BancoSat)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BancoSAT");

                entity.Property(e => e.Celular)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CodPost)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaBancaria)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Curp)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("CURP");

                entity.Property(e => e.Delegacion)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.IdBancoSat).HasColumnName("IdBancoSAT");

                entity.Property(e => e.IdCiudad).HasColumnName("idCiudad");

                entity.Property(e => e.Mail)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.MonedaSatdefault)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MonedaSATDefault");

                entity.Property(e => e.RazonSocial)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCuentaAcreedorNavigation)
                    .WithMany(p => p.AcCatAcreedores)
                    .HasForeignKey(d => d.IdCuentaAcreedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcCatAcreedores_CtbCuentas");
            });

            modelBuilder.Entity<AcCatAduanasSat>(entity =>
            {
                entity.HasKey(e => e.IdAduana);

                entity.ToTable("AcCatAduanasSAT");

                entity.HasIndex(e => e.CodigoAduana, "IX_AcCatAduanasSAT")
                    .IsUnique();

                entity.Property(e => e.CodigoAduana)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FechaFinVig).HasColumnType("datetime");

                entity.Property(e => e.FechaIniVig).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('v3.3')");
            });

            modelBuilder.Entity<AcCatBancosSat>(entity =>
            {
                entity.HasKey(e => e.IdBancoSat);

                entity.ToTable("AcCatBancosSAT");

                entity.HasIndex(e => e.Clave, "IX_AcCatBancosSAT")
                    .IsUnique();

                entity.Property(e => e.IdBancoSat).HasColumnName("IdBancoSAT");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCorto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AcCatCategoriasProrrateo>(entity =>
            {
                entity.HasKey(e => e.IdCategoriaProrrateo);

                entity.ToTable("AcCatCategoriasProrrateo");

                entity.HasIndex(e => e.Categoria, "IX_AcCatCategoriasProrrateo")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuentaCargo, "IX_AcCatCategoriasProrrateo_1")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuentaAbono, "IX_AcCatCategoriasProrrateo_2")
                    .HasFillFactor(90);

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CostoDia).HasColumnType("money");

                entity.Property(e => e.CostoHora).HasColumnType("money");

                entity.Property(e => e.CostoMes).HasColumnType("money");

                entity.Property(e => e.CostoSemana).HasColumnType("money");

                entity.HasOne(d => d.IdCuentaAbonoNavigation)
                    .WithMany(p => p.AcCatCategoriasProrrateoIdCuentaAbonoNavigations)
                    .HasForeignKey(d => d.IdCuentaAbono)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcCatCategoriasProrrateo_CtbCuentas1");

                entity.HasOne(d => d.IdCuentaCargoNavigation)
                    .WithMany(p => p.AcCatCategoriasProrrateoIdCuentaCargoNavigations)
                    .HasForeignKey(d => d.IdCuentaCargo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcCatCategoriasProrrateo_CtbCuentas");
            });

            modelBuilder.Entity<AcCatCiudade>(entity =>
            {
                entity.HasKey(e => e.IdCiudad);

                entity.HasIndex(e => e.Ciudad, "IX_AcCatCiudades")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.AcCatCiudades)
                    .HasForeignKey(d => d.IdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcCatCiudades_AcCatEstados");
            });

            modelBuilder.Entity<AcCatClavesTransferencia>(entity =>
            {
                entity.HasKey(e => e.IdClaveTransferencia);

                entity.HasIndex(e => e.ClaveTransferencia, "IX_AcCatClavesTransferencias")
                    .IsUnique();

                entity.Property(e => e.ClaveTransferencia)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.NumInstitucion)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AcCatCodigosPostalesSat>(entity =>
            {
                entity.HasKey(e => e.IdCodigoPostalSat);

                entity.ToTable("AcCatCodigosPostalesSAT");

                entity.HasIndex(e => new { e.CodigoPostalSat, e.CodigoEstadoSat, e.CodigoMunicipioSat, e.CodigoLocalidadSat }, "IX_AcCatCodigosPostalesSAT")
                    .IsUnique();

                entity.Property(e => e.IdCodigoPostalSat).HasColumnName("IdCodigoPostalSAT");

                entity.Property(e => e.CodigoEstadoSat)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CodigoEstadoSAT");

                entity.Property(e => e.CodigoLocalidadSat)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CodigoLocalidadSAT");

                entity.Property(e => e.CodigoMunicipioSat)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CodigoMunicipioSAT");

                entity.Property(e => e.CodigoPostalSat)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CodigoPostalSAT");

                entity.Property(e => e.FechaFinVig).HasColumnType("datetime");

                entity.Property(e => e.FechaIniVig).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('v3.3')");
            });

            modelBuilder.Entity<AcCatConceptosIetu>(entity =>
            {
                entity.HasKey(e => e.IdConceptoIetu);

                entity.ToTable("AcCatConceptosIETU");

                entity.HasIndex(e => e.ConceptoIetu, "IX_AcCatConceptosIETU")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdConceptoIetu).HasColumnName("idConceptoIETU");

                entity.Property(e => e.ConceptoIetu)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ConceptoIETU");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AcCatContratosStatus>(entity =>
            {
                entity.HasKey(e => e.IdCatStatus);

                entity.ToTable("AcCatContratosStatus");

                entity.HasIndex(e => e.Codigo, "IX_AcCatContratosStatus")
                    .IsUnique();

                entity.Property(e => e.IdCatStatus).HasColumnName("idCatStatus");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AcCatDeudore>(entity =>
            {
                entity.HasKey(e => e.IdDeudor);

                entity.HasIndex(e => e.Rfc, "IX_AcCatDeudores")
                    .IsUnique();

                entity.Property(e => e.IdDeudor).HasColumnName("idDeudor");

                entity.Property(e => e.BancoSat)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BancoSAT");

                entity.Property(e => e.Celular)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CodPost)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaBancaria)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Curp)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("CURP");

                entity.Property(e => e.Delegacion)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.IdBancoSat).HasColumnName("IdBancoSAT");

                entity.Property(e => e.IdCiudad).HasColumnName("idCiudad");

                entity.Property(e => e.Mail)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.MonedaSatdefault)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MonedaSATDefault");

                entity.Property(e => e.RazonSocial)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCuentaDeudorNavigation)
                    .WithMany(p => p.AcCatDeudores)
                    .HasForeignKey(d => d.IdCuentaDeudor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcCatDeudores_CtbCuentas");
            });

            modelBuilder.Entity<AcCatEstado>(entity =>
            {
                entity.HasKey(e => e.IdEstado)
                    .HasName("PK_Estados");

                entity.HasIndex(e => e.Estado, "IxEstadoCodigo")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.ClaveEstadoSat)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ClaveEstadoSAT");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoInegi)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("EstadoINEGI")
                    .HasDefaultValueSql("('00')");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AcCatFlujo>(entity =>
            {
                entity.HasKey(e => e.IdFlujo)
                    .HasName("PK_AcCatFl");

                entity.HasIndex(e => e.Codigo, "IX_AcCatFl")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.GenerarDiot).HasColumnName("GenerarDIOT");

                entity.Property(e => e.GenerarIetu).HasColumnName("GenerarIETU");

                entity.Property(e => e.IdConceptoIetu).HasColumnName("idConceptoIETU");

                entity.HasOne(d => d.IdConceptoIetuNavigation)
                    .WithMany(p => p.AcCatFlujos)
                    .HasForeignKey(d => d.IdConceptoIetu)
                    .HasConstraintName("FK_AcCatFlujos_AcCatConceptosIETU");
            });

            modelBuilder.Entity<AcCatFlujoEfectivoOtrosIngresosEgreso>(entity =>
            {
                entity.HasKey(e => e.IdTipoOtroIngresoEgreso);

                entity.HasIndex(e => e.TipoOtroIngresoEgreso, "IX_AcCatFlujoEfectivoOtrosIngresosEgresos")
                    .IsUnique();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.TipoOtroIngresoEgreso)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<AcCatFormasPagoSat>(entity =>
            {
                entity.HasKey(e => e.IdFormaPago);

                entity.ToTable("AcCatFormasPagoSAT");

                entity.HasIndex(e => e.FormaPago, "IX_AcCatFormasPagoSAT")
                    .IsUnique();

                entity.Property(e => e.Bancarizado)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.BancoEmisorExtranjero)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CtaBeneficiario)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.CtaOrdenante)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.FechaFinVig).HasColumnType("datetime");

                entity.Property(e => e.FechaIniVig).HasColumnType("datetime");

                entity.Property(e => e.FormaPago)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NoOperacion)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.PatronCtaBen)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PatronCtaOrd)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.RfcemisorCtaBen)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("RFCEmisorCtaBen");

                entity.Property(e => e.RfcemisorCtaOrd)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("RFCEmisorCtaOrd");

                entity.Property(e => e.TipoCadenaPago)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('v3.3')");
            });

            modelBuilder.Entity<AcCatGiro>(entity =>
            {
                entity.HasKey(e => e.IdGiro)
                    .HasName("aaaaaGiros_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.Giro, "IX_Giros_Unico")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdGiro).HasColumnName("idGiro");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Giro)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('GIRO')");
            });

            modelBuilder.Entity<AcCatInsumo>(entity =>
            {
                entity.HasKey(e => e.IdInsumo)
                    .HasName("aaaaaCatalogo_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.IdCuenta, "IX_AcCatInsumos")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Insumo, "Ix_Insumo")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdInsumo).HasColumnName("idInsumo");

                entity.Property(e => e.CantidadMinimaDeCompra).HasColumnType("money");

                entity.Property(e => e.ControladoXprograma)
                    .IsRequired()
                    .HasColumnName("ControladoXPrograma")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Costo).HasColumnType("money");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionLarga)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.FactorDeConversion)
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaCalculo).HasColumnType("datetime");

                entity.Property(e => e.IdCuenta).HasColumnName("idCuenta");

                entity.Property(e => e.IdFamilia).HasColumnName("idFamilia");

                entity.Property(e => e.IdInsumoPadre).HasColumnName("idInsumoPadre");

                entity.Property(e => e.IdProveedorDefault).HasColumnName("idProveedorDefault");

                entity.Property(e => e.IdTipoInsumo).HasColumnName("idTipoInsumo");

                entity.Property(e => e.IdTipoMoneda).HasColumnName("idTipoMoneda");

                entity.Property(e => e.IdUnidad).HasColumnName("idUnidad");

                entity.Property(e => e.Insumo)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.PagoComisionesCv).HasColumnName("PagoComisionesCV");

                entity.Property(e => e.PrecioVentaAlzado).HasColumnType("money");

                entity.Property(e => e.PrecioVentaCalculado).HasColumnType("money");

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithMany(p => p.AcCatInsumos)
                    .HasForeignKey(d => d.IdCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcCatInsumos_Cuentas");

                entity.HasOne(d => d.IdFamiliaNavigation)
                    .WithMany(p => p.AcCatInsumos)
                    .HasForeignKey(d => d.IdFamilia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcCatInsumos_Familias");

                entity.HasOne(d => d.IdProveedorDefaultNavigation)
                    .WithMany(p => p.AcCatInsumos)
                    .HasForeignKey(d => d.IdProveedorDefault)
                    .HasConstraintName("FK_AcCatInsumos_AcProveedores");

                entity.HasOne(d => d.IdTipoInsumoNavigation)
                    .WithMany(p => p.AcCatInsumos)
                    .HasForeignKey(d => d.IdTipoInsumo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcCatInsumos_AcTiposInsumos");

                entity.HasOne(d => d.IdTipoMonedaNavigation)
                    .WithMany(p => p.AcCatInsumos)
                    .HasForeignKey(d => d.IdTipoMoneda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcCatInsumos_AcCatMonedas");

                entity.HasOne(d => d.IdUnidadNavigation)
                    .WithMany(p => p.AcCatInsumoIdUnidadNavigations)
                    .HasForeignKey(d => d.IdUnidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcCatInsumos_AcCatUnidades");

                entity.HasOne(d => d.IdUnidadConversionNavigation)
                    .WithMany(p => p.AcCatInsumoIdUnidadConversionNavigations)
                    .HasForeignKey(d => d.IdUnidadConversion)
                    .HasConstraintName("FK_AcCatInsumos_AcCatUnidades1");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AcCatInsumos)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcCatInsumos_SegUsuarios");
            });

            modelBuilder.Entity<AcCatInsumosProrrateo>(entity =>
            {
                entity.HasKey(e => e.IdInsumoProrrateo);

                entity.ToTable("AcCatInsumosProrrateo");

                entity.HasIndex(e => e.InsumoProrrateo, "IX_AcCatInsumosProrrateo")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.CostoDia).HasColumnType("money");

                entity.Property(e => e.CostoHora).HasColumnType("money");

                entity.Property(e => e.CostoMes).HasColumnType("money");

                entity.Property(e => e.CostoSemana).HasColumnType("money");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.InsumoProrrateo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCategoriaProrrateoNavigation)
                    .WithMany(p => p.AcCatInsumosProrrateos)
                    .HasForeignKey(d => d.IdCategoriaProrrateo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcCatInsumosProrrateo_AcCatCategoriasProrrateo");

                entity.HasOne(d => d.IdProyectoAbonoNavigation)
                    .WithMany(p => p.AcCatInsumosProrrateos)
                    .HasForeignKey(d => d.IdProyectoAbono)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcCatInsumosProrrateo_Proyectos");
            });

            modelBuilder.Entity<AcCatMetodosPagoSat>(entity =>
            {
                entity.HasKey(e => e.IdMetodoPago);

                entity.ToTable("AcCatMetodosPagoSAT");

                entity.HasIndex(e => e.Codigo, "IX_AcCatMetodosPagoSAT")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaFinVig).HasColumnType("datetime");

                entity.Property(e => e.FechaIniVig).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('v3.2')");
            });

            modelBuilder.Entity<AcCatMoneda>(entity =>
            {
                entity.HasKey(e => e.IdTipoMoneda)
                    .HasName("aaaaaMonedas_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.TipoMoneda, "IX_AcCatMonedas")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdTipoMoneda).HasColumnName("idTipoMoneda");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionParaExportar)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdCatMonedasSat).HasColumnName("IdCatMonedasSAT");

                entity.Property(e => e.Paridad)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RemateMoneda)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCatMonedasSatNavigation)
                    .WithMany(p => p.AcCatMoneda)
                    .HasForeignKey(d => d.IdCatMonedasSat)
                    .HasConstraintName("FK_AcCatMonedas_CtbCatMonedasSAT");
            });

            modelBuilder.Entity<AcCatMonedasDet>(entity =>
            {
                entity.HasKey(e => e.IdMonedaDet)
                    .HasName("PK_MonedasDet");

                entity.ToTable("AcCatMonedasDet");

                entity.HasIndex(e => new { e.IdTipoMoneda, e.Fecha }, "IX_MonedasDet")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdTipoMoneda).HasColumnName("idTipoMoneda");

                entity.Property(e => e.Paridad).HasColumnType("money");

                entity.HasOne(d => d.IdTipoMonedaNavigation)
                    .WithMany(p => p.AcCatMonedasDets)
                    .HasForeignKey(d => d.IdTipoMoneda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcMonedasParidad_AcCatMonedas");
            });

            modelBuilder.Entity<AcCatNumsPedimentoAdSat>(entity =>
            {
                entity.HasKey(e => e.IdNumPedimentoAdSat);

                entity.ToTable("AcCatNumsPedimentoAdSAT");

                entity.HasIndex(e => new { e.CodigoAduana, e.CodigoPatenteAduanal, e.EjercicioSat, e.CantidadSat }, "IX_AcCatNumsPedimentoAdSAT")
                    .IsUnique();

                entity.Property(e => e.IdNumPedimentoAdSat).HasColumnName("IdNumPedimentoAdSAT");

                entity.Property(e => e.CantidadSat)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("CantidadSAT");

                entity.Property(e => e.CodigoAduana)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPatenteAduanal)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.EjercicioSat)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("EjercicioSAT");

                entity.Property(e => e.FechaFinVig).HasColumnType("datetime");

                entity.Property(e => e.FechaIniVig).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('v3.3')");
            });

            modelBuilder.Entity<AcCatPaise>(entity =>
            {
                entity.HasKey(e => e.IdPais);

                entity.HasIndex(e => e.ClavePais, "IX_AcCatPaises")
                    .IsUnique();

                entity.Property(e => e.Agrupaciones)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ClavePais)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionPais)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FormatoCp)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("FormatoCP");

                entity.Property(e => e.FormatoRegIdTrib)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ValidacionRegIdTrib)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('v3.2')");
            });

            modelBuilder.Entity<AcCatPartidaFlujo>(entity =>
            {
                entity.HasKey(e => e.IdPartidaFlujo);

                entity.ToTable("AcCatPartidaFlujo");

                entity.Property(e => e.AceptaMov)
                    .IsRequired()
                    .HasColumnName("Acepta_Mov")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MontoPresupuesto).HasColumnType("money");

                entity.Property(e => e.PartidaFlujo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AcCatPatentesAduanalesSat>(entity =>
            {
                entity.HasKey(e => e.IdPatenteAduanal);

                entity.ToTable("AcCatPatentesAduanalesSAT");

                entity.HasIndex(e => e.CodigoPatenteAduanal, "IX_AcCatPatentesAduanalesSAT")
                    .IsUnique();

                entity.Property(e => e.CodigoPatenteAduanal)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FechaFinVig).HasColumnType("datetime");

                entity.Property(e => e.FechaIniVig).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('v3.3')");
            });

            modelBuilder.Entity<AcCatPlantillasCorreo>(entity =>
            {
                entity.HasKey(e => e.IdPlantillaCorreo);

                entity.ToTable("AcCatPlantillasCorreo");

                entity.HasIndex(e => e.Plantilla, "IX_AcCatPlantillasCorreo")
                    .IsUnique();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Plantilla)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Urlplantilla)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("URLplantilla");
            });

            modelBuilder.Entity<AcCatProductosServicioSat>(entity =>
            {
                entity.HasKey(e => e.IdProductoServicioSat);

                entity.ToTable("AcCatProductosServicioSAT");

                entity.HasIndex(e => e.ClaveProductoServicio, "IX_AcCatProductosServicioSAT")
                    .IsUnique();

                entity.Property(e => e.IdProductoServicioSat).HasColumnName("IdProductoServicioSAT");

                entity.Property(e => e.ClaveProductoServicio)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ComplementoAincluirPs)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ComplementoAIncluirPS");

                entity.Property(e => e.DescripcionProductoServicio)
                    .IsRequired()
                    .HasMaxLength(147)
                    .IsUnicode(false);

                entity.Property(e => e.FechaFinVig).HasColumnType("datetime");

                entity.Property(e => e.FechaIniVig).HasColumnType("datetime");

                entity.Property(e => e.IncluirIepstrasladadoPs)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("IncluirIEPSTrasladadoPS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IncluirIvaTprodServ)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("IncluirIvaTProdServ")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PalabrasSimilares)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('v3.3')");
            });

            modelBuilder.Entity<AcCatRegimenesFiscalesSat>(entity =>
            {
                entity.HasKey(e => e.IdCatRegimen);

                entity.ToTable("AcCatRegimenesFiscalesSAT");

                entity.HasIndex(e => e.CodigoRegimen, "IX_AcCatRegimenesFiscalesSAT")
                    .IsUnique();

                entity.Property(e => e.AplicaPfisica).HasColumnName("AplicaPFisica");

                entity.Property(e => e.AplicaPmoral).HasColumnName("AplicaPMoral");

                entity.Property(e => e.CodigoRegimen)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.DescripcionRegimen)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FechaFinVig).HasColumnType("datetime");

                entity.Property(e => e.FechaIniVig).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('v3.3')");
            });

            modelBuilder.Entity<AcCatTasaOcuotaSat>(entity =>
            {
                entity.HasKey(e => e.IdTasaOcuota);

                entity.ToTable("AcCatTasaOCuotaSAT");

                entity.Property(e => e.IdTasaOcuota).HasColumnName("IdTasaOCuota");

                entity.Property(e => e.CodigoFactor)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionImpuesto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaFinVig).HasColumnType("datetime");

                entity.Property(e => e.FechaIniVig).HasColumnType("datetime");

                entity.Property(e => e.RangoOfijo)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("RangoOFijo");

                entity.Property(e => e.ValorMaximo).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ValorMinimo).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('v3.3')");
            });

            modelBuilder.Entity<AcCatTipoCheque>(entity =>
            {
                entity.HasKey(e => e.IdTipoCheque);

                entity.HasIndex(e => e.TipoCheque, "IX_AcCatTipoCheques")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DividirEntre).HasColumnType("decimal(19, 16)");

                entity.Property(e => e.IdFlujo).HasColumnName("idFlujo");

                entity.Property(e => e.TipoCheque)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdFlujoNavigation)
                    .WithMany(p => p.AcCatTipoCheques)
                    .HasForeignKey(d => d.IdFlujo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcCatTipoCheques_AcCatFlujos");

                entity.HasOne(d => d.IdTipoPolizaNavigation)
                    .WithMany(p => p.AcCatTipoCheques)
                    .HasForeignKey(d => d.IdTipoPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcCatTipoCheques_CtbTiposPoliza");
            });

            modelBuilder.Entity<AcCatTipoChequeDet>(entity =>
            {
                entity.HasKey(e => e.IdTipoChequeDet);

                entity.ToTable("AcCatTipoChequeDet");

                entity.HasIndex(e => new { e.IdTipoCheque, e.Renglon }, "IX_AcCatTipoChequeDet")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdCuenta).HasColumnName("idCuenta");

                entity.Property(e => e.IdTipoCheque).HasColumnName("idTipoCheque");

                entity.Property(e => e.Porcentaje).HasColumnType("money");

                entity.Property(e => e.Renglon).HasDefaultValueSql("((1))");

                entity.Property(e => e.SeCarga)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SecuenciaDeCalculo).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdTipoChequeNavigation)
                    .WithMany(p => p.AcCatTipoChequeDets)
                    .HasForeignKey(d => d.IdTipoCheque)
                    .HasConstraintName("FK_AcCatTipoChequeDet_AcCatTipoCheques");
            });

            modelBuilder.Entity<AcCatTipoClientesCuenta>(entity =>
            {
                entity.HasKey(e => e.IdTipoClienteCuenta);

                entity.HasIndex(e => new { e.IdTipoCliente, e.IdCuenta, e.ParaAnticipo }, "IX_AcCatTipoClientesCuentas")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuenta, "IX_AcCatTipoClientesCuentas_1")
                    .HasFillFactor(90);

                entity.Property(e => e.IdTipoClienteCuenta).HasColumnName("idTipoClienteCuenta");

                entity.Property(e => e.DescripcionFactura)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.EsCargo)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FeRetencionFisr).HasColumnName("FeRetencionFISR");

                entity.Property(e => e.FeRetencionFiva).HasColumnName("FeRetencionFIVA");

                entity.Property(e => e.IdCuenta).HasColumnName("idCuenta");

                entity.Property(e => e.IdTipoCliente).HasColumnName("idTipoCliente");

                entity.Property(e => e.Porcentaje).HasColumnType("money");

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithMany(p => p.AcCatTipoClientesCuenta)
                    .HasForeignKey(d => d.IdCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcCatTipoClientesCuentas_CtbCuentas");

                entity.HasOne(d => d.IdTipoClienteNavigation)
                    .WithMany(p => p.AcCatTipoClientesCuenta)
                    .HasForeignKey(d => d.IdTipoCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcCatTipoClientesCuentas_AcCatTiposCliente");
            });

            modelBuilder.Entity<AcCatTipoConceptosCliente>(entity =>
            {
                entity.HasKey(e => e.IdTipoConceptoCliente);

                entity.ToTable("AcCatTipoConceptosCliente");

                entity.HasIndex(e => e.TipoConceptoCliente, "IX_AcCatTipoConceptosCliente")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuentaIngreso, "IX_AcCatTipoConceptosCliente_1")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuentaNc, "IX_AcCatTipoConceptosCliente_2")
                    .HasFillFactor(90);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.IdCuentaNc).HasColumnName("IdCuentaNC");

                entity.Property(e => e.TipoConceptoCliente)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCuentaIngresoNavigation)
                    .WithMany(p => p.AcCatTipoConceptosClienteIdCuentaIngresoNavigations)
                    .HasForeignKey(d => d.IdCuentaIngreso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcCatTipoConceptosCliente_CtbCuentas");

                entity.HasOne(d => d.IdCuentaNcNavigation)
                    .WithMany(p => p.AcCatTipoConceptosClienteIdCuentaNcNavigations)
                    .HasForeignKey(d => d.IdCuentaNc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcCatTipoConceptosCliente_CtbCuentas1");
            });

            modelBuilder.Entity<AcCatTipoDeposito>(entity =>
            {
                entity.HasKey(e => e.IdTipoDeposito);

                entity.HasIndex(e => e.TipoDeposito, "IX_AcCatTipoDepositos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DividirEntre).HasColumnType("decimal(19, 16)");

                entity.Property(e => e.TipoDeposito)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdFlujoNavigation)
                    .WithMany(p => p.AcCatTipoDepositos)
                    .HasForeignKey(d => d.IdFlujo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcCatTipoDepositos_AcCatFlujos");

                entity.HasOne(d => d.IdTipoPolizaNavigation)
                    .WithMany(p => p.AcCatTipoDepositos)
                    .HasForeignKey(d => d.IdTipoPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcCatTipoDepositos_CtbTiposPoliza");
            });

            modelBuilder.Entity<AcCatTipoDepositosDet>(entity =>
            {
                entity.HasKey(e => e.IdTipoDepositoDet);

                entity.ToTable("AcCatTipoDepositosDet");

                entity.HasIndex(e => e.IdCuenta, "IX_AcCatTipoDepositosDet")
                    .HasFillFactor(90);

                entity.Property(e => e.IdCuenta).HasColumnName("idCuenta");

                entity.Property(e => e.IdTipoDeposito).HasColumnName("idTipoDeposito");

                entity.Property(e => e.Porcentaje).HasColumnType("money");

                entity.Property(e => e.Renglon).HasDefaultValueSql("((1))");

                entity.Property(e => e.SeCarga)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SecuenciaDeCalculo).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithMany(p => p.AcCatTipoDepositosDets)
                    .HasForeignKey(d => d.IdCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcCatTipoDepositosDet_CtbCuentas");

                entity.HasOne(d => d.IdTipoDepositoNavigation)
                    .WithMany(p => p.AcCatTipoDepositosDets)
                    .HasForeignKey(d => d.IdTipoDeposito)
                    .HasConstraintName("FK_AcCatTipoDepositosDet_AcCatTipoDepositos");
            });

            modelBuilder.Entity<AcCatTipoProveedor>(entity =>
            {
                entity.HasKey(e => e.IdTipoProveedor)
                    .HasName("aaaaaTipoProveedor_PK")
                    .IsClustered(false);

                entity.ToTable("AcCatTipoProveedor");

                entity.HasIndex(e => e.IdCuentaProveedor, "IX_AcCatTipoProveedor")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuentaAnticipo, "IX_AcCatTipoProveedor_1")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuentaFonGar, "IX_AcCatTipoProveedor_2")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.TipoProveedor, "IX_TipoProveedor_Unico")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdTipoProveedor).HasColumnName("idTipoProveedor");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.FactorAplicarImportes)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdCuentaAnticipo).HasColumnName("idCuentaAnticipo");

                entity.Property(e => e.IdCuentaFonGar).HasColumnName("idCuentaFonGar");

                entity.Property(e => e.IdCuentaProveedor).HasColumnName("idCuentaProveedor");

                entity.Property(e => e.TipoProveedor)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCuentaAnticipoNavigation)
                    .WithMany(p => p.AcCatTipoProveedorIdCuentaAnticipoNavigations)
                    .HasForeignKey(d => d.IdCuentaAnticipo)
                    .HasConstraintName("FK_AcCatTipoProveedor_Cuentas1");

                entity.HasOne(d => d.IdCuentaFonGarNavigation)
                    .WithMany(p => p.AcCatTipoProveedorIdCuentaFonGarNavigations)
                    .HasForeignKey(d => d.IdCuentaFonGar)
                    .HasConstraintName("FK_AcCatTipoProveedor_Cuentas2");

                entity.HasOne(d => d.IdCuentaOtrasRetencionesNavigation)
                    .WithMany(p => p.AcCatTipoProveedorIdCuentaOtrasRetencionesNavigations)
                    .HasForeignKey(d => d.IdCuentaOtrasRetenciones)
                    .HasConstraintName("FK_AcCatTipoProveedor_CtbCuentas1");

                entity.HasOne(d => d.IdCuentaPagoEnEspecieNavigation)
                    .WithMany(p => p.AcCatTipoProveedorIdCuentaPagoEnEspecieNavigations)
                    .HasForeignKey(d => d.IdCuentaPagoEnEspecie)
                    .HasConstraintName("FK_AcCatTipoProveedor_CtbCuentas");

                entity.HasOne(d => d.IdCuentaProveedorNavigation)
                    .WithMany(p => p.AcCatTipoProveedorIdCuentaProveedorNavigations)
                    .HasForeignKey(d => d.IdCuentaProveedor)
                    .HasConstraintName("FK_AcCatTipoProveedor_Cuentas");

                entity.HasOne(d => d.IdTipoChequeNavigation)
                    .WithMany(p => p.AcCatTipoProveedors)
                    .HasForeignKey(d => d.IdTipoCheque)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcCatTipoProveedor_AcCatTipoCheques");

                entity.HasOne(d => d.IdTipoPolizaNavigation)
                    .WithMany(p => p.AcCatTipoProveedors)
                    .HasForeignKey(d => d.IdTipoPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcCatTipoProveedor_CtbTiposPoliza");
            });

            modelBuilder.Entity<AcCatTipoProveedorCuenta>(entity =>
            {
                entity.HasKey(e => e.IdTipoProveedorCuenta)
                    .HasName("PK_AcTipoProveedorCuentas");

                entity.HasIndex(e => new { e.IdTipoProveedor, e.IdCuenta, e.ParaAnticipo }, "IX_AcCatTipoProveedorCuentas")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuenta, "IX_AcCatTipoProveedorCuentas_1")
                    .HasFillFactor(90);

                entity.Property(e => e.IdTipoProveedorCuenta).HasColumnName("idTipoProveedorCuenta");

                entity.Property(e => e.DescripcionFactura)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.IdCuenta).HasColumnName("idCuenta");

                entity.Property(e => e.IdTipoProveedor).HasColumnName("idTipoProveedor");

                entity.Property(e => e.Porcentaje).HasColumnType("money");

                entity.Property(e => e.SeCarga)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SecuenciaDeCalculo).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithMany(p => p.AcCatTipoProveedorCuenta)
                    .HasForeignKey(d => d.IdCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcTipoProveedorCuentas_Cuentas");

                entity.HasOne(d => d.IdTipoProveedorNavigation)
                    .WithMany(p => p.AcCatTipoProveedorCuenta)
                    .HasForeignKey(d => d.IdTipoProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcTipoProveedorCuentas_AcCatTipoProveedor");
            });

            modelBuilder.Entity<AcCatTipoUnidadesNegocio>(entity =>
            {
                entity.HasKey(e => e.IdTipoUnidadNegocio);

                entity.ToTable("AcCatTipoUnidadesNegocio");

                entity.HasIndex(e => e.TipoUnidadNegocio, "IX_AcCatTipoUnidadesNegocio_TipoUN")
                    .IsUnique();

                entity.Property(e => e.IdTipoUnidadNegocio).HasColumnName("idTipoUnidadNegocio");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TipoUnidadNegocio)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AcCatTiposCliente>(entity =>
            {
                entity.HasKey(e => e.IdTipoCliente);

                entity.ToTable("AcCatTiposCliente");

                entity.HasIndex(e => e.IdCuentaCliente, "IX_AcCatTiposCliente")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuentaAnticipo, "IX_AcCatTiposCliente_1")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuentaFonGar, "IX_AcCatTiposCliente_2")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.TipoCliente, "IX_TipoCliente_Unico")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdTipoCliente).HasColumnName("idTipoCliente");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCuentaAnticipo).HasColumnName("idCuentaAnticipo");

                entity.Property(e => e.IdCuentaCliente).HasColumnName("idCuentaCliente");

                entity.Property(e => e.IdCuentaFonGar).HasColumnName("idCuentaFonGar");

                entity.Property(e => e.TipoCliente)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCuentaAnticipoNavigation)
                    .WithMany(p => p.AcCatTiposClienteIdCuentaAnticipoNavigations)
                    .HasForeignKey(d => d.IdCuentaAnticipo)
                    .HasConstraintName("FK_AcCatTiposCliente_CtbCuentas1");

                entity.HasOne(d => d.IdCuentaClienteNavigation)
                    .WithMany(p => p.AcCatTiposClienteIdCuentaClienteNavigations)
                    .HasForeignKey(d => d.IdCuentaCliente)
                    .HasConstraintName("FK_AcCatTiposCliente_CtbCuentas");

                entity.HasOne(d => d.IdCuentaFonGarNavigation)
                    .WithMany(p => p.AcCatTiposClienteIdCuentaFonGarNavigations)
                    .HasForeignKey(d => d.IdCuentaFonGar)
                    .HasConstraintName("FK_AcCatTiposCliente_CtbCuentas2");

                entity.HasOne(d => d.IdTipoDepositoNavigation)
                    .WithMany(p => p.AcCatTiposClientes)
                    .HasForeignKey(d => d.IdTipoDeposito)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcCatTiposCliente_AcCatTipoDepositos");

                entity.HasOne(d => d.IdTipoPolizaNavigation)
                    .WithMany(p => p.AcCatTiposClientes)
                    .HasForeignKey(d => d.IdTipoPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcCatTiposCliente_CtbTiposPoliza");
            });

            modelBuilder.Entity<AcCatTiposComprobanteSat>(entity =>
            {
                entity.HasKey(e => e.IdTipoComprobanteSat);

                entity.ToTable("AcCatTiposComprobanteSAT");

                entity.HasIndex(e => e.CodigoTipoComprobante, "IX_AcCatTiposComprobanteSAT")
                    .IsUnique();

                entity.Property(e => e.IdTipoComprobanteSat).HasColumnName("IdTipoComprobanteSAT");

                entity.Property(e => e.CodigoTipoComprobante)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionTipoComprob)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaFinVig).HasColumnType("datetime");

                entity.Property(e => e.FechaIniVig).HasColumnType("datetime");

                entity.Property(e => e.ValorMaximoTc)
                    .HasColumnType("decimal(24, 6)")
                    .HasColumnName("ValorMaximoTC");

                entity.Property(e => e.ValorMaximoTcndS)
                    .HasColumnType("decimal(24, 6)")
                    .HasColumnName("ValorMaximoTCNdS");

                entity.Property(e => e.ValosMaximoTcns)
                    .HasColumnType("decimal(24, 6)")
                    .HasColumnName("ValosMaximoTCNS");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('v3.3')");
            });

            modelBuilder.Entity<AcCatTiposFactorSat>(entity =>
            {
                entity.HasKey(e => e.IdTipoFactorSat);

                entity.ToTable("AcCatTiposFactorSAT");

                entity.HasIndex(e => e.CodigoFactor, "IX_AcCatTiposFactorSAT")
                    .IsUnique();

                entity.Property(e => e.IdTipoFactorSat).HasColumnName("IdTipoFactorSAT");

                entity.Property(e => e.CodigoFactor)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('v3.3')");
            });

            modelBuilder.Entity<AcCatTiposImpuesto>(entity =>
            {
                entity.HasKey(e => e.IdTipoImpuesto);

                entity.HasIndex(e => e.ClaveImpuesto, "IX_AcCatTiposImpuestos")
                    .IsUnique();

                entity.Property(e => e.ClaveImpuesto)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionImpuesto)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Entidad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalFederal)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('v3.2')");
            });

            modelBuilder.Entity<AcCatTiposNc>(entity =>
            {
                entity.HasKey(e => e.IdTipoNc);

                entity.ToTable("AcCatTiposNC");

                entity.HasIndex(e => e.TipoNc, "IX_AcCatTiposNC")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdTipoNc).HasColumnName("IdTipoNC");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.EsParaProveedor)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdCuentaIva).HasColumnName("IdCuentaIVA");

                entity.Property(e => e.TipoNc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TipoNC");

                entity.HasOne(d => d.IdCuentaDescuentoNavigation)
                    .WithMany(p => p.AcCatTiposNcIdCuentaDescuentoNavigations)
                    .HasForeignKey(d => d.IdCuentaDescuento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcCatTiposNC_CtbCuentas");

                entity.HasOne(d => d.IdCuentaIvaNavigation)
                    .WithMany(p => p.AcCatTiposNcIdCuentaIvaNavigations)
                    .HasForeignKey(d => d.IdCuentaIva)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcCatTiposNC_CtbCuentas1");

                entity.HasOne(d => d.IdTipoPolizaNavigation)
                    .WithMany(p => p.AcCatTiposNcs)
                    .HasForeignKey(d => d.IdTipoPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcCatTiposNC_CtbTiposPoliza");
            });

            modelBuilder.Entity<AcCatTiposRelacionSat>(entity =>
            {
                entity.HasKey(e => e.IdTipoRelacionSat);

                entity.ToTable("AcCatTiposRelacionSAT");

                entity.HasIndex(e => e.CodigoRelacionSat, "IX_AcCatTiposRelacionSAT")
                    .IsUnique();

                entity.Property(e => e.IdTipoRelacionSat).HasColumnName("IdTipoRelacionSAT");

                entity.Property(e => e.CodigoRelacionSat)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CodigoRelacionSAT");

                entity.Property(e => e.DescripcionRelacionSat)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DescripcionRelacionSAT");

                entity.Property(e => e.FechaFinVig).HasColumnType("datetime");

                entity.Property(e => e.FechaIniVig).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('v3.3')");
            });

            modelBuilder.Entity<AcCatTiposRetencione>(entity =>
            {
                entity.HasKey(e => e.IdTipoRetencion);

                entity.HasIndex(e => e.ClaveRetencion, "IX_AcCatTiposRetenciones")
                    .IsUnique();

                entity.Property(e => e.ClaveRetencion)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionRetencion)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AcCatUnidade>(entity =>
            {
                entity.HasKey(e => e.IdUnidad);

                entity.HasIndex(e => e.Unidad, "IX_AcCatUnidades")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.IdUnidadSat).HasColumnName("IdUnidadSAT");

                entity.Property(e => e.Unidad)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdUnidadSatNavigation)
                    .WithMany(p => p.AcCatUnidades)
                    .HasForeignKey(d => d.IdUnidadSat)
                    .HasConstraintName("FK_AcCatUnidades_AcCatUnidadesSAT");
            });

            modelBuilder.Entity<AcCatUnidadesSat>(entity =>
            {
                entity.HasKey(e => e.IdUnidadSat);

                entity.ToTable("AcCatUnidadesSAT");

                entity.HasIndex(e => e.ClaveUnidadSat, "IX_AcCatUnidadesSAT")
                    .IsUnique();

                entity.Property(e => e.IdUnidadSat).HasColumnName("IdUnidadSAT");

                entity.Property(e => e.ClaveUnidadSat)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ClaveUnidadSAT");

                entity.Property(e => e.DescripcionUnidadSat)
                    .HasMaxLength(600)
                    .IsUnicode(false)
                    .HasColumnName("DescripcionUnidadSAT");

                entity.Property(e => e.FechaFinVig).HasColumnType("datetime");

                entity.Property(e => e.FechaIniVig).HasColumnType("datetime");

                entity.Property(e => e.NombreUnidadSat)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("NombreUnidadSAT");

                entity.Property(e => e.NotaUnidadSat)
                    .HasMaxLength(600)
                    .IsUnicode(false)
                    .HasColumnName("NotaUnidadSAT");

                entity.Property(e => e.SimboloUnidadSat)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SimboloUnidadSAT");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('v3.3')");
            });

            modelBuilder.Entity<AcCatUsosCfdisat>(entity =>
            {
                entity.HasKey(e => e.IdUsoCfdiSat);

                entity.ToTable("AcCatUsosCFDISAT");

                entity.HasIndex(e => e.CodigoUso, "IX_AcUsosCFDISAT")
                    .IsUnique();

                entity.Property(e => e.IdUsoCfdiSat).HasColumnName("IdUsoCfdiSAT");

                entity.Property(e => e.AplicaPfisica).HasColumnName("AplicaPFisica");

                entity.Property(e => e.AplicaPmoral).HasColumnName("AplicaPMoral");

                entity.Property(e => e.CodigoUso)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionUso)
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.FechaFinVig).HasColumnType("datetime");

                entity.Property(e => e.FechaIniVig).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('v3.3')");
            });

            modelBuilder.Entity<AcCfditraslado>(entity =>
            {
                entity.HasKey(e => e.IdCfditraslado);

                entity.ToTable("AcCFDITraslado");

                entity.Property(e => e.IdCfditraslado).HasColumnName("IdCFDITraslado");

                entity.Property(e => e.DescripcionCancelacion)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.EstatusSat).HasColumnName("EstatusSAT");

                entity.Property(e => e.FechaCancelacion).HasColumnType("datetime");

                entity.Property(e => e.FechaSolicitudCancelacion).HasColumnType("datetime");

                entity.Property(e => e.FechaTimbrado).HasColumnType("datetime");

                entity.Property(e => e.FechaUltimaActualizacion).HasColumnType("datetime");

                entity.Property(e => e.FolioFiscalCfdi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FolioFiscalCFDI");

                entity.Property(e => e.IdCfditrasladoDirecciones).HasColumnName("IdCFDITrasladoDirecciones");

                entity.Property(e => e.IdTipoComprobanteSat).HasColumnName("IdTipoComprobanteSAT");

                entity.Property(e => e.IdTipoRelacionSat).HasColumnName("IdTipoRelacionSAT");

                entity.Property(e => e.IdUsoCfdiSat).HasColumnName("IdUsoCfdiSAT");

                entity.Property(e => e.NoCertificado)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones).IsUnicode(false);

                entity.Property(e => e.Serie)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCfditrasladoDireccionesNavigation)
                    .WithMany(p => p.AcCfditraslados)
                    .HasForeignKey(d => d.IdCfditrasladoDirecciones)
                    .HasConstraintName("FK_IdCFDITrasladoDirecciones_AcCFDITraslado");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.AcCfditraslados)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IdCliente_AcCFDITraslado");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AcCfditraslados)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IdProyecto_AcCFDITraslado");

                entity.HasOne(d => d.IdTipoComprobanteSatNavigation)
                    .WithMany(p => p.AcCfditraslados)
                    .HasForeignKey(d => d.IdTipoComprobanteSat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IdTipoComprobanteSAT_AcCFDITraslado");

                entity.HasOne(d => d.IdTipoRelacionSatNavigation)
                    .WithMany(p => p.AcCfditraslados)
                    .HasForeignKey(d => d.IdTipoRelacionSat)
                    .HasConstraintName("FK_IdTipoRelacionSAT_AcCFDITraslado");

                entity.HasOne(d => d.IdUsoCfdiSatNavigation)
                    .WithMany(p => p.AcCfditraslados)
                    .HasForeignKey(d => d.IdUsoCfdiSat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IdUsoCfdiSAT_AcCFDITraslado");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AcCfditrasladoIdUsuarioNavigations)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IdUsuario_AcCFDITraslado");

                entity.HasOne(d => d.IdUsuarioCancelacionNavigation)
                    .WithMany(p => p.AcCfditrasladoIdUsuarioCancelacionNavigations)
                    .HasForeignKey(d => d.IdUsuarioCancelacion)
                    .HasConstraintName("FK_IdUsuarioCancelacion_AcCFDITraslado");
            });

            modelBuilder.Entity<AcCfditrasladoCfd>(entity =>
            {
                entity.HasKey(e => e.IdCfditrasladoCfd);

                entity.ToTable("AcCFDITrasladoCFD");

                entity.Property(e => e.IdCfditrasladoCfd).HasColumnName("IdCFDITrasladoCFD");

                entity.Property(e => e.FechaHora).HasColumnType("datetime");

                entity.Property(e => e.IdCfditraslado).HasColumnName("IdCFDITraslado");

                entity.Property(e => e.Xmlcfd)
                    .IsUnicode(false)
                    .HasColumnName("XMLCFD");

                entity.HasOne(d => d.IdCfditrasladoNavigation)
                    .WithMany(p => p.AcCfditrasladoCfds)
                    .HasForeignKey(d => d.IdCfditraslado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IdCFDITraslado_AcCFDITrasladoCFD");
            });

            modelBuilder.Entity<AcCfditrasladoDet>(entity =>
            {
                entity.HasKey(e => e.IdCfditrasladoDet);

                entity.ToTable("AcCFDITrasladoDet");

                entity.Property(e => e.IdCfditrasladoDet).HasColumnName("IdCFDITrasladoDet");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.DescripcionAuxiliar).IsUnicode(false);

                entity.Property(e => e.IdCfditraslado).HasColumnName("IdCFDITraslado");

                entity.Property(e => e.IdProductoServicioSat).HasColumnName("IdProductoServicioSAT");

                entity.Property(e => e.IdUnidadSat).HasColumnName("IdUnidadSAT");

                entity.HasOne(d => d.IdCfditrasladoNavigation)
                    .WithMany(p => p.AcCfditrasladoDets)
                    .HasForeignKey(d => d.IdCfditraslado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IdCFDITraslado_AcCFDITrasladoDet");

                entity.HasOne(d => d.IdProductoServicioSatNavigation)
                    .WithMany(p => p.AcCfditrasladoDets)
                    .HasForeignKey(d => d.IdProductoServicioSat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IdProductoServicioSAT_AcCFDITrasladoDet");

                entity.HasOne(d => d.IdProyectoConceptoNavigation)
                    .WithMany(p => p.AcCfditrasladoDets)
                    .HasForeignKey(d => d.IdProyectoConcepto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IdProyectoConcepto_AcCFDITrasladoDet");

                entity.HasOne(d => d.IdUnidadSatNavigation)
                    .WithMany(p => p.AcCfditrasladoDets)
                    .HasForeignKey(d => d.IdUnidadSat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IdUnidadSAT_AcCFDITrasladoDet");
            });

            modelBuilder.Entity<AcCfditrasladoDireccione>(entity =>
            {
                entity.HasKey(e => e.IdCfditrasladoDirecciones);

                entity.ToTable("AcCFDITrasladoDirecciones");

                entity.Property(e => e.IdCfditrasladoDirecciones)
                    .ValueGeneratedNever()
                    .HasColumnName("IdCFDITrasladoDirecciones");

                entity.Property(e => e.CodigoPostal)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Delegacion)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.EntreCalles)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.NombreDireccion)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCiudadNavigation)
                    .WithMany(p => p.AcCfditrasladoDirecciones)
                    .HasForeignKey(d => d.IdCiudad)
                    .HasConstraintName("FK_IdCiudad_AcCFDITrasladoDirecciones");
            });

            modelBuilder.Entity<AcCfditrasladoRelac>(entity =>
            {
                entity.HasKey(e => e.IdCfditrasladoRelac);

                entity.ToTable("AcCFDITrasladoRelac");

                entity.Property(e => e.IdCfditrasladoRelac).HasColumnName("IdCFDITrasladoRelac");

                entity.Property(e => e.IdCfditraslado).HasColumnName("IdCFDITraslado");

                entity.Property(e => e.Uuid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("UUID");

                entity.HasOne(d => d.IdCfditrasladoNavigation)
                    .WithMany(p => p.AcCfditrasladoRelacs)
                    .HasForeignKey(d => d.IdCfditraslado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IdCFDITraslado_AcCFDITrasladoRelac");
            });

            modelBuilder.Entity<AcCliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente);

                entity.HasIndex(e => e.Cliente, "IX_AcClientes")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuenta, "IX_AcClientes_1")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuentaAnticipo, "IX_AcClientes_2")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuentaFongar, "IX_AcClientes_3")
                    .HasFillFactor(90);

                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ApellidoPaterno)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Area)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BancoSat)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BancoSAt");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPostal)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPostalCobranza)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPostalEnvio)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ColoniaCobranza)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ColoniaEnvio)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Contacto)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaBancaria)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Curp)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("CURP");

                entity.Property(e => e.Delegacion)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DelegacionCobranza)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DelegacionEnvio)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionCobranza)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionEnvio)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.EntreCallesCobranza)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.EntreCallesEnvio)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FaxCobranza)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FaxEnvio)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdBancoSat).HasColumnName("IdBancoSAT");

                entity.Property(e => e.IdCodigoPostalSat).HasColumnName("IdCodigoPostalSAT");

                entity.Property(e => e.IdCuentaFongar).HasColumnName("IdCuentaFONGAR");

                entity.Property(e => e.IdPaisSat).HasColumnName("IdPaisSAT");

                entity.Property(e => e.IdTipoCliente).HasColumnName("idTipoCliente");

                entity.Property(e => e.IdTipoMoneda).HasColumnName("idTipoMoneda");

                entity.Property(e => e.LimiteCredito).HasColumnType("money");

                entity.Property(e => e.Localidad)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.MailContacto)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.MonedaSatdefault)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MonedaSATDefault");

                entity.Property(e => e.NoExterior)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoInterior)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NumCtaPago)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NumRegIdTrib)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Pais)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PinContacto)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Referencia)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("RFC");

                entity.Property(e => e.StrMetodosPago)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoCobranza)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoContacto)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoEnvio)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Web)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCiudadNavigation)
                    .WithMany(p => p.AcClienteIdCiudadNavigations)
                    .HasForeignKey(d => d.IdCiudad)
                    .HasConstraintName("FK_AcClientes_AcCatCiudades");

                entity.HasOne(d => d.IdCiudadCobranzaNavigation)
                    .WithMany(p => p.AcClienteIdCiudadCobranzaNavigations)
                    .HasForeignKey(d => d.IdCiudadCobranza)
                    .HasConstraintName("FK_AcClientes_AcCatCiudades2");

                entity.HasOne(d => d.IdCiudadEnvioNavigation)
                    .WithMany(p => p.AcClienteIdCiudadEnvioNavigations)
                    .HasForeignKey(d => d.IdCiudadEnvio)
                    .HasConstraintName("FK_AcClientes_AcCatCiudades1");

                entity.HasOne(d => d.IdCodigoPostalSatNavigation)
                    .WithMany(p => p.AcClientes)
                    .HasForeignKey(d => d.IdCodigoPostalSat)
                    .HasConstraintName("FK_AcClientes_AcCatCodigosPostalesSAT");

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithOne(p => p.AcClienteIdCuentaNavigation)
                    .HasForeignKey<AcCliente>(d => d.IdCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcClientes_CtbCuentas");

                entity.HasOne(d => d.IdCuentaAnticipoNavigation)
                    .WithMany(p => p.AcClienteIdCuentaAnticipoNavigations)
                    .HasForeignKey(d => d.IdCuentaAnticipo)
                    .HasConstraintName("FK_AcClientes_CtbCuentas1");

                entity.HasOne(d => d.IdCuentaFongarNavigation)
                    .WithMany(p => p.AcClienteIdCuentaFongarNavigations)
                    .HasForeignKey(d => d.IdCuentaFongar)
                    .HasConstraintName("FK_AcClientes_CtbCuentas2");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.AcClientes)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_AcClientes_AcCatEstados");

                entity.HasOne(d => d.IdPaisSatNavigation)
                    .WithMany(p => p.AcClientes)
                    .HasForeignKey(d => d.IdPaisSat)
                    .HasConstraintName("FK_AcClientes_AcCatPaises");

                entity.HasOne(d => d.IdTipoClienteNavigation)
                    .WithMany(p => p.AcClientes)
                    .HasForeignKey(d => d.IdTipoCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcClientes_AcCatTiposCliente");

                entity.HasOne(d => d.IdTipoMonedaNavigation)
                    .WithMany(p => p.AcClientes)
                    .HasForeignKey(d => d.IdTipoMoneda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcClientes_AcCatMonedas");
            });

            modelBuilder.Entity<AcClientesAddenda>(entity =>
            {
                entity.HasKey(e => e.IdClienteAddenda);

                entity.HasIndex(e => new { e.IdCliente, e.CodigoAddenda }, "IX_AcClientesAddendas")
                    .IsUnique();

                entity.Property(e => e.CodigoAddenda)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.AcClientesAddenda)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcClientesAddendas_AcClientes");
            });

            modelBuilder.Entity<AcClientesAntilavado>(entity =>
            {
                entity.HasKey(e => e.IdClienteAntilavado);

                entity.ToTable("AcClientesAntilavado");

                entity.HasIndex(e => e.Rfc, "IX_AcClientesAntilavado")
                    .IsUnique();

                entity.Property(e => e.ActividadOcupacion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ApellidoPaterno)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Curp)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("CURP");

                entity.Property(e => e.DomicilioCalle)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DomicilioCalleExtranjero)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DomicilioCiudadExtranjero)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DomicilioCodigoPostal)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DomicilioCodigoPostalExtranjero)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DomicilioColonia)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DomicilioColoniaExtranjero)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DomicilioDelegacion)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DomicilioDelegacionExtranjero)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DomicilioEstadoExtranjero)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DomicilioNoExterior)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DomicilioNoExteriorExtranjero)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DomicilioNoInterior)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DomicilioNoInteriorExtranjero)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DomicilioPais)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DomicilioPaisExtranjero)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.FechaDeNacimiento).HasColumnType("datetime");

                entity.Property(e => e.IdentificacionEmisor)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdentificacionNombre)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdentificacionNumero)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PaisDeNacimiento)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PaisDeNacionalidad)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("RFC");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.DomicilioIdCiudadNavigation)
                    .WithMany(p => p.AcClientesAntilavados)
                    .HasForeignKey(d => d.DomicilioIdCiudad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcClientesAntilavado_AcCatCiudades");

                entity.HasOne(d => d.DomicilioIdEstadoNavigation)
                    .WithMany(p => p.AcClientesAntilavados)
                    .HasForeignKey(d => d.DomicilioIdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcClientesAntilavado_AcCatEstados");
            });

            modelBuilder.Entity<AcClientesAntilavadoDet>(entity =>
            {
                entity.HasKey(e => e.IdClienteAntilavadoDet);

                entity.ToTable("AcClientesAntilavadoDet");

                entity.HasIndex(e => e.IdClienteAntilavado, "IX_AcClientesAntilavadoDet");

                entity.HasIndex(e => new { e.IdClienteAntilavado, e.NombreDocumento }, "IX_AcClientesAntilavadoDet_1")
                    .IsUnique();

                entity.Property(e => e.NombreDocumento)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClienteAntilavadoNavigation)
                    .WithMany(p => p.AcClientesAntilavadoDets)
                    .HasForeignKey(d => d.IdClienteAntilavado)
                    .HasConstraintName("FK_AcClientesAntilavadoDet_AcClientesAntilavado");
            });

            modelBuilder.Entity<AcClientesConsecutivo>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<AcClientesFactura>(entity =>
            {
                entity.HasKey(e => e.IdClienteFactura)
                    .HasName("PK_AcFacturasClientes");

                entity.Property(e => e.CargoCuentaClientes).HasColumnType("money");

                entity.Property(e => e.CargoCuentaClientesComplementaria).HasColumnType("money");

                entity.Property(e => e.CodigoAddenda)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoAuxiliar)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPostal)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Concepto)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ConceptoFeanticipo)
                    .IsUnicode(false)
                    .HasColumnName("ConceptoFEAnticipo");

                entity.Property(e => e.CondicionesFactura)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Curp)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("CURP");

                entity.Property(e => e.Delegacion)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.DescripcionCancelacion)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EstatusSat).HasColumnName("EstatusSAT");

                entity.Property(e => e.FacturaSerie)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCancelacion).HasColumnType("datetime");

                entity.Property(e => e.FechaFactura).HasColumnType("datetime");

                entity.Property(e => e.FechaFolioFiscalOrig).HasColumnType("datetime");

                entity.Property(e => e.FechaHora).HasColumnType("datetime");

                entity.Property(e => e.FechaProbablePago).HasColumnType("datetime");

                entity.Property(e => e.FechaSolicitudCancelacion).HasColumnType("datetime");

                entity.Property(e => e.FechaUltimaActualizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaUltimoCambio).HasColumnType("datetime");

                entity.Property(e => e.FolioFiscalCfdi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FolioFiscalCFDI");

                entity.Property(e => e.FolioFiscalOrig)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FormaDePago)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImporteFacturaAnticipo).HasColumnType("money");

                entity.Property(e => e.Localidad)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontoFolioFiscalOrig).HasColumnType("money");

                entity.Property(e => e.MontoNc)
                    .HasColumnType("money")
                    .HasColumnName("MontoNC");

                entity.Property(e => e.NoCertificado)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NoExterior)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoInterior)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumCtaPago)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Pais)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Referencia)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("RFC");

                entity.Property(e => e.SerieFolioFiscalOrig)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StrMetodosPago)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TextoCaratula).IsUnicode(false);

                entity.Property(e => e.Unidad)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsarFormatoPie).HasColumnName("UsarFormatoPIE");

                entity.HasOne(d => d.IdCatResponsable1Navigation)
                    .WithMany(p => p.AcClientesFacturaIdCatResponsable1Navigations)
                    .HasForeignKey(d => d.IdCatResponsable1)
                    .HasConstraintName("FK_AcClientesFacturas_ACResponsables");

                entity.HasOne(d => d.IdCatResponsable2Navigation)
                    .WithMany(p => p.AcClientesFacturaIdCatResponsable2Navigations)
                    .HasForeignKey(d => d.IdCatResponsable2)
                    .HasConstraintName("FK_AcClientesFacturas_ACResponsables1");

                entity.HasOne(d => d.IdCatResponsable3Navigation)
                    .WithMany(p => p.AcClientesFacturaIdCatResponsable3Navigations)
                    .HasForeignKey(d => d.IdCatResponsable3)
                    .HasConstraintName("FK_AcClientesFacturas_ACResponsables2");

                entity.HasOne(d => d.IdCatResponsable4Navigation)
                    .WithMany(p => p.AcClientesFacturaIdCatResponsable4Navigations)
                    .HasForeignKey(d => d.IdCatResponsable4)
                    .HasConstraintName("FK_AcClientesFacturas_ACResponsables3");

                entity.HasOne(d => d.IdCiudadNavigation)
                    .WithMany(p => p.AcClientesFacturas)
                    .HasForeignKey(d => d.IdCiudad)
                    .HasConstraintName("FK_AcFacturasClientes_AcCatCiudades");

                entity.HasOne(d => d.IdCondicionPagoNavigation)
                    .WithMany(p => p.AcClientesFacturas)
                    .HasForeignKey(d => d.IdCondicionPago)
                    .HasConstraintName("FK_AcClientesFacturas_AcCondicionesPago");

                entity.HasOne(d => d.IdContratoNavigation)
                    .WithMany(p => p.AcClientesFacturas)
                    .HasForeignKey(d => d.IdContrato)
                    .HasConstraintName("FK_AcFacturasClientes_AcContratos");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.AcClientesFacturas)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_AcClientesFacturas_AcCatEstados");

                entity.HasOne(d => d.IdMetodoPagoNavigation)
                    .WithMany(p => p.AcClientesFacturas)
                    .HasForeignKey(d => d.IdMetodoPago)
                    .HasConstraintName("FK_AcClientesFacturas_AcMetodoPago");

                entity.HasOne(d => d.IdPolizaNavigation)
                    .WithMany(p => p.AcClientesFacturaIdPolizaNavigations)
                    .HasForeignKey(d => d.IdPoliza)
                    .HasConstraintName("FK_AcFacturasClientes_CtbPolizas");

                entity.HasOne(d => d.IdPolizaDetNavigation)
                    .WithMany(p => p.AcClientesFacturas)
                    .HasForeignKey(d => d.IdPolizaDet)
                    .HasConstraintName("FK_AcClientesFacturas_CtbPolizasDet");

                entity.HasOne(d => d.IdPolizaInversaNavigation)
                    .WithMany(p => p.AcClientesFacturaIdPolizaInversaNavigations)
                    .HasForeignKey(d => d.IdPolizaInversa)
                    .HasConstraintName("FK_AcFacturasClientes_CtbPolizas1");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AcClientesFacturaIdUsuarioNavigations)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcFacturasClientes_SegUsuarios1");

                entity.HasOne(d => d.IdUsuarioCancelacionNavigation)
                    .WithMany(p => p.AcClientesFacturaIdUsuarioCancelacionNavigations)
                    .HasForeignKey(d => d.IdUsuarioCancelacion)
                    .HasConstraintName("FK_AcFacturasClientes_SegUsuarios");

                entity.HasOne(d => d.IdUsuarioUltimoCambioNavigation)
                    .WithMany(p => p.AcClientesFacturaIdUsuarioUltimoCambioNavigations)
                    .HasForeignKey(d => d.IdUsuarioUltimoCambio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcFacturasClientes_SegUsuarios2");
            });

            modelBuilder.Entity<AcClientesFacturas2017>(entity =>
            {
                entity.HasKey(e => e.IdClienteFactura2017);

                entity.ToTable("AcClientesFacturas2017");

                entity.Property(e => e.ClaveConfirmacion)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ConsiderarFgcomoDescuento).HasColumnName("ConsiderarFGcomoDescuento");

                entity.Property(e => e.Descuento).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.FechaTimbrado).HasColumnType("datetime");

                entity.Property(e => e.IdCatMonedasSat).HasColumnName("IdCatMonedasSAT");

                entity.Property(e => e.IdFormaPagoSat).HasColumnName("IdFormaPagoSAT");

                entity.Property(e => e.IdMetodoPagoSat).HasColumnName("IdMetodoPagoSAT");

                entity.Property(e => e.IdProductoServicioSat).HasColumnName("IdProductoServicioSAT");

                entity.Property(e => e.IdTipoComprobanteSat).HasColumnName("IdTipoComprobanteSAT");

                entity.Property(e => e.IdTipoRelacionSat).HasColumnName("IdTipoRelacionSAT");

                entity.Property(e => e.IdUnidadSat).HasColumnName("IdUnidadSAT");

                entity.Property(e => e.IdUsoCfdiSat).HasColumnName("IdUsoCfdiSAT");

                entity.Property(e => e.NumRegIdTribReceptor)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones).IsUnicode(false);

                entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TipoCambio)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdCatMonedasSatNavigation)
                    .WithMany(p => p.AcClientesFacturas2017s)
                    .HasForeignKey(d => d.IdCatMonedasSat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcClientesFacturas2017_CtbCatMonedasSAT");

                entity.HasOne(d => d.IdClienteFacturaNavigation)
                    .WithMany(p => p.AcClientesFacturas2017s)
                    .HasForeignKey(d => d.IdClienteFactura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcClientesFacturas2017_AcClientesFacturas");

                entity.HasOne(d => d.IdFormaPagoSatNavigation)
                    .WithMany(p => p.AcClientesFacturas2017s)
                    .HasForeignKey(d => d.IdFormaPagoSat)
                    .HasConstraintName("FK_AcClientesFacturas2017_AcCatFormasPagoSAT");

                entity.HasOne(d => d.IdMetodoPagoSatNavigation)
                    .WithMany(p => p.AcClientesFacturas2017s)
                    .HasForeignKey(d => d.IdMetodoPagoSat)
                    .HasConstraintName("FK_AcClientesFacturas2017_AcCatMetodosPagoSAT");

                entity.HasOne(d => d.IdPaisReceptorNavigation)
                    .WithMany(p => p.AcClientesFacturas2017s)
                    .HasForeignKey(d => d.IdPaisReceptor)
                    .HasConstraintName("FK_AcClientesFacturas2017_AcCatPaises");

                entity.HasOne(d => d.IdProductoServicioSatNavigation)
                    .WithMany(p => p.AcClientesFacturas2017s)
                    .HasForeignKey(d => d.IdProductoServicioSat)
                    .HasConstraintName("FK_AcClientesFacturas2017_AcCatProductosServicioSAT");

                entity.HasOne(d => d.IdTipoComprobanteSatNavigation)
                    .WithMany(p => p.AcClientesFacturas2017s)
                    .HasForeignKey(d => d.IdTipoComprobanteSat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcClientesFacturas2017_AcCatTiposComprobanteSAT");

                entity.HasOne(d => d.IdTipoRelacionSatNavigation)
                    .WithMany(p => p.AcClientesFacturas2017s)
                    .HasForeignKey(d => d.IdTipoRelacionSat)
                    .HasConstraintName("FK_AcClientesFacturas2017_AcCatTiposRelacionSAT");

                entity.HasOne(d => d.IdUnidadSatNavigation)
                    .WithMany(p => p.AcClientesFacturas2017s)
                    .HasForeignKey(d => d.IdUnidadSat)
                    .HasConstraintName("FK_AcClientesFacturas2017_AcCatUnidadesSAT");

                entity.HasOne(d => d.IdUsoCfdiSatNavigation)
                    .WithMany(p => p.AcClientesFacturas2017s)
                    .HasForeignKey(d => d.IdUsoCfdiSat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcClientesFacturas2017_AcCatUsosCFDISAT");
            });

            modelBuilder.Entity<AcClientesFacturasCfd>(entity =>
            {
                entity.HasKey(e => e.IdClienteFacturaCfd);

                entity.ToTable("AcClientesFacturasCFD");

                entity.Property(e => e.IdClienteFacturaCfd).HasColumnName("IdClienteFacturaCFD");

                entity.Property(e => e.FechaHora).HasColumnType("datetime");

                entity.Property(e => e.NombreXlsx)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("NombreXLSX");

                entity.Property(e => e.Xlsx).HasColumnName("XLSX");

                entity.Property(e => e.Xmlcfd)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("XMLCFD");

                entity.Property(e => e.XmlcfdsinAddenda)
                    .IsUnicode(false)
                    .HasColumnName("XMLCFDSinAddenda");

                entity.Property(e => e.Xmlpoliza)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("XMLPoliza");

                entity.HasOne(d => d.IdClienteFacturaNavigation)
                    .WithMany(p => p.AcClientesFacturasCfds)
                    .HasForeignKey(d => d.IdClienteFactura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcClientesFacturasCFD_AcClientesFacturas");
            });

            modelBuilder.Entity<AcClientesFacturasCfdirelac>(entity =>
            {
                entity.HasKey(e => e.IdCfdirelacionado);

                entity.ToTable("AcClientesFacturasCFDIRelac");

                entity.Property(e => e.IdCfdirelacionado).HasColumnName("IdCFDIRelacionado");

                entity.Property(e => e.Uuid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("UUID");

                entity.HasOne(d => d.IdClienteFactura2017Navigation)
                    .WithMany(p => p.AcClientesFacturasCfdirelacs)
                    .HasForeignKey(d => d.IdClienteFactura2017)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcClientesFacturasCFDIRelac_AcClientesFacturas2017");
            });

            modelBuilder.Entity<AcClientesFacturasCuenta>(entity =>
            {
                entity.HasKey(e => e.IdClienteFacturaCuenta)
                    .HasName("PK_AcFacturasClientesDescuentos");

                entity.HasIndex(e => e.IdCuenta, "IX_AcClientesFacturasCuentas")
                    .HasFillFactor(90);

                entity.Property(e => e.CapturarPorcentaje)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DescripcionFactura)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.FeRetencionFisr).HasColumnName("FeRetencionFISR");

                entity.Property(e => e.FeRetencionFiva).HasColumnName("FeRetencionFIVA");

                entity.Property(e => e.IdCuenta).HasColumnName("idCuenta");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.MontoBase).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoPesos).HasColumnType("money");

                entity.Property(e => e.Porcentaje).HasColumnType("money");

                entity.HasOne(d => d.IdClienteFacturaNavigation)
                    .WithMany(p => p.AcClientesFacturasCuenta)
                    .HasForeignKey(d => d.IdClienteFactura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcFacturasClientesDescuentos_AcFacturasClientes");

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithMany(p => p.AcClientesFacturasCuenta)
                    .HasForeignKey(d => d.IdCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcFacturasClientesDescuentos_CtbCuentas");
            });

            modelBuilder.Entity<AcClientesFacturasDet>(entity =>
            {
                entity.HasKey(e => e.IdClienteFacturaDet)
                    .HasName("PK_AcDetFacturasClientes");

                entity.ToTable("AcClientesFacturasDet");

                entity.HasIndex(e => new { e.IdClienteFactura, e.IdContratoDet }, "IX_AcClientesFacturasDet")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CuentaPredial)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionAuxiliar).IsUnicode(false);

                entity.Property(e => e.Descuento).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.IdProductoServicioSat).HasColumnName("IdProductoServicioSAT");

                entity.Property(e => e.IdUnidadSat).HasColumnName("IdUnidadSAT");

                entity.Property(e => e.ImpuestosRetenidos).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ImpuestosTrasladados).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Precio).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.IdClienteFacturaNavigation)
                    .WithMany(p => p.AcClientesFacturasDets)
                    .HasForeignKey(d => d.IdClienteFactura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcDetFacturasClientes_AcFacturasClientes");

                entity.HasOne(d => d.IdContratoDetNavigation)
                    .WithMany(p => p.AcClientesFacturasDets)
                    .HasForeignKey(d => d.IdContratoDet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcClientesFacturasDet_AcPresupuestos");

                entity.HasOne(d => d.IdProductoServicioSatNavigation)
                    .WithMany(p => p.AcClientesFacturasDets)
                    .HasForeignKey(d => d.IdProductoServicioSat)
                    .HasConstraintName("FK_AcClientesFacturasDet_AcCatProductosServicioSAT");

                entity.HasOne(d => d.IdUnidadSatNavigation)
                    .WithMany(p => p.AcClientesFacturasDets)
                    .HasForeignKey(d => d.IdUnidadSat)
                    .HasConstraintName("FK_AcClientesFacturasDet_AcCatUnidadesSAT");
            });

            modelBuilder.Entity<AcClientesFacturasDetAduana>(entity =>
            {
                entity.HasKey(e => e.IdClienteFacturaDetAduana);

                entity.ToTable("AcClientesFacturasDetAduana");

                entity.Property(e => e.Aduana)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClienteFacturaDetNavigation)
                    .WithMany(p => p.AcClientesFacturasDetAduanas)
                    .HasForeignKey(d => d.IdClienteFacturaDet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcClientesFacturasDetAduana_AcClientesFacturasDet");
            });

            modelBuilder.Entity<AcClientesFacturasDetCuenta>(entity =>
            {
                entity.HasKey(e => e.IdClienteFacturaDetCuenta);

                entity.Property(e => e.CapturarPorcentaje)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DescripcionFactura)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.FeRetencionFisr).HasColumnName("FeRetencionFISR");

                entity.Property(e => e.FeRetencionFiva).HasColumnName("FeRetencionFIVA");

                entity.Property(e => e.IdCuenta).HasColumnName("idCuenta");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.MontoBase).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoPesos).HasColumnType("money");

                entity.Property(e => e.Porcentaje).HasColumnType("money");

                entity.HasOne(d => d.IdClienteFacturaDetNavigation)
                    .WithMany(p => p.AcClientesFacturasDetCuenta)
                    .HasForeignKey(d => d.IdClienteFacturaDet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcClientesFacturasDetCuentas_AcClientesFacturasDet");

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithMany(p => p.AcClientesFacturasDetCuenta)
                    .HasForeignKey(d => d.IdCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcClientesFacturasDetCuentas_CtbCuentas");
            });

            modelBuilder.Entity<AcClientesFacturasNc>(entity =>
            {
                entity.HasKey(e => e.IdClienteFacturaNc);

                entity.ToTable("AcClientesFacturasNC");

                entity.Property(e => e.IdClienteFacturaNc).HasColumnName("IdClienteFacturaNC");

                entity.Property(e => e.CodigoAddenda)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionCancelacion)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.EstatusSat).HasColumnName("EstatusSAT");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaCancelacion).HasColumnType("datetime");

                entity.Property(e => e.FechaSolicitudCancelacion).HasColumnType("datetime");

                entity.Property(e => e.FechaUltimaActualizacion).HasColumnType("datetime");

                entity.Property(e => e.FolioFiscalCfdi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FolioFiscalCFDI");

                entity.Property(e => e.FolioFiscalCfdicapturado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FolioFiscalCFDICapturado");

                entity.Property(e => e.IdTipoNc).HasColumnName("IdTipoNC");

                entity.Property(e => e.Monto).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoIva)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("MontoIVA");

                entity.Property(e => e.MontoTotal).HasColumnType("money");

                entity.Property(e => e.NoCertificado)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NoNc).HasColumnName("NoNC");

                entity.Property(e => e.PorcentajeIva).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SerieFe)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("SerieFE");

                entity.Property(e => e.TipoNotaFe).HasColumnName("TipoNotaFE");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.AcClientesFacturasNcs)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcClientesFacturasNC_AcClientes");

                entity.HasOne(d => d.IdPolizaNavigation)
                    .WithMany(p => p.AcClientesFacturasNcIdPolizaNavigations)
                    .HasForeignKey(d => d.IdPoliza)
                    .HasConstraintName("FK_AcClientesFacturasNC_CtbPolizas");

                entity.HasOne(d => d.IdPolizaDetNavigation)
                    .WithMany(p => p.AcClientesFacturasNcIdPolizaDetNavigations)
                    .HasForeignKey(d => d.IdPolizaDet)
                    .HasConstraintName("FK_AcClientesFacturasNC_CtbPolizasDet");

                entity.HasOne(d => d.IdPolizaDetFacturaNavigation)
                    .WithMany(p => p.AcClientesFacturasNcIdPolizaDetFacturaNavigations)
                    .HasForeignKey(d => d.IdPolizaDetFactura)
                    .HasConstraintName("FK_AcClientesFacturasNC_CtbPolizasDet1");

                entity.HasOne(d => d.IdPolizaInversaNavigation)
                    .WithMany(p => p.AcClientesFacturasNcIdPolizaInversaNavigations)
                    .HasForeignKey(d => d.IdPolizaInversa)
                    .HasConstraintName("FK_AcClientesFacturasNC_CtbPolizas1");

                entity.HasOne(d => d.IdTipoNcNavigation)
                    .WithMany(p => p.AcClientesFacturasNcs)
                    .HasForeignKey(d => d.IdTipoNc)
                    .HasConstraintName("FK_AcClientesFacturasNC_AcCatTiposNC");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AcClientesFacturasNcIdUsuarioNavigations)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcClientesFacturasNC_SegUsuarios");

                entity.HasOne(d => d.IdUsuarioCancelacionNavigation)
                    .WithMany(p => p.AcClientesFacturasNcIdUsuarioCancelacionNavigations)
                    .HasForeignKey(d => d.IdUsuarioCancelacion)
                    .HasConstraintName("FK_AcClientesFacturasNC_SegUsuarios1");
            });

            modelBuilder.Entity<AcClientesFacturasNc2017>(entity =>
            {
                entity.HasKey(e => e.IdClienteFacturaNc2017);

                entity.ToTable("AcClientesFacturasNC2017");

                entity.HasIndex(e => e.IdClienteFacturaNc, "IX_AcClientesFacturasNC2017")
                    .IsUnique();

                entity.Property(e => e.IdClienteFacturaNc2017).HasColumnName("IdClienteFacturaNC2017");

                entity.Property(e => e.ClaveConfirmacion)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Descuento).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.FechaTimbrado).HasColumnType("datetime");

                entity.Property(e => e.IdCatMonedasSat).HasColumnName("IdCatMonedasSAT");

                entity.Property(e => e.IdClienteFacturaNc).HasColumnName("IdClienteFacturaNC");

                entity.Property(e => e.IdFormaPagoSat).HasColumnName("IdFormaPagoSAT");

                entity.Property(e => e.IdMetodoPagoSat).HasColumnName("IdMetodoPagoSAT");

                entity.Property(e => e.IdProductoServicioSat).HasColumnName("IdProductoServicioSAT");

                entity.Property(e => e.IdTipoComprobanteSat).HasColumnName("IdTipoComprobanteSAT");

                entity.Property(e => e.IdTipoRelacionSat).HasColumnName("IdTipoRelacionSAT");

                entity.Property(e => e.IdUnidadSat).HasColumnName("IdUnidadSAT");

                entity.Property(e => e.IdUsoCfdiSat).HasColumnName("IdUsoCfdiSAT");

                entity.Property(e => e.NumRegIdTribReceptor)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones).IsUnicode(false);

                entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TipoCambio)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdCatMonedasSatNavigation)
                    .WithMany(p => p.AcClientesFacturasNc2017s)
                    .HasForeignKey(d => d.IdCatMonedasSat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcClientesFacturasNC2017_CtbCatMonedasSAT");

                entity.HasOne(d => d.IdClienteFacturaNcNavigation)
                    .WithOne(p => p.AcClientesFacturasNc2017)
                    .HasForeignKey<AcClientesFacturasNc2017>(d => d.IdClienteFacturaNc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcClientesFacturasNC2017_AcClientesFacturasNC");

                entity.HasOne(d => d.IdContratoNavigation)
                    .WithMany(p => p.AcClientesFacturasNc2017s)
                    .HasForeignKey(d => d.IdContrato)
                    .HasConstraintName("FK_AcClientesFacturasNC2017_AcContratos");

                entity.HasOne(d => d.IdFormaPagoSatNavigation)
                    .WithMany(p => p.AcClientesFacturasNc2017s)
                    .HasForeignKey(d => d.IdFormaPagoSat)
                    .HasConstraintName("FK_AcClientesFacturasNC2017_AcCatFormasPagoSAT");

                entity.HasOne(d => d.IdMetodoPagoSatNavigation)
                    .WithMany(p => p.AcClientesFacturasNc2017s)
                    .HasForeignKey(d => d.IdMetodoPagoSat)
                    .HasConstraintName("FK_AcClientesFacturasNC2017_AcCatMetodosPagoSAT");

                entity.HasOne(d => d.IdPaisReceptorNavigation)
                    .WithMany(p => p.AcClientesFacturasNc2017s)
                    .HasForeignKey(d => d.IdPaisReceptor)
                    .HasConstraintName("FK_AcClientesFacturasNC2017_AcCatPaises");

                entity.HasOne(d => d.IdProductoServicioSatNavigation)
                    .WithMany(p => p.AcClientesFacturasNc2017s)
                    .HasForeignKey(d => d.IdProductoServicioSat)
                    .HasConstraintName("FK_AcClientesFacturasNC2017_AcCatProductosServicioSAT");

                entity.HasOne(d => d.IdTipoComprobanteSatNavigation)
                    .WithMany(p => p.AcClientesFacturasNc2017s)
                    .HasForeignKey(d => d.IdTipoComprobanteSat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcClientesFacturasNC2017_AcCatTiposComprobanteSAT");

                entity.HasOne(d => d.IdTipoRelacionSatNavigation)
                    .WithMany(p => p.AcClientesFacturasNc2017s)
                    .HasForeignKey(d => d.IdTipoRelacionSat)
                    .HasConstraintName("FK_AcClientesFacturasNC2017_AcCatTiposRelacionSAT");

                entity.HasOne(d => d.IdUnidadSatNavigation)
                    .WithMany(p => p.AcClientesFacturasNc2017s)
                    .HasForeignKey(d => d.IdUnidadSat)
                    .HasConstraintName("FK_AcClientesFacturasNC2017_AcCatUnidadesSAT");

                entity.HasOne(d => d.IdUsoCfdiSatNavigation)
                    .WithMany(p => p.AcClientesFacturasNc2017s)
                    .HasForeignKey(d => d.IdUsoCfdiSat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcClientesFacturasNC2017_AcCatUsosCFDISAT");
            });

            modelBuilder.Entity<AcClientesFacturasNcCfd>(entity =>
            {
                entity.HasKey(e => e.IdClienteFacturaNcCfd);

                entity.ToTable("AcClientesFacturasNcCFD");

                entity.Property(e => e.IdClienteFacturaNcCfd).HasColumnName("IdClienteFacturaNcCFD");

                entity.Property(e => e.FechaHora).HasColumnType("datetime");

                entity.Property(e => e.IdClienteFacturaNc).HasColumnName("IdClienteFacturaNC");

                entity.Property(e => e.Xmlcfd)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("XMLCFD");

                entity.Property(e => e.XmlcfdsinAddenda)
                    .IsUnicode(false)
                    .HasColumnName("XMLCFDSinAddenda");

                entity.Property(e => e.Xmlpoliza)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("XMLPoliza");

                entity.HasOne(d => d.IdClienteFacturaNcNavigation)
                    .WithMany(p => p.AcClientesFacturasNcCfds)
                    .HasForeignKey(d => d.IdClienteFacturaNc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcClientesFacturasNcCFD_AcClientesFacturasNC");
            });

            modelBuilder.Entity<AcClientesFacturasNccfdirelac>(entity =>
            {
                entity.HasKey(e => e.IdCfdirelacionado);

                entity.ToTable("AcClientesFacturasNCCFDIRelac");

                entity.Property(e => e.IdCfdirelacionado).HasColumnName("IdCFDIRelacionado");

                entity.Property(e => e.IdClienteFacturaNc2017).HasColumnName("IdClienteFacturaNC2017");

                entity.Property(e => e.Uuid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("UUID");

                entity.HasOne(d => d.IdClienteFacturaNc2017Navigation)
                    .WithMany(p => p.AcClientesFacturasNccfdirelacs)
                    .HasForeignKey(d => d.IdClienteFacturaNc2017)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcClientesFacturasNCCFDIRelac_AcClientesFacturasNC2017");
            });

            modelBuilder.Entity<AcClientesFacturasNccuenta>(entity =>
            {
                entity.HasKey(e => e.IdClienteFacturaNccuenta);

                entity.ToTable("AcClientesFacturasNCCuentas");

                entity.HasIndex(e => e.IdCuenta, "IX_AcClientesFacturasNCCuentas");

                entity.Property(e => e.IdClienteFacturaNccuenta).HasColumnName("IdClienteFacturaNCCuenta");

                entity.Property(e => e.CapturarPorcentaje)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DescripcionFactura)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.FeRetencionFisr).HasColumnName("FeRetencionFISR");

                entity.Property(e => e.FeRetencionFiva).HasColumnName("FeRetencionFIVA");

                entity.Property(e => e.IdClienteFacturaNc).HasColumnName("IdClienteFacturaNC");

                entity.Property(e => e.IdCuenta).HasColumnName("idCuenta");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.MontoBase).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoPesos).HasColumnType("money");

                entity.Property(e => e.Porcentaje).HasColumnType("money");

                entity.HasOne(d => d.IdClienteFacturaNcNavigation)
                    .WithMany(p => p.AcClientesFacturasNccuenta)
                    .HasForeignKey(d => d.IdClienteFacturaNc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcClientesFacturasNCCuentas_AcClientesFacturasNC");

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithMany(p => p.AcClientesFacturasNccuenta)
                    .HasForeignKey(d => d.IdCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcClientesFacturasNCCuentas_CtbCuentas");
            });

            modelBuilder.Entity<AcClientesFacturasNcdet>(entity =>
            {
                entity.HasKey(e => e.IdClienteFacturaNcdet);

                entity.ToTable("AcClientesFacturasNCDet");

                entity.HasIndex(e => e.IdClienteFacturaNc, "IX_AcClientesFacturasNCDet");

                entity.Property(e => e.IdClienteFacturaNcdet).HasColumnName("IdClienteFacturaNCDet");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CuentaPredial)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionAuxiliar).IsUnicode(false);

                entity.Property(e => e.Descuento).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.IdClienteFacturaNc).HasColumnName("IdClienteFacturaNC");

                entity.Property(e => e.IdConceptosDetNc).HasColumnName("IdConceptosDetNC");

                entity.Property(e => e.IdProductoServicioSat).HasColumnName("IdProductoServicioSAT");

                entity.Property(e => e.IdUnidadSat).HasColumnName("IdUnidadSAT");

                entity.Property(e => e.ImpuestosRetenidos).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ImpuestosTrasladados).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Precio).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.IdClienteFacturaNcNavigation)
                    .WithMany(p => p.AcClientesFacturasNcdets)
                    .HasForeignKey(d => d.IdClienteFacturaNc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcClientesFacturasNCDet_AcClientesFacturasNC");

                entity.HasOne(d => d.IdProductoServicioSatNavigation)
                    .WithMany(p => p.AcClientesFacturasNcdets)
                    .HasForeignKey(d => d.IdProductoServicioSat)
                    .HasConstraintName("FK_AcClientesFacturasNCDet_AcCatProductosServicioSAT");

                entity.HasOne(d => d.IdUnidadSatNavigation)
                    .WithMany(p => p.AcClientesFacturasNcdets)
                    .HasForeignKey(d => d.IdUnidadSat)
                    .HasConstraintName("FK_AcClientesFacturasNCDet_AcCatUnidadesSAT");
            });

            modelBuilder.Entity<AcClientesFacturasNcdetCuenta>(entity =>
            {
                entity.HasKey(e => e.IdClienteFacturaNcdetCuenta);

                entity.ToTable("AcClientesFacturasNCDetCuentas");

                entity.Property(e => e.IdClienteFacturaNcdetCuenta).HasColumnName("IdClienteFacturaNCDetCuenta");

                entity.Property(e => e.CapturarPorcentaje)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DescripcionFactura)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.FeRetencionFisr).HasColumnName("FeRetencionFISR");

                entity.Property(e => e.FeRetencionFiva).HasColumnName("FeRetencionFIVA");

                entity.Property(e => e.IdClienteFacturaNcdet).HasColumnName("IdClienteFacturaNCDet");

                entity.Property(e => e.IdCuenta).HasColumnName("idCuenta");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.MontoBase).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoPesos).HasColumnType("money");

                entity.Property(e => e.Porcentaje).HasColumnType("money");

                entity.HasOne(d => d.IdClienteFacturaNcdetNavigation)
                    .WithMany(p => p.AcClientesFacturasNcdetCuenta)
                    .HasForeignKey(d => d.IdClienteFacturaNcdet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcClientesFacturasNCDetCuentas_AcClientesFacturasNCDet");

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithMany(p => p.AcClientesFacturasNcdetCuenta)
                    .HasForeignKey(d => d.IdCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcClientesFacturasNCDetCuentas_CtbCuentas");
            });

            modelBuilder.Entity<AcClientesObra>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.IdCatCliente, e.Obra }, "IX_AcObras")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.IdClienteObra).ValueGeneratedOnAdd();

                entity.Property(e => e.Obra)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AcClientesOperadore>(entity =>
            {
                entity.HasKey(e => e.IdClienteOperador)
                    .HasName("PK_AcOperadores");

                entity.HasIndex(e => e.Operador, "IX_AcOperadores")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Licencia)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Operador)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AcClientesPlanta>(entity =>
            {
                entity.HasKey(e => e.IdClientePlanta)
                    .HasName("PK_AcPlantas");

                entity.HasIndex(e => e.Planta, "IX_AcPlantas")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.CodigoPostal)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Delegacion)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Encargado)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Planta)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCiudadNavigation)
                    .WithMany(p => p.AcClientesPlanta)
                    .HasForeignKey(d => d.IdCiudad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcClientesPlantas_AcCatCiudades");
            });

            modelBuilder.Entity<AcClientesRemisione>(entity =>
            {
                entity.HasKey(e => e.IdClienteRemision)
                    .HasName("PK_AcRemision");

                entity.HasIndex(e => new { e.IdClientePlanta, e.FolioRemision }, "IX_AcRemision")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaUltimoCambio).HasColumnType("datetime");

                entity.Property(e => e.HoraSalida).HasColumnType("datetime");

                entity.Property(e => e.Horaentrada).HasColumnType("datetime");

                entity.HasOne(d => d.IdClienteFacturaNavigation)
                    .WithMany(p => p.AcClientesRemisiones)
                    .HasForeignKey(d => d.IdClienteFactura)
                    .HasConstraintName("FK_AcClientesRemisiones_AcFacturasClientes");

                entity.HasOne(d => d.IdClienteOperadorNavigation)
                    .WithMany(p => p.AcClientesRemisiones)
                    .HasForeignKey(d => d.IdClienteOperador)
                    .HasConstraintName("FK_AcRemision_AcOperadores");

                entity.HasOne(d => d.IdClientePlantaNavigation)
                    .WithMany(p => p.AcClientesRemisiones)
                    .HasForeignKey(d => d.IdClientePlanta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcRemision_AcPlantas");

                entity.HasOne(d => d.IdClienteResponsableRemisionNavigation)
                    .WithMany(p => p.AcClientesRemisiones)
                    .HasForeignKey(d => d.IdClienteResponsableRemision)
                    .HasConstraintName("FK_AcRemision_AcResponsablesRemisiones");

                entity.HasOne(d => d.IdClienteTransporteNavigation)
                    .WithMany(p => p.AcClientesRemisiones)
                    .HasForeignKey(d => d.IdClienteTransporte)
                    .HasConstraintName("FK_AcRemision_AcEquipos");

                entity.HasOne(d => d.IdContratoNavigation)
                    .WithMany(p => p.AcClientesRemisiones)
                    .HasForeignKey(d => d.IdContrato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcRemision_AcContratosClientes");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AcClientesRemisioneIdUsuarioNavigations)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcRemisiones_SegUsuarios");

                entity.HasOne(d => d.IdUsuarioUltimoCambioNavigation)
                    .WithMany(p => p.AcClientesRemisioneIdUsuarioUltimoCambioNavigations)
                    .HasForeignKey(d => d.IdUsuarioUltimoCambio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcClientesRemisiones_SegUsuarios");
            });

            modelBuilder.Entity<AcClientesRemisionesDet>(entity =>
            {
                entity.HasKey(e => e.IdCienteRemisionDet)
                    .HasName("PK_AcDetRemision");

                entity.ToTable("AcClientesRemisionesDet");

                entity.HasIndex(e => new { e.IdClienteRemision, e.IdContratoDet }, "IX_AcDetRemisiones")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Cantidad).HasColumnType("money");

                entity.HasOne(d => d.IdClienteRemisionNavigation)
                    .WithMany(p => p.AcClientesRemisionesDets)
                    .HasForeignKey(d => d.IdClienteRemision)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcDetRemision_AcRemision");

                entity.HasOne(d => d.IdContratoDetNavigation)
                    .WithMany(p => p.AcClientesRemisionesDets)
                    .HasForeignKey(d => d.IdContratoDet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcDetRemision_AcDetContratosClientes");
            });

            modelBuilder.Entity<AcClientesResponsablesRemisione>(entity =>
            {
                entity.HasKey(e => e.IdClienteResponsableRemision)
                    .HasName("PK_AcResponsablesRemisiones");

                entity.HasIndex(e => e.ResponsableRemision, "IX_AcResponsablesRemisiones")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ResponsableRemision)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AcClientesSolicitante>(entity =>
            {
                entity.HasKey(e => e.IdClienteSolicitante);

                entity.HasIndex(e => new { e.IdCliente, e.Solicitante }, "IX_AcClientesSolicitantes")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Cargo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Solicitante)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.AcClientesSolicitantes)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcClientesSolicitantes_AcClientes");
            });

            modelBuilder.Entity<AcClientesTransporte>(entity =>
            {
                entity.HasKey(e => e.IdClienteTransporte)
                    .HasName("PK_AcEquipos");

                entity.HasIndex(e => e.Transporte, "IX_AcEquipos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Capacidad)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NumSerie)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Placas)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Transporte)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AcComplementoPago>(entity =>
            {
                entity.HasKey(e => e.IdComplementoPago);

                entity.ToTable("AcComplementoPago");

                entity.Property(e => e.CadenaPago).IsUnicode(false);

                entity.Property(e => e.CertificadoPago).IsUnicode(false);

                entity.Property(e => e.Confirmacion)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaBancariaCliente)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaBancariaEmisor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionCancelacion)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.EstatusSat).HasColumnName("EstatusSAT");

                entity.Property(e => e.FechaCancelacion).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraComplemento).HasColumnType("datetime");

                entity.Property(e => e.FechaSolicitudCancelacion).HasColumnType("datetime");

                entity.Property(e => e.FechaUltimaActualizacion).HasColumnType("datetime");

                entity.Property(e => e.FolioFiscalCfdi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FolioFiscalCFDI");

                entity.Property(e => e.HoraDeposito).HasColumnType("datetime");

                entity.Property(e => e.IdBancoIngreso).HasColumnName("idBancoIngreso");

                entity.Property(e => e.IdCatMonedasSat).HasColumnName("IdCatMonedasSAT");

                entity.Property(e => e.IdCodigoPostalSat).HasColumnName("IdCodigoPostalSAT");

                entity.Property(e => e.IdFormaPagoSat).HasColumnName("IdFormaPagoSAT");

                entity.Property(e => e.MontoPago).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.NombreBancoExt)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.NumOperacion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumRegisIdentidadFis)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones).IsUnicode(false);

                entity.Property(e => e.ParidadOficial).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ResidenciaFiscal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RfcbancoCliente)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("RFCBancoCliente");

                entity.Property(e => e.RfcbancoEmisor)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("RFCBancoEmisor");

                entity.Property(e => e.SelloPago).IsUnicode(false);

                entity.Property(e => e.SerieComplementoPago)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCadPago)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCambio).HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.IdBancoIngresoNavigation)
                    .WithMany(p => p.AcComplementoPagos)
                    .HasForeignKey(d => d.IdBancoIngreso)
                    .HasConstraintName("FK_AcComplementoPago_AcBancosIngresos");

                entity.HasOne(d => d.IdCatMonedasSatNavigation)
                    .WithMany(p => p.AcComplementoPagos)
                    .HasForeignKey(d => d.IdCatMonedasSat)
                    .HasConstraintName("FK_AcComplementoPago_CtbCatMonedasSat");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.AcComplementoPagos)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK_AcComplementoPago_AcClientes");

                entity.HasOne(d => d.IdFormaPagoSatNavigation)
                    .WithMany(p => p.AcComplementoPagos)
                    .HasForeignKey(d => d.IdFormaPagoSat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcComplementoPago_AcCatFormasPagoSAT");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AcComplementoPagos)
                    .HasForeignKey(d => d.IdProyecto)
                    .HasConstraintName("FK_AcComplementoPago_Proyectos");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AcComplementoPagoIdUsuarioNavigations)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcComplementoPago_SegUsuarios");

                entity.HasOne(d => d.IdUsuarioCancelacionNavigation)
                    .WithMany(p => p.AcComplementoPagoIdUsuarioCancelacionNavigations)
                    .HasForeignKey(d => d.IdUsuarioCancelacion)
                    .HasConstraintName("FK_AcComplementoPago_SegUsuarios1");
            });

            modelBuilder.Entity<AcComplementoPagoCfd>(entity =>
            {
                entity.HasKey(e => e.IdComplementoPagoCfd);

                entity.ToTable("AcComplementoPagoCFD");

                entity.Property(e => e.IdComplementoPagoCfd).HasColumnName("IdComplementoPagoCFD");

                entity.Property(e => e.FechaHora).HasColumnType("datetime");

                entity.Property(e => e.Xmlcfd)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("XMLCFD");

                entity.HasOne(d => d.IdComplementoPagoNavigation)
                    .WithMany(p => p.AcComplementoPagoCfds)
                    .HasForeignKey(d => d.IdComplementoPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcComplementoPagoCFD_AcComplementoPago");
            });

            modelBuilder.Entity<AcComplementoPagoCfdrelac>(entity =>
            {
                entity.HasKey(e => e.IdCfdirelacionado);

                entity.ToTable("AcComplementoPagoCFDRelac");

                entity.Property(e => e.IdCfdirelacionado).HasColumnName("IdCFDIRelacionado");

                entity.Property(e => e.Cfdirelacionado)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CFDIRelacionado");

                entity.HasOne(d => d.IdComplementoPagoNavigation)
                    .WithMany(p => p.AcComplementoPagoCfdrelacs)
                    .HasForeignKey(d => d.IdComplementoPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcComplementoPagoCFDRelac_AcComplementoPago");
            });

            modelBuilder.Entity<AcComplementoPagoDet>(entity =>
            {
                entity.HasKey(e => e.IdComplementoPagoDet);

                entity.ToTable("AcComplementoPagoDet");

                entity.Property(e => e.IdXmlproveedor).HasColumnName("IdXMLProveedor");

                entity.Property(e => e.ImportePagado).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SaldoAnterior).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SaldoInsoluto).HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.IdClienteFacturaNavigation)
                    .WithMany(p => p.AcComplementoPagoDets)
                    .HasForeignKey(d => d.IdClienteFactura)
                    .HasConstraintName("FK_AcComplementoPagoDet_AcClientesFacturas");

                entity.HasOne(d => d.IdComplementoPagoNavigation)
                    .WithMany(p => p.AcComplementoPagoDets)
                    .HasForeignKey(d => d.IdComplementoPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcComplementoPagoDet_AcComplementoPago");

                entity.HasOne(d => d.IdPolizaDetNavigation)
                    .WithMany(p => p.AcComplementoPagoDets)
                    .HasForeignKey(d => d.IdPolizaDet)
                    .HasConstraintName("FK_AcComplementoPagoDet_CtbPolizasDet");

                entity.HasOne(d => d.IdXmlproveedorNavigation)
                    .WithMany(p => p.AcComplementoPagoDets)
                    .HasForeignKey(d => d.IdXmlproveedor)
                    .HasConstraintName("FK_AcComplementoPago_AcProveedoresXML");
            });

            modelBuilder.Entity<AcConceptosDetNc>(entity =>
            {
                entity.HasKey(e => e.IdConceptosDetNc);

                entity.ToTable("AcConceptosDetNC");

                entity.Property(e => e.IdConceptosDetNc).HasColumnName("IdConceptosDetNC");

                entity.Property(e => e.Cantidad).HasColumnType("money");

                entity.Property(e => e.DescripcionAuxiliar).IsUnicode(false);

                entity.Property(e => e.IdClienteFacturaNcdet).HasColumnName("IdClienteFacturaNCDet");

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.HasOne(d => d.IdProyectoConceptoNavigation)
                    .WithMany(p => p.AcConceptosDetNcs)
                    .HasForeignKey(d => d.IdProyectoConcepto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcConceptosDetNC_AcContratosConceptos");

                entity.HasOne(d => d.IdProyectoPartidaNavigation)
                    .WithMany(p => p.AcConceptosDetNcs)
                    .HasForeignKey(d => d.IdProyectoPartida)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcConceptosDetNC_AcProyectoPartidas");
            });

            modelBuilder.Entity<AcCondicionesPago>(entity =>
            {
                entity.HasKey(e => e.IdCondicionPago);

                entity.ToTable("AcCondicionesPago");

                entity.HasIndex(e => e.Codigo, "IX_AcCondicionesPago_Unico")
                    .IsUnique();

                entity.Property(e => e.IdCondicionPago).HasColumnName("idCondicionPago");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AcConsecutivosCuenta>(entity =>
            {
                entity.HasKey(e => e.Proceso);

                entity.Property(e => e.Proceso)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AcConstanciasRetencione>(entity =>
            {
                entity.HasKey(e => e.IdConstanciaRetencion);

                entity.Property(e => e.CodigoAddenda)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoComplemento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Curp)
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionCancelacion)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionConstancia)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EstatusSat).HasColumnName("EstatusSAT");

                entity.Property(e => e.FechaCancelacion).HasColumnType("datetime");

                entity.Property(e => e.FechaConstancia).HasColumnType("datetime");

                entity.Property(e => e.FechaUltimoCambio).HasColumnType("datetime");

                entity.Property(e => e.FolioAuxConstancia)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FolioFiscalCfdi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FolioFiscalCFDI");

                entity.Property(e => e.MontoTotalExento).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoTotalGravado).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoTotalOperacion).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoTotalRetenido).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.NoCertificado)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumRegIdFiscal)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoRetencionNavigation)
                    .WithMany(p => p.AcConstanciasRetenciones)
                    .HasForeignKey(d => d.IdTipoRetencion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcConstanciasRetenciones_AcCatTiposRetenciones");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AcConstanciasRetencioneIdUsuarioNavigations)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcConstanciasRetenciones_SegUsuarios");

                entity.HasOne(d => d.IdUsuarioCancelacionNavigation)
                    .WithMany(p => p.AcConstanciasRetencioneIdUsuarioCancelacionNavigations)
                    .HasForeignKey(d => d.IdUsuarioCancelacion)
                    .HasConstraintName("FK_AcConstanciasRetenciones_SegUsuarios1");

                entity.HasOne(d => d.IdUsuarioUltimoCambioNavigation)
                    .WithMany(p => p.AcConstanciasRetencioneIdUsuarioUltimoCambioNavigations)
                    .HasForeignKey(d => d.IdUsuarioUltimoCambio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcConstanciasRetenciones_SegUsuarios2");
            });

            modelBuilder.Entity<AcConstanciasRetencionesCfd>(entity =>
            {
                entity.HasKey(e => e.IdConstanciaRetencionCfd);

                entity.ToTable("AcConstanciasRetencionesCFD");

                entity.Property(e => e.IdConstanciaRetencionCfd).HasColumnName("IdConstanciaRetencionCFD");

                entity.Property(e => e.CadenaComplemento).IsUnicode(false);

                entity.Property(e => e.FechaHora).HasColumnType("datetime");

                entity.Property(e => e.Xmlcfd)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("XMLCFD");

                entity.Property(e => e.XmlcfdsinAddenda)
                    .IsUnicode(false)
                    .HasColumnName("XMLCFDSinAddenda");

                entity.HasOne(d => d.IdConstanciaRetencionNavigation)
                    .WithMany(p => p.AcConstanciasRetencionesCfds)
                    .HasForeignKey(d => d.IdConstanciaRetencion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcConstanciasRetencionesCFD_AcConstanciasRetenciones");
            });

            modelBuilder.Entity<AcConstanciasRetencionesDet>(entity =>
            {
                entity.HasKey(e => e.IdConstanciaRetencionDet);

                entity.ToTable("AcConstanciasRetencionesDet");

                entity.Property(e => e.MontoBase).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoRetencion).HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.IdConstanciaRetencionNavigation)
                    .WithMany(p => p.AcConstanciasRetencionesDets)
                    .HasForeignKey(d => d.IdConstanciaRetencion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcConstanciasRetencionesDet_AcConstanciasRetenciones");

                entity.HasOne(d => d.IdTipoImpuestoNavigation)
                    .WithMany(p => p.AcConstanciasRetencionesDets)
                    .HasForeignKey(d => d.IdTipoImpuesto)
                    .HasConstraintName("FK_AcConstanciasRetencionesDet_AcCatTiposImpuestos");
            });

            modelBuilder.Entity<AcContrato>(entity =>
            {
                entity.HasKey(e => e.IdContrato)
                    .HasName("PK_AcContratosCliente");

                entity.HasIndex(e => e.IdProyecto, "IX_AcContratos")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Contrato, "IX_AcContratos_1")
                    .HasFillFactor(90);

                entity.Property(e => e.BaseDatosPu2010)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BaseDatosPU2010");

                entity.Property(e => e.CapturarPorcentajeAnticipo)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CapturarPorcentajeFonGar)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CapturarPorcentajeIva)
                    .IsRequired()
                    .HasColumnName("CapturarPorcentajeIVA")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ConsiderarFgcomoDescuento).HasColumnName("ConsiderarFGcomoDescuento");

                entity.Property(e => e.Contrato)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionContrato)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.FechaDelContrato).HasColumnType("datetime");

                entity.Property(e => e.FechaFin).HasColumnType("datetime");

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.Property(e => e.FechaUltimoCambio).HasColumnType("datetime");

                entity.Property(e => e.IdContratoPu2010).HasColumnName("IdContratoPU2010");

                entity.Property(e => e.IdPresupuestoPu2010).HasColumnName("IdPresupuestoPU2010");

                entity.Property(e => e.IdProyecto).HasColumnName("idProyecto");

                entity.Property(e => e.ImporteAntesIva)
                    .HasColumnType("money")
                    .HasColumnName("ImporteAntesIVA");

                entity.Property(e => e.MontoAnticipo).HasColumnType("money");

                entity.Property(e => e.MontoContrato).HasColumnType("money");

                entity.Property(e => e.MontoFonGar).HasColumnType("money");

                entity.Property(e => e.MontoIva)
                    .HasColumnType("money")
                    .HasColumnName("MontoIVA");

                entity.Property(e => e.MontoIvaAnticipo).HasColumnType("money");

                entity.Property(e => e.Observaciones).IsUnicode(false);

                entity.Property(e => e.PorcentajeAnticipo).HasColumnType("money");

                entity.Property(e => e.PorcentajeFonGar).HasColumnType("money");

                entity.Property(e => e.PorcentajeIva)
                    .HasColumnType("money")
                    .HasColumnName("PorcentajeIVA");

                entity.Property(e => e.ServidorPu2010)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ServidorPU2010");

                entity.HasOne(d => d.IdCatResponsable1Navigation)
                    .WithMany(p => p.AcContratoIdCatResponsable1Navigations)
                    .HasForeignKey(d => d.IdCatResponsable1)
                    .HasConstraintName("FK_AcContratos_ACResponsables");

                entity.HasOne(d => d.IdCatResponsable2Navigation)
                    .WithMany(p => p.AcContratoIdCatResponsable2Navigations)
                    .HasForeignKey(d => d.IdCatResponsable2)
                    .HasConstraintName("FK_AcContratos_ACResponsables1");

                entity.HasOne(d => d.IdCatResponsable3Navigation)
                    .WithMany(p => p.AcContratoIdCatResponsable3Navigations)
                    .HasForeignKey(d => d.IdCatResponsable3)
                    .HasConstraintName("FK_AcContratos_ACResponsables2");

                entity.HasOne(d => d.IdCatResponsable4Navigation)
                    .WithMany(p => p.AcContratoIdCatResponsable4Navigations)
                    .HasForeignKey(d => d.IdCatResponsable4)
                    .HasConstraintName("FK_AcContratos_ACResponsables3");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.AcContratos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcContratos_AcClientes");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AcContratos)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcContratos_Proyectos");

                entity.HasOne(d => d.IdTipoFiscalNavigation)
                    .WithMany(p => p.AcContratos)
                    .HasForeignKey(d => d.IdTipoFiscal)
                    .HasConstraintName("FK_AcContratos_AcTipoFiscal");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AcContratoIdUsuarioNavigations)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcContratos_SegUsuarios");

                entity.HasOne(d => d.IdUsuarioAutorizaNavigation)
                    .WithMany(p => p.AcContratoIdUsuarioAutorizaNavigations)
                    .HasForeignKey(d => d.IdUsuarioAutoriza)
                    .HasConstraintName("FK_AcContratos_SegUsuarios1");
            });

            modelBuilder.Entity<AcContratosDatosAdicSeguridad>(entity =>
            {
                entity.HasKey(e => e.IdContratoSeguridad);

                entity.ToTable("AcContratosDatosAdicSeguridad");

                entity.HasIndex(e => e.IdUsuario, "IX_AcContratosDatosAdicSeguridad")
                    .IsUnique();

                entity.Property(e => e.AdmCuenta)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Asignado)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Autorizado)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Calidad)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Cancelado)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.CasetasEfectivoLiberado)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.CasetasEfectivoPpto)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CasetasEfectivoPPTO")
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ClienteFiscal)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ClienteSitio)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ComentarioAdicional1)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ComentarioAdicional2)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ComentarioAdicional3)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ComentariosCompras)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ComentariosPlaneacion)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ComentariosServicios)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ComidaAliberado)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ComidaALiberado")
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ComidaAppto)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ComidaAPPTO")
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ComidaBliberado)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ComidaBLiberado")
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ComidaBppto)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ComidaBPPTO")
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ConsumiblesLiberado)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ConsumiblesPpto)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ConsumiblesPPTO")
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.DiasEstandar)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.FechaCierreContable)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.FechaComprometida)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.FechaContrato)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.FechaDisponibilidadComprometida)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.FechaDisponibilidadEstimada)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.FechaDisponibilidadFinal)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.FechaDocumentacionCompleta)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.FechaFactura)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.FechaProgramadaIniciar)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.FechaProgramadaTerminar)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.FechaRealizada)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.FechaRecepcionPedido)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.FechaSolicitadaCliente)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.FolioFactura)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.GasolinaLiberado)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.GasolinaPpto)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("GasolinaPPTO")
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.HospedajeLiberado)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.HospedajePpto)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("HospedajePPTO")
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Libre1)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Libre2)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Libre3)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Libre4)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Libre5)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.NumeroContrato)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.PendientePorFacturar)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.PeriodoAdmon)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.PeriodoTecnico)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.PorcenMargen)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.PorcenPresupuestado)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.PorcenRendimiento)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.PorcenTasa)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Proyecto)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.SaldoPesosFactura)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.TipoDeMoneda)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.TransporteAereoLiberado)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.TransporteAereoPpto)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TransporteAereoPPTO")
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.TransporteTerrestreLiberado)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.TransporteTerrestrePpto)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TransporteTerrestrePPTO")
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ValorCobrado)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ValorContrato)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ValorFacturado)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Vendedor)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithOne(p => p.AcContratosDatosAdicSeguridad)
                    .HasForeignKey<AcContratosDatosAdicSeguridad>(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcContratosDatosAdicSeguridad_SegUsuarios");
            });

            modelBuilder.Entity<AcContratosDatosAdicionale>(entity =>
            {
                entity.HasKey(e => e.IdContratoAdicional);

                entity.HasIndex(e => e.IdContrato, "IX_AcContratosDatosAdicionales")
                    .IsUnique();

                entity.Property(e => e.AdmCuenta)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Calidad)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CasetasEfectivoLiberado).HasColumnType("money");

                entity.Property(e => e.CasetasEfectivoPpto)
                    .HasColumnType("money")
                    .HasColumnName("CasetasEfectivoPPTO");

                entity.Property(e => e.ClienteSitio)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ComentarioAdicional1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ComentarioAdicional2)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ComentarioAdicional3)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ComentariosCompras)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ComentariosPlaneacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ComentariosServicios)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ComidaAliberado)
                    .HasColumnType("money")
                    .HasColumnName("ComidaALiberado");

                entity.Property(e => e.ComidaAppto)
                    .HasColumnType("money")
                    .HasColumnName("ComidaAPPTO");

                entity.Property(e => e.ComidaBliberado)
                    .HasColumnType("money")
                    .HasColumnName("ComidaBLiberado");

                entity.Property(e => e.ComidaBppto)
                    .HasColumnType("money")
                    .HasColumnName("ComidaBPPTO");

                entity.Property(e => e.ConsumiblesLiberado).HasColumnType("money");

                entity.Property(e => e.ConsumiblesPpto)
                    .HasColumnType("money")
                    .HasColumnName("ConsumiblesPPTO");

                entity.Property(e => e.DiasStandar)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCierreContable).HasColumnType("datetime");

                entity.Property(e => e.FechaComprometidaFtech)
                    .HasColumnType("datetime")
                    .HasColumnName("FechaComprometidaFTECH");

                entity.Property(e => e.FechaDisponibilidadComprometida).HasColumnType("datetime");

                entity.Property(e => e.FechaDisponibilidadEstimada).HasColumnType("datetime");

                entity.Property(e => e.FechaDisponibilidadFinal).HasColumnType("datetime");

                entity.Property(e => e.FechaDocumentacionCompleta).HasColumnType("datetime");

                entity.Property(e => e.FechaProgramadaDeTerminacion).HasColumnType("datetime");

                entity.Property(e => e.FechaProgramadaIniciar).HasColumnType("datetime");

                entity.Property(e => e.FechaRealizada).HasColumnType("datetime");

                entity.Property(e => e.FechaRecepcionPedido).HasColumnType("datetime");

                entity.Property(e => e.FechaSolicitudCliente).HasColumnType("datetime");

                entity.Property(e => e.GasolinaLiberado).HasColumnType("money");

                entity.Property(e => e.GasolinaPpto)
                    .HasColumnType("money")
                    .HasColumnName("GasolinaPPTO");

                entity.Property(e => e.HospedajeLiberado).HasColumnType("money");

                entity.Property(e => e.HospedajePpto)
                    .HasColumnType("money")
                    .HasColumnName("HospedajePPTO");

                entity.Property(e => e.Libre1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Libre2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Libre3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Libre4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Libre5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodoAdmon)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodoTecnico)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PorcenMargen).HasColumnType("money");

                entity.Property(e => e.PorcenPresupuestado)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PorcenRendimiento).HasColumnType("money");

                entity.Property(e => e.PorcenTasa).HasColumnType("money");

                entity.Property(e => e.TransporteAereoLiberado).HasColumnType("money");

                entity.Property(e => e.TransporteAereoPpto)
                    .HasColumnType("money")
                    .HasColumnName("TransporteAereoPPTO");

                entity.Property(e => e.TransporteTerrestreLiberado).HasColumnType("money");

                entity.Property(e => e.TransporteTerrestrePpto)
                    .HasColumnType("money")
                    .HasColumnName("TransporteTerrestrePPTO");

                entity.Property(e => e.Vendedor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCatStatusNavigation)
                    .WithMany(p => p.AcContratosDatosAdicionales)
                    .HasForeignKey(d => d.IdCatStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcContratosDatosAdicionales_AcCatContratosStatus");

                entity.HasOne(d => d.IdContratoNavigation)
                    .WithOne(p => p.AcContratosDatosAdicionale)
                    .HasForeignKey<AcContratosDatosAdicionale>(d => d.IdContrato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcContratosDatosAdicionales_AcContratos");
            });

            modelBuilder.Entity<AcContratosDet>(entity =>
            {
                entity.HasKey(e => e.IdContratoDet)
                    .HasName("PK_AcDetContratosClientes");

                entity.ToTable("AcContratosDet");

                entity.Property(e => e.Cantidad).HasColumnType("money");

                entity.Property(e => e.CantidadOrdenCambio).HasColumnType("money");

                entity.Property(e => e.ControlPu2010).HasColumnName("ControlPU2010");

                entity.Property(e => e.DescripcionAuxiliar).IsUnicode(false);

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.HasOne(d => d.IdContratoNavigation)
                    .WithMany(p => p.AcContratosDets)
                    .HasForeignKey(d => d.IdContrato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcContratosDet_AcContratos");

                entity.HasOne(d => d.IdProyectoConceptoNavigation)
                    .WithMany(p => p.AcContratosDets)
                    .HasForeignKey(d => d.IdProyectoConcepto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcContratosDet_AcContratosConceptos");

                entity.HasOne(d => d.IdProyectoPartidaNavigation)
                    .WithMany(p => p.AcContratosDets)
                    .HasForeignKey(d => d.IdProyectoPartida)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcContratosDet_AcProyectoPartidas");
            });

            modelBuilder.Entity<AcContratosOc>(entity =>
            {
                entity.HasKey(e => e.IdContratoOc);

                entity.ToTable("AcContratosOC");

                entity.HasIndex(e => new { e.IdContrato, e.NumeroOrdenCambio }, "IX_AcContratosOC")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdContratoOc).HasColumnName("IdContratoOC");

                entity.Property(e => e.Fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.RazonCambio)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdContratoNavigation)
                    .WithMany(p => p.AcContratosOcs)
                    .HasForeignKey(d => d.IdContrato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcContratosOC_AcContratos");
            });

            modelBuilder.Entity<AcContratosOcdet>(entity =>
            {
                entity.HasKey(e => e.IdContratoOcdet);

                entity.ToTable("AcContratosOCDet");

                entity.Property(e => e.IdContratoOcdet).HasColumnName("IdContratoOCDet");

                entity.Property(e => e.Cantidad).HasColumnType("money");

                entity.Property(e => e.IdContratoOc).HasColumnName("IdContratoOC");

                entity.HasOne(d => d.IdContratoDetNavigation)
                    .WithMany(p => p.AcContratosOcdets)
                    .HasForeignKey(d => d.IdContratoDet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcContratosOCDet_AcContratosDet");

                entity.HasOne(d => d.IdContratoOcNavigation)
                    .WithMany(p => p.AcContratosOcdets)
                    .HasForeignKey(d => d.IdContratoOc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcContratosOCDet_AcContratosOC");
            });

            modelBuilder.Entity<AcCostosXproyecto>(entity =>
            {
                entity.HasKey(e => e.IdCostoXproyecto);

                entity.ToTable("AcCostosXProyecto");

                entity.HasIndex(e => new { e.IdProyecto, e.IdInsumo }, "IX_AcCostosXProyecto")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdCostoXproyecto).HasColumnName("idCostoXProyecto");

                entity.Property(e => e.Costo).HasColumnType("money");

                entity.Property(e => e.CostoOriginal).HasColumnType("money");

                entity.Property(e => e.IdInsumo).HasColumnName("idInsumo");

                entity.Property(e => e.IdProyecto).HasColumnName("idProyecto");

                entity.HasOne(d => d.IdInsumoNavigation)
                    .WithMany(p => p.AcCostosXproyectos)
                    .HasForeignKey(d => d.IdInsumo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcCostosXProyecto_AcCatInsumos");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AcCostosXproyectos)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcCostosXProyecto_Proyectos");
            });

            modelBuilder.Entity<AcCuentasBancaria>(entity =>
            {
                entity.HasKey(e => e.IdCuentaBancaria)
                    .HasName("aaaaaCtaCuentas_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.Cuenta, "IX_AcCuentasBancarias")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuenta, "IX_AcCuentasBancarias_1")
                    .HasFillFactor(90);

                entity.Property(e => e.IdCuentaBancaria).HasColumnName("idCuentaBancaria");

                entity.Property(e => e.Banco)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BancoSat)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BancoSAT")
                    .HasDefaultValueSql("((999))");

                entity.Property(e => e.Cuenta)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaBancoSat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CuentaBancoSAT");

                entity.Property(e => e.CuentaClabe)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("CuentaCLABE");

                entity.Property(e => e.IdBancoSat).HasColumnName("IdBancoSAT");

                entity.Property(e => e.IdCuenta).HasColumnName("idCuenta");

                entity.Property(e => e.IdTipoMoneda).HasColumnName("idTipoMoneda");

                entity.Property(e => e.MonedaSat)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MonedaSAT")
                    .HasDefaultValueSql("('MXN')");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.BancoSatNavigation)
                    .WithMany(p => p.AcCuentasBancaria)
                    .HasPrincipalKey(p => p.Clave)
                    .HasForeignKey(d => d.BancoSat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcCuentasBancarias_AcCatBancosSAT");

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithMany(p => p.AcCuentasBancaria)
                    .HasForeignKey(d => d.IdCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CtaCuentas_FK00");

                entity.HasOne(d => d.IdTipoMonedaNavigation)
                    .WithMany(p => p.AcCuentasBancaria)
                    .HasForeignKey(d => d.IdTipoMoneda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcCuentasBancarias_AcCatMonedas");

                entity.HasOne(d => d.MonedaSatNavigation)
                    .WithMany(p => p.AcCuentasBancaria)
                    .HasPrincipalKey(p => p.Clave)
                    .HasForeignKey(d => d.MonedaSat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcCuentasBancarias_CtbCatMonedasSAT");
            });

            modelBuilder.Entity<AcExplosionInsumo>(entity =>
            {
                entity.HasKey(e => e.IdExplosionInsumos)
                    .HasName("aaaaaExplosionInsumos_PK")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.IdProyecto, e.IdInsumo }, "IX_AcExplosionInsumos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdProyecto, "IX_AcExplosionInsumos_1");

                entity.Property(e => e.IdExplosionInsumos).HasColumnName("idExplosionInsumos");

                entity.Property(e => e.CantidadAdicional).HasColumnType("money");

                entity.Property(e => e.CantidadApartadaOp)
                    .HasColumnType("money")
                    .HasColumnName("CantidadApartadaOP");

                entity.Property(e => e.CantidadEntradasConFactura).HasColumnType("money");

                entity.Property(e => e.CantidadEntradasConPedido).HasColumnType("money");

                entity.Property(e => e.CantidadEntradasMultiProyecto).HasColumnType("money");

                entity.Property(e => e.CantidadEntradasPorRm)
                    .HasColumnType("money")
                    .HasColumnName("CantidadEntradasPorRM");

                entity.Property(e => e.CantidadFacturadaConPedido).HasColumnType("money");

                entity.Property(e => e.CantidadFacturadaSinPedido).HasColumnType("money");

                entity.Property(e => e.CantidadInventarioInicial).HasColumnType("money");

                entity.Property(e => e.CantidadMaxima).HasColumnType("money");

                entity.Property(e => e.CantidadMinima).HasColumnType("money");

                entity.Property(e => e.CantidadOriginal).HasColumnType("money");

                entity.Property(e => e.CantidadOriginalImportada).HasColumnType("money");

                entity.Property(e => e.CantidadPedida).HasColumnType("money");

                entity.Property(e => e.CantidadProgramada).HasColumnType("money");

                entity.Property(e => e.CantidadRequerida).HasColumnType("money");

                entity.Property(e => e.CantidadSalidasMultiProyecto).HasColumnType("money");

                entity.Property(e => e.CantidadTraspasoEntrada).HasColumnType("money");

                entity.Property(e => e.CantidadTraspasoSalida).HasColumnType("money");

                entity.Property(e => e.CantidadXgeneradorPoliza)
                    .HasColumnType("money")
                    .HasColumnName("CantidadXGeneradorPoliza");

                entity.Property(e => e.CostoInventarioInicial).HasColumnType("money");

                entity.Property(e => e.CostoOriginal).HasColumnType("money");

                entity.Property(e => e.CostoOriginalImportado).HasColumnType("money");

                entity.Property(e => e.CostoTopeCompra).HasColumnType("money");

                entity.Property(e => e.ExistenciaTotal).HasColumnType("money");

                entity.Property(e => e.ExistenciaTotalAyer).HasColumnType("money");

                entity.Property(e => e.ExistenciaTotalTmp)
                    .HasColumnType("money")
                    .HasColumnName("ExistenciaTotalTMP");

                entity.Property(e => e.IdAditivaInventarioInicial).HasColumnName("idAditivaInventarioInicial");

                entity.Property(e => e.IdInsumo).HasColumnName("idInsumo");

                entity.Property(e => e.IdProyecto).HasColumnName("idProyecto");

                entity.Property(e => e.ImporteTotal).HasColumnType("money");

                entity.Property(e => e.ImporteTotalAyer).HasColumnType("money");

                entity.Property(e => e.ImporteTotalTmp)
                    .HasColumnType("money")
                    .HasColumnName("ImporteTotalTMP");

                entity.Property(e => e.ToparCantidad)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ToparPrecio)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdInsumoNavigation)
                    .WithMany(p => p.AcExplosionInsumos)
                    .HasForeignKey(d => d.IdInsumo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ExplosionInsumos_FK00");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AcExplosionInsumos)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcExplosionInsumos_Proyectos");
            });

            modelBuilder.Entity<AcFacturasAddendasCampo>(entity =>
            {
                entity.HasKey(e => e.IdFacturaAddendaCampo)
                    .HasName("PK_AcFacturasCamposAddendas");

                entity.Property(e => e.Campo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Detalle)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdClienteFacturaCv).HasColumnName("IdClienteFacturaCV");

                entity.Property(e => e.IdClienteFacturaNc).HasColumnName("IdClienteFacturaNC");

                entity.Property(e => e.TipoArchivo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClienteFacturaCvNavigation)
                    .WithMany(p => p.AcFacturasAddendasCampos)
                    .HasForeignKey(d => d.IdClienteFacturaCv)
                    .HasConstraintName("FK_AcFacturasAddendasCampos_CvClientesFacturas");

                entity.HasOne(d => d.IdClienteFacturaNcNavigation)
                    .WithMany(p => p.AcFacturasAddendasCampos)
                    .HasForeignKey(d => d.IdClienteFacturaNc)
                    .HasConstraintName("FK_AcFacturasAddendasCampos_AcClientesFacturasNC");

                entity.HasOne(d => d.IdConstanciaRetencionNavigation)
                    .WithMany(p => p.AcFacturasAddendasCampos)
                    .HasForeignKey(d => d.IdConstanciaRetencion)
                    .HasConstraintName("FK_AcFacturasAddendasCampos_AcConstanciasRetenciones");

                entity.HasOne(d => d.IdFacturaNavigation)
                    .WithMany(p => p.AcFacturasAddendasCampos)
                    .HasForeignKey(d => d.IdFactura)
                    .HasConstraintName("FK_AcFacturasAddendasCampos_AcClientesFacturas");
            });

            modelBuilder.Entity<AcFacturasAddendasProducto>(entity =>
            {
                entity.HasKey(e => e.IdFacturaAddendaProducto);

                entity.Property(e => e.Campo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdClienteFacturaCv).HasColumnName("IdClienteFacturaCV");

                entity.Property(e => e.IdClienteFacturaNc).HasColumnName("IdClienteFacturaNC");

                entity.Property(e => e.Producto)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClienteFacturaCvNavigation)
                    .WithMany(p => p.AcFacturasAddendasProductos)
                    .HasForeignKey(d => d.IdClienteFacturaCv)
                    .HasConstraintName("FK_AcFacturasAddendasProductos_CvClientesFacturas");

                entity.HasOne(d => d.IdClienteFacturaNcNavigation)
                    .WithMany(p => p.AcFacturasAddendasProductos)
                    .HasForeignKey(d => d.IdClienteFacturaNc)
                    .HasConstraintName("FK_AcFacturasAddendasProductos_AcClientesFacturasNC");

                entity.HasOne(d => d.IdConstanciaRetencionNavigation)
                    .WithMany(p => p.AcFacturasAddendasProductos)
                    .HasForeignKey(d => d.IdConstanciaRetencion)
                    .HasConstraintName("FK_AcFacturasAddendasProductos_AcConstanciasRetenciones");

                entity.HasOne(d => d.IdFacturaNavigation)
                    .WithMany(p => p.AcFacturasAddendasProductos)
                    .HasForeignKey(d => d.IdFactura)
                    .HasConstraintName("FK_AcFacturasAddendasProductos_AcClientesFacturas");
            });

            modelBuilder.Entity<AcFacturasProveedore>(entity =>
            {
                entity.HasKey(e => e.IdFacturaProveedor)
                    .HasName("aaaaaFacturas_PK")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.IdProveedor, e.Factura }, "IX_AcFacturasProveedores");

                entity.HasIndex(e => e.IdPedido, "IX_AcFacturasProveedores_idPedido");

                entity.HasIndex(e => e.IdPoliza, "IX_AcFacturasProveedores_idPoliza");

                entity.HasIndex(e => e.IdPolizaDet, "IX_AcFacturasProveedores_idPolizaDet");

                entity.Property(e => e.IdFacturaProveedor).HasColumnName("idFacturaProveedor");

                entity.Property(e => e.AbonoCuentaProveedor).HasColumnType("money");

                entity.Property(e => e.AbonoCuentaProveedorComplementaria).HasColumnType("money");

                entity.Property(e => e.DescripcionCancelacion)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionFactura)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Factura)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCancelacion).HasColumnType("datetime");

                entity.Property(e => e.FechaFactura).HasColumnType("datetime");

                entity.Property(e => e.FechaFacturaNueva).HasColumnType("datetime");

                entity.Property(e => e.FechaImportacionDaltonDin)
                    .HasColumnType("datetime")
                    .HasColumnName("FechaImportacionDaltonDIN");

                entity.Property(e => e.FechaPoliza).HasColumnType("datetime");

                entity.Property(e => e.FechaProbablePago).HasColumnType("datetime");

                entity.Property(e => e.IdPedido).HasColumnName("idPedido");

                entity.Property(e => e.IdPoliza).HasColumnName("idPoliza");

                entity.Property(e => e.IdPolizaInversa).HasColumnName("idPolizaInversa");

                entity.Property(e => e.IdProveedor).HasColumnName("idProveedor");

                entity.Property(e => e.IdProyecto).HasColumnName("idProyecto");

                entity.Property(e => e.IdXmlproveedor).HasColumnName("IdXMLProveedor");

                entity.Property(e => e.ImportadoDaltonDin).HasColumnName("ImportadoDaltonDIN");

                entity.Property(e => e.ImporteFacturaAnticipo).HasColumnType("money");

                entity.Property(e => e.IntInmfacturaProveedorKey).HasColumnName("intINMFacturaProveedorKey");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.AcFacturasProveedores)
                    .HasForeignKey(d => d.IdPedido)
                    .HasConstraintName("FK_AcFacturasProveedores_AcPedidos");

                entity.HasOne(d => d.IdPolizaNavigation)
                    .WithMany(p => p.AcFacturasProveedoreIdPolizaNavigations)
                    .HasForeignKey(d => d.IdPoliza)
                    .HasConstraintName("FK_AcFacturasProveedores_CtbPolizas");

                entity.HasOne(d => d.IdPolizaDetNavigation)
                    .WithMany(p => p.AcFacturasProveedores)
                    .HasForeignKey(d => d.IdPolizaDet)
                    .HasConstraintName("FK_AcFacturasProveedores_CtbPolizasDet");

                entity.HasOne(d => d.IdPolizaInversaNavigation)
                    .WithMany(p => p.AcFacturasProveedoreIdPolizaInversaNavigations)
                    .HasForeignKey(d => d.IdPolizaInversa)
                    .HasConstraintName("FK_AcFacturasProveedores_CtbPolizas1");

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.AcFacturasProveedores)
                    .HasForeignKey(d => d.IdProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcFacturasProveedores_AcProveedores");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AcFacturasProveedores)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcFacturasProveedores_Proyectos");

                entity.HasOne(d => d.IdSubContratoNavigation)
                    .WithMany(p => p.AcFacturasProveedores)
                    .HasForeignKey(d => d.IdSubContrato)
                    .HasConstraintName("FK_AcFacturasProveedores_AoSubContratos");

                entity.HasOne(d => d.IdSubContratoEstNavigation)
                    .WithMany(p => p.AcFacturasProveedores)
                    .HasForeignKey(d => d.IdSubContratoEst)
                    .HasConstraintName("FK_AcFacturasProveedores_AoSubContratosEst");

                entity.HasOne(d => d.IdTipoProveedorNavigation)
                    .WithMany(p => p.AcFacturasProveedores)
                    .HasForeignKey(d => d.IdTipoProveedor)
                    .HasConstraintName("FK_AcFacturasProveedores_AcCatTipoProveedor");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AcFacturasProveedoreIdUsuarioNavigations)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcFacturasProveedores_SegUsuarios");

                entity.HasOne(d => d.IdUsuarioCancelacionNavigation)
                    .WithMany(p => p.AcFacturasProveedoreIdUsuarioCancelacionNavigations)
                    .HasForeignKey(d => d.IdUsuarioCancelacion)
                    .HasConstraintName("FK_AcFacturasProveedores_SegUsuarios1");

                entity.HasOne(d => d.IdXmlproveedorNavigation)
                    .WithMany(p => p.AcFacturasProveedores)
                    .HasForeignKey(d => d.IdXmlproveedor)
                    .HasConstraintName("FK_AcFacturasProveedores_AcProveedoresXML");
            });

            modelBuilder.Entity<AcFacturasProveedoresCuenta>(entity =>
            {
                entity.HasKey(e => e.IdFacturaProveedorCuenta)
                    .HasName("PK_AcFacturasProveedoresDescuentos");

                entity.HasIndex(e => e.IdFacturaProveedorCuenta, "IX_AcFacturasProveedoresCuentas")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuenta, "IX_AcFacturasProveedoresCuentas_1")
                    .HasFillFactor(90);

                entity.Property(e => e.CapturarPorcentaje)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DescripcionFactura)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.IdCuenta).HasColumnName("idCuenta");

                entity.Property(e => e.IdFacturaProveedor).HasColumnName("idFacturaProveedor");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.MontoPesos).HasColumnType("money");

                entity.Property(e => e.Porcentaje).HasColumnType("money");

                entity.Property(e => e.SecuenciaDeCalculo).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithMany(p => p.AcFacturasProveedoresCuenta)
                    .HasForeignKey(d => d.IdCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcFacturasProveedoresDescuentos_CtbCuentas");

                entity.HasOne(d => d.IdFacturaProveedorNavigation)
                    .WithMany(p => p.AcFacturasProveedoresCuenta)
                    .HasForeignKey(d => d.IdFacturaProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcFacturasProveedoresDescuentos_AcFacturasProveedores");
            });

            modelBuilder.Entity<AcFacturasProveedoresDet>(entity =>
            {
                entity.HasKey(e => e.IdFacturaProveedorDet);

                entity.ToTable("AcFacturasProveedoresDet");

                entity.HasIndex(e => e.IdCuenta, "IX_AcFacturasProveedoresDet")
                    .HasFillFactor(90);

                entity.Property(e => e.Cantidad).HasColumnType("money");

                entity.Property(e => e.Costo).HasColumnType("money");

                entity.Property(e => e.IdCuenta).HasColumnName("idCuenta");

                entity.Property(e => e.IdExplosionInsumos).HasColumnName("idExplosionInsumos");

                entity.Property(e => e.IdFacturaProveedor).HasColumnName("idFacturaProveedor");

                entity.Property(e => e.IdSubcontratoDet).HasColumnName("idSubcontratoDet");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithMany(p => p.AcFacturasProveedoresDets)
                    .HasForeignKey(d => d.IdCuenta)
                    .HasConstraintName("FK_AcFacturasProveedoresDet_CtbCuentas");

                entity.HasOne(d => d.IdExplosionInsumosNavigation)
                    .WithMany(p => p.AcFacturasProveedoresDets)
                    .HasForeignKey(d => d.IdExplosionInsumos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcFacturasProveedoresDet_AcExplosionInsumos");

                entity.HasOne(d => d.IdFacturaProveedorNavigation)
                    .WithMany(p => p.AcFacturasProveedoresDets)
                    .HasForeignKey(d => d.IdFacturaProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcFacturasProveedoresDet_AcFacturasProveedores");

                entity.HasOne(d => d.IdPedidoDetNavigation)
                    .WithMany(p => p.AcFacturasProveedoresDets)
                    .HasForeignKey(d => d.IdPedidoDet)
                    .HasConstraintName("FK_AcFacturasProveedoresDet_AcPedidosDet");
            });

            modelBuilder.Entity<AcFacturasProveedoresNc>(entity =>
            {
                entity.HasKey(e => e.IdFacturaProveedorNc)
                    .HasName("aaaaaMovFacturas_PK")
                    .IsClustered(false);

                entity.ToTable("AcFacturasProveedoresNC");

                entity.HasIndex(e => new { e.IdProveedor, e.NoNc }, "IX_AcFacturasProveedoresNC")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdFacturaProveedorNc).HasColumnName("idFacturaProveedorNC");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionCancelacion)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaCancelacion).HasColumnType("smalldatetime");

                entity.Property(e => e.IdPoliza).HasColumnName("idPoliza");

                entity.Property(e => e.IdPolizaInversa).HasColumnName("idPolizaInversa");

                entity.Property(e => e.IdTipoNc).HasColumnName("IdTipoNC");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.MontoIva)
                    .HasColumnType("money")
                    .HasColumnName("MontoIVA");

                entity.Property(e => e.NoNc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NoNC");

                entity.HasOne(d => d.IdPolizaNavigation)
                    .WithMany(p => p.AcFacturasProveedoresNcIdPolizaNavigations)
                    .HasForeignKey(d => d.IdPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcProveedoresFacturasNC_CtbPolizas");

                entity.HasOne(d => d.IdPolizaDetNavigation)
                    .WithMany(p => p.AcFacturasProveedoresNcs)
                    .HasForeignKey(d => d.IdPolizaDet)
                    .HasConstraintName("FK_AcFacturasProveedoresNC_CtbPolizasDet");

                entity.HasOne(d => d.IdPolizaInversaNavigation)
                    .WithMany(p => p.AcFacturasProveedoresNcIdPolizaInversaNavigations)
                    .HasForeignKey(d => d.IdPolizaInversa)
                    .HasConstraintName("FK_AcProveedoresFacturasNC_CtbPolizas1");

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.AcFacturasProveedoresNcs)
                    .HasForeignKey(d => d.IdProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcFacturasProveedoresNC_AcProveedores");

                entity.HasOne(d => d.IdSubContratoEstNavigation)
                    .WithMany(p => p.AcFacturasProveedoresNcs)
                    .HasForeignKey(d => d.IdSubContratoEst)
                    .HasConstraintName("FK_AcFacturasProveedoresNC_AoSubContratosEst");

                entity.HasOne(d => d.IdTipoNcNavigation)
                    .WithMany(p => p.AcFacturasProveedoresNcs)
                    .HasForeignKey(d => d.IdTipoNc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcFacturasProveedoresNC_AcCatTiposNC");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AcFacturasProveedoresNcIdUsuarioNavigations)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcProveedoresFacturasNC_SegUsuarios");

                entity.HasOne(d => d.IdUsuarioCancelacionNavigation)
                    .WithMany(p => p.AcFacturasProveedoresNcIdUsuarioCancelacionNavigations)
                    .HasForeignKey(d => d.IdUsuarioCancelacion)
                    .HasConstraintName("FK_AcFacturasProveedoresNC_SegUsuarios");

                entity.HasOne(d => d.IdXmlProveedorNavigation)
                    .WithMany(p => p.AcFacturasProveedoresNcs)
                    .HasForeignKey(d => d.IdXmlProveedor)
                    .HasConstraintName("FK_AcFacturasProveedoresNC_AcProveedoresXML");
            });

            modelBuilder.Entity<AcFacturasSeries>(entity =>
            {
                entity.HasKey(e => e.IdFacturaSerie);

                entity.HasIndex(e => new { e.IdFacturaSerie, e.FacturaSerie, e.Folio, e.NoAprobacion }, "IX_AcFacturasSeries")
                    .IsUnique();

                entity.Property(e => e.EsCbb).HasColumnName("EsCBB");

                entity.Property(e => e.FacturaSerie)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAprobacion).HasColumnType("datetime");

                entity.Property(e => e.ImagenCbb).HasColumnName("ImagenCBB");

                entity.Property(e => e.TipoComprobante)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdMatrizSucursalNavigation)
                    .WithMany(p => p.AcFacturasSeries)
                    .HasForeignKey(d => d.IdMatrizSucursal)
                    .HasConstraintName("FK_AcFacturasSeries_FENeodataMatrizSucursales");
            });

            modelBuilder.Entity<AcFamilia>(entity =>
            {
                entity.HasKey(e => e.IdFamilia)
                    .HasName("aaaaaFamilias_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.IdCuenta, "IX_AcFamilias")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Familia, "IX_Familias_Unico")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdFamilia).HasColumnName("idFamilia");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Familia)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('CodigoFamilia')");

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithMany(p => p.AcFamilia)
                    .HasForeignKey(d => d.IdCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcFamilias_CtbCuentas");
            });

            modelBuilder.Entity<AcFlujoEfectivoOtrosIngresosEgreso>(entity =>
            {
                entity.HasKey(e => e.IdFlujoEfectivoOtroIngresoEgreso);

                entity.HasIndex(e => e.IdProyecto, "IX_AcFlujoEfectivoOtrosIngresosEgresos");

                entity.HasIndex(e => new { e.IdProyecto, e.Fecha }, "IX_AcFlujoEfectivoOtrosIngresosEgresos_1");

                entity.Property(e => e.IdFlujoEfectivoOtroIngresoEgreso).HasColumnName("idFlujoEfectivoOtroIngresoEgreso");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.Observaciones).HasMaxLength(250);

                entity.Property(e => e.Referencia)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.IdCuentaBancariaNavigation)
                    .WithMany(p => p.AcFlujoEfectivoOtrosIngresosEgresos)
                    .HasForeignKey(d => d.IdCuentaBancaria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcFlujoEfectivoOtrosIngresosEgresos_AcCuentasBancarias");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AcFlujoEfectivoOtrosIngresosEgresos)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcFlujoEfectivoOtrosIngresosEgresos_Proyectos");

                entity.HasOne(d => d.IdTipoOtroIngresoEgresoNavigation)
                    .WithMany(p => p.AcFlujoEfectivoOtrosIngresosEgresos)
                    .HasForeignKey(d => d.IdTipoOtroIngresoEgreso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcFlujoEfectivoOtrosIngresosEgresos_AcCatFlujoEfectivoOtrosIngresosEgresos");
            });

            modelBuilder.Entity<AcGastosFinanciero>(entity =>
            {
                entity.HasKey(e => e.IdGastosFinancieros);

                entity.HasIndex(e => new { e.IdProyecto, e.Folio }, "IX_AcGastosFinancieros")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuentaBancaria, "IX_AcGastosFinancieros_1")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdPoliza, "IX_AcGastosFinancieros_2")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdPolizaInversa, "IX_AcGastosFinancieros_3")
                    .HasFillFactor(90);

                entity.Property(e => e.FechaCancelacion).HasColumnType("datetime");

                entity.Property(e => e.FechaPoliza).HasColumnType("datetime");

                entity.Property(e => e.IdCuentaBancaria).HasColumnName("idCuentaBancaria");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCuentaBancariaNavigation)
                    .WithMany(p => p.AcGastosFinancieros)
                    .HasForeignKey(d => d.IdCuentaBancaria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcGastosFinancieros_AcCuentasBancarias");

                entity.HasOne(d => d.IdPolizaNavigation)
                    .WithMany(p => p.AcGastosFinancieroIdPolizaNavigations)
                    .HasForeignKey(d => d.IdPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcGastosFinancieros_CtbPolizas");

                entity.HasOne(d => d.IdPolizaInversaNavigation)
                    .WithMany(p => p.AcGastosFinancieroIdPolizaInversaNavigations)
                    .HasForeignKey(d => d.IdPolizaInversa)
                    .HasConstraintName("FK_AcGastosFinancieros_CtbPolizas1");

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.AcGastosFinancieros)
                    .HasForeignKey(d => d.IdProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcGastosFinancieros_AcProveedores");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AcGastosFinancieros)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcGastosFinancieros_Proyectos");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AcGastosFinancieroIdUsuarioNavigations)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcGastosFinancieros_SegUsuarios");

                entity.HasOne(d => d.IdUsuarioCancelacionNavigation)
                    .WithMany(p => p.AcGastosFinancieroIdUsuarioCancelacionNavigations)
                    .HasForeignKey(d => d.IdUsuarioCancelacion)
                    .HasConstraintName("FK_AcGastosFinancieros_SegUsuarios1");
            });

            modelBuilder.Entity<AcGastosFinancierosDet>(entity =>
            {
                entity.HasKey(e => e.IdGastosFinancierosDet);

                entity.ToTable("AcGastosFinancierosDet");

                entity.HasIndex(e => e.IdCuentaIva, "IX_AcGastosFinancierosDet")
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.IdGastosFinancieros, e.IdProyecto, e.Factura, e.IdExplosionInsumos }, "IX_AcGastosFinancierosDet_1")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Cantidad).HasColumnType("money");

                entity.Property(e => e.Costo).HasColumnType("money");

                entity.Property(e => e.Factura)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdCuentaIva).HasColumnName("IdCuentaIVA");

                entity.Property(e => e.IdExplosionInsumos).HasColumnName("idExplosionInsumos");

                entity.Property(e => e.Iva)
                    .HasColumnType("money")
                    .HasColumnName("IVA");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCuentaIvaNavigation)
                    .WithMany(p => p.AcGastosFinancierosDets)
                    .HasForeignKey(d => d.IdCuentaIva)
                    .HasConstraintName("FK_AcGastosFinancierosDet_CtbCuentas");

                entity.HasOne(d => d.IdExplosionInsumosNavigation)
                    .WithMany(p => p.AcGastosFinancierosDets)
                    .HasForeignKey(d => d.IdExplosionInsumos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcGastosFinancierosDet_AcExplosionInsumos");

                entity.HasOne(d => d.IdGastosFinancierosNavigation)
                    .WithMany(p => p.AcGastosFinancierosDets)
                    .HasForeignKey(d => d.IdGastosFinancieros)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcGastosFinancierosDet_AcGastosFinancieros");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AcGastosFinancierosDets)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcGastosFinancierosDet_Proyectos");
            });

            modelBuilder.Entity<AcGastosXcomprobar>(entity =>
            {
                entity.HasKey(e => e.IdGastoXcomprobar);

                entity.ToTable("AcGastosXComprobar");

                entity.HasIndex(e => new { e.IdProyecto, e.Folio }, "IX_AcGastosXComprobar")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuenta, "IX_AcGastosXComprobar_1")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdPoliza, "IX_AcGastosXComprobar_2")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdPolizaInversa, "IX_AcGastosXComprobar_3")
                    .HasFillFactor(90);

                entity.Property(e => e.IdGastoXcomprobar).HasColumnName("IdGastoXComprobar");

                entity.Property(e => e.FechaCancelacion).HasColumnType("datetime");

                entity.Property(e => e.FechaPoliza).HasColumnType("datetime");

                entity.Property(e => e.MesPolizaDiot).HasColumnName("MesPolizaDIOT");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAcreedorNavigation)
                    .WithMany(p => p.AcGastosXcomprobars)
                    .HasForeignKey(d => d.IdAcreedor)
                    .HasConstraintName("FK_AcGastosXComprobar_AcCatAcreedores");

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithMany(p => p.AcGastosXcomprobars)
                    .HasForeignKey(d => d.IdCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcGastosXComprobar_CtbCuentas");

                entity.HasOne(d => d.IdDeudorNavigation)
                    .WithMany(p => p.AcGastosXcomprobars)
                    .HasForeignKey(d => d.IdDeudor)
                    .HasConstraintName("FK_AcGastosXComprobar_AcCatDeudores");

                entity.HasOne(d => d.IdFlujoNavigation)
                    .WithMany(p => p.AcGastosXcomprobars)
                    .HasForeignKey(d => d.IdFlujo)
                    .HasConstraintName("FK_AcGastosXComprobar_AcCatFlujos");

                entity.HasOne(d => d.IdPolizaNavigation)
                    .WithMany(p => p.AcGastosXcomprobarIdPolizaNavigations)
                    .HasForeignKey(d => d.IdPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcGastosXComprobar_CtbPolizas");

                entity.HasOne(d => d.IdPolizaInversaNavigation)
                    .WithMany(p => p.AcGastosXcomprobarIdPolizaInversaNavigations)
                    .HasForeignKey(d => d.IdPolizaInversa)
                    .HasConstraintName("FK_AcGastosXComprobar_CtbPolizas1");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AcGastosXcomprobars)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcGastosXComprobar_Proyectos");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AcGastosXcomprobarIdUsuarioNavigations)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcGastosXComprobar_SegUsuarios");

                entity.HasOne(d => d.IdUsuarioCancelacionNavigation)
                    .WithMany(p => p.AcGastosXcomprobarIdUsuarioCancelacionNavigations)
                    .HasForeignKey(d => d.IdUsuarioCancelacion)
                    .HasConstraintName("FK_AcGastosXComprobar_SegUsuarios1");
            });

            modelBuilder.Entity<AcGastosXcomprobarDet>(entity =>
            {
                entity.HasKey(e => e.IdGastoXcomprobarDet);

                entity.ToTable("AcGastosXComprobarDet");

                entity.HasIndex(e => e.IdCuentaIva, "IX_AcGastosXComprobarDet")
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.IdGastoXcomprobar, e.IdProyecto, e.Factura, e.IdExplosionInsumos }, "IX_AcGastosXComprobarDet_1")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdGastoXcomprobarDet).HasColumnName("IdGastoXComprobarDet");

                entity.Property(e => e.Cantidad).HasColumnType("money");

                entity.Property(e => e.Costo).HasColumnType("money");

                entity.Property(e => e.Factura)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IdCuentaIva).HasColumnName("IdCuentaIVA");

                entity.Property(e => e.IdCuentaRetencionIsr).HasColumnName("IdCuentaRetencionISR");

                entity.Property(e => e.IdCuentaRetencionIva).HasColumnName("IdCuentaRetencionIVA");

                entity.Property(e => e.IdExplosionInsumos).HasColumnName("idExplosionInsumos");

                entity.Property(e => e.IdGastoXcomprobar).HasColumnName("IdGastoXComprobar");

                entity.Property(e => e.IdXmlproveedor).HasColumnName("IdXMLProveedor");

                entity.Property(e => e.Iva)
                    .HasColumnType("money")
                    .HasColumnName("IVA");

                entity.Property(e => e.MontoRetencionIsr)
                    .HasColumnType("money")
                    .HasColumnName("MontoRetencionISR");

                entity.Property(e => e.MontoRetencionIva)
                    .HasColumnType("money")
                    .HasColumnName("MontoRetencionIVA");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCuentaIvaNavigation)
                    .WithMany(p => p.AcGastosXcomprobarDets)
                    .HasForeignKey(d => d.IdCuentaIva)
                    .HasConstraintName("FK_AcGastosXComprobarDet_CtbCuentas");

                entity.HasOne(d => d.IdExplosionInsumosNavigation)
                    .WithMany(p => p.AcGastosXcomprobarDets)
                    .HasForeignKey(d => d.IdExplosionInsumos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcGastosXComprobarDet_AcExplosionInsumos");

                entity.HasOne(d => d.IdGastoXcomprobarNavigation)
                    .WithMany(p => p.AcGastosXcomprobarDets)
                    .HasForeignKey(d => d.IdGastoXcomprobar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcGastosXComprobarDet_AcGastosXComprobar");

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.AcGastosXcomprobarDets)
                    .HasForeignKey(d => d.IdProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcGastosXComprobarDet_AcProveedores");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AcGastosXcomprobarDets)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcGastosXComprobarDet_Proyectos");

                entity.HasOne(d => d.IdXmlproveedorNavigation)
                    .WithMany(p => p.AcGastosXcomprobarDets)
                    .HasForeignKey(d => d.IdXmlproveedor)
                    .HasConstraintName("FK_AcGastosXComprobarDet_AcProveedoresXML");
            });

            modelBuilder.Entity<AcGastosXcomprobarDetDiot>(entity =>
            {
                entity.HasKey(e => e.IdGastosXcomprobarDetDiot);

                entity.ToTable("AcGastosXComprobarDetDiot");

                entity.Property(e => e.IdGastosXcomprobarDetDiot).HasColumnName("IdGastosXComprobarDetDiot");

                entity.Property(e => e.IdConceptoDiot).HasColumnName("IdConceptoDIOT");

                entity.Property(e => e.IdGastosXcomprobarDet).HasColumnName("IdGastosXComprobarDet");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.MontoIva)
                    .HasColumnType("money")
                    .HasColumnName("MontoIVA");

                entity.HasOne(d => d.IdConceptoDiotNavigation)
                    .WithMany(p => p.AcGastosXcomprobarDetDiots)
                    .HasForeignKey(d => d.IdConceptoDiot)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcGastosXComprobarDetDiot_CtbConceptosDIOT");

                entity.HasOne(d => d.IdGastosXcomprobarDetNavigation)
                    .WithMany(p => p.AcGastosXcomprobarDetDiots)
                    .HasForeignKey(d => d.IdGastosXcomprobarDet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcGastosXComprobarDetDiot_AcGastosXComprobarDet");
            });

            modelBuilder.Entity<AcGeneradorPoliza>(entity =>
            {
                entity.HasKey(e => e.IdGeneradorPoliza);

                entity.HasIndex(e => new { e.IdProyecto, e.Folio }, "IX_AcGeneradorPolizas")
                    .IsUnique();

                entity.Property(e => e.Concepto)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCancelacion).HasColumnType("datetime");

                entity.Property(e => e.FechaPoliza).HasColumnType("datetime");

                entity.HasOne(d => d.IdPolizaNavigation)
                    .WithMany(p => p.AcGeneradorPolizas)
                    .HasForeignKey(d => d.IdPoliza)
                    .HasConstraintName("FK_AcGeneradorPolizas_CtbPolizas");

                entity.HasOne(d => d.IdPolizaModeloNavigation)
                    .WithMany(p => p.AcGeneradorPolizas)
                    .HasForeignKey(d => d.IdPolizaModelo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcGeneradorPolizas_AcModelosPoliza");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AcGeneradorPolizas)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcGeneradorPolizas_Proyectos");

                entity.HasOne(d => d.IdTipoPolizaNavigation)
                    .WithMany(p => p.AcGeneradorPolizas)
                    .HasForeignKey(d => d.IdTipoPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcGeneradorPolizas_CtbTiposPoliza");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AcGeneradorPolizaIdUsuarioNavigations)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcGeneradorPolizas_SegUsuarios");

                entity.HasOne(d => d.IdUsuarioCancelacionNavigation)
                    .WithMany(p => p.AcGeneradorPolizaIdUsuarioCancelacionNavigations)
                    .HasForeignKey(d => d.IdUsuarioCancelacion)
                    .HasConstraintName("FK_AcGeneradorPolizas_SegUsuarios1");
            });

            modelBuilder.Entity<AcGeneradorPolizaCuenta>(entity =>
            {
                entity.HasKey(e => e.IdGeneradorPolizaCuenta);

                entity.Property(e => e.Importe).HasColumnType("money");

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithMany(p => p.AcGeneradorPolizaCuenta)
                    .HasForeignKey(d => d.IdCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcGeneradorPolizaCuentas_CtbCuentas");

                entity.HasOne(d => d.IdGeneradorPolizaNavigation)
                    .WithMany(p => p.AcGeneradorPolizaCuenta)
                    .HasForeignKey(d => d.IdGeneradorPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcGeneradorPolizaCuentas_AcGeneradorPolizas");
            });

            modelBuilder.Entity<AcGeneradorPolizaInsumo>(entity =>
            {
                entity.HasKey(e => e.IdGeneradorPolizaInsumo);

                entity.Property(e => e.Cantidad).HasColumnType("money");

                entity.Property(e => e.Costo).HasColumnType("money");

                entity.Property(e => e.Importe).HasColumnType("money");

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithMany(p => p.AcGeneradorPolizaInsumos)
                    .HasForeignKey(d => d.IdCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcGeneradorPolizaInsumos_CtbCuentas");

                entity.HasOne(d => d.IdExplosionInsumosNavigation)
                    .WithMany(p => p.AcGeneradorPolizaInsumos)
                    .HasForeignKey(d => d.IdExplosionInsumos)
                    .HasConstraintName("FK_AcGeneradorPolizaInsumos_AcExplosionInsumos");

                entity.HasOne(d => d.IdGeneradorPolizaNavigation)
                    .WithMany(p => p.AcGeneradorPolizaInsumos)
                    .HasForeignKey(d => d.IdGeneradorPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcGeneradorPolizaInsumos_AcGeneradorPolizas");
            });

            modelBuilder.Entity<AcLayoutCw>(entity =>
            {
                entity.HasKey(e => e.IdLayoutCw);

                entity.ToTable("AcLayoutCW");

                entity.HasIndex(e => e.LayoutCw, "IX_AcLayoutCW")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdLayoutCw).HasColumnName("IdLayoutCW");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .UseCollation("Traditional_Spanish_CI_AS");

                entity.Property(e => e.LayoutCw)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LayoutCW")
                    .UseCollation("Traditional_Spanish_CI_AS");

                entity.Property(e => e.Separador)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .UseCollation("Traditional_Spanish_CI_AS");
            });

            modelBuilder.Entity<AcLayoutCwdet>(entity =>
            {
                entity.HasKey(e => e.IdLayoutCwdet);

                entity.ToTable("AcLayoutCWDet");

                entity.HasIndex(e => e.IdLayoutCw, "IX_AcLayoutCWDet")
                    .HasFillFactor(90);

                entity.Property(e => e.IdLayoutCwdet).HasColumnName("IdLayoutCWDet");

                entity.Property(e => e.DataField)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .UseCollation("Traditional_Spanish_CI_AS");

                entity.Property(e => e.IdLayoutCw).HasColumnName("IdLayoutCW");

                entity.Property(e => e.Justificado)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('IZQ')")
                    .UseCollation("Traditional_Spanish_CI_AS");

                entity.Property(e => e.NombreCampo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .UseCollation("Traditional_Spanish_CI_AS");

                entity.Property(e => e.Relleno)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .UseCollation("Traditional_Spanish_CI_AS");

                entity.HasOne(d => d.IdLayoutCwNavigation)
                    .WithMany(p => p.AcLayoutCwdets)
                    .HasForeignKey(d => d.IdLayoutCw)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcLayoutCWDet_AcLayoutCW");
            });

            modelBuilder.Entity<AcMetodoPago>(entity =>
            {
                entity.HasKey(e => e.IdMetodoPago);

                entity.ToTable("AcMetodoPago");

                entity.HasIndex(e => e.Codigo, "IX_AcMetodoPago_Unico")
                    .IsUnique();

                entity.Property(e => e.IdMetodoPago).HasColumnName("idMetodoPago");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AcModelosPoliza>(entity =>
            {
                entity.HasKey(e => e.IdPolizaModelo);

                entity.ToTable("AcModelosPoliza");

                entity.HasIndex(e => e.PolizaModelo, "IX_AcModelosPoliza")
                    .IsUnique();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PolizaModelo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AcModelosPolizaCuenta>(entity =>
            {
                entity.HasKey(e => e.IdModeloPolizaCuenta);

                entity.HasIndex(e => new { e.IdPolizaModelo, e.IdCuenta }, "IX_AcModelosPolizaCuentas")
                    .IsUnique();

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithMany(p => p.AcModelosPolizaCuenta)
                    .HasForeignKey(d => d.IdCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcModelosPolizaCuentas_CtbCuentas");
            });

            modelBuilder.Entity<AcModelosPolizaInsumo>(entity =>
            {
                entity.HasKey(e => e.IdModeloPolizaInsumo);

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithMany(p => p.AcModelosPolizaInsumos)
                    .HasForeignKey(d => d.IdCuenta)
                    .HasConstraintName("FK_AcModelosPolizaInsumos_CtbCuentas");

                entity.HasOne(d => d.IdInsumoNavigation)
                    .WithMany(p => p.AcModelosPolizaInsumos)
                    .HasForeignKey(d => d.IdInsumo)
                    .HasConstraintName("FK_AcModelosPolizaInsumos_AcCatInsumos");
            });

            modelBuilder.Entity<AcNominaCatalogoConcepto>(entity =>
            {
                entity.HasKey(e => e.IdNominaConcepto)
                    .HasName("PK_AcCatalogoConceptosNomina");

                entity.HasIndex(e => e.Concepto, "IX_AcCatalogoConceptosNomina")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Formula).HasMaxLength(20);
            });

            modelBuilder.Entity<AcNominaModelo>(entity =>
            {
                entity.HasKey(e => e.IdNominaModelo)
                    .HasName("PK_AcModelosNomina");

                entity.HasIndex(e => e.NominaModelo, "IX_AcModelosNomina")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AcNominaModelosCuenta>(entity =>
            {
                entity.HasKey(e => e.IdNominaModeloCuenta)
                    .HasName("PK_AcModelosNominaAbonos");

                entity.HasIndex(e => new { e.IdNominaModelo, e.IdCuenta, e.IdNominaConcepto }, "IX_AcModelosNominaAbonos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuenta, "IX_AcModelosNominaCuentas")
                    .HasFillFactor(90);

                entity.Property(e => e.IdCuenta).HasColumnName("idCuenta");

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithMany(p => p.AcNominaModelosCuenta)
                    .HasForeignKey(d => d.IdCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcModelosNominaAbonos_Cuentas");

                entity.HasOne(d => d.IdNominaConceptoNavigation)
                    .WithMany(p => p.AcNominaModelosCuenta)
                    .HasForeignKey(d => d.IdNominaConcepto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcModelosNominaAbonos_AcCatalogoConceptosNomina");

                entity.HasOne(d => d.IdNominaModeloNavigation)
                    .WithMany(p => p.AcNominaModelosCuenta)
                    .HasForeignKey(d => d.IdNominaModelo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcModelosNominaAbonos_AcModelosNomina");
            });

            modelBuilder.Entity<AcNominaModelosInsumo>(entity =>
            {
                entity.HasKey(e => e.IdNominaModeloInsumo)
                    .HasName("PK_AcModelosNominaCargos");

                entity.HasIndex(e => new { e.IdNominaModelo, e.IdNominaConcepto, e.IdTipoCuadrillaNomina }, "IX_AcModelosNominaCargos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasOne(d => d.IdInsumoNavigation)
                    .WithMany(p => p.AcNominaModelosInsumos)
                    .HasForeignKey(d => d.IdInsumo)
                    .HasConstraintName("FK_AcNominaModelosInsumos_AcCatInsumos");

                entity.HasOne(d => d.IdNominaConceptoNavigation)
                    .WithMany(p => p.AcNominaModelosInsumos)
                    .HasForeignKey(d => d.IdNominaConcepto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcModelosNominaCargos_AcCatalogoConceptosNomina");

                entity.HasOne(d => d.IdNominaModeloNavigation)
                    .WithMany(p => p.AcNominaModelosInsumos)
                    .HasForeignKey(d => d.IdNominaModelo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcModelosNominaCargos_AcModelosNomina");

                entity.HasOne(d => d.IdTipoCuadrillaNominaNavigation)
                    .WithMany(p => p.AcNominaModelosInsumos)
                    .HasForeignKey(d => d.IdTipoCuadrillaNomina)
                    .HasConstraintName("FK_AcModelosNominaCargos_AcTiposCategoriaNomina");
            });

            modelBuilder.Entity<AcNominaPoliza>(entity =>
            {
                entity.HasKey(e => e.IdNominaPoliza)
                    .HasName("PK_AcRequeridoNomina");

                entity.ToTable("AcNominaPoliza");

                entity.HasIndex(e => new { e.IdProyecto, e.Folio }, "IX_AcRequeridoNomina_1")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaCancelacion).HasColumnType("datetime");

                entity.HasOne(d => d.IdNominaModeloNavigation)
                    .WithMany(p => p.AcNominaPolizas)
                    .HasForeignKey(d => d.IdNominaModelo)
                    .HasConstraintName("FK_AcRequeridoNomina_AcModelosNomina");

                entity.HasOne(d => d.IdNominaTipoNavigation)
                    .WithMany(p => p.AcNominaPolizas)
                    .HasForeignKey(d => d.IdNominaTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcRequeridoNomina_AcTipoNominas");

                entity.HasOne(d => d.IdPolizaNavigation)
                    .WithMany(p => p.AcNominaPolizaIdPolizaNavigations)
                    .HasForeignKey(d => d.IdPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcRequeridoNomina_CtbMtoPolizas");

                entity.HasOne(d => d.IdPolizaInversaNavigation)
                    .WithMany(p => p.AcNominaPolizaIdPolizaInversaNavigations)
                    .HasForeignKey(d => d.IdPolizaInversa)
                    .HasConstraintName("FK_AcRequeridoNomina_CtbMtoPolizas1");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AcNominaPolizas)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcRequeridoNomina_Proyectos");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AcNominaPolizas)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcRequeridoNomina_SegUsuarios");
            });

            modelBuilder.Entity<AcNominaPolizaCuenta>(entity =>
            {
                entity.HasKey(e => e.IdNominaPolizaCuenta)
                    .HasName("PK_AcRequeridoNominaCuentas");

                entity.HasIndex(e => new { e.IdNominaPoliza, e.IdCuenta }, "IX_AcRequeridoNominaCuentas")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuenta, "IX_AcRequeridoNominaCuentas_1")
                    .HasFillFactor(90);

                entity.Property(e => e.Cantidad).HasColumnType("money");

                entity.Property(e => e.IdCuenta).HasColumnName("idCuenta");

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithMany(p => p.AcNominaPolizaCuenta)
                    .HasForeignKey(d => d.IdCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcRequeridoNominaCuentas_CtbCuentas");

                entity.HasOne(d => d.IdNominaPolizaNavigation)
                    .WithMany(p => p.AcNominaPolizaCuenta)
                    .HasForeignKey(d => d.IdNominaPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcRequeridoNominaCuentas_AcRequeridoNomina");
            });

            modelBuilder.Entity<AcNominaPolizaInsumo>(entity =>
            {
                entity.HasKey(e => e.IdNominaPolizaInsumo)
                    .HasName("PK_AcRequeridoNominaDet");

                entity.HasIndex(e => new { e.IdNominaPoliza, e.IdExplosionInsumos }, "IX_AcRequeridoNominaInsumos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Cantidad).HasColumnType("money");

                entity.Property(e => e.Costo).HasColumnType("money");

                entity.HasOne(d => d.IdExplosionInsumosNavigation)
                    .WithMany(p => p.AcNominaPolizaInsumos)
                    .HasForeignKey(d => d.IdExplosionInsumos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcRequeridoNominaDet_ExplosionInsumos");

                entity.HasOne(d => d.IdNominaPolizaNavigation)
                    .WithMany(p => p.AcNominaPolizaInsumos)
                    .HasForeignKey(d => d.IdNominaPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcRequeridoNominaDet_AcRequeridoNomina");
            });

            modelBuilder.Entity<AcNominaTipo>(entity =>
            {
                entity.HasKey(e => e.IdNominaTipo)
                    .HasName("PK_AcTipoNominas");

                entity.HasIndex(e => e.NominaTipo, "IX_AcTipoNominas")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AcOrdenProduccion>(entity =>
            {
                entity.HasKey(e => e.IdOrdenProduccion);

                entity.ToTable("AcOrdenProduccion");

                entity.HasIndex(e => new { e.IdProyecto, e.FolioOrdenProduccion }, "IX_AcOrdenProduccion")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdRequisicion, "IX_AcOrdenProduccion_1")
                    .HasFillFactor(90);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaCancelacion).HasColumnType("datetime");

                entity.Property(e => e.IdProyectoDestino).HasColumnName("idProyectoDestino");

                entity.Property(e => e.IdRequisicion).HasColumnName("idRequisicion");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AcOrdenProduccionIdProyectoNavigations)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcOrdenProduccion_Proyectos");

                entity.HasOne(d => d.IdProyectoDestinoNavigation)
                    .WithMany(p => p.AcOrdenProduccionIdProyectoDestinoNavigations)
                    .HasForeignKey(d => d.IdProyectoDestino)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcOrdenProduccion_Proyectos1");

                entity.HasOne(d => d.IdRequisicionNavigation)
                    .WithMany(p => p.AcOrdenProduccions)
                    .HasForeignKey(d => d.IdRequisicion)
                    .HasConstraintName("FK_AcOrdenProduccion_AcRequisiciones");

                entity.HasOne(d => d.IdResponsableNavigation)
                    .WithMany(p => p.AcOrdenProduccions)
                    .HasForeignKey(d => d.IdResponsable)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcOrdenProduccion_ACResponsables");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AcOrdenProduccionIdUsuarioNavigations)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcOrdenProduccion_SegUsuarios");

                entity.HasOne(d => d.IdUsuarioCancelacionNavigation)
                    .WithMany(p => p.AcOrdenProduccionIdUsuarioCancelacionNavigations)
                    .HasForeignKey(d => d.IdUsuarioCancelacion)
                    .HasConstraintName("FK_AcOrdenProduccion_SegUsuarios1");
            });

            modelBuilder.Entity<AcOrdenProduccionDet>(entity =>
            {
                entity.HasKey(e => e.IdOrdenProduccionDet);

                entity.ToTable("AcOrdenProduccionDet");

                entity.HasIndex(e => new { e.IdOrdenProduccion, e.IdExplosionInsumos }, "IX_AcOrdenProduccionDet")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Cantidad).HasColumnType("money");

                entity.Property(e => e.CantidadRequerida).HasColumnType("money");

                entity.Property(e => e.IdExplosionInsumos).HasColumnName("idExplosionInsumos");

                entity.HasOne(d => d.IdExplosionInsumosNavigation)
                    .WithMany(p => p.AcOrdenProduccionDets)
                    .HasForeignKey(d => d.IdExplosionInsumos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcOrdenProduccionDet_AcExplosionInsumos");

                entity.HasOne(d => d.IdOrdenProduccionNavigation)
                    .WithMany(p => p.AcOrdenProduccionDets)
                    .HasForeignKey(d => d.IdOrdenProduccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcOrdenProduccionDet_AcOrdenProduccion");
            });

            modelBuilder.Entity<AcPedido>(entity =>
            {
                entity.HasKey(e => e.IdPedido)
                    .HasName("aaaaaMtoPedido_PK")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.IdProyecto, e.Pedido }, "IX_AcPedidos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdPedido).HasColumnName("idPedido");

                entity.Property(e => e.CapturarPorcentajeAnticipo)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ComentarioAjuste)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CondicionesPagoTexto)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EmbarquesePor)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EsComisionCv).HasColumnName("EsComisionCV");

                entity.Property(e => e.EsInventariable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaAjuste).HasColumnType("datetime");

                entity.Property(e => e.FechaAutorizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaCancelacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEntrega).HasColumnType("datetime");

                entity.Property(e => e.FechaPedido).HasColumnType("datetime");

                entity.Property(e => e.FechaUltimaModificacion).HasColumnType("datetime");

                entity.Property(e => e.IdProyecto).HasColumnName("idProyecto");

                entity.Property(e => e.IdRequisicion).HasColumnName("idRequisicion");

                entity.Property(e => e.Lab)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAB");

                entity.Property(e => e.LugarEntregaMateriales)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MontoAjuste).HasColumnType("money");

                entity.Property(e => e.MontoAnticipo).HasColumnType("money");

                entity.Property(e => e.MontoCargos).HasColumnType("money");

                entity.Property(e => e.MontoDescuentos).HasColumnType("money");

                entity.Property(e => e.MontoIva)
                    .HasColumnType("money")
                    .HasColumnName("MontoIVA");

                entity.Property(e => e.MontoOtrosImpuestos).HasColumnType("money");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ObservacionesAlmacen)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PorcentajeAnticipo).HasColumnType("smallmoney");

                entity.Property(e => e.PorcentajeIva)
                    .HasColumnType("smallmoney")
                    .HasColumnName("PorcentajeIVA");

                entity.Property(e => e.SubTotalDescuentosCargos).HasColumnType("money");

                entity.Property(e => e.SubTotalDescuentosCargosCig)
                    .HasColumnType("money")
                    .HasColumnName("SubTotalDescuentosCargosCIG");

                entity.Property(e => e.SumaEntradas).HasColumnType("money");

                entity.Property(e => e.SumaInsumos).HasColumnType("money");

                entity.Property(e => e.SumaInsumosCig)
                    .HasColumnType("money")
                    .HasColumnName("SumaInsumosCIG");

                entity.Property(e => e.TextoFechaEntrega)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.TotalCig)
                    .HasColumnType("money")
                    .HasColumnName("TotalCIG");

                entity.HasOne(d => d.IdAutorizoNavigation)
                    .WithMany(p => p.AcPedidoIdAutorizoNavigations)
                    .HasForeignKey(d => d.IdAutorizo)
                    .HasConstraintName("FK_AcPedidos_ACResponsables3");

                entity.HasOne(d => d.IdCompradorNavigation)
                    .WithMany(p => p.AcPedidoIdCompradorNavigations)
                    .HasForeignKey(d => d.IdComprador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcPedidos_ACResponsables");

                entity.HasOne(d => d.IdContabilidadNavigation)
                    .WithMany(p => p.AcPedidoIdContabilidadNavigations)
                    .HasForeignKey(d => d.IdContabilidad)
                    .HasConstraintName("FK_AcPedidos_ACResponsables4");

                entity.HasOne(d => d.IdElaboroNavigation)
                    .WithMany(p => p.AcPedidoIdElaboroNavigations)
                    .HasForeignKey(d => d.IdElaboro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcPedidos_ACResponsables1");

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.AcPedidos)
                    .HasForeignKey(d => d.IdProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcPedidos_AcProveedores");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AcPedidos)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcPedidos_Proyectos");

                entity.HasOne(d => d.IdRequisicionNavigation)
                    .WithMany(p => p.AcPedidos)
                    .HasForeignKey(d => d.IdRequisicion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcPedidos_AcRequisiciones");

                entity.HasOne(d => d.IdRevisoNavigation)
                    .WithMany(p => p.AcPedidoIdRevisoNavigations)
                    .HasForeignKey(d => d.IdReviso)
                    .HasConstraintName("FK_AcPedidos_ACResponsables2");

                entity.HasOne(d => d.IdTipoFiscalNavigation)
                    .WithMany(p => p.AcPedidos)
                    .HasForeignKey(d => d.IdTipoFiscal)
                    .HasConstraintName("FK_AcPedidos_AcTipoFiscal");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AcPedidoIdUsuarioNavigations)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcPedidos_SegUsuarios");

                entity.HasOne(d => d.IdUsuarioAutorizacionNavigation)
                    .WithMany(p => p.AcPedidoIdUsuarioAutorizacionNavigations)
                    .HasForeignKey(d => d.IdUsuarioAutorizacion)
                    .HasConstraintName("FK_AcPedidos_SegUsuarios2");

                entity.HasOne(d => d.IdUsuarioCancelacionNavigation)
                    .WithMany(p => p.AcPedidoIdUsuarioCancelacionNavigations)
                    .HasForeignKey(d => d.IdUsuarioCancelacion)
                    .HasConstraintName("FK_AcPedidos_SegUsuarios1");
            });

            modelBuilder.Entity<AcPedidosBitacora>(entity =>
            {
                entity.HasKey(e => e.IdPedidoBitacora)
                    .HasName("PK_IdPedidobitacora");

                entity.ToTable("AcPedidosBitacora");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.ImporteAnterior).HasColumnType("money");

                entity.Property(e => e.ImporteFinal).HasColumnType("money");

                entity.Property(e => e.MotivoModificacion).IsUnicode(false);

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.AcPedidosBitacoras)
                    .HasForeignKey(d => d.IdPedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IdPedido");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AcPedidosBitacoras)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IdProyecto");

                entity.HasOne(d => d.IdUsuarioModificoNavigation)
                    .WithMany(p => p.AcPedidosBitacoras)
                    .HasForeignKey(d => d.IdUsuarioModifico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IdUsuarioModifico");
            });

            modelBuilder.Entity<AcPedidosDescuento>(entity =>
            {
                entity.HasKey(e => e.IdPedidoDescuento);

                entity.HasIndex(e => new { e.IdPedido, e.Tipo, e.Renglon }, "IX_AcPedidosDescuentos")
                    .HasFillFactor(90);

                entity.Property(e => e.IdPedidoDescuento).HasColumnName("idPedidoDescuento");

                entity.Property(e => e.CapturarPorcentaje)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.IdPedido).HasColumnName("idPedido");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.MontoCig)
                    .HasColumnType("money")
                    .HasColumnName("MontoCIG");

                entity.Property(e => e.Porcentaje).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.Renglon).HasDefaultValueSql("((10))");

                entity.Property(e => e.Tipo).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.AcPedidosDescuentos)
                    .HasForeignKey(d => d.IdPedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcPedidosDescuentos_AcPedidos");
            });

            modelBuilder.Entity<AcPedidosDet>(entity =>
            {
                entity.HasKey(e => e.IdPedidoDet)
                    .HasName("PK_DetPedido");

                entity.ToTable("AcPedidosDet");

                entity.HasIndex(e => new { e.IdPedido, e.IdRequisicionDet }, "IX_AcPedidosDet")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdPedidoDet).HasColumnName("idPedidoDet");

                entity.Property(e => e.Cantidad).HasColumnType("money");

                entity.Property(e => e.Costo).HasColumnType("money");

                entity.Property(e => e.CostoNeto).HasColumnType("money");

                entity.Property(e => e.DescripcionLarga)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.FechaProbableDeEntrega).HasColumnType("smalldatetime");

                entity.Property(e => e.IdPedido).HasColumnName("idPedido");

                entity.Property(e => e.IdRequisicionDet).HasColumnName("idRequisicionDet");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ObservacionesAlmacen)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PorcentajeDescuento).HasColumnType("money");

                entity.Property(e => e.PrecioCigneto)
                    .HasColumnType("money")
                    .HasColumnName("PrecioCIGNeto");

                entity.Property(e => e.PrecioConIvaGuatemala).HasColumnType("money");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.AcPedidosDets)
                    .HasForeignKey(d => d.IdPedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DetPedido_FK01");

                entity.HasOne(d => d.IdRequisicionDetNavigation)
                    .WithMany(p => p.AcPedidosDets)
                    .HasForeignKey(d => d.IdRequisicionDet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcPedidosDet_AcRequisicionDet");
            });

            modelBuilder.Entity<AcProrrateoCosto>(entity =>
            {
                entity.HasKey(e => e.IdProrrateoCostos);

                entity.Property(e => e.Concepto)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionCancelacion)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaCancelacion).HasColumnType("datetime");

                entity.HasOne(d => d.IdPolizaNavigation)
                    .WithMany(p => p.AcProrrateoCostoIdPolizaNavigations)
                    .HasForeignKey(d => d.IdPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcProrrateoCostos_CtbPolizas");

                entity.HasOne(d => d.IdPolizaInversaNavigation)
                    .WithMany(p => p.AcProrrateoCostoIdPolizaInversaNavigations)
                    .HasForeignKey(d => d.IdPolizaInversa)
                    .HasConstraintName("FK_AcProrrateoCostos_CtbPolizas1");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AcProrrateoCostos)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcProrrateoCostos_Proyectos");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AcProrrateoCostoIdUsuarioNavigations)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcProrrateoCostos_SegUsuarios");

                entity.HasOne(d => d.IdUsuarioCancelacionNavigation)
                    .WithMany(p => p.AcProrrateoCostoIdUsuarioCancelacionNavigations)
                    .HasForeignKey(d => d.IdUsuarioCancelacion)
                    .HasConstraintName("FK_AcProrrateoCostos_SegUsuarios1");
            });

            modelBuilder.Entity<AcProrrateoCostosDet>(entity =>
            {
                entity.HasKey(e => e.IdProrrateoCostosDet);

                entity.ToTable("AcProrrateoCostosDet");

                entity.Property(e => e.Cantidad).HasColumnType("money");

                entity.Property(e => e.Costo).HasColumnType("money");

                entity.Property(e => e.Periodo).HasDefaultValueSql("((3))");

                entity.HasOne(d => d.IdInsumoProrrateoNavigation)
                    .WithMany(p => p.AcProrrateoCostosDets)
                    .HasForeignKey(d => d.IdInsumoProrrateo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcProrrateoCostosDet_AcCatInsumosProrrateo");

                entity.HasOne(d => d.IdProrrateoCostosNavigation)
                    .WithMany(p => p.AcProrrateoCostosDets)
                    .HasForeignKey(d => d.IdProrrateoCostos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcProrrateoCostosDet_AcProrrateoCostos");
            });

            modelBuilder.Entity<AcProveedore>(entity =>
            {
                entity.HasKey(e => e.IdProveedor)
                    .HasName("aaaaaProveedores_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.IdCuentaProveedor, "IX_AcProveedores")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuentaProveedor, "IX_AcProveedores_1")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuentaAnticipo, "IX_AcProveedores_2")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuentaFonGar, "IX_AcProveedores_3")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuentaDeudor, "IX_AcProveedores_4")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Codigo, "prov2")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdProveedor).HasColumnName("idProveedor");

                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ApellidoPaterno)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Banco)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BancoSat)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BancoSAT");

                entity.Property(e => e.Celular)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Clabe)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("CLABE");

                entity.Property(e => e.ClaveCliente)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodPost)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoSap)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CodigoSAP");

                entity.Property(e => e.Colonia)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ConceptoCiecash)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ConceptoCIECASH");

                entity.Property(e => e.CondicionesPago)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Contacto)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ConvenioCiecash)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("ConvenioCIECASH");

                entity.Property(e => e.CuentaBancaria)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Curp)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("CURP");

                entity.Property(e => e.Delegacion)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.IdBancoSat).HasColumnName("IdBancoSAT");

                entity.Property(e => e.IdCiudad).HasColumnName("idCiudad");

                entity.Property(e => e.IdGiro).HasColumnName("idGiro");

                entity.Property(e => e.IdTipoMoneda).HasColumnName("idTipoMoneda");

                entity.Property(e => e.IdTipoOperacion).HasDefaultValueSql("((1))");

                entity.Property(e => e.IdTipoProveedor).HasColumnName("idTipoProveedor");

                entity.Property(e => e.IdTipoTerceros).HasDefaultValueSql("((1))");

                entity.Property(e => e.Infonavit)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.LimiteCredito).HasColumnType("money");

                entity.Property(e => e.Mail)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.MonedaSatdefault)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MonedaSATDefault");

                entity.Property(e => e.Nacionalidad)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NombreJefe)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NumRegIdFiscal)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones).IsUnicode(false);

                entity.Property(e => e.PaginaWeb)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PermitirExentoIva).HasColumnName("PermitirExentoIVA");

                entity.Property(e => e.PersonaMoral)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PersonasAtiendenPedidos)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PlazaBanxico)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PuestoJefe)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenciaCiecash)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ReferenciaCIECASH");

                entity.Property(e => e.RegistroCamara)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.RegistroPatronal)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Rfc)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Sucursal)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDeCuentaCash)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TipoDeCuentaCASH");

                entity.Property(e => e.TipoFiscal)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAgaCatAcreedorNavigation)
                    .WithMany(p => p.AcProveedores)
                    .HasForeignKey(d => d.IdAgaCatAcreedor)
                    .HasConstraintName("FK_AcProveedores_AgaCatAcreedores");

                entity.HasOne(d => d.IdCiudadNavigation)
                    .WithMany(p => p.AcProveedores)
                    .HasForeignKey(d => d.IdCiudad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcProveedores_AcCatCiudades");

                entity.HasOne(d => d.IdClaveTransferenciaNavigation)
                    .WithMany(p => p.AcProveedores)
                    .HasForeignKey(d => d.IdClaveTransferencia)
                    .HasConstraintName("FK_AcProveedores_AcCatClavesTransferencias");

                entity.HasOne(d => d.IdCuentaAnticipoNavigation)
                    .WithMany(p => p.AcProveedoreIdCuentaAnticipoNavigations)
                    .HasForeignKey(d => d.IdCuentaAnticipo)
                    .HasConstraintName("FK_AcProveedores_CtbCuentas1");

                entity.HasOne(d => d.IdCuentaDeudorNavigation)
                    .WithMany(p => p.AcProveedoreIdCuentaDeudorNavigations)
                    .HasForeignKey(d => d.IdCuentaDeudor)
                    .HasConstraintName("FK_AcProveedores_CtbCuentas3");

                entity.HasOne(d => d.IdCuentaFonGarNavigation)
                    .WithMany(p => p.AcProveedoreIdCuentaFonGarNavigations)
                    .HasForeignKey(d => d.IdCuentaFonGar)
                    .HasConstraintName("FK_AcProveedores_CtbCuentas2");

                entity.HasOne(d => d.IdCuentaOtrasRetencionesNavigation)
                    .WithMany(p => p.AcProveedoreIdCuentaOtrasRetencionesNavigations)
                    .HasForeignKey(d => d.IdCuentaOtrasRetenciones)
                    .HasConstraintName("FK_AcProveedores_CtbCuentas5");

                entity.HasOne(d => d.IdCuentaPagoEnEspecieNavigation)
                    .WithMany(p => p.AcProveedoreIdCuentaPagoEnEspecieNavigations)
                    .HasForeignKey(d => d.IdCuentaPagoEnEspecie)
                    .HasConstraintName("FK_AcProveedores_CtbCuentas4");

                entity.HasOne(d => d.IdCuentaProveedorNavigation)
                    .WithOne(p => p.AcProveedoreIdCuentaProveedorNavigation)
                    .HasForeignKey<AcProveedore>(d => d.IdCuentaProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcProveedores_CtbCuentas");

                entity.HasOne(d => d.IdGiroNavigation)
                    .WithMany(p => p.AcProveedores)
                    .HasForeignKey(d => d.IdGiro)
                    .HasConstraintName("FK_AcProveedores_AcCatGiros");

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.AcProveedores)
                    .HasForeignKey(d => d.IdPais)
                    .HasConstraintName("FK_AcProveedores_AcCatPaises");

                entity.HasOne(d => d.IdTipoMonedaNavigation)
                    .WithMany(p => p.AcProveedores)
                    .HasForeignKey(d => d.IdTipoMoneda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcProveedores_AcCatMonedas");

                entity.HasOne(d => d.IdTipoOperacionNavigation)
                    .WithMany(p => p.AcProveedores)
                    .HasForeignKey(d => d.IdTipoOperacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcProveedores_CtbDIOTTipoOperacion");

                entity.HasOne(d => d.IdTipoProveedorNavigation)
                    .WithMany(p => p.AcProveedores)
                    .HasForeignKey(d => d.IdTipoProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcProveedores_AcCatTipoProveedor");

                entity.HasOne(d => d.IdTipoTercerosNavigation)
                    .WithMany(p => p.AcProveedores)
                    .HasForeignKey(d => d.IdTipoTerceros)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcProveedores_CtbDIOTTipoTerceros");
            });

            modelBuilder.Entity<AcProveedoresCertificado>(entity =>
            {
                entity.HasKey(e => e.IdProveedorCertificado);

                entity.HasIndex(e => new { e.IdProveedor, e.NoCertificado }, "IX_AcProveedoresCertificados")
                    .IsUnique();

                entity.Property(e => e.IdProveedorCertificado).HasColumnName("idProveedorCertificado");

                entity.Property(e => e.Certificado).IsUnicode(false);

                entity.Property(e => e.IdProveedor).HasColumnName("idProveedor");

                entity.Property(e => e.NoCertificado)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VigenciaFinal).HasColumnType("datetime");

                entity.Property(e => e.VigenciaInicial).HasColumnType("datetime");

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.AcProveedoresCertificados)
                    .HasForeignKey(d => d.IdProveedor)
                    .HasConstraintName("FK_AcProveedoresCertificados_AcProveedores");
            });

            modelBuilder.Entity<AcProveedoresCfd>(entity =>
            {
                entity.HasKey(e => e.IdCfd);

                entity.ToTable("AcProveedoresCFDs");

                entity.Property(e => e.IdCfd).HasColumnName("idCFD");

                entity.Property(e => e.FechaEmision).HasColumnType("smalldatetime");

                entity.Property(e => e.IdPoliza).HasColumnName("idPoliza");

                entity.Property(e => e.IdProveedor).HasColumnName("idProveedor");

                entity.Property(e => e.Isrretenido)
                    .HasColumnType("money")
                    .HasColumnName("ISRRetenido");

                entity.Property(e => e.Ivaretenido)
                    .HasColumnType("money")
                    .HasColumnName("IVARetenido");

                entity.Property(e => e.Ivatrasladado)
                    .HasColumnType("money")
                    .HasColumnName("IVATrasladado");

                entity.Property(e => e.IvatrasladadoTxt)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("IVATrasladadoTxt");

                entity.Property(e => e.MetodoEncripcion)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoCertificado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomArchivoOriginal)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nomArchivoOriginal");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .IsRequired()
                    .HasMaxLength(122)
                    .IsUnicode(false);

                entity.Property(e => e.Rfcemisor)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("RFCEmisor");

                entity.Property(e => e.Rfcreceptor)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("RFCReceptor");

                entity.Property(e => e.Serie)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SinCertificado)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Subtotal).HasColumnType("money");

                entity.Property(e => e.TipoDeComprobante)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.Xmlcfd)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("XMLCFD");

                entity.HasOne(d => d.IdPolizaNavigation)
                    .WithMany(p => p.AcProveedoresCfds)
                    .HasForeignKey(d => d.IdPoliza)
                    .HasConstraintName("FK_AcProveedoresCFDs_CtbPolizas");

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.AcProveedoresCfds)
                    .HasForeignKey(d => d.IdProveedor)
                    .HasConstraintName("FK_AcProveedoresCFDs_AcProveedores");
            });

            modelBuilder.Entity<AcProveedoresXml>(entity =>
            {
                entity.HasKey(e => e.IdXmlproveedor)
                    .HasName("PK_Unica");

                entity.ToTable("AcProveedoresXML");

                entity.HasIndex(e => e.FechaComprobante, "IX_FechaComprobante");

                entity.HasIndex(e => e.Rfcemisor, "IX_RFCemisor");

                entity.HasIndex(e => e.Rfcreceptor, "IX_RFCreceptor");

                entity.HasIndex(e => new { e.Serie, e.Folio }, "IX_SerieFolio");

                entity.HasIndex(e => e.Uuid, "IX_UUID")
                    .IsUnique();

                entity.Property(e => e.IdXmlproveedor).HasColumnName("IdXMLProveedor");

                entity.Property(e => e.Descuento).HasColumnType("money");

                entity.Property(e => e.DocumentosRelacionados)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.EsProveedor)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EstatusSat).HasColumnName("EstatusSAT");

                entity.Property(e => e.FechaComprobante).HasColumnType("datetime");

                entity.Property(e => e.FechaTimbrado).HasColumnType("datetime");

                entity.Property(e => e.FechaUltimaActualizacion).HasColumnType("datetime");

                entity.Property(e => e.Folio)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Isrretenido)
                    .HasColumnType("money")
                    .HasColumnName("ISRRetenido");

                entity.Property(e => e.Iva)
                    .HasColumnType("money")
                    .HasColumnName("IVA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ivaretenido)
                    .HasColumnType("money")
                    .HasColumnName("IVARetenido");

                entity.Property(e => e.MensajeValidacion)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Moneda)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocialEmisor)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Rfcemisor)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("RFCemisor");

                entity.Property(e => e.Rfcreceptor)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("RFCreceptor");

                entity.Property(e => e.Serie)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StrMetodosPago)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubTotal).HasColumnType("money");

                entity.Property(e => e.TipoCambio)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TipoComprobante)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.Uuid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UUID");

                entity.Property(e => e.Xmlproveedor)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("XMLProveedor");
            });

            modelBuilder.Entity<AcProveedoresXmldocRel>(entity =>
            {
                entity.HasKey(e => e.IdDoctoRelacionado);

                entity.ToTable("AcProveedoresXMLDocRel");

                entity.Property(e => e.Folio)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.IdDocumento)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.IdXmlproveedor).HasColumnName("IdXMLProveedor");

                entity.Property(e => e.ImportePagado).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ImporteSaldoAnterior).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ImporteSaldoInsoluto).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MetodoDePagoDr)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MetodoDePagoDR");

                entity.Property(e => e.MonedaDr)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MonedaDR");

                entity.Property(e => e.Serie)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCambioDr)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("TipoCambioDR");

                entity.HasOne(d => d.IdXmlproveedorNavigation)
                    .WithMany(p => p.AcProveedoresXmldocRels)
                    .HasForeignKey(d => d.IdXmlproveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcProveedoresXMLDocRel_AcProveedoresXML");
            });

            modelBuilder.Entity<AcProyectoConcepto>(entity =>
            {
                entity.HasKey(e => e.IdProyectoConcepto)
                    .HasName("PK_AcContratosConceptos");

                entity.HasIndex(e => new { e.IdProyecto, e.Concepto }, "IX_AcPresupuestosConceptos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Concepto)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionLarga)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.IdProductoServicioSat).HasColumnName("IdProductoServicioSAT");

                entity.Property(e => e.IdUnidadSat).HasColumnName("IdUnidadSAT");

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.Unidad)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('UNIDAD')");

                entity.HasOne(d => d.IdProductoServicioSatNavigation)
                    .WithMany(p => p.AcProyectoConceptos)
                    .HasForeignKey(d => d.IdProductoServicioSat)
                    .HasConstraintName("FK_AcProyectoConceptos_AcCatProductosServicioSAT");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AcProyectoConceptos)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcPresupuestosConceptos_Proyectos");

                entity.HasOne(d => d.IdTipoConceptoClienteNavigation)
                    .WithMany(p => p.AcProyectoConceptos)
                    .HasForeignKey(d => d.IdTipoConceptoCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcProyectoConceptos_AcCatTipoConceptosCliente");

                entity.HasOne(d => d.IdTipoMonedaNavigation)
                    .WithMany(p => p.AcProyectoConceptos)
                    .HasForeignKey(d => d.IdTipoMoneda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcProyectoConceptos_AcCatMonedas");

                entity.HasOne(d => d.IdUnidadSatNavigation)
                    .WithMany(p => p.AcProyectoConceptos)
                    .HasForeignKey(d => d.IdUnidadSat)
                    .HasConstraintName("FK_AcProyectoConceptos_AcCatUnidadesSAT");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AcProyectoConceptos)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcContratosConceptos_SegUsuarios");
            });

            modelBuilder.Entity<AcProyectoPartida>(entity =>
            {
                entity.HasKey(e => e.IdProyectoPartida)
                    .HasName("PK_AcPartidasContratos");

                entity.HasIndex(e => new { e.IdProyecto, e.Partida }, "IX_AcPresupuestosPartidas")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionLarga).IsUnicode(false);

                entity.Property(e => e.Partida)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AcProyectoPartida)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcPresupuestosPartidas_Proyectos");
            });

            modelBuilder.Entity<AcProyectosConsecutivo>(entity =>
            {
                entity.HasKey(e => e.IdProyectoConsecutivo)
                    .HasName("PK_ERPConsecutivosAlmacen");

                entity.HasIndex(e => e.IdProyecto, "IX_ERPConsecutivosAlmacen")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdProyectoConsecutivo).HasColumnName("idProyectoConsecutivo");

                entity.Property(e => e.GastosXcomprobar).HasColumnName("GastosXComprobar");

                entity.Property(e => e.IdProyecto).HasColumnName("idProyecto");

                entity.Property(e => e.OcpresupuestoCliente).HasColumnName("OCPresupuestoCliente");

                entity.Property(e => e.OcpresupuestoControl).HasColumnName("OCPresupuestoControl");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithOne(p => p.AcProyectosConsecutivo)
                    .HasForeignKey<AcProyectosConsecutivo>(d => d.IdProyecto)
                    .HasConstraintName("FK_AcProyectosConsecutivos_Proyectos");
            });

            modelBuilder.Entity<AcProyectosNominaModelo>(entity =>
            {
                entity.HasKey(e => e.IdProyectoNominaModelo);

                entity.HasIndex(e => new { e.IdProyecto, e.IdNominaTipo, e.IdNominaModelo }, "IX_AcProyectosNominaModelos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasOne(d => d.IdNominaModeloNavigation)
                    .WithMany(p => p.AcProyectosNominaModelos)
                    .HasForeignKey(d => d.IdNominaModelo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcProyectosNominaModelos_AcNominaModelos");

                entity.HasOne(d => d.IdNominaTipoNavigation)
                    .WithMany(p => p.AcProyectosNominaModelos)
                    .HasForeignKey(d => d.IdNominaTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcProyectosNominaModelos_AcNominaTipos");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AcProyectosNominaModelos)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcProyectosNominaModelos_Proyectos");
            });

            modelBuilder.Entity<AcRelAforoProyecto>(entity =>
            {
                entity.HasKey(e => e.IdRelAforoProyecto);

                entity.ToTable("AcRelAforoProyecto");

                entity.Property(e => e.Cant).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Desc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AcRelAforoProyectos)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcRelAforoProyectoIdProyecto");
            });

            modelBuilder.Entity<AcRelClienteCfdiEgreso>(entity =>
            {
                entity.HasKey(e => e.IdRelClienteCfdiEgreso);

                entity.ToTable("AcRelClienteCfdiEgreso");

                entity.Property(e => e.IdRelClienteCfdiEgreso).HasColumnName("idRelClienteCfdiEgreso");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("cantidad");

                entity.Property(e => e.Claveprodserv)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("claveprodserv");

                entity.Property(e => e.Claveunidad)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("claveunidad");

                entity.Property(e => e.Concepto)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("concepto");

                entity.Property(e => e.Cuentapredial)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("cuentapredial");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Descripcionauxiliar)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("descripcionauxiliar");

                entity.Property(e => e.Descripcionpartida)
                    .HasMaxLength(800)
                    .IsUnicode(false)
                    .HasColumnName("descripcionpartida");

                entity.Property(e => e.Descuento)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("descuento");

                entity.Property(e => e.IdProductoServicioSat)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("IdProductoServicioSAT");

                entity.Property(e => e.IdUnidadSat)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("IdUnidadSAT");

                entity.Property(e => e.Importe)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("importe");

                entity.Property(e => e.Impuestosretenidos)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("impuestosretenidos");

                entity.Property(e => e.Impuestostrasladados)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("impuestostrasladados");

                entity.Property(e => e.MontoPoliza).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Partida)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("partida");

                entity.Property(e => e.Precio)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("precio");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("total");

                entity.Property(e => e.Unidad)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("unidad");
            });

            modelBuilder.Entity<AcRelCuentaProyecto>(entity =>
            {
                entity.HasKey(e => e.IdRelCuentaProyecto);

                entity.ToTable("AcRelCuentaProyecto");

                entity.HasIndex(e => new { e.IdProyecto, e.IdCuenta }, "IX_AcRelCuentaProyecto")
                    .IsUnique();

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithMany(p => p.AcRelCuentaProyectos)
                    .HasForeignKey(d => d.IdCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcRelCuentaProyectoIdCuenta");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AcRelCuentaProyectos)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcRelCuentaProyectoIdProyecto");
            });

            modelBuilder.Entity<AcRelCuentaProyectoDet>(entity =>
            {
                entity.HasKey(e => e.IdRelCuentaProyectoDet);

                entity.ToTable("AcRelCuentaProyectoDet");

                entity.Property(e => e.Cant).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Desc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithMany(p => p.AcRelCuentaProyectoDets)
                    .HasForeignKey(d => d.IdCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcRelCuentaProyectoDetIdCuenta");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AcRelCuentaProyectoDets)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcRelCuentaProyectoDetIdProyecto");
            });

            modelBuilder.Entity<AcRelInterestaProyecto>(entity =>
            {
                entity.HasKey(e => e.IdRelInterestaProyecto);

                entity.ToTable("AcRelInterestaProyecto");

                entity.Property(e => e.Cant).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Desc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AcRelInterestaProyectos)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcRelInterestaProyectoIdProyecto");
            });

            modelBuilder.Entity<AcRelRemanentesProyecto>(entity =>
            {
                entity.HasKey(e => e.IdRelRemanenteProyecto);

                entity.ToTable("AcRelRemanentesProyecto");

                entity.Property(e => e.Cant).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Desc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AcRelRemanentesProyectos)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcRelRemanentesProyectoIdProyecto");
            });

            modelBuilder.Entity<AcRelSeleccionProyecto>(entity =>
            {
                entity.HasKey(e => e.IdRelSeleccionProyecto);

                entity.ToTable("AcRelSeleccionProyecto");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AcRelSeleccionProyectos)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcRelSeleccionProyectoIdProyecto");
            });

            modelBuilder.Entity<AcRelSeleccionProyectoAcum>(entity =>
            {
                entity.HasKey(e => e.IdRelSeleccionProyectoAcum);

                entity.ToTable("AcRelSeleccionProyectoAcum");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AcRelSeleccionProyectoAcums)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcRelSeleccionProyectoAcumIdProyecto");
            });

            modelBuilder.Entity<AcRequisicionBitacora>(entity =>
            {
                entity.HasKey(e => e.IdRequisicionBitacora)
                    .HasName("PK_IdRequisicionBitacora");

                entity.ToTable("AcRequisicionBitacora");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.ImporteAnterior).HasColumnType("money");

                entity.Property(e => e.ImporteFinal).HasColumnType("money");

                entity.Property(e => e.MotivoModificacion).IsUnicode(false);

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AcRequisicionBitacoras)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IdProyectoAcRequisicionBitacora");

                entity.HasOne(d => d.IdRequisicionNavigation)
                    .WithMany(p => p.AcRequisicionBitacoras)
                    .HasForeignKey(d => d.IdRequisicion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IdRequisicionAcRequisicionBitacora");

                entity.HasOne(d => d.IdUsuarioModificoNavigation)
                    .WithMany(p => p.AcRequisicionBitacoras)
                    .HasForeignKey(d => d.IdUsuarioModifico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IdUsuarioModificoAcRequisicionBitacora");
            });

            modelBuilder.Entity<AcRequisicionDet>(entity =>
            {
                entity.HasKey(e => e.IdRequisicionDet)
                    .HasName("PK_DetRequisicion");

                entity.ToTable("AcRequisicionDet");

                entity.HasIndex(e => new { e.IdRequisicion, e.IdExplosionInsumos }, "IX_AcRequisicionDet")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdRequisicionDet).HasColumnName("idRequisicionDet");

                entity.Property(e => e.Cantidad).HasColumnType("money");

                entity.Property(e => e.IdExplosionInsumos).HasColumnName("idExplosionInsumos");

                entity.Property(e => e.IdPartida).HasColumnName("idPartida");

                entity.Property(e => e.IdRequisicion).HasColumnName("idRequisicion");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdExplosionInsumosNavigation)
                    .WithMany(p => p.AcRequisicionDets)
                    .HasForeignKey(d => d.IdExplosionInsumos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcRequisicionDet_AcExplosionInsumos");

                entity.HasOne(d => d.IdPartidaNavigation)
                    .WithMany(p => p.AcRequisicionDets)
                    .HasForeignKey(d => d.IdPartida)
                    .HasConstraintName("FK_AcRequisicionDet_AoPartidas");

                entity.HasOne(d => d.IdRequisicionNavigation)
                    .WithMany(p => p.AcRequisicionDets)
                    .HasForeignKey(d => d.IdRequisicion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DetRequisicion_FK00");
            });

            modelBuilder.Entity<AcRequisicione>(entity =>
            {
                entity.HasKey(e => e.IdRequisicion)
                    .HasName("aaaaaMtoRequisicion_PK")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.IdProyecto, e.Requisicion }, "IX_AcRequisiciones")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdRequisicion).HasColumnName("idRequisicion");

                entity.Property(e => e.CodigoAuxiliar)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Contrato)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EsComisionCv).HasColumnName("EsComisionCV");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaAutorizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaCancelacion).HasColumnType("datetime");

                entity.Property(e => e.FechaPosibleEntrega).HasColumnType("datetime");

                entity.Property(e => e.GeneradaPorOp).HasColumnName("GeneradaPorOP");

                entity.Property(e => e.GeneradaPorPu).HasColumnName("GeneradaPorPU");

                entity.Property(e => e.GeneradaPorSm).HasColumnName("GeneradaPorSM");

                entity.Property(e => e.IdAutorizacionCompras).HasColumnName("idAutorizacionCompras");

                entity.Property(e => e.IdAutorizacionTecnica).HasColumnName("idAutorizacionTecnica");

                entity.Property(e => e.IdCentro).HasColumnName("idCentro");

                entity.Property(e => e.IdProyecto).HasColumnName("idProyecto");

                entity.Property(e => e.IdSolicitante).HasColumnName("idSolicitante");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.LugarEntregaMat)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAutorizacionComprasNavigation)
                    .WithMany(p => p.AcRequisicioneIdAutorizacionComprasNavigations)
                    .HasForeignKey(d => d.IdAutorizacionCompras)
                    .HasConstraintName("FK_AcRequisiciones_ACResponsables1");

                entity.HasOne(d => d.IdAutorizacionTecnicaNavigation)
                    .WithMany(p => p.AcRequisicioneIdAutorizacionTecnicaNavigations)
                    .HasForeignKey(d => d.IdAutorizacionTecnica)
                    .HasConstraintName("FK_AcRequisiciones_ACResponsables");

                entity.HasOne(d => d.IdCentroNavigation)
                    .WithMany(p => p.AcRequisiciones)
                    .HasForeignKey(d => d.IdCentro)
                    .HasConstraintName("FK_AcRequisiciones_Centros");

                entity.HasOne(d => d.IdPartidaNavigation)
                    .WithMany(p => p.AcRequisiciones)
                    .HasForeignKey(d => d.IdPartida)
                    .HasConstraintName("FK_AcRequisiciones_AoPartidas");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AcRequisicionesNavigation)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcRequisiciones_Proyectos");

                entity.HasOne(d => d.IdResponsableSeguimientoNavigation)
                    .WithMany(p => p.AcRequisicioneIdResponsableSeguimientoNavigations)
                    .HasForeignKey(d => d.IdResponsableSeguimiento)
                    .HasConstraintName("FK_AcRequisiciones_ACResponsables3");

                entity.HasOne(d => d.IdSolicitanteNavigation)
                    .WithMany(p => p.AcRequisicioneIdSolicitanteNavigations)
                    .HasForeignKey(d => d.IdSolicitante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcRequisiciones_ACResponsables2");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AcRequisicioneIdUsuarioNavigations)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcRequisiciones_SegUsuarios");

                entity.HasOne(d => d.IdUsuarioAutorizacionNavigation)
                    .WithMany(p => p.AcRequisicioneIdUsuarioAutorizacionNavigations)
                    .HasForeignKey(d => d.IdUsuarioAutorizacion)
                    .HasConstraintName("FK_AcRequisiciones_SegUsuarios1");

                entity.HasOne(d => d.IdUsuarioCancelacionNavigation)
                    .WithMany(p => p.AcRequisicioneIdUsuarioCancelacionNavigations)
                    .HasForeignKey(d => d.IdUsuarioCancelacion)
                    .HasConstraintName("FK_AcRequisiciones_SegUsuarios2");
            });

            modelBuilder.Entity<AcSolicitudMaterial>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudMaterial);

                entity.ToTable("AcSolicitudMaterial");

                entity.HasIndex(e => new { e.IdAlmacenObra, e.Folio }, "IX_AcSolicitudMaterial")
                    .IsUnique();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.HasOne(d => d.IdAlmacenGeneralNavigation)
                    .WithMany(p => p.AcSolicitudMaterialIdAlmacenGeneralNavigations)
                    .HasForeignKey(d => d.IdAlmacenGeneral)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcSolicitudMaterial_Proyectos1");

                entity.HasOne(d => d.IdAlmacenObraNavigation)
                    .WithMany(p => p.AcSolicitudMaterialIdAlmacenObraNavigations)
                    .HasForeignKey(d => d.IdAlmacenObra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcSolicitudMaterial_Proyectos");

                entity.HasOne(d => d.IdAlmacenTransitoNavigation)
                    .WithMany(p => p.AcSolicitudMaterialIdAlmacenTransitoNavigations)
                    .HasForeignKey(d => d.IdAlmacenTransito)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcSolicitudMaterial_Proyectos2");

                entity.HasOne(d => d.IdRequisicionNavigation)
                    .WithMany(p => p.AcSolicitudMaterials)
                    .HasForeignKey(d => d.IdRequisicion)
                    .HasConstraintName("FK_AcSolicitudMaterial_AcRequisiciones");

                entity.HasOne(d => d.IdResponsableNavigation)
                    .WithMany(p => p.AcSolicitudMaterials)
                    .HasForeignKey(d => d.IdResponsable)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcSolicitudMaterial_ACResponsables");

                entity.HasOne(d => d.IdTraspasoObraNavigation)
                    .WithMany(p => p.AcSolicitudMaterialIdTraspasoObraNavigations)
                    .HasForeignKey(d => d.IdTraspasoObra)
                    .HasConstraintName("FK_AcSolicitudMaterial_AcAlmacenTraspasos1");

                entity.HasOne(d => d.IdTraspasoTransitoNavigation)
                    .WithMany(p => p.AcSolicitudMaterialIdTraspasoTransitoNavigations)
                    .HasForeignKey(d => d.IdTraspasoTransito)
                    .HasConstraintName("FK_AcSolicitudMaterial_AcAlmacenTraspasos");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AcSolicitudMaterials)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcSolicitudMaterial_SegUsuarios");
            });

            modelBuilder.Entity<AcSolicitudMaterialDet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AcSolicitudMaterialDet");

                entity.Property(e => e.Cantidad).HasColumnType("money");

                entity.Property(e => e.CantidadRequerida).HasColumnType("money");

                entity.Property(e => e.CantidadTransito).HasColumnType("money");

                entity.Property(e => e.CantidadTraspazada).HasColumnType("money");

                entity.Property(e => e.IdExplosionInsumos).HasColumnName("idExplosionInsumos");

                entity.Property(e => e.IdSolicitudMaterialDet).ValueGeneratedOnAdd();

                entity.HasOne(d => d.IdExplosionInsumosNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdExplosionInsumos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcSolicitudMaterialDet_AcExplosionInsumos");

                entity.HasOne(d => d.IdSolicitudMaterialNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdSolicitudMaterial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcSolicitudMaterialDet_AcSolicitudMaterial");
            });

            modelBuilder.Entity<AcTipDocAlmacen>(entity =>
            {
                entity.HasKey(e => e.IdTipDocAlmacen)
                    .HasName("aaaaaTipDoc_PK")
                    .IsClustered(false);

                entity.ToTable("AcTipDocAlmacen");

                entity.HasIndex(e => e.TipDoc, "IX_TipDoc_Unico")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdTipDocAlmacen).HasColumnName("idTipDocAlmacen");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoPoliza).HasColumnName("idTipoPoliza");

                entity.Property(e => e.TipDoc)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoPolizaNavigation)
                    .WithMany(p => p.AcTipDocAlmacens)
                    .HasForeignKey(d => d.IdTipoPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcTipDocAlmacen_CtbTiposPoliza");
            });

            modelBuilder.Entity<AcTipoFiscal>(entity =>
            {
                entity.HasKey(e => e.IdTipoFiscal);

                entity.ToTable("AcTipoFiscal");

                entity.HasIndex(e => e.Codigo, "IX_AcTipoFiscal")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Descripcion).HasMaxLength(100);
            });

            modelBuilder.Entity<AcTipoMovBanco>(entity =>
            {
                entity.HasKey(e => e.IdTipoMovBanco)
                    .HasName("PK_TipoMovBancos");

                entity.HasIndex(e => e.TipoMovBanco, "IX_TipoMovBancos_Unico")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdTipoMovBanco).HasColumnName("idTipoMovBanco");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TipoMovBanco)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AcTiposCuadrillaNomina>(entity =>
            {
                entity.HasKey(e => e.IdTipoCuadrillaNomina)
                    .HasName("PK_AcTiposCategoriaNomina");

                entity.ToTable("AcTiposCuadrillaNomina");

                entity.Property(e => e.Descripcion).HasMaxLength(40);

                entity.Property(e => e.TipoCuadrillaNomina)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<AcTiposInsumo>(entity =>
            {
                entity.HasKey(e => e.IdTipoInsumo)
                    .HasName("aaaaaTipoInsumos_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.Tipo, "IX_AcTiposInsumos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdTipoInsumo).HasColumnName("idTipoInsumo");

                entity.Property(e => e.ConsiderarEnIvadeSubcon).HasColumnName("ConsiderarEnIVAdeSubcon");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.EsInventariable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PorcentajeIndirecto).HasColumnType("money");

                entity.Property(e => e.PorcentajeIva)
                    .HasColumnType("money")
                    .HasColumnName("PorcentajeIVA");

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<AcUnidadesNegocio>(entity =>
            {
                entity.HasKey(e => e.IdUnidadNegocio);

                entity.ToTable("AcUnidadesNegocio");

                entity.HasIndex(e => e.UnidadNegocio, "IX_AcUnidadesNegocio")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.AceptaMov).HasColumnName("Acepta_Mov");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoUnidadNegocio).HasColumnName("idTipoUnidadNegocio");

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Rfc)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("RFC");

                entity.Property(e => e.UnidadNegocio)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoUnidadNegocioNavigation)
                    .WithMany(p => p.AcUnidadesNegocios)
                    .HasForeignKey(d => d.IdTipoUnidadNegocio)
                    .HasConstraintName("FK_AcUnidadesNegocio_AcCatTipoUnidadesNegocio");
            });

            modelBuilder.Entity<AcactivoFijo>(entity =>
            {
                entity.HasKey(e => e.IdActivo)
                    .HasName("PK_AOActivos");

                entity.ToTable("ACActivoFijo");

                entity.HasIndex(e => e.Codigo, "IX_AOActivos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCompra).HasColumnType("datetime");

                entity.Property(e => e.IdProveedor).HasColumnName("idProveedor");

                entity.Property(e => e.ImporteCompra).HasColumnType("money");

                entity.Property(e => e.LugarDeCompra)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Marca)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Modelo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones).IsUnicode(false);

                entity.Property(e => e.Serie)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCategoriaActivoNavigation)
                    .WithMany(p => p.AcactivoFijos)
                    .HasForeignKey(d => d.IdCategoriaActivo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AOActivos_AOCategoriaActivos1");

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.AcactivoFijos)
                    .HasForeignKey(d => d.IdProveedor)
                    .HasConstraintName("FK_AOActivoFijo_Proveedores");
            });

            modelBuilder.Entity<AcactivoFijoDet>(entity =>
            {
                entity.HasKey(e => e.IdActivoDet)
                    .HasName("PK_AOActivoDet");

                entity.ToTable("ACActivoFijoDet");

                entity.Property(e => e.IdActivoDet).HasColumnName("idActivoDet");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaEntregado).HasColumnType("datetime");

                entity.Property(e => e.IdActivo).HasColumnName("idActivo");

                entity.Property(e => e.IdResponsable).HasColumnName("idResponsable");

                entity.Property(e => e.Observaciones).IsUnicode(false);

                entity.HasOne(d => d.IdActivoNavigation)
                    .WithMany(p => p.AcactivoFijoDets)
                    .HasForeignKey(d => d.IdActivo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AOActivoDet_AOActivo");

                entity.HasOne(d => d.IdResponsableNavigation)
                    .WithMany(p => p.AcactivoFijoDets)
                    .HasForeignKey(d => d.IdResponsable)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AOActivoFijoDet_ACResponsables");
            });

            modelBuilder.Entity<AcactivoFijoFoto>(entity =>
            {
                entity.HasKey(e => e.IdActivoFoto)
                    .HasName("PK_AOActivoFijoFoto");

                entity.ToTable("ACActivoFijoFoto");

                entity.HasIndex(e => e.Ruta, "IX_AOActivoFijoFoto")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Ruta)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdActivoDetNavigation)
                    .WithMany(p => p.AcactivoFijoFotos)
                    .HasForeignKey(d => d.IdActivoDet)
                    .HasConstraintName("FK_AOActivoFijoFoto_AOActivoFijoDet");
            });

            modelBuilder.Entity<AcalmacenSaldosMensuale>(entity =>
            {
                entity.HasKey(e => e.IdAlmacenSaldoMensual)
                    .HasName("PK_AOSaldosAlmacen");

                entity.ToTable("ACAlmacenSaldosMensuales");

                entity.HasIndex(e => new { e.IdExplosionInsumos, e.Mes }, "IX_AOSaldosAlmacen")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.ExistenciaInicial).HasColumnType("money");

                entity.Property(e => e.IdExplosionInsumos).HasColumnName("idExplosionInsumos");

                entity.Property(e => e.ImporteInicial).HasColumnType("money");

                entity.HasOne(d => d.IdExplosionInsumosNavigation)
                    .WithMany(p => p.AcalmacenSaldosMensuales)
                    .HasForeignKey(d => d.IdExplosionInsumos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AOSaldosAlmacen_AcExplosionInsumos");
            });

            modelBuilder.Entity<AccategoriaActivoFijo>(entity =>
            {
                entity.HasKey(e => e.IdCategoriaActivo)
                    .HasName("PK_AOCATEGORIAACTIVOS");

                entity.ToTable("ACCategoriaActivoFijo");

                entity.HasIndex(e => e.Codigo, "IX_AOCATEGORIAACTIVOS")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Porcentaje).HasColumnType("money");
            });

            modelBuilder.Entity<AcproveedoresInsumo>(entity =>
            {
                entity.HasKey(e => e.IdProveedorInsumo);

                entity.ToTable("ACProveedoresInsumos");

                entity.HasIndex(e => new { e.IdProveedor, e.IdInsumo }, "IX_ACProveedoresInsumos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdInsumo).HasColumnName("idInsumo");

                entity.Property(e => e.IdProveedor).HasColumnName("idProveedor");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.HasOne(d => d.IdInsumoNavigation)
                    .WithMany(p => p.AcproveedoresInsumos)
                    .HasForeignKey(d => d.IdInsumo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACProveedoresInsumos_AcCatInsumos");

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.AcproveedoresInsumos)
                    .HasForeignKey(d => d.IdProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACProveedoresInsumos_AcProveedores");
            });

            modelBuilder.Entity<Acresponsable>(entity =>
            {
                entity.HasKey(e => e.IdResponsable);

                entity.ToTable("ACResponsables");

                entity.HasIndex(e => e.Responsable, "IX_ACResponsables")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Cargo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Curp)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("CURP");

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Lada)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Responsable)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rfc)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("RFC");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AgaCatAcreedore>(entity =>
            {
                entity.HasKey(e => e.IdAgaCatAcreedor);

                entity.HasIndex(e => e.AgaCodigo, "IX_AgaCatAcreedores")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.AgaCodigo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AgaCatIva>(entity =>
            {
                entity.HasKey(e => e.IdAgaCatIva);

                entity.ToTable("AgaCatIVA");

                entity.Property(e => e.IdAgaCatIva).HasColumnName("IdAgaCatIVA");

                entity.Property(e => e.CodigoIva)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CodigoIVA");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AgaCme>(entity =>
            {
                entity.HasKey(e => e.IdAgaCme);

                entity.ToTable("AgaCME");

                entity.HasIndex(e => e.Cme, "IX_AgaCME")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdAgaCme).HasColumnName("IdAgaCME");

                entity.Property(e => e.Cme)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CME");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithMany(p => p.AgaCmes)
                    .HasForeignKey(d => d.IdCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AgaCME_CtbCuentas");
            });

            modelBuilder.Entity<AoAnticiposDestajista>(entity =>
            {
                entity.HasKey(e => e.IdAnticipoDestajista);

                entity.Property(e => e.DescripcionCancelacion)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaCancelacion).HasColumnType("smalldatetime");

                entity.Property(e => e.Importe).HasColumnType("money");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDestajistaNavigation)
                    .WithMany(p => p.AoAnticiposDestajista)
                    .HasForeignKey(d => d.IdDestajista)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoAnticiposDestajistas_AoCatDestajistas");

                entity.HasOne(d => d.IdPolizaNavigation)
                    .WithMany(p => p.AoAnticiposDestajistaIdPolizaNavigations)
                    .HasForeignKey(d => d.IdPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoAnticiposDestajistas_CtbPolizas1");

                entity.HasOne(d => d.IdPolizaInversaNavigation)
                    .WithMany(p => p.AoAnticiposDestajistaIdPolizaInversaNavigations)
                    .HasForeignKey(d => d.IdPolizaInversa)
                    .HasConstraintName("FK_AoAnticiposDestajistas_CtbPolizas");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AoAnticiposDestajista)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoAnticiposDestajistas_Proyectos");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AoAnticiposDestajistaIdUsuarioNavigations)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoAnticiposDestajistas_SegUsuarios");

                entity.HasOne(d => d.IdUsuarioCancelacionNavigation)
                    .WithMany(p => p.AoAnticiposDestajistaIdUsuarioCancelacionNavigations)
                    .HasForeignKey(d => d.IdUsuarioCancelacion)
                    .HasConstraintName("FK_AoAnticiposDestajistas_SegUsuarios1");
            });

            modelBuilder.Entity<AoAvanceDiario>(entity =>
            {
                entity.HasKey(e => e.IdAvanceDiario);

                entity.ToTable("AoAvanceDiario");

                entity.HasIndex(e => new { e.IdPresupuestoControl, e.IdCentro, e.Fecha }, "IX_AoAvanceDiario")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdAvanceDiario).HasColumnName("idAvanceDiario");

                entity.Property(e => e.Cantidad).HasColumnType("money");

                entity.Property(e => e.Fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.IdCentro).HasColumnName("idCentro");

                entity.Property(e => e.IdContratista).HasColumnName("idContratista");

                entity.Property(e => e.IdDestajista).HasColumnName("idDestajista");

                entity.Property(e => e.IdPresupuestoControl).HasColumnName("idPresupuestoControl");

                entity.HasOne(d => d.IdCentroNavigation)
                    .WithMany(p => p.AoAvanceDiarios)
                    .HasForeignKey(d => d.IdCentro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoAvanceDiario_Centros");

                entity.HasOne(d => d.IdContratistaNavigation)
                    .WithMany(p => p.AoAvanceDiarios)
                    .HasForeignKey(d => d.IdContratista)
                    .HasConstraintName("FK_AoAvanceDiario_AoCatContratistas");

                entity.HasOne(d => d.IdDestajistaNavigation)
                    .WithMany(p => p.AoAvanceDiarios)
                    .HasForeignKey(d => d.IdDestajista)
                    .HasConstraintName("FK_AoAvanceDiario_AoCatDestajistas");

                entity.HasOne(d => d.IdPresupuestoControlNavigation)
                    .WithMany(p => p.AoAvanceDiarios)
                    .HasForeignKey(d => d.IdPresupuestoControl)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoAvanceDiario_AoPresupuestoControl");
            });

            modelBuilder.Entity<AoCatConcepto>(entity =>
            {
                entity.HasKey(e => e.IdConcepto);

                entity.HasIndex(e => new { e.IdProyecto, e.IdSubcontrato }, "IX_AoCatConceptos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdConcepto).HasColumnName("idConcepto");

                entity.Property(e => e.DescripcionLarga)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.DestajoMax).HasColumnType("money");

                entity.Property(e => e.FolioOcmatriz).HasColumnName("FolioOCMatriz");

                entity.Property(e => e.IdDestajo).HasColumnName("idDestajo");

                entity.Property(e => e.IdProyecto).HasColumnName("idProyecto");

                entity.Property(e => e.IdSubcontrato).HasColumnName("idSubcontrato");

                entity.Property(e => e.IdSubmo).HasColumnName("idSUBMO");

                entity.Property(e => e.SubcontratoMax).HasColumnType("money");

                entity.HasOne(d => d.IdDestajoNavigation)
                    .WithMany(p => p.AoCatConceptoIdDestajoNavigations)
                    .HasForeignKey(d => d.IdDestajo)
                    .HasConstraintName("FK_AoCatConceptos_AcCatInsumos1");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AoCatConceptos)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoCatConceptos_Proyectos");

                entity.HasOne(d => d.IdSubcontratoNavigation)
                    .WithMany(p => p.AoCatConceptoIdSubcontratoNavigations)
                    .HasForeignKey(d => d.IdSubcontrato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoCatConceptos_AcCatInsumos");

                entity.HasOne(d => d.IdSubmoNavigation)
                    .WithMany(p => p.AoCatConceptoIdSubmoNavigations)
                    .HasForeignKey(d => d.IdSubmo)
                    .HasConstraintName("FK_AoCatConceptos_AcCatInsumos2");
            });

            modelBuilder.Entity<AoCatContratista>(entity =>
            {
                entity.HasKey(e => e.IdContratista)
                    .HasName("aaaaaSubcontratistas_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.Contratista, "IxContratista")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdContratista).HasColumnName("idContratista");

                entity.Property(e => e.CiudadNotario)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CiudadRegistroNotario)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPostal)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Contratista)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Delegacion)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DomicilioNotario)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.EscrituraRepresentante)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Especialidad)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEscritura).HasColumnType("datetime");

                entity.Property(e => e.FechaEscrituraRepresentante).HasColumnType("datetime");

                entity.Property(e => e.FolioRegistroNotario)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdCiudad).HasColumnName("idCiudad");

                entity.Property(e => e.IdProveedor).HasColumnName("idProveedor");

                entity.Property(e => e.Mail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Notario)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.NotarioRepresentante)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.NumEscritura)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroNotaria)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .IsRequired()
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.RepresentanteLegal)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCiudadNavigation)
                    .WithMany(p => p.AoCatContratista)
                    .HasForeignKey(d => d.IdCiudad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoCatContratistas_AcCatCiudades");

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.AoCatContratista)
                    .HasForeignKey(d => d.IdProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoCatContratistas_AcProveedores");
            });

            modelBuilder.Entity<AoCatDescuento>(entity =>
            {
                entity.HasKey(e => e.IdDescuento);

                entity.HasIndex(e => e.Descuento, "IX_AoCatDescuentos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuenta, "IX_AoCatDescuentos_1")
                    .HasFillFactor(90);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Descuento)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithMany(p => p.AoCatDescuentos)
                    .HasForeignKey(d => d.IdCuenta)
                    .HasConstraintName("FK_AoCatDescuentos_CtbCuentas");
            });

            modelBuilder.Entity<AoCatDestajista>(entity =>
            {
                entity.HasKey(e => e.IdDestajista);

                entity.HasIndex(e => e.IdCuentaAcreedor, "IX_AoCatDestajistas");

                entity.HasIndex(e => e.IdCuentaAnticipo, "IX_AoCatDestajistas_1");

                entity.HasIndex(e => e.IdCuentaViaticos, "IX_AoCatDestajistas_2");

                entity.Property(e => e.IdDestajista).HasColumnName("idDestajista");

                entity.Property(e => e.CodigoPostal)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Delegacion)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Destajista)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.EsContratistaMo).HasColumnName("EsContratistaMO");

                entity.Property(e => e.Especialidad)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdCiudad).HasColumnName("idCiudad");

                entity.Property(e => e.IdContratista).HasColumnName("idContratista");

                entity.Property(e => e.Mail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PorcentajeFonGar).HasColumnType("money");

                entity.Property(e => e.RazonSocial)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCiudadNavigation)
                    .WithMany(p => p.AoCatDestajista)
                    .HasForeignKey(d => d.IdCiudad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoCatDestajistas_AcCatCiudades");

                entity.HasOne(d => d.IdContratistaNavigation)
                    .WithMany(p => p.AoCatDestajista)
                    .HasForeignKey(d => d.IdContratista)
                    .HasConstraintName("FK_AoCatDestajistas_AoCatContratistas");

                entity.HasOne(d => d.IdCuentaAcreedorNavigation)
                    .WithMany(p => p.AoCatDestajistaIdCuentaAcreedorNavigations)
                    .HasForeignKey(d => d.IdCuentaAcreedor)
                    .HasConstraintName("FK_AoCatDestajistas_CtbCuentas");

                entity.HasOne(d => d.IdCuentaAnticipoNavigation)
                    .WithMany(p => p.AoCatDestajistaIdCuentaAnticipoNavigations)
                    .HasForeignKey(d => d.IdCuentaAnticipo)
                    .HasConstraintName("FK_AoCatDestajistas_CtbCuentas1");

                entity.HasOne(d => d.IdCuentaViaticosNavigation)
                    .WithMany(p => p.AoCatDestajistaIdCuentaViaticosNavigations)
                    .HasForeignKey(d => d.IdCuentaViaticos)
                    .HasConstraintName("FK_AoCatDestajistas_CtbCuentas2");

                entity.HasOne(d => d.IdTipoMonedaNavigation)
                    .WithMany(p => p.AoCatDestajista)
                    .HasForeignKey(d => d.IdTipoMoneda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoCatDestajistas_AcCatMonedas");
            });

            modelBuilder.Entity<AoConceptosXdestajistum>(entity =>
            {
                entity.HasKey(e => e.IdConceptoXdestajista)
                    .HasName("PK_AoDestajosConceptos");

                entity.ToTable("AoConceptosXDestajista");

                entity.HasIndex(e => new { e.IdDestajista, e.IdPresupuestoControl }, "IX_AoDestajosConceptos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdConceptoXdestajista).HasColumnName("IdConceptoXDestajista");

                entity.Property(e => e.IdDestajista).HasColumnName("idDestajista");

                entity.HasOne(d => d.IdDestajistaNavigation)
                    .WithMany(p => p.AoConceptosXdestajista)
                    .HasForeignKey(d => d.IdDestajista)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoDestajosConceptos_AoCatDestajistas");

                entity.HasOne(d => d.IdPresupuestoControlNavigation)
                    .WithMany(p => p.AoConceptosXdestajista)
                    .HasForeignKey(d => d.IdPresupuestoControl)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoDestajosConceptos_AoPresupuestoControl");
            });

            modelBuilder.Entity<AoDestajistasContratistasPu2010>(entity =>
            {
                entity.HasKey(e => e.IdDestajistaContratistaPu2010);

                entity.ToTable("AoDestajistasContratistasPU2010");

                entity.HasIndex(e => new { e.IdProyecto, e.IdDestajista }, "IX_AoDestajistasContratistasPU2010")
                    .IsUnique();

                entity.Property(e => e.IdDestajistaContratistaPu2010).HasColumnName("IdDestajistaContratistaPU2010");

                entity.Property(e => e.IdContratistaPu2010).HasColumnName("IdContratistaPU2010");

                entity.HasOne(d => d.IdDestajistaNavigation)
                    .WithMany(p => p.AoDestajistasContratistasPu2010s)
                    .HasForeignKey(d => d.IdDestajista)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoDestajistasContratistasPU2010_AoCatDestajistas");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AoDestajistasContratistasPu2010s)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoDestajistasContratistasPU2010_Proyectos");
            });

            modelBuilder.Entity<AoDestajosEst>(entity =>
            {
                entity.HasKey(e => e.IdDestajoEst);

                entity.ToTable("AoDestajosEst");

                entity.HasIndex(e => new { e.IdProyecto, e.FolioEstimacion, e.IdDestajista }, "IX_AoDestajosEst")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Agrupa)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BaseDatosPu2010)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BaseDatosPU2010");

                entity.Property(e => e.DevolucionFonGar).HasColumnType("money");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaFin).HasColumnType("datetime");

                entity.Property(e => e.FechaInicial).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.FechaPoliza).HasColumnType("smalldatetime");

                entity.Property(e => e.IdDestajista).HasColumnName("idDestajista");

                entity.Property(e => e.IdEstimacionPu2010).HasColumnName("IdEstimacionPU2010");

                entity.Property(e => e.IdPresupuestoPu2010).HasColumnName("IdPresupuestoPU2010");

                entity.Property(e => e.Importe).HasColumnType("money");

                entity.Property(e => e.ImporteFonGar).HasColumnType("money");

                entity.Property(e => e.ImporteOriginal).HasColumnType("money");

                entity.Property(e => e.Observaciones).IsUnicode(false);

                entity.Property(e => e.ServidorPu2010)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ServidorPU2010");

                entity.HasOne(d => d.IdDestajistaNavigation)
                    .WithMany(p => p.AoDestajosEsts)
                    .HasForeignKey(d => d.IdDestajista)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoDestajosEst_AoCatDestajistas");

                entity.HasOne(d => d.IdPolizaNavigation)
                    .WithMany(p => p.AoDestajosEsts)
                    .HasForeignKey(d => d.IdPoliza)
                    .HasConstraintName("FK_AoDestajosEst_CtbPolizas");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AoDestajosEsts)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoDestajosEst_Proyectos");

                entity.HasOne(d => d.IdUsuarioPolizaNavigation)
                    .WithMany(p => p.AoDestajosEsts)
                    .HasForeignKey(d => d.IdUsuarioPoliza)
                    .HasConstraintName("FK_AoDestajosEst_SegUsuarios");
            });

            modelBuilder.Entity<AoDestajosEstCc>(entity =>
            {
                entity.HasKey(e => e.IdDestajoEstCc);

                entity.ToTable("AoDestajosEstCC");

                entity.HasIndex(e => new { e.IdDestajoDet, e.IdCentro }, "IX_AoDestajosEstCC")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdDestajoEstCc).HasColumnName("IdDestajoEstCC");

                entity.Property(e => e.Cantidad).HasColumnType("money");

                entity.Property(e => e.IdCentro).HasColumnName("idCentro");

                entity.HasOne(d => d.IdCentroNavigation)
                    .WithMany(p => p.AoDestajosEstCcs)
                    .HasForeignKey(d => d.IdCentro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoDestajosEstCC_Centros");

                entity.HasOne(d => d.IdDestajoDetNavigation)
                    .WithMany(p => p.AoDestajosEstCcs)
                    .HasForeignKey(d => d.IdDestajoDet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoDestajosEstCC_AoDestajosEstDet");
            });

            modelBuilder.Entity<AoDestajosEstDet>(entity =>
            {
                entity.HasKey(e => e.IdDestajoDet);

                entity.ToTable("AoDestajosEstDet");

                entity.HasIndex(e => new { e.IdDestajoEst, e.IdPresupuestoControl }, "IX_AoDestajosEstDet")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Cantidad).HasColumnType("money");

                entity.Property(e => e.Costo).HasColumnType("money");

                entity.Property(e => e.Importe).HasColumnType("money");

                entity.HasOne(d => d.IdDestajoEstNavigation)
                    .WithMany(p => p.AoDestajosEstDets)
                    .HasForeignKey(d => d.IdDestajoEst)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoDestajosEstDet_AoDestajosEst");

                entity.HasOne(d => d.IdPresupuestoControlNavigation)
                    .WithMany(p => p.AoDestajosEstDets)
                    .HasForeignKey(d => d.IdPresupuestoControl)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoDestajosEstDet_AoPresupuestoControl");
            });

            modelBuilder.Entity<AoDestajosFolio>(entity =>
            {
                entity.HasKey(e => new { e.IdProyecto, e.IdDestajista });
            });

            modelBuilder.Entity<AoExpXconcepto>(entity =>
            {
                entity.HasKey(e => e.IdExpXconcepto)
                    .HasName("aaaaaExpXconcepto_PK")
                    .IsClustered(false);

                entity.ToTable("AoExpXConcepto");

                entity.HasIndex(e => new { e.IdConcepto, e.IdCostoXproyecto }, "IX_AoExpXConcepto")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdExpXconcepto).HasColumnName("idExpXconcepto");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CantidadOc)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("CantidadOC");

                entity.Property(e => e.IdConcepto).HasColumnName("idConcepto");

                entity.Property(e => e.IdCostoXproyecto).HasColumnName("idCostoXProyecto");

                entity.HasOne(d => d.IdConceptoNavigation)
                    .WithMany(p => p.AoExpXconceptos)
                    .HasForeignKey(d => d.IdConcepto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoExpXConcepto_AoCatConceptos");

                entity.HasOne(d => d.IdCostoXproyectoNavigation)
                    .WithMany(p => p.AoExpXconceptos)
                    .HasForeignKey(d => d.IdCostoXproyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoExpXConcepto_AcCostosXProyecto");
            });

            modelBuilder.Entity<AoExpXpartidum>(entity =>
            {
                entity.HasKey(e => e.IdExpXpartida);

                entity.ToTable("AoExpXPartida");

                entity.HasIndex(e => new { e.IdProyecto, e.IdPartida, e.IdInsumo }, "IX_AoExpXPartida")
                    .IsUnique();

                entity.Property(e => e.IdExpXpartida).HasColumnName("idExpXPartida");

                entity.Property(e => e.CantidadRequisicion).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.IdInsumo).HasColumnName("idInsumo");

                entity.Property(e => e.IdPartida).HasColumnName("idPartida");

                entity.HasOne(d => d.IdInsumoNavigation)
                    .WithMany(p => p.AoExpXpartida)
                    .HasForeignKey(d => d.IdInsumo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoExpXPartida_AcCatInsumos");

                entity.HasOne(d => d.IdPartidaNavigation)
                    .WithMany(p => p.AoExpXpartida)
                    .HasForeignKey(d => d.IdPartida)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoExpXPartida_AoPartidas");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AoExpXpartida)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoExpXPartida_Proyectos");
            });

            modelBuilder.Entity<AoMatrizOc>(entity =>
            {
                entity.HasKey(e => e.IdMatrizOc);

                entity.ToTable("AoMatrizOC");

                entity.HasIndex(e => new { e.IdConcepto, e.NumeroOrdenCambio }, "IX_AoMatrizOC")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdMatrizOc).HasColumnName("idMatrizOC");

                entity.Property(e => e.Fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.IdConcepto).HasColumnName("idConcepto");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.RazonCambio)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdConceptoNavigation)
                    .WithMany(p => p.AoMatrizOcs)
                    .HasForeignKey(d => d.IdConcepto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoMatrizOC_AoCatConceptos");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AoMatrizOcs)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoMatrizOC_SegUsuarios");
            });

            modelBuilder.Entity<AoMatrizOcdet>(entity =>
            {
                entity.HasKey(e => e.IdMatrizOcdet);

                entity.ToTable("AoMatrizOCDet");

                entity.HasIndex(e => new { e.IdMatrizOc, e.IdExpXconcepto }, "IX_AoMatrizOCDet")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdMatrizOcdet).HasColumnName("idMatrizOCDet");

                entity.Property(e => e.Cantidad).HasColumnType("money");

                entity.Property(e => e.IdExpXconcepto).HasColumnName("idExpXConcepto");

                entity.Property(e => e.IdMatrizOc).HasColumnName("idMatrizOC");

                entity.HasOne(d => d.IdExpXconceptoNavigation)
                    .WithMany(p => p.AoMatrizOcdets)
                    .HasForeignKey(d => d.IdExpXconcepto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoMatrizOCDet_AoExpXConcepto");

                entity.HasOne(d => d.IdMatrizOcNavigation)
                    .WithMany(p => p.AoMatrizOcdets)
                    .HasForeignKey(d => d.IdMatrizOc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoMatrizOCDet_AoMatrizOC");
            });

            modelBuilder.Entity<AoPartida>(entity =>
            {
                entity.HasKey(e => e.IdPartida)
                    .HasName("PK_AcPartidas");

                entity.HasIndex(e => new { e.IdProyecto, e.Partida }, "IX_AcPartidas")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.AceptaMov)
                    .IsRequired()
                    .HasColumnName("Acepta_Mov")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionLarga).IsUnicode(false);

                entity.Property(e => e.IdUnegocio).HasColumnName("IdUNegocio");

                entity.Property(e => e.ModeloCasa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Partida)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AoPartida)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoPartidas_Proyectos");

                entity.HasOne(d => d.IdUnegocioNavigation)
                    .WithMany(p => p.AoPartida)
                    .HasForeignKey(d => d.IdUnegocio)
                    .HasConstraintName("FK_AcPartidas_AOUnidadNegociogeo");
            });

            modelBuilder.Entity<AoPartidasAvanceFisico>(entity =>
            {
                entity.HasKey(e => e.IdPartidaAvanceFisico);

                entity.ToTable("AoPartidasAvanceFisico");

                entity.HasIndex(e => new { e.IdProyecto, e.Folio }, "IX_AoPartidasAvanceFisico")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AoPartidasAvanceFisicos)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoPartidasAvanceFisico_Proyectos");
            });

            modelBuilder.Entity<AoPartidasAvanceFisicoDet>(entity =>
            {
                entity.HasKey(e => e.IdPartidaAvanceFisicoDet);

                entity.ToTable("AoPartidasAvanceFisicoDet");

                entity.HasIndex(e => new { e.IdPartidaAvanceFisico, e.IdPartida }, "IX_AoPartidasAvanceFisicoDet")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Porcentaje).HasColumnType("money");

                entity.HasOne(d => d.IdPartidaNavigation)
                    .WithMany(p => p.AoPartidasAvanceFisicoDets)
                    .HasForeignKey(d => d.IdPartida)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoPartidasAvanceFisicoDet_AoPartidas");

                entity.HasOne(d => d.IdPartidaAvanceFisicoNavigation)
                    .WithMany(p => p.AoPartidasAvanceFisicoDets)
                    .HasForeignKey(d => d.IdPartidaAvanceFisico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoPartidasAvanceFisicoDet_AoPartidasAvanceFisico");
            });

            modelBuilder.Entity<AoPresupuestoControl>(entity =>
            {
                entity.HasKey(e => e.IdPresupuestoControl);

                entity.ToTable("AoPresupuestoControl");

                entity.HasIndex(e => new { e.IdProyecto, e.IdPartida, e.Renglon }, "IX_AoPresupuestoControl")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.CantidadDesestimada)
                    .HasColumnType("money")
                    .HasColumnName("CantidadDESEstimada");

                entity.Property(e => e.CantidadMocapturado)
                    .HasColumnType("money")
                    .HasColumnName("CantidadMOCapturado");

                entity.Property(e => e.CantidadMocapturadoAnt)
                    .HasColumnType("money")
                    .HasColumnName("CantidadMOCapturadoANT");

                entity.Property(e => e.CantidadMocontratado)
                    .HasColumnType("money")
                    .HasColumnName("CantidadMOContratado");

                entity.Property(e => e.CantidadMocontratadoSubmo)
                    .HasColumnType("money")
                    .HasColumnName("CantidadMOContratadoSUBMO");

                entity.Property(e => e.CantidadOc)
                    .HasColumnType("money")
                    .HasColumnName("CantidadOC");

                entity.Property(e => e.CantidadOriginal).HasColumnType("money");

                entity.Property(e => e.CantidadOriginalAnt)
                    .HasColumnType("money")
                    .HasColumnName("CantidadOriginalANT");

                entity.Property(e => e.CantidadOriginalImportada).HasColumnType("money");

                entity.Property(e => e.CantidadSubestimada)
                    .HasColumnType("money")
                    .HasColumnName("CantidadSUBEstimada");

                entity.Property(e => e.CantidadSubmo)
                    .HasColumnType("money")
                    .HasColumnName("CantidadSUBMO");

                entity.Property(e => e.CantidadSubmoant)
                    .HasColumnType("money")
                    .HasColumnName("CantidadSUBMOANT");

                entity.Property(e => e.CantidadSubmoestimada)
                    .HasColumnType("money")
                    .HasColumnName("CantidadSUBMOEstimada");

                entity.Property(e => e.ControlPu2010).HasColumnName("ControlPU2010");

                entity.Property(e => e.CostoDestajoActual).HasColumnType("money");

                entity.Property(e => e.CostoGlobalActual).HasColumnType("money");

                entity.Property(e => e.CostoOriginalImportado).HasColumnType("money");

                entity.Property(e => e.CostoOriginalSubcontrato).HasColumnType("money");

                entity.Property(e => e.CostoSubmoactual)
                    .HasColumnType("money")
                    .HasColumnName("CostoSUBMOActual");

                entity.Property(e => e.EstimaDecimal)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaFinPrograma).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioPrograma).HasColumnType("datetime");

                entity.Property(e => e.FraccionaTope)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdConcepto).HasColumnName("idConcepto");

                entity.Property(e => e.IdPartida).HasColumnName("idPartida");

                entity.HasOne(d => d.IdConceptoNavigation)
                    .WithMany(p => p.AoPresupuestoControls)
                    .HasForeignKey(d => d.IdConcepto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoPresupuestoControl_AoCatConceptos");

                entity.HasOne(d => d.IdPartidaNavigation)
                    .WithMany(p => p.AoPresupuestoControls)
                    .HasForeignKey(d => d.IdPartida)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoPresupuestoControl_AcPartidas");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AoPresupuestoControls)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoPresupuestoControl_Proyectos1");
            });

            modelBuilder.Entity<AoPresupuestoControlOc>(entity =>
            {
                entity.HasKey(e => e.IdPresupuestoControlOc);

                entity.ToTable("AoPresupuestoControlOC");

                entity.HasIndex(e => new { e.IdProyecto, e.NumeroOrdenCambio }, "IX_AoPresupuestoControlOC")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdPresupuestoControlOc).HasColumnName("IdPresupuestoControlOC");

                entity.Property(e => e.Autorizada)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaAutorizada).HasColumnType("datetime");

                entity.Property(e => e.RazonCambio)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AoPresupuestoControlOcs)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoPresupuestoControlOC_Proyectos");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AoPresupuestoControlOcs)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoPresupuestoControlOC_SegUsuarios");
            });

            modelBuilder.Entity<AoPresupuestoControlOcdet>(entity =>
            {
                entity.HasKey(e => e.IdPresupuestoControlOcdet);

                entity.ToTable("AoPresupuestoControlOCDet");

                entity.HasIndex(e => new { e.IdPresupuestoControlOc, e.IdPresupuestoControl }, "IX_AoPresupuestoControlOCDet")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdPresupuestoControlOcdet).HasColumnName("IdPresupuestoControlOCDet");

                entity.Property(e => e.Cantidad).HasColumnType("money");

                entity.Property(e => e.IdPresupuestoControlOc).HasColumnName("IdPresupuestoControlOC");

                entity.HasOne(d => d.IdPresupuestoControlNavigation)
                    .WithMany(p => p.AoPresupuestoControlOcdets)
                    .HasForeignKey(d => d.IdPresupuestoControl)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoPresupuestoControlOCDet_AoPresupuestoControl");

                entity.HasOne(d => d.IdPresupuestoControlOcNavigation)
                    .WithMany(p => p.AoPresupuestoControlOcdets)
                    .HasForeignKey(d => d.IdPresupuestoControlOc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoPresupuestoControlOCDet_AoPresupuestoControlOC");
            });

            modelBuilder.Entity<AoPresupuestoControlPeriodo>(entity =>
            {
                entity.HasKey(e => e.IdPresupuestocontrolPeriodo);

                entity.HasIndex(e => new { e.IdPresupuestoControl, e.Periodo }, "IX_AoPresupuestoControlPeriodos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.CantidadDestajo).HasColumnType("money");

                entity.Property(e => e.CantidadSubcontrato).HasColumnType("money");

                entity.HasOne(d => d.IdPresupuestoControlNavigation)
                    .WithMany(p => p.AoPresupuestoControlPeriodos)
                    .HasForeignKey(d => d.IdPresupuestoControl)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoPresupuestoControlPeriodos_AoPresupuestoControl");
            });

            modelBuilder.Entity<AoPresupuestoControlPrecedencia>(entity =>
            {
                entity.HasKey(e => e.IdPresupuestocontroltPrecedencia);

                entity.HasIndex(e => new { e.IdPresupuestoControlPadre, e.IdPresupuestoControlHijo }, "IX_AoPresupuestoControlPrecedencias")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasOne(d => d.IdPresupuestoControlHijoNavigation)
                    .WithMany(p => p.AoPresupuestoControlPrecedenciaIdPresupuestoControlHijoNavigations)
                    .HasForeignKey(d => d.IdPresupuestoControlHijo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoPresupuestoControlPrecedencias_AoPresupuestoControl1");

                entity.HasOne(d => d.IdPresupuestoControlPadreNavigation)
                    .WithMany(p => p.AoPresupuestoControlPrecedenciaIdPresupuestoControlPadreNavigations)
                    .HasForeignKey(d => d.IdPresupuestoControlPadre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoPresupuestoControlPrecedencias_AoPresupuestoControl");
            });

            modelBuilder.Entity<AoProgramaObra>(entity =>
            {
                entity.HasKey(e => e.IdProgramaObra);

                entity.ToTable("AoProgramaObra");

                entity.HasIndex(e => new { e.IdPresupuestoControl, e.Periodo }, "IX_AoProgramaObra")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdPresupuestoControl, "IX_AoProgramaObra_1")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Periodo, "IX_AoProgramaObra_2")
                    .HasFillFactor(90);

                entity.Property(e => e.IdProgramaObra).HasColumnName("idProgramaObra");

                entity.Property(e => e.IdPresupuestoControl).HasColumnName("idPresupuestoControl");

                entity.Property(e => e.Volumen).HasColumnType("money");

                entity.HasOne(d => d.IdPresupuestoControlNavigation)
                    .WithMany(p => p.AoProgramaObras)
                    .HasForeignKey(d => d.IdPresupuestoControl)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoProgramaObra_AoPresupuestoControl");
            });

            modelBuilder.Entity<AoProgramaSuministro>(entity =>
            {
                entity.HasKey(e => e.IdProgramaSuministros);

                entity.HasIndex(e => new { e.IdExplosionInsumos, e.Periodo }, "IX_AoProgramaSuministros")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdExplosionInsumos, "IX_AoProgramaSuministros_1")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Periodo, "IX_AoProgramaSuministros_2")
                    .HasFillFactor(90);

                entity.Property(e => e.IdProgramaSuministros).HasColumnName("idProgramaSuministros");

                entity.Property(e => e.IdExplosionInsumos).HasColumnName("idExplosionInsumos");

                entity.Property(e => e.Volumen).HasColumnType("money");

                entity.HasOne(d => d.IdExplosionInsumosNavigation)
                    .WithMany(p => p.AoProgramaSuministros)
                    .HasForeignKey(d => d.IdExplosionInsumos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoProgramaSuministros_AcExplosionInsumos");
            });

            modelBuilder.Entity<AoPrototipo>(entity =>
            {
                entity.HasKey(e => e.IdPrototipo);

                entity.HasIndex(e => new { e.IdProyecto, e.Prototipo }, "IX_AoPrototipos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Prototipo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AoPrototipos)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoPrototipos_Proyectos");
            });

            modelBuilder.Entity<AoPrototiposDet>(entity =>
            {
                entity.HasKey(e => e.IdPrototipoDet);

                entity.ToTable("AoPrototiposDet");

                entity.HasIndex(e => new { e.IdPrototipo, e.IdPresupuestoControl }, "IX_AoPrototiposDet")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Cantidad).HasColumnType("money");

                entity.Property(e => e.EstimaDecimal)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FraccionaTope)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdPresupuestoControlNavigation)
                    .WithMany(p => p.AoPrototiposDets)
                    .HasForeignKey(d => d.IdPresupuestoControl)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoPrototiposDet_AoPresupuestoControl");

                entity.HasOne(d => d.IdPrototipoNavigation)
                    .WithMany(p => p.AoPrototiposDets)
                    .HasForeignKey(d => d.IdPrototipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoPrototiposDet_AoPrototipos");
            });

            modelBuilder.Entity<AoSubContrato>(entity =>
            {
                entity.HasKey(e => e.IdSubContrato)
                    .HasName("aaaaaMtoSubcon_PK")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.IdProyecto, e.FolioSubcontrato }, "IX_AoSubContratos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Anticipo).HasColumnType("money");

                entity.Property(e => e.Area)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BaseDatosPu2010)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BaseDatosPU2010");

                entity.Property(e => e.CapturarPorcentajeAnticipo)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CapturarPorcentajeFonGar)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CapturarPorcentajeOr).HasColumnName("CapturarPorcentajeOR");

                entity.Property(e => e.CapturarPorcentajePe).HasColumnName("CapturarPorcentajePE");

                entity.Property(e => e.ClausulaSub).IsUnicode(false);

                entity.Property(e => e.CodigoAuxiliar)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentoLegal)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EsSubMo).HasColumnName("EsSubMO");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaFin).HasColumnType("datetime");

                entity.Property(e => e.FechaImportacionDaltonDin)
                    .HasColumnType("datetime")
                    .HasColumnName("FechaImportacionDaltonDIN");

                entity.Property(e => e.FechaInicial).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.FechaProrroga).HasColumnType("datetime");

                entity.Property(e => e.FianzaAnticipo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FianzaCumplimiento)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FianzaGarantia)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FolioOc).HasColumnName("FolioOC");

                entity.Property(e => e.FonGar).HasColumnType("money");

                entity.Property(e => e.Frente)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdContratista).HasColumnName("idContratista");

                entity.Property(e => e.IdContratoPu2010).HasColumnName("IdContratoPU2010");

                entity.Property(e => e.IdPresupuestoPu2010).HasColumnName("IdPresupuestoPU2010");

                entity.Property(e => e.IdResidente).HasColumnName("idResidente");

                entity.Property(e => e.IdSupIntendente1).HasColumnName("idSupIntendente1");

                entity.Property(e => e.IdSupIntendente2).HasColumnName("idSupIntendente2");

                entity.Property(e => e.IdVoBo).HasColumnName("idVoBo");

                entity.Property(e => e.ImportadoDaltonDin).HasColumnName("ImportadoDaltonDIN");

                entity.Property(e => e.ImporteSubcontrato).HasColumnType("money");

                entity.Property(e => e.IntInmdocumentoContratoDeObraKey).HasColumnName("intINMDocumentoContratoDeObraKey");

                entity.Property(e => e.Iva).HasColumnType("money");

                entity.Property(e => e.MontoPaquete).HasColumnType("money");

                entity.Property(e => e.Objeto)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.OtrasRetenciones).HasColumnType("money");

                entity.Property(e => e.PagoEnEspecie).HasColumnType("money");

                entity.Property(e => e.PorcentajeAnticipo).HasColumnType("money");

                entity.Property(e => e.PorcentajeFonGar).HasColumnType("money");

                entity.Property(e => e.PorcentajeIva)
                    .HasColumnType("money")
                    .HasColumnName("PorcentajeIVA");

                entity.Property(e => e.PorcentajeOtrasRetenciones).HasColumnType("money");

                entity.Property(e => e.PorcentajePagoEnEspecie).HasColumnType("money");

                entity.Property(e => e.Prototipo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ServidorPu2010)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ServidorPU2010");

                entity.HasOne(d => d.IdContratistaNavigation)
                    .WithMany(p => p.AoSubContratos)
                    .HasForeignKey(d => d.IdContratista)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoSubContratos_AoCatContratistas");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AoSubContratos)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoSubContratos_Proyectos");

                entity.HasOne(d => d.IdResidenteNavigation)
                    .WithMany(p => p.AoSubContratoIdResidenteNavigations)
                    .HasForeignKey(d => d.IdResidente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoSubContratos_ACResponsables");

                entity.HasOne(d => d.IdSupIntendente1Navigation)
                    .WithMany(p => p.AoSubContratoIdSupIntendente1Navigations)
                    .HasForeignKey(d => d.IdSupIntendente1)
                    .HasConstraintName("FK_AoSubContratos_ACResponsables1");

                entity.HasOne(d => d.IdSupIntendente2Navigation)
                    .WithMany(p => p.AoSubContratoIdSupIntendente2Navigations)
                    .HasForeignKey(d => d.IdSupIntendente2)
                    .HasConstraintName("FK_AoSubContratos_ACResponsables2");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AoSubContratos)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoSubContratos_SegUsuarios");

                entity.HasOne(d => d.IdVoBoNavigation)
                    .WithMany(p => p.AoSubContratoIdVoBoNavigations)
                    .HasForeignKey(d => d.IdVoBo)
                    .HasConstraintName("FK_AoSubContratos_ACResponsables3");
            });

            modelBuilder.Entity<AoSubContratosEst>(entity =>
            {
                entity.HasKey(e => e.IdSubContratoEst)
                    .HasName("aaaaaMtoEstimacion_PK")
                    .IsClustered(false);

                entity.ToTable("AoSubContratosEst");

                entity.HasIndex(e => new { e.IdSubContrato, e.FolioEstimacion }, "IX_AoSubContratosEst")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Agrupa)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DevolucionFonGar).HasColumnType("money");

                entity.Property(e => e.DevolucionOtrasRetenciones).HasColumnType("money");

                entity.Property(e => e.DevolucionPagoEnEspecie).HasColumnType("money");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaFin).HasColumnType("datetime");

                entity.Property(e => e.FechaImportacionDaltonDin)
                    .HasColumnType("datetime")
                    .HasColumnName("FechaImportacionDaltonDIN");

                entity.Property(e => e.FechaInicial).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.IdEstimacionPu2010).HasColumnName("IdEstimacionPU2010");

                entity.Property(e => e.ImportadoDaltonDin).HasColumnName("ImportadoDaltonDIN");

                entity.Property(e => e.ImporteAnticipo).HasColumnType("money");

                entity.Property(e => e.ImporteFonGar).HasColumnType("money");

                entity.Property(e => e.ImporteIva)
                    .HasColumnType("money")
                    .HasColumnName("ImporteIVA");

                entity.Property(e => e.ImporteOtrasRetenciones).HasColumnType("money");

                entity.Property(e => e.ImportePagoEnEspecie).HasColumnType("money");

                entity.Property(e => e.IntIdestimacionDin).HasColumnName("intIDEstimacionDIN");

                entity.Property(e => e.Observaciones).IsUnicode(false);

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AoSubContratosEsts)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoSubContratosEst_Proyectos");

                entity.HasOne(d => d.IdSubContratoNavigation)
                    .WithMany(p => p.AoSubContratosEsts)
                    .HasForeignKey(d => d.IdSubContrato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoSubContratosEst_AoSubContratos");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AoSubContratosEsts)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoSubContratosEst_SegUsuarios");
            });

            modelBuilder.Entity<AoSubContratosEstDescuento>(entity =>
            {
                entity.HasKey(e => e.IdSubContratoEstDescuento);

                entity.HasIndex(e => new { e.IdSubContratoEst, e.IdDescuento }, "IX_AoSubContratosEstDescuentos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.HasOne(d => d.IdDescuentoNavigation)
                    .WithMany(p => p.AoSubContratosEstDescuentos)
                    .HasForeignKey(d => d.IdDescuento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoSubContratosEstDescuentos_AoCatDescuentos");

                entity.HasOne(d => d.IdSubContratoEstNavigation)
                    .WithMany(p => p.AoSubContratosEstDescuentos)
                    .HasForeignKey(d => d.IdSubContratoEst)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoSubContratosEstDescuentos_AoSubContratosEst");
            });

            modelBuilder.Entity<AoSubContratosEstDet>(entity =>
            {
                entity.HasKey(e => e.IdSubContratoEstDet)
                    .HasName("aaaaaDetEstimacion_PK")
                    .IsClustered(false);

                entity.ToTable("AoSubContratosEstDet");

                entity.HasIndex(e => new { e.IdSubContratoEst, e.IdSubcontratoDet }, "IX_AoSubContratosEstDet")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Cantidad).HasColumnType("money");

                entity.Property(e => e.Costo).HasColumnType("money");

                entity.Property(e => e.IdSubcontratoDet).HasColumnName("idSubcontratoDet");

                entity.HasOne(d => d.IdSubContratoEstNavigation)
                    .WithMany(p => p.AoSubContratosEstDets)
                    .HasForeignKey(d => d.IdSubContratoEst)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoSubContratosEstDet_AoSubContratosEst");

                entity.HasOne(d => d.IdSubcontratoDetNavigation)
                    .WithMany(p => p.AoSubContratosEstDets)
                    .HasForeignKey(d => d.IdSubcontratoDet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoSubContratosEstDet_AoSubcontratosDet");
            });

            modelBuilder.Entity<AoSubContratosEstDetCc>(entity =>
            {
                entity.HasKey(e => e.IdSubContratoEstDetCc);

                entity.ToTable("AoSubContratosEstDetCC");

                entity.HasIndex(e => new { e.IdSubContratoEstDet, e.IdCentro }, "IX_AoSubContratosEstDetCC")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdSubContratoEstDetCc).HasColumnName("idSubContratoEstDetCC");

                entity.Property(e => e.Cantidad).HasColumnType("money");

                entity.Property(e => e.IdCentro).HasColumnName("idCentro");

                entity.HasOne(d => d.IdCentroNavigation)
                    .WithMany(p => p.AoSubContratosEstDetCcs)
                    .HasForeignKey(d => d.IdCentro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoSubContratosEstDetCC_Centros");

                entity.HasOne(d => d.IdSubContratoEstDetNavigation)
                    .WithMany(p => p.AoSubContratosEstDetCcs)
                    .HasForeignKey(d => d.IdSubContratoEstDet)
                    .HasConstraintName("FK_AoSubContratosEstDetCC_AoSubContratosEstDet");
            });

            modelBuilder.Entity<AoSubcontratosDet>(entity =>
            {
                entity.HasKey(e => e.IdSubcontratoDet)
                    .HasName("PK_DetSubcon");

                entity.ToTable("AoSubcontratosDet");

                entity.HasIndex(e => new { e.IdSubcontrato, e.Renglon }, "IX_AoSubcontratosDet")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdSubcontratoDet).HasColumnName("idSubcontratoDet");

                entity.Property(e => e.Cantidad).HasColumnType("money");

                entity.Property(e => e.CantidadEstimada).HasColumnType("money");

                entity.Property(e => e.CantidadOc)
                    .HasColumnType("money")
                    .HasColumnName("CantidadOC");

                entity.Property(e => e.ControlPu2010).HasColumnName("ControlPU2010");

                entity.Property(e => e.Costo).HasColumnType("money");

                entity.Property(e => e.IdSubcontrato).HasColumnName("idSubcontrato");

                entity.HasOne(d => d.IdPresupuestoControlNavigation)
                    .WithMany(p => p.AoSubcontratosDets)
                    .HasForeignKey(d => d.IdPresupuestoControl)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoSubcontratosDet_AoPresupuestoControl");

                entity.HasOne(d => d.IdSubcontratoNavigation)
                    .WithMany(p => p.AoSubcontratosDets)
                    .HasForeignKey(d => d.IdSubcontrato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DetSubcon_FK02");
            });

            modelBuilder.Entity<AoSubcontratosDetCosto>(entity =>
            {
                entity.HasKey(e => e.IdSubcontratoDetCosto)
                    .HasName("PK_AuSubcontratosDetCostos");

                entity.Property(e => e.IdSubcontratoDetCosto).HasColumnName("idSubcontratoDetCosto");

                entity.Property(e => e.CostoAnterior).HasColumnType("money");

                entity.Property(e => e.Fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Hora)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.IdSubcontratoDet).HasColumnName("idSubcontratoDet");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.HasOne(d => d.IdSubcontratoDetNavigation)
                    .WithMany(p => p.AoSubcontratosDetCostos)
                    .HasForeignKey(d => d.IdSubcontratoDet)
                    .HasConstraintName("FK_AoSubcontratosDetCostos_AoSubcontratosDet");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AoSubcontratosDetCostos)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoSubcontratosDetCostos_SegUsuarios");
            });

            modelBuilder.Entity<AoSubcontratosOc>(entity =>
            {
                entity.HasKey(e => e.IdSubcontratoOc);

                entity.ToTable("AoSubcontratosOC");

                entity.HasIndex(e => new { e.IdSubcontrato, e.NumeroOrdenCambio }, "IX_AoSubcontratosOC")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdSubcontratoOc).HasColumnName("IdSubcontratoOC");

                entity.Property(e => e.Fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaImportacionDaltonDin)
                    .HasColumnType("datetime")
                    .HasColumnName("FechaImportacionDaltonDIN");

                entity.Property(e => e.ImportadoDaltonDin).HasColumnName("ImportadoDaltonDIN");

                entity.Property(e => e.IntInmordenDeCambioDinkey).HasColumnName("intINMOrdenDeCambioDINKey");

                entity.Property(e => e.RazonCambio)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdSubcontratoNavigation)
                    .WithMany(p => p.AoSubcontratosOcs)
                    .HasForeignKey(d => d.IdSubcontrato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoSubcontratosOC_AoSubContratos");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AoSubcontratosOcs)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoSubcontratosOC_SegUsuarios");
            });

            modelBuilder.Entity<AoSubcontratosOcdet>(entity =>
            {
                entity.HasKey(e => e.IdSubcontratoOcdet);

                entity.ToTable("AoSubcontratosOCDet");

                entity.HasIndex(e => new { e.IdSubContratoOc, e.IdSubContratoDet }, "IX_AoSubcontratosOCDet")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdSubcontratoOcdet).HasColumnName("IdSubcontratoOCDet");

                entity.Property(e => e.Cantidad).HasColumnType("money");

                entity.Property(e => e.IdSubContratoOc).HasColumnName("IdSubContratoOC");

                entity.HasOne(d => d.IdSubContratoDetNavigation)
                    .WithMany(p => p.AoSubcontratosOcdets)
                    .HasForeignKey(d => d.IdSubContratoDet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoSubcontratosOCDet_AoSubcontratosDet");

                entity.HasOne(d => d.IdSubContratoOcNavigation)
                    .WithMany(p => p.AoSubcontratosOcdets)
                    .HasForeignKey(d => d.IdSubContratoOc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AoSubcontratosOCDet_AoSubcontratosOC");
            });

            modelBuilder.Entity<AoestimadoTerminacion>(entity =>
            {
                entity.HasKey(e => e.IdEstimado);

                entity.ToTable("AOEstimadoTerminacion");

                entity.HasIndex(e => new { e.IdProyecto, e.Vigencia }, "IX_AOEstimadoTerminacion")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.FechaDeCorte).HasColumnType("datetime");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AoestimadoTerminacions)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AOEstimadoTerminacion_Proyectos");
            });

            modelBuilder.Entity<AoestimadoTerminacionDetalle>(entity =>
            {
                entity.HasKey(e => e.IdEstimadoDet);

                entity.ToTable("AOEstimadoTerminacionDetalle");

                entity.Property(e => e.Acaestimado)
                    .HasColumnType("money")
                    .HasColumnName("ACAEstimado");

                entity.Property(e => e.Acafaltante)
                    .HasColumnType("money")
                    .HasColumnName("ACAFaltante");

                entity.Property(e => e.Eqestimado)
                    .HasColumnType("money")
                    .HasColumnName("EQEstimado");

                entity.Property(e => e.Eqfaltante)
                    .HasColumnType("money")
                    .HasColumnName("EQFaltante");

                entity.Property(e => e.Maestimado)
                    .HasColumnType("money")
                    .HasColumnName("MAEstimado");

                entity.Property(e => e.Mafaltante)
                    .HasColumnType("money")
                    .HasColumnName("MAFaltante");

                entity.Property(e => e.Moestimado)
                    .HasColumnType("money")
                    .HasColumnName("MOEstimado");

                entity.Property(e => e.Mofaltante)
                    .HasColumnType("money")
                    .HasColumnName("MOFaltante");

                entity.Property(e => e.Subestimado)
                    .HasColumnType("money")
                    .HasColumnName("SUBEstimado");

                entity.Property(e => e.Subfaltante)
                    .HasColumnType("money")
                    .HasColumnName("SUBFaltante");

                entity.HasOne(d => d.IdEstimadoNavigation)
                    .WithMany(p => p.AoestimadoTerminacionDetalles)
                    .HasForeignKey(d => d.IdEstimado)
                    .HasConstraintName("FK_AOEstimadoTerminacionDetalle_AOEstimadoTerminacion");
            });

            modelBuilder.Entity<Aomizar>(entity =>
            {
                entity.HasKey(e => e.IdMizar);

                entity.ToTable("AOMizar");

                entity.Property(e => e.AplicadoFgantesIva).HasColumnName("AplicadoFGAntesIVA");

                entity.Property(e => e.CentrodeCosto)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Iva)
                    .HasColumnType("money")
                    .HasColumnName("IVA");

                entity.Property(e => e.SubTotal).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.Unegocio)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("UNegocio");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.Aomizars)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AOMizar_Proyectos");
            });

            modelBuilder.Entity<AomizarDet>(entity =>
            {
                entity.HasKey(e => e.IdMizarDet);

                entity.ToTable("AOMizarDet");

                entity.HasIndex(e => new { e.IdMizar, e.CentrodeCosto }, "IX_AOMizarDet")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.CentrodeCosto)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.HasOne(d => d.IdMizarNavigation)
                    .WithMany(p => p.AomizarDets)
                    .HasForeignKey(d => d.IdMizar)
                    .HasConstraintName("FK_AOMizarDet_AOMizar");
            });

            modelBuilder.Entity<AoplantillasContrato>(entity =>
            {
                entity.HasKey(e => e.IdPlantillaContrato);

                entity.ToTable("AOPlantillasContratos");

                entity.HasIndex(e => e.PlantillaContrato, "IX_AOPlantillasContratos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdPlantillaContrato).HasColumnName("idPlantillaContrato");

                entity.Property(e => e.PlantillaContrato)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ruta)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Texto)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AotipoProyecto>(entity =>
            {
                entity.HasKey(e => e.IdTipoProyecto);

                entity.ToTable("AOTipoProyectos");

                entity.HasIndex(e => e.TipoProyecto, "IX_AOTipoProyectos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Texto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AounidadNegociogeo>(entity =>
            {
                entity.HasKey(e => e.IdUnegociogeo)
                    .HasName("PK_AOUnidadNegocio");

                entity.ToTable("AOUnidadNegociogeo");

                entity.HasIndex(e => e.Unegocio, "IX_AOUnidadNegocio")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdUnegociogeo).HasColumnName("idUNegociogeo");

                entity.Property(e => e.Texto).HasMaxLength(50);

                entity.Property(e => e.Unegocio)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("UNegocio");
            });

            modelBuilder.Entity<BiCatModulo>(entity =>
            {
                entity.HasKey(e => e.IdModulo);

                entity.HasIndex(e => e.Modulo, "IX_BiCatModulos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Modulo)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<BiCatProceso>(entity =>
            {
                entity.HasKey(e => e.IdProceso);

                entity.HasIndex(e => e.Proceso, "IX_BiCatProcesos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Proceso)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<BiHistorico>(entity =>
            {
                entity.HasKey(e => e.IdHistorico)
                    .HasName("PK__BiHistorico__0DF7C08F");

                entity.ToTable("BiHistorico");

                entity.Property(e => e.Detalle)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.BiHistoricos)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BiHistorico_Proyectos");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.BiHistoricos)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BiHistorico_SegUsuarios");
            });

            modelBuilder.Entity<BiHistoricoDet>(entity =>
            {
                entity.HasKey(e => e.IdHistoricoDet);

                entity.ToTable("BiHistoricoDet");

                entity.HasOne(d => d.IdConceptoNavigation)
                    .WithMany(p => p.BiHistoricoDets)
                    .HasForeignKey(d => d.IdConcepto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BiHistoricoDet_AoCatConceptos");

                entity.HasOne(d => d.IdHistoricoNavigation)
                    .WithMany(p => p.BiHistoricoDets)
                    .HasForeignKey(d => d.IdHistorico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BiHistoricoDet_BiHistorico");
            });

            modelBuilder.Entity<BiTabla>(entity =>
            {
                entity.HasKey(e => e.IdTabla);

                entity.ToTable("BiTabla");

                entity.HasIndex(e => e.Tabla, "IX_BiTabla")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Tabla)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bitacora>(entity =>
            {
                entity.HasKey(e => e.IdBitacora);

                entity.ToTable("Bitacora");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.HasOne(d => d.IdModuloNavigation)
                    .WithMany(p => p.Bitacoras)
                    .HasForeignKey(d => d.IdModulo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bitacora_BiCatModulos");

                entity.HasOne(d => d.IdProcesoNavigation)
                    .WithMany(p => p.Bitacoras)
                    .HasForeignKey(d => d.IdProceso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bitacora_BiCatProcesos");

                entity.HasOne(d => d.IdSistemaNavigation)
                    .WithMany(p => p.Bitacoras)
                    .HasForeignKey(d => d.IdSistema)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bitacora_SegSistemas");

                entity.HasOne(d => d.IdTablaNavigation)
                    .WithMany(p => p.Bitacoras)
                    .HasForeignKey(d => d.IdTabla)
                    .HasConstraintName("FK_Bitacora_BiTabla");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Bitacoras)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bitacora_SegUsuarios");
            });

            modelBuilder.Entity<Centro>(entity =>
            {
                entity.HasKey(e => e.IdCentro);

                entity.HasIndex(e => new { e.IdProyecto, e.Centro1 }, "IX_Centros")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdCentro).HasColumnName("idCentro");

                entity.Property(e => e.AceptaMov).HasColumnName("Acepta_Mov");

                entity.Property(e => e.Centro1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Centro");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.IdProyecto).HasColumnName("idProyecto");

                entity.Property(e => e.InicioProgramado).HasColumnType("datetime");

                entity.HasOne(d => d.IdPrototipoNavigation)
                    .WithMany(p => p.Centros)
                    .HasForeignKey(d => d.IdPrototipo)
                    .HasConstraintName("FK_Centros_AoPrototipos");

                entity.HasOne(d => d.IdPrototipoDetNavigation)
                    .WithMany(p => p.Centros)
                    .HasForeignKey(d => d.IdPrototipoDet)
                    .HasConstraintName("FK_Centros_AoPrototiposDet");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.Centros)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Centros_Proyectos");
            });

            modelBuilder.Entity<CrmAddendasCampo>(entity =>
            {
                entity.HasKey(e => e.IdAddendaCampo)
                    .HasName("PK_CrmCamposAddendas");

                entity.Property(e => e.Campo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Receptor)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TipoArchivo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CrmAddendasProducto>(entity =>
            {
                entity.HasKey(e => e.IdAddendaProducto);

                entity.Property(e => e.Campo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CrmFacturasAddendasCampo>(entity =>
            {
                entity.HasKey(e => e.IdFacturaAddendaCampo)
                    .HasName("PK_CrmFacturasCamposAddendas");

                entity.Property(e => e.Campo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Detalle)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdClienteFacturaCv).HasColumnName("IdClienteFacturaCV");

                entity.Property(e => e.IdClienteFacturaNc).HasColumnName("IdClienteFacturaNC");

                entity.Property(e => e.TipoArchivo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClienteFacturaCvNavigation)
                    .WithMany(p => p.CrmFacturasAddendasCampos)
                    .HasForeignKey(d => d.IdClienteFacturaCv)
                    .HasConstraintName("FK_CrmFacturasAddendasCampos_CvClientesFacturas");

                entity.HasOne(d => d.IdClienteFacturaNcNavigation)
                    .WithMany(p => p.CrmFacturasAddendasCampos)
                    .HasForeignKey(d => d.IdClienteFacturaNc)
                    .HasConstraintName("FK_CrmFacturasAddendasCampos_AcClientesFacturasNC");

                entity.HasOne(d => d.IdConstanciaRetencionNavigation)
                    .WithMany(p => p.CrmFacturasAddendasCampos)
                    .HasForeignKey(d => d.IdConstanciaRetencion)
                    .HasConstraintName("FK_CrmFacturasAddendasCampos_AcConstanciasRetenciones");

                entity.HasOne(d => d.IdFacturaNavigation)
                    .WithMany(p => p.CrmFacturasAddendasCampos)
                    .HasForeignKey(d => d.IdFactura)
                    .HasConstraintName("FK_CrmFacturasAddendasCampos_AcClientesFacturas");
            });

            modelBuilder.Entity<CtbAgrupadorSat>(entity =>
            {
                entity.HasKey(e => e.IdAgrupadorSat);

                entity.ToTable("CtbAgrupadorSAT");

                entity.HasIndex(e => e.Agrupador, "IX_CtbAgrupadorSAT")
                    .IsUnique();

                entity.Property(e => e.IdAgrupadorSat).HasColumnName("IdAgrupadorSAT");

                entity.Property(e => e.Agrupador)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionAgrupador)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoAgrupador)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CtbAgrupadorSatn>(entity =>
            {
                entity.HasKey(e => e.IdAgrupadorSatn);

                entity.ToTable("CtbAgrupadorSATN");

                entity.HasIndex(e => e.Agrupador, "IX_CtbAgrupadorSATN")
                    .IsUnique();

                entity.Property(e => e.IdAgrupadorSatn).HasColumnName("IdAgrupadorSATN");

                entity.Property(e => e.Agrupador)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionAgrupador)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Nivel).HasDefaultValueSql("((1))");

                entity.Property(e => e.TipoAgrupador)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CtbCatMetodosPagoSat>(entity =>
            {
                entity.HasKey(e => e.IdMetodoPagoSat);

                entity.ToTable("CtbCatMetodosPagoSAT");

                entity.HasIndex(e => e.ClaveMetodo, "IX_CtbCatMetodosPagoSAT")
                    .IsUnique();

                entity.Property(e => e.IdMetodoPagoSat).HasColumnName("IdMetodoPagoSAT");

                entity.Property(e => e.ClaveMetodo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ConceptoMetodo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CtbCatMonedasSat>(entity =>
            {
                entity.HasKey(e => e.IdCatMonedasSat);

                entity.ToTable("CtbCatMonedasSAT");

                entity.HasIndex(e => e.Clave, "IX_CtbCatMonedasSAT")
                    .IsUnique();

                entity.Property(e => e.IdCatMonedasSat).HasColumnName("IdCatMonedasSAT");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Decimales).HasDefaultValueSql("((2))");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FechaFinVig).HasColumnType("datetime");

                entity.Property(e => e.FechaIniVig).HasColumnType("datetime");

                entity.Property(e => e.PorcentajeVariacion)
                    .HasColumnType("decimal(18, 15)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('v3.2')");
            });

            modelBuilder.Entity<CtbCatTipoImpuesto>(entity =>
            {
                entity.HasKey(e => e.IdTipoImpuesto);

                entity.HasIndex(e => e.Clave, "IX_CtbCatTipoImpuestos")
                    .IsUnique();

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TipoImpuesto)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CtbCatTipoRetencione>(entity =>
            {
                entity.HasKey(e => e.IdTipoRetencion);

                entity.HasIndex(e => e.Clave, "IX_CtbCatTipoRetenciones")
                    .IsUnique();

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Retencion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CtbCatTiposPolizaSat>(entity =>
            {
                entity.HasKey(e => e.IdTipoPolizaSat);

                entity.ToTable("CtbCatTiposPolizaSAT");

                entity.HasIndex(e => e.Tipo, "IX_CtbCatTiposPolizaSAT")
                    .IsUnique();

                entity.Property(e => e.IdTipoPolizaSat).HasColumnName("IdTipoPolizaSAT");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CtbConceptosDiot>(entity =>
            {
                entity.HasKey(e => e.IdConceptoDiot);

                entity.ToTable("CtbConceptosDIOT");

                entity.Property(e => e.IdConceptoDiot)
                    .ValueGeneratedNever()
                    .HasColumnName("IdConceptoDIOT");

                entity.Property(e => e.Concepto)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionCuenta)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MostrarEnCuentas)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<CtbConsecutivosPolizasXanio>(entity =>
            {
                entity.HasKey(e => e.IdConsecutivoPoliza);

                entity.ToTable("CtbConsecutivosPolizasXAnio");

                entity.HasIndex(e => new { e.IdProyecto, e.IdTipoPoliza, e.AnioPoliza }, "IX_CtbConsecutivosPolizasXAnio")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.CtbConsecutivosPolizasXanios)
                    .HasForeignKey(d => d.IdProyecto)
                    .HasConstraintName("FK_CtbConsecutivosPolizasXAnio_Proyectos");

                entity.HasOne(d => d.IdTipoPolizaNavigation)
                    .WithMany(p => p.CtbConsecutivosPolizasXanios)
                    .HasForeignKey(d => d.IdTipoPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CtbConsecutivosPolizasXAnio_CtbTiposPoliza");
            });

            modelBuilder.Entity<CtbConsecutivosPolizasXme>(entity =>
            {
                entity.HasKey(e => e.IdConsecutivoPoliza)
                    .HasName("PK_CtbConsecutivosPolizas");

                entity.ToTable("CtbConsecutivosPolizasXMes");

                entity.HasIndex(e => new { e.IdTipoPoliza, e.MesPoliza, e.IdProyecto }, "IX_CtbConsecutivosPolizas")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.CtbConsecutivosPolizasXmes)
                    .HasForeignKey(d => d.IdProyecto)
                    .HasConstraintName("FK_CtbConsecutivosPolizas_Proyectos");

                entity.HasOne(d => d.IdTipoPolizaNavigation)
                    .WithMany(p => p.CtbConsecutivosPolizasXmes)
                    .HasForeignKey(d => d.IdTipoPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CtbConsecutivosPolizas_CtbTiposPoliza");
            });

            modelBuilder.Entity<CtbConstanciaRetencionDet>(entity =>
            {
                entity.HasKey(e => e.IdConstanciaRetencionDet);

                entity.ToTable("CtbConstanciaRetencionDet");

                entity.HasIndex(e => new { e.IdConstanciaRetencion, e.TipoImpuesto }, "IX_CtbConstanciaRetencionDet");

                entity.Property(e => e.IdConstanciaRetencionDet).ValueGeneratedNever();

                entity.Property(e => e.EsPagoDefinitivo)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MontoBase).HasColumnType("money");

                entity.Property(e => e.MontoRetencion).HasColumnType("money");

                entity.Property(e => e.TipoImpuesto)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdConstanciaRetencionNavigation)
                    .WithMany(p => p.CtbConstanciaRetencionDets)
                    .HasForeignKey(d => d.IdConstanciaRetencion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CtbConstanciaRetencionDet_CtbConstanciaRetenciones");

                entity.HasOne(d => d.TipoImpuestoNavigation)
                    .WithMany(p => p.CtbConstanciaRetencionDets)
                    .HasPrincipalKey(p => p.Clave)
                    .HasForeignKey(d => d.TipoImpuesto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CtbConstanciaRetencionDet_CtbCatTipoImpuestos");
            });

            modelBuilder.Entity<CtbConstanciaRetencione>(entity =>
            {
                entity.HasKey(e => e.IdConstanciaRetencion);

                entity.HasIndex(e => e.Folio, "IX_CtbConstanciaRetenciones")
                    .IsUnique();

                entity.Property(e => e.IdConstanciaRetencion).ValueGeneratedNever();

                entity.Property(e => e.Curp)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CURP");

                entity.Property(e => e.DescripcionRetencion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EsNacional)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaTimbrado).HasColumnType("datetime");

                entity.Property(e => e.Final).HasColumnType("datetime");

                entity.Property(e => e.IdFiscal)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Inicial).HasColumnType("datetime");

                entity.Property(e => e.MensajeValidacion)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.MontoExento).HasColumnType("money");

                entity.Property(e => e.MontoGravado).HasColumnType("money");

                entity.Property(e => e.MontoRetenido).HasColumnType("money");

                entity.Property(e => e.MontoTotal).HasColumnType("money");

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Rfcreceptor)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("RFCReceptor");

                entity.Property(e => e.TipoRetencion)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Xml)
                    .IsUnicode(false)
                    .HasColumnName("XML");

                entity.Property(e => e.Xmlgenerado).HasColumnName("XMLGenerado");

                entity.HasOne(d => d.TipoRetencionNavigation)
                    .WithMany(p => p.CtbConstanciaRetenciones)
                    .HasPrincipalKey(p => p.Clave)
                    .HasForeignKey(d => d.TipoRetencion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CtbConstanciaRetenciones_CtbCatTipoRetenciones");
            });

            modelBuilder.Entity<CtbCuenta>(entity =>
            {
                entity.HasKey(e => e.IdCuenta)
                    .HasName("aaaaaCuentas_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.IdCuentaComplementaria, "IX_CtbCuentas")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Cuenta, "IX_Cuentas")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdCuenta).HasColumnName("idCuenta");

                entity.Property(e => e.AceptaMov)
                    .IsRequired()
                    .HasColumnName("Acepta_Mov")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Agrupador)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cuenta)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.EsCuentaIva).HasColumnName("EsCuentaIVA");

                entity.Property(e => e.IdAgaCatIva).HasColumnName("IdAgaCatIVA");

                entity.Property(e => e.IdAgrupadorSat).HasColumnName("IdAgrupadorSAT");

                entity.Property(e => e.IdConceptoDiot).HasColumnName("IdConceptoDIOT");

                entity.Property(e => e.IdCtaCostoTac).HasColumnName("IdCtaCostoTAC");

                entity.Property(e => e.IdCuentaComplementaria).HasColumnName("idCuentaComplementaria");

                entity.Property(e => e.IdTipoCuenta).HasColumnName("idTipoCuenta");

                entity.Property(e => e.IdTipoMoneda).HasColumnName("idTipoMoneda");

                entity.Property(e => e.SaldoLimiteDeudor).HasColumnType("money");

                entity.Property(e => e.ToparChequeVsSaldo)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdAgaCatIvaNavigation)
                    .WithMany(p => p.CtbCuenta)
                    .HasForeignKey(d => d.IdAgaCatIva)
                    .HasConstraintName("FK_CtbCuentas_AgaCatIVA");

                entity.HasOne(d => d.IdConceptoDiotNavigation)
                    .WithMany(p => p.CtbCuenta)
                    .HasForeignKey(d => d.IdConceptoDiot)
                    .HasConstraintName("FK_CtbCuentas_CtbConceptosDIOT");

                entity.HasOne(d => d.IdCtaCostoTacNavigation)
                    .WithMany(p => p.InverseIdCtaCostoTacNavigation)
                    .HasForeignKey(d => d.IdCtaCostoTac)
                    .HasConstraintName("FK_CtbCuentas_CtbCuentas");

                entity.HasOne(d => d.IdCuentaComplementariaNavigation)
                    .WithMany(p => p.InverseIdCuentaComplementariaNavigation)
                    .HasForeignKey(d => d.IdCuentaComplementaria)
                    .HasConstraintName("FK_Cuentas_Cuentas");

                entity.HasOne(d => d.IdTipoCuentaNavigation)
                    .WithMany(p => p.CtbCuenta)
                    .HasForeignKey(d => d.IdTipoCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cuentas_CtbTiposCuenta");

                entity.HasOne(d => d.IdTipoMonedaNavigation)
                    .WithMany(p => p.CtbCuenta)
                    .HasForeignKey(d => d.IdTipoMoneda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CtbCuentas_AcCatMonedas");
            });

            modelBuilder.Entity<CtbCuentasDiot>(entity =>
            {
                entity.HasKey(e => e.IdCuentaDiot);

                entity.ToTable("CtbCuentasDIOT");

                entity.HasIndex(e => e.IdCuenta, "IX_CtbCuentasDIOT")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdCuentaDiot).HasColumnName("IdCuentaDIOT");

                entity.Property(e => e.ColumnaDiot).HasColumnName("ColumnaDIOT");

                entity.Property(e => e.EsIvaAcreditable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithOne(p => p.CtbCuentasDiot)
                    .HasForeignKey<CtbCuentasDiot>(d => d.IdCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CtbCuentasDIOT_CtbCuentas");
            });

            modelBuilder.Entity<CtbDiottipoOperacion>(entity =>
            {
                entity.HasKey(e => e.IdTipoOperacion);

                entity.ToTable("CtbDIOTTipoOperacion");

                entity.HasIndex(e => e.TipoOperacion, "IX_CtbDIOTTipoOperacion")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdTipoOperacion).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TipoOperacion)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CtbDiottipoTercero>(entity =>
            {
                entity.HasKey(e => e.IdTipoTerceros);

                entity.ToTable("CtbDIOTTipoTerceros");

                entity.Property(e => e.IdTipoTerceros).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TipoTerceros)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CtbPoliza>(entity =>
            {
                entity.HasKey(e => e.IdPoliza)
                    .HasName("aaaaaCtbMtoPolizas_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.IdTipoPoliza, "CtbTiposPolizaCtbMtoPolizas")
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.MesPoliza, e.IdTipoPoliza, e.NumPoliza, e.IdCuentaBancaria, e.IdProyecto }, "IX_CtbPolizas")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdPoliza).HasColumnName("idPoliza");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EsAutomatica)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaConciliacion).HasColumnType("datetime");

                entity.Property(e => e.FechaFactura).HasColumnType("datetime");

                entity.Property(e => e.FechaImportadoDalton).HasColumnType("datetime");

                entity.Property(e => e.FechaUltimaModificacion).HasColumnType("datetime");

                entity.Property(e => e.GeneradaCanceladaToSap).HasColumnName("GeneradaCanceladaToSAP");

                entity.Property(e => e.GeneradaToSap).HasColumnName("GeneradaToSAP");

                entity.Property(e => e.IdPolizaOrigen).HasColumnName("idPolizaOrigen");

                entity.Property(e => e.IdTipoPoliza).HasColumnName("idTipoPoliza");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.IntGenencabezadoPolizaKey).HasColumnName("intGENEncabezadoPolizaKey");

                entity.HasOne(d => d.IdCuentaBancariaNavigation)
                    .WithMany(p => p.CtbPolizas)
                    .HasForeignKey(d => d.IdCuentaBancaria)
                    .HasConstraintName("FK_CtbPolizas_AcCuentasBancarias");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.CtbPolizas)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CtbPolizas_Proyectos");

                entity.HasOne(d => d.IdTipoPolizaNavigation)
                    .WithMany(p => p.CtbPolizas)
                    .HasForeignKey(d => d.IdTipoPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CtbPolizas_CtbTiposPoliza");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.CtbPolizas)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CtbPolizas_SegUsuarios");
            });

            modelBuilder.Entity<CtbPolizasDet>(entity =>
            {
                entity.HasKey(e => e.IdPolizaDet)
                    .HasName("PK_CtbDetPolizas");

                entity.ToTable("CtbPolizasDet");

                entity.HasIndex(e => e.IdPoliza, "IX_CtbPolizasDet")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuenta, "IX_CtbPolizasDet_1")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdProyecto, "IX_CtbPolizasDet_idProyecto");

                entity.Property(e => e.IdPolizaDet).HasColumnName("idPolizaDet");

                entity.Property(e => e.Abono).HasColumnType("money");

                entity.Property(e => e.Cargo).HasColumnType("money");

                entity.Property(e => e.EsAutomatica)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaProbablePago).HasColumnType("datetime");

                entity.Property(e => e.IdCuenta).HasColumnName("idCuenta");

                entity.Property(e => e.IdPoliza).HasColumnName("idPoliza");

                entity.Property(e => e.MonedaSat)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MonedaSAT")
                    .HasDefaultValueSql("('MXN')");

                entity.Property(e => e.MontoIetu)
                    .HasColumnType("money")
                    .HasColumnName("MontoIETU");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCambioSat)
                    .HasColumnType("money")
                    .HasColumnName("TipoCambioSAT")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdClienteAntilavadoNavigation)
                    .WithMany(p => p.CtbPolizasDets)
                    .HasForeignKey(d => d.IdClienteAntilavado)
                    .HasConstraintName("FK_CtbPolizasDet_AcClientesAntilavado");

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithMany(p => p.CtbPolizasDets)
                    .HasForeignKey(d => d.IdCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CtbDetPolizas_FK01");

                entity.HasOne(d => d.IdFlujoNavigation)
                    .WithMany(p => p.CtbPolizasDets)
                    .HasForeignKey(d => d.IdFlujo)
                    .HasConstraintName("FK_CtbPolizasDet_AcCatFlujos");

                entity.HasOne(d => d.IdPolizaNavigation)
                    .WithMany(p => p.CtbPolizasDets)
                    .HasForeignKey(d => d.IdPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CtbDetPolizas_FK00");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.CtbPolizasDets)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CtbPolizasDet_Proyectos");
            });

            modelBuilder.Entity<CtbPolizasDetAp>(entity =>
            {
                entity.HasKey(e => e.IdPolizaDetAp);

                entity.ToTable("CtbPolizasDetAP");

                entity.HasIndex(e => new { e.IdPolizaDetCargo, e.IdPolizaDetAbono }, "IX_CtbPolizasDetAP")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdPolizaDetAbono, "IX_CtbPolizasDetAP_1")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdPolizaDetCargo, "IX_CtbPolizasDetAP_2")
                    .HasFillFactor(90);

                entity.Property(e => e.IdPolizaDetAp).HasColumnName("IdPolizaDetAP");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.HasOne(d => d.IdPolizaDetAbonoNavigation)
                    .WithMany(p => p.CtbPolizasDetApIdPolizaDetAbonoNavigations)
                    .HasForeignKey(d => d.IdPolizaDetAbono)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CtbPolizasDetAP_CtbPolizasDet1");

                entity.HasOne(d => d.IdPolizaDetCargoNavigation)
                    .WithMany(p => p.CtbPolizasDetApIdPolizaDetCargoNavigations)
                    .HasForeignKey(d => d.IdPolizaDetCargo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CtbPolizasDetAP_CtbPolizasDet");

                entity.HasOne(d => d.IdUsuarioAutorizoNavigation)
                    .WithMany(p => p.CtbPolizasDetApIdUsuarioAutorizoNavigations)
                    .HasForeignKey(d => d.IdUsuarioAutorizo)
                    .HasConstraintName("FK_CtbPolizasDetAP_SegUsuarios");

                entity.HasOne(d => d.IdUsuarioEmitioChequeNavigation)
                    .WithMany(p => p.CtbPolizasDetApIdUsuarioEmitioChequeNavigations)
                    .HasForeignKey(d => d.IdUsuarioEmitioCheque)
                    .HasConstraintName("FK_CtbPolizasDetAP_SegUsuarios2");

                entity.HasOne(d => d.IdUsuarioManualNavigation)
                    .WithMany(p => p.CtbPolizasDetApIdUsuarioManualNavigations)
                    .HasForeignKey(d => d.IdUsuarioManual)
                    .HasConstraintName("FK_CtbPolizasDetAP_SegUsuarios1");
            });

            modelBuilder.Entity<CtbPolizasDetCheque>(entity =>
            {
                entity.HasKey(e => e.IdPolizaDetCheque);

                entity.Property(e => e.BancoOrigen)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Beneficiario)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaOrigen)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdPolizaDet).HasColumnName("idPolizaDet");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.NumeroCheque)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("RFC");
            });

            modelBuilder.Entity<CtbPolizasDetCliente>(entity =>
            {
                entity.HasKey(e => e.IdPolizaDetCliente);

                entity.HasIndex(e => new { e.IdPolizaDet, e.IdClienteFactura }, "IX_CtbPolizasDetClientes")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdClienteFactura, "IX_CtbPolizasDetClientes_1")
                    .HasFillFactor(90);

                entity.Property(e => e.IdPolizaDet).HasColumnName("idPolizaDet");

                entity.HasOne(d => d.IdClienteFacturaNavigation)
                    .WithMany(p => p.CtbPolizasDetClientes)
                    .HasForeignKey(d => d.IdClienteFactura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CtbPolizasDetClientes_AcClientesFacturas");

                entity.HasOne(d => d.IdPolizaDetNavigation)
                    .WithMany(p => p.CtbPolizasDetClientes)
                    .HasForeignKey(d => d.IdPolizaDet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CtbPolizasDetClientes_CtbPolizasDet");
            });

            modelBuilder.Entity<CtbPolizasDetCompExt>(entity =>
            {
                entity.HasKey(e => e.IdPolizaDetCompExt);

                entity.ToTable("CtbPolizasDetCompExt");

                entity.HasIndex(e => e.IdPolizaDet, "IX_CtbPolizasDetCompExt");

                entity.HasIndex(e => e.NumFactExt, "IX_CtbPolizasDetCompExt_1");

                entity.Property(e => e.Moneda)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MXN')");

                entity.Property(e => e.MontoTotal).HasColumnType("money");

                entity.Property(e => e.NumFactExt)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.TaxId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("TaxID");

                entity.Property(e => e.TipCamb)
                    .HasColumnType("decimal(18, 5)")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdPolizaDetNavigation)
                    .WithMany(p => p.CtbPolizasDetCompExts)
                    .HasForeignKey(d => d.IdPolizaDet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CtbPolizasDetCompExt_CtbPolizasDet");
            });

            modelBuilder.Entity<CtbPolizasDetCompNal>(entity =>
            {
                entity.HasKey(e => e.IdPolizaDetCompNal)
                    .HasName("PK_ctbPolizasDetCompNal");

                entity.ToTable("CtbPolizasDetCompNal");

                entity.HasIndex(e => e.IdPolizaDet, "IX_ctbPolizasDetCompNal");

                entity.HasIndex(e => e.UuidCfdi, "IX_ctbPolizasDetCompNal_1");

                entity.HasIndex(e => e.Rfc, "IX_ctbPolizasDetCompNal_2");

                entity.Property(e => e.Moneda)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MXN')");

                entity.Property(e => e.MontoTotal).HasColumnType("money");

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("RFC");

                entity.Property(e => e.TipCamb)
                    .HasColumnType("decimal(18, 5)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UuidCfdi)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UUID_CFDI");

                entity.HasOne(d => d.IdPolizaDetNavigation)
                    .WithMany(p => p.CtbPolizasDetCompNals)
                    .HasForeignKey(d => d.IdPolizaDet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ctbPolizasDetCompNal_CtbPolizasDet");
            });

            modelBuilder.Entity<CtbPolizasDetCompNalOtr>(entity =>
            {
                entity.HasKey(e => e.IdPolizaDetCompNalOtr);

                entity.ToTable("CtbPolizasDetCompNalOtr");

                entity.HasIndex(e => e.IdPolizaDet, "IX_CtbPolizasDetCompNalOtr");

                entity.HasIndex(e => e.Rfc, "IX_CtbPolizasDetCompNalOtr_1");

                entity.Property(e => e.CfdCbbNumFol)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CFD_CBB_NumFol");

                entity.Property(e => e.CfdCbbSerie)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CFD_CBB_Serie");

                entity.Property(e => e.Moneda)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MXN')");

                entity.Property(e => e.MontoTotal).HasColumnType("money");

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("RFC");

                entity.Property(e => e.TipCamb)
                    .HasColumnType("decimal(18, 5)")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdPolizaDetNavigation)
                    .WithMany(p => p.CtbPolizasDetCompNalOtrs)
                    .HasForeignKey(d => d.IdPolizaDet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CtbPolizasDetCompNalOtr_CtbPolizasDet");
            });

            modelBuilder.Entity<CtbPolizasDetComprobante>(entity =>
            {
                entity.HasKey(e => e.IdPolizaDetComprobante);

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("RFC");

                entity.Property(e => e.Uuid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UUID");
            });

            modelBuilder.Entity<CtbPolizasDetDc>(entity =>
            {
                entity.HasKey(e => e.IdPolizaDetDc);

                entity.ToTable("CtbPolizasDetDC");

                entity.HasIndex(e => new { e.IdPolizaDetAbono, e.IdPolizaDetCargo }, "IX_CtbPolizasDetDC")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdPolizaDetAbono, "IX_CtbPolizasDetDC_1")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdPolizaDetCargo, "IX_CtbPolizasDetDC_2")
                    .HasFillFactor(90);

                entity.Property(e => e.IdPolizaDetDc).HasColumnName("IdPolizaDetDC");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.HasOne(d => d.IdPolizaDetAbonoNavigation)
                    .WithMany(p => p.CtbPolizasDetDcIdPolizaDetAbonoNavigations)
                    .HasForeignKey(d => d.IdPolizaDetAbono)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CtbPolizasDetDC_CtbPolizasDet");

                entity.HasOne(d => d.IdPolizaDetCargoNavigation)
                    .WithMany(p => p.CtbPolizasDetDcIdPolizaDetCargoNavigations)
                    .HasForeignKey(d => d.IdPolizaDetCargo)
                    .HasConstraintName("FK_CtbPolizasDetDC_CtbPolizasDet1");

                entity.HasOne(d => d.IdUsuarioManualNavigation)
                    .WithMany(p => p.CtbPolizasDetDcs)
                    .HasForeignKey(d => d.IdUsuarioManual)
                    .HasConstraintName("FK_CtbPolizasDetDC_SegUsuarios");
            });

            modelBuilder.Entity<CtbPolizasDetNodoCheque>(entity =>
            {
                entity.HasKey(e => e.IdPolizaDetNodoCheque);

                entity.HasIndex(e => e.Rfc, "IX_CtbPolizasDetNodoCheques");

                entity.HasIndex(e => e.BanEmisNal, "IX_CtbPolizasDetNodoCheques_1");

                entity.Property(e => e.BanEmisExt)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BanEmisNal)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Benef)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CtaOri)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Moneda)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MXN')");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.Num)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("RFC");

                entity.Property(e => e.TipCamb)
                    .HasColumnType("decimal(18, 5)")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdPolizaDetNavigation)
                    .WithMany(p => p.CtbPolizasDetNodoCheques)
                    .HasForeignKey(d => d.IdPolizaDet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CtbPolizasDetNodoCheques_CtbPolizasDet");
            });

            modelBuilder.Entity<CtbPolizasDetNodoOtrMetodosPago>(entity =>
            {
                entity.HasKey(e => e.IdPolizaDetNodoOtrMetodoPago);

                entity.ToTable("CtbPolizasDetNodoOtrMetodosPago");

                entity.HasIndex(e => e.Rfc, "IX_CtbPolizasDetNodoOtrMetodosPago");

                entity.HasIndex(e => e.MetPagoPol, "IX_CtbPolizasDetNodoOtrMetodosPago_1");

                entity.Property(e => e.Benef)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.MetPagoPol)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Moneda)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MXN')");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("RFC");

                entity.Property(e => e.TipCamb)
                    .HasColumnType("decimal(18, 5)")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdPolizaDetNavigation)
                    .WithMany(p => p.CtbPolizasDetNodoOtrMetodosPagos)
                    .HasForeignKey(d => d.IdPolizaDet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CtbPolizasDetNodoOtrMetodosPago_CtbPolizasDet");
            });

            modelBuilder.Entity<CtbPolizasDetNodoTransferencia>(entity =>
            {
                entity.HasKey(e => e.IdPolizaDetNodoTransferencia);

                entity.HasIndex(e => e.Rfc, "IX_CtbPolizasDetNodoTransferencias");

                entity.HasIndex(e => e.BancoOriNal, "IX_CtbPolizasDetNodoTransferencias_1");

                entity.Property(e => e.BancoDestExt)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BancoDestNal)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.BancoOriExt)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BancoOriNal)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Benef)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CtaDest)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CtaOri)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Moneda)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MXN')");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("RFC");

                entity.Property(e => e.TipCamb)
                    .HasColumnType("decimal(18, 5)")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdPolizaDetNavigation)
                    .WithMany(p => p.CtbPolizasDetNodoTransferencia)
                    .HasForeignKey(d => d.IdPolizaDet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CtbPolizasDetNodoTransferencias_CtbPolizasDet");
            });

            modelBuilder.Entity<CtbPolizasDetPp>(entity =>
            {
                entity.HasKey(e => e.IdPolizaDetPp);

                entity.ToTable("CtbPolizasDetPP");

                entity.HasIndex(e => new { e.IdCuentaProveedor, e.IdPolizaDetAbono }, "IX_CtbPolizasDetPP")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuentaProveedor, "IX_CtbPolizasDetPP_1")
                    .HasFillFactor(90);

                entity.Property(e => e.IdPolizaDetPp).HasColumnName("IdPolizaDetPP");

                entity.Property(e => e.MontoApagar)
                    .HasColumnType("money")
                    .HasColumnName("MontoAPagar");

                entity.HasOne(d => d.IdBancoEgresoNavigation)
                    .WithMany(p => p.CtbPolizasDetPps)
                    .HasForeignKey(d => d.IdBancoEgreso)
                    .HasConstraintName("FK_CtbPolizasDetPP_AcBancosEgresos");

                entity.HasOne(d => d.IdCuentaProveedorNavigation)
                    .WithMany(p => p.CtbPolizasDetPps)
                    .HasForeignKey(d => d.IdCuentaProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CtbPolizasDetPP_CtbCuentas");

                entity.HasOne(d => d.IdPolizaDetAbonoNavigation)
                    .WithMany(p => p.CtbPolizasDetPps)
                    .HasForeignKey(d => d.IdPolizaDetAbono)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CtbPolizasDetPP_CtbPolizasDet");

                entity.HasOne(d => d.IdUsuarioAutorizoNavigation)
                    .WithMany(p => p.CtbPolizasDetPps)
                    .HasForeignKey(d => d.IdUsuarioAutorizo)
                    .HasConstraintName("FK_CtbPolizasDetPP_SegUsuarios");
            });

            modelBuilder.Entity<CtbPolizasDetTransferencia>(entity =>
            {
                entity.HasKey(e => e.IdPolizaDetTransferencia)
                    .HasName("PK_CtbPolizasDetTransferencia");

                entity.Property(e => e.BancoDestino)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.BancoOrigen)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Beneficiario)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaDestino)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaOrigen)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdPolizaDet).HasColumnName("idPolizaDet");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("RFC");
            });

            modelBuilder.Entity<CtbPolizasDiot>(entity =>
            {
                entity.HasKey(e => e.IdPolizaDiot)
                    .HasName("PK_CtbPolizasDetDIOT");

                entity.ToTable("CtbPolizasDIOT");

                entity.HasIndex(e => e.IdPolizaDetAbono, "IX_CtbPolizasDIOT")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuentaProveedor, "IX_CtbPolizasDIOT_1")
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.IdPoliza, e.IdCuentaProveedor, e.IdConceptoDiot }, "IX_CtbPolizasDetDIOT")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdPolizaDiot).HasColumnName("IdPolizaDIOT");

                entity.Property(e => e.IdConceptoDiot).HasColumnName("IdConceptoDIOT");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.MontoIva)
                    .HasColumnType("money")
                    .HasColumnName("MontoIVA");

                entity.HasOne(d => d.IdConceptoDiotNavigation)
                    .WithMany(p => p.CtbPolizasDiots)
                    .HasForeignKey(d => d.IdConceptoDiot)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CtbPolizasDetDIOT_CtbConceptosDIOT");

                entity.HasOne(d => d.IdCuentaProveedorNavigation)
                    .WithMany(p => p.CtbPolizasDiots)
                    .HasForeignKey(d => d.IdCuentaProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CtbPolizasDetDIOT_CtbCuentas");

                entity.HasOne(d => d.IdPolizaNavigation)
                    .WithMany(p => p.CtbPolizasDiots)
                    .HasForeignKey(d => d.IdPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CtbPolizasDetDIOT_CtbPolizas");
            });

            modelBuilder.Entity<CtbPolizasIetu>(entity =>
            {
                entity.HasKey(e => e.IdPolizaIetu);

                entity.ToTable("CtbPolizasIETU");

                entity.HasIndex(e => e.IdPolizaDet, "IX_CtbPolizasIETU")
                    .HasFillFactor(90);

                entity.Property(e => e.IdPolizaIetu).HasColumnName("IdPolizaIETU");

                entity.Property(e => e.MontoIvaTrasladado).HasColumnType("money");

                entity.Property(e => e.MontoIvaacreditable10)
                    .HasColumnType("money")
                    .HasColumnName("MontoIVAAcreditable10");

                entity.Property(e => e.MontoIvaacreditable15)
                    .HasColumnType("money")
                    .HasColumnName("MontoIVAAcreditable15");

                entity.Property(e => e.MontoIvanoAcreditable10)
                    .HasColumnType("money")
                    .HasColumnName("MontoIVANoAcreditable10");

                entity.Property(e => e.MontoIvanoAcreditable15)
                    .HasColumnType("money")
                    .HasColumnName("MontoIVANoAcreditable15");

                entity.Property(e => e.MontoIvaretenido)
                    .HasColumnType("money")
                    .HasColumnName("MontoIVARetenido");

                entity.Property(e => e.OrigenIetu)
                    .HasColumnName("OrigenIETU")
                    .HasDefaultValueSql("((2))");

                entity.HasOne(d => d.IdPolizaDetNavigation)
                    .WithMany(p => p.CtbPolizasIetus)
                    .HasForeignKey(d => d.IdPolizaDet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CtbPolizasIETU_CtbPolizasDet");
            });

            modelBuilder.Entity<CtbPolizasIetuconcepto>(entity =>
            {
                entity.HasKey(e => e.IdPolizaIetuconcepto);

                entity.ToTable("CtbPolizasIETUConceptos");

                entity.HasIndex(e => new { e.IdPolizaDet, e.IdConceptoIetu }, "IX_CtbPolizasIETUConceptos")
                    .IsUnique();

                entity.Property(e => e.IdPolizaIetuconcepto).HasColumnName("IdPolizaIETUConcepto");

                entity.Property(e => e.IdConceptoIetu).HasColumnName("IdConceptoIETU");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.HasOne(d => d.IdConceptoIetuNavigation)
                    .WithMany(p => p.CtbPolizasIetuconceptos)
                    .HasForeignKey(d => d.IdConceptoIetu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CtbPolizasIETUConceptos_AcCatConceptosIETU");

                entity.HasOne(d => d.IdPolizaDetNavigation)
                    .WithMany(p => p.CtbPolizasIetuconceptos)
                    .HasForeignKey(d => d.IdPolizaDet)
                    .HasConstraintName("FK_CtbPolizasIETUConceptos_CtbPolizasDet");
            });

            modelBuilder.Entity<CtbPrefijo>(entity =>
            {
                entity.HasKey(e => e.IdPrefijo);

                entity.HasIndex(e => e.Prefijo, "IX_CtbPrefijos")
                    .IsUnique();

                entity.Property(e => e.NombreBase)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Prefijo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RutaArchivo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CtbSaldoXflujo>(entity =>
            {
                entity.HasKey(e => e.IdSaldoXflujo);

                entity.ToTable("ctbSaldoXFlujo");

                entity.HasIndex(e => new { e.IdFlujo, e.IdProyecto, e.IdCuentaBancaria }, "IX_ctbSaldoXFlujo")
                    .IsUnique();

                entity.Property(e => e.IdSaldoXflujo).HasColumnName("idSaldoXFlujo");

                entity.Property(e => e.Fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.IdCuentaBancaria).HasColumnName("idCuentaBancaria");

                entity.Property(e => e.IdFlujo).HasColumnName("idFlujo");

                entity.Property(e => e.IdProyecto).HasColumnName("idProyecto");

                entity.Property(e => e.Saldo).HasColumnType("money");

                entity.HasOne(d => d.IdCuentaBancariaNavigation)
                    .WithMany(p => p.CtbSaldoXflujos)
                    .HasForeignKey(d => d.IdCuentaBancaria)
                    .HasConstraintName("FK_ctbSaldoXFlujo_AcCuentasBancarias");

                entity.HasOne(d => d.IdFlujoNavigation)
                    .WithMany(p => p.CtbSaldoXflujos)
                    .HasForeignKey(d => d.IdFlujo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ctbSaldoXFlujo_AcCatFlujos");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.CtbSaldoXflujos)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ctbSaldoXFlujo_Proyectos");
            });

            modelBuilder.Entity<CtbSaldosCuentasProyecto>(entity =>
            {
                entity.HasKey(e => e.IdSaldoEjercicio)
                    .HasName("PK_ctbSaldosCuentasCC");

                entity.ToTable("ctbSaldosCuentasProyecto");

                entity.HasIndex(e => e.IdCuenta, "IX_ctbSaldosCuentasProyecto")
                    .HasFillFactor(90);

                entity.Property(e => e.IdSaldoEjercicio).HasColumnName("idSaldoEjercicio");

                entity.Property(e => e.IdCuenta).HasColumnName("idCuenta");

                entity.Property(e => e.Saldo).HasColumnType("money");

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithMany(p => p.CtbSaldosCuentasProyectos)
                    .HasForeignKey(d => d.IdCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ctbSaldosCuentasCC_Cuentas");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.CtbSaldosCuentasProyectos)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ctbSaldosCuentasProyecto_Proyectos");
            });

            modelBuilder.Entity<CtbTiposCuentum>(entity =>
            {
                entity.HasKey(e => e.IdTipoCuenta);

                entity.HasIndex(e => new { e.TipoCuenta, e.SubTipoCuenta }, "IX_CtbTiposCuenta")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdTipoCuenta).HasColumnName("idTipoCuenta");

                entity.Property(e => e.CuentaFinal)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaInicial)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Naturaleza).HasColumnName("naturaleza");

                entity.Property(e => e.Operador)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SubTipoCuenta)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Texto)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TextoSubtipo)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCuenta)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TiposDeUtilidad)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CtbTiposPoliza>(entity =>
            {
                entity.HasKey(e => e.IdTipoPoliza);

                entity.ToTable("CtbTiposPoliza");

                entity.HasIndex(e => e.TipoPoliza, "IX_CtbTiposPoliza")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdTipoPoliza).HasColumnName("idTipoPoliza");

                entity.Property(e => e.IdTipoPolizaSat).HasColumnName("IdTipoPolizaSAT");

                entity.Property(e => e.Texto)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("texto");

                entity.Property(e => e.TipoPoliza)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoPolizaSatNavigation)
                    .WithMany(p => p.CtbTiposPolizas)
                    .HasForeignKey(d => d.IdTipoPolizaSat)
                    .HasConstraintName("FK_CtbTiposPoliza_CtbCatTiposPolizaSAT");
            });

            modelBuilder.Entity<CvAccesorio>(entity =>
            {
                entity.HasKey(e => e.IdAccesorio);

                entity.HasIndex(e => e.Accesorio, "In_CvAccesoriosAccesorio")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Accesorio)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Partida).HasMaxLength(30);

                entity.Property(e => e.Texto)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasDefaultValueSql("('DESCRIPCION')");

                entity.Property(e => e.Unidad)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'UNIDAD')");
            });

            modelBuilder.Entity<CvAjusteCliente>(entity =>
            {
                entity.HasKey(e => e.IdAjusteCliente)
                    .HasName("PK_CvPasivosCliente");

                entity.HasIndex(e => e.Folio, "IX_CvAjusteClientes")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.DescripcionCancelacion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaCancelacion).HasColumnType("smalldatetime");

                entity.Property(e => e.MontoContrato).HasColumnType("money");

                entity.Property(e => e.MontoDevolucion).HasColumnType("money");

                entity.Property(e => e.MontoDevolucionesAnteriores).HasColumnType("money");

                entity.Property(e => e.MontoEscritura).HasColumnType("money");

                entity.Property(e => e.MontoIvaTrasladadoPorAplicar).HasColumnType("money");

                entity.Property(e => e.MontoNotasCargo).HasColumnType("money");

                entity.Property(e => e.MontoNotasCredito).HasColumnType("money");

                entity.Property(e => e.MontoPagado).HasColumnType("money");

                entity.HasOne(d => d.IdClienteEscrituracionNavigation)
                    .WithMany(p => p.CvAjusteClientes)
                    .HasForeignKey(d => d.IdClienteEscrituracion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvPasivosCliente_CvClienteEscrituracion");

                entity.HasOne(d => d.IdPolizaNavigation)
                    .WithMany(p => p.CvAjusteClienteIdPolizaNavigations)
                    .HasForeignKey(d => d.IdPoliza)
                    .HasConstraintName("FK_CvPasivosCliente_CtbMtoPolizas");

                entity.HasOne(d => d.IdPolizaInversaNavigation)
                    .WithMany(p => p.CvAjusteClienteIdPolizaInversaNavigations)
                    .HasForeignKey(d => d.IdPolizaInversa)
                    .HasConstraintName("FK_CvPasivosCliente_CtbMtoPolizas1");
            });

            modelBuilder.Entity<CvApartado>(entity =>
            {
                entity.HasKey(e => e.IdApartado);

                entity.HasIndex(e => e.FolioApartado, "IX_CvApartados")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.DescripcionCancelacion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaCancelacion).HasColumnType("smalldatetime");

                entity.Property(e => e.MontoApartado).HasColumnType("money");

                entity.Property(e => e.Paridad)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.CvApartados)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvApartados_CvClientes");

                entity.HasOne(d => d.IdDepositoNavigation)
                    .WithMany(p => p.CvApartados)
                    .HasForeignKey(d => d.IdDeposito)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvApartados_CvDepositosCliente");

                entity.HasOne(d => d.IdPolizaNavigation)
                    .WithMany(p => p.CvApartadoIdPolizaNavigations)
                    .HasForeignKey(d => d.IdPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvApartados_CtbMtoPolizas");

                entity.HasOne(d => d.IdPolizaInversaNavigation)
                    .WithMany(p => p.CvApartadoIdPolizaInversaNavigations)
                    .HasForeignKey(d => d.IdPolizaInversa)
                    .HasConstraintName("FK_CvApartados_CtbMtoPolizas1");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.CvApartados)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvApartados_Proyectos");
            });

            modelBuilder.Entity<CvAplicacionApartado>(entity =>
            {
                entity.HasKey(e => e.IdAplicacionApartado);

                entity.Property(e => e.DescripcionCancelacion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAplicacion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaCancelacion).HasColumnType("smalldatetime");

                entity.Property(e => e.MontoAbonoCapital).HasColumnType("money");

                entity.Property(e => e.MontoDocumento).HasColumnType("money");

                entity.Property(e => e.MontoExcedente).HasColumnType("money");

                entity.Property(e => e.MontoGastosAdicionales).HasColumnType("money");

                entity.Property(e => e.MontoInteres).HasColumnType("money");

                entity.Property(e => e.MontoIvaExcedente).HasColumnType("money");

                entity.Property(e => e.MontoIvadocumento)
                    .HasColumnType("money")
                    .HasColumnName("MontoIVADocumento");

                entity.Property(e => e.MontoIvamoratorio)
                    .HasColumnType("money")
                    .HasColumnName("MontoIVAMoratorio");

                entity.Property(e => e.MontoMoratorio).HasColumnType("money");

                entity.Property(e => e.Paridad)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdAjusteClienteNavigation)
                    .WithMany(p => p.CvAplicacionApartados)
                    .HasForeignKey(d => d.IdAjusteCliente)
                    .HasConstraintName("FK_CvAplicacionApartados_CvAjusteClientes");

                entity.HasOne(d => d.IdApartadoNavigation)
                    .WithMany(p => p.CvAplicacionApartados)
                    .HasForeignKey(d => d.IdApartado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvAplicacionApartados_CvApartados");

                entity.HasOne(d => d.IdContratoNavigation)
                    .WithMany(p => p.CvAplicacionApartados)
                    .HasForeignKey(d => d.IdContrato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvAplicacionApartados_CvContratos");

                entity.HasOne(d => d.IdPolizaNavigation)
                    .WithMany(p => p.CvAplicacionApartadoIdPolizaNavigations)
                    .HasForeignKey(d => d.IdPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvAplicacionApartados_CtbMtoPolizas");

                entity.HasOne(d => d.IdPolizaInversaNavigation)
                    .WithMany(p => p.CvAplicacionApartadoIdPolizaInversaNavigations)
                    .HasForeignKey(d => d.IdPolizaInversa)
                    .HasConstraintName("FK_CvAplicacionApartados_CtbMtoPolizas1");
            });

            modelBuilder.Entity<CvAplicacionApartadosDet>(entity =>
            {
                entity.HasKey(e => e.IdAplicacionApartadoDet);

                entity.ToTable("CvAplicacionApartadosDet");

                entity.Property(e => e.MontoAbonoCapital).HasColumnType("money");

                entity.Property(e => e.MontoAbonoCapitalBase).HasColumnType("money");

                entity.Property(e => e.MontoBase).HasColumnType("money");

                entity.Property(e => e.MontoDocumento).HasColumnType("money");

                entity.Property(e => e.MontoGastosAdicionales).HasColumnType("money");

                entity.Property(e => e.MontoGastosAdicionalesBase).HasColumnType("money");

                entity.Property(e => e.MontoInteres).HasColumnType("money");

                entity.Property(e => e.MontoInteresBase).HasColumnType("money");

                entity.Property(e => e.MontoIvaDocumentoBase).HasColumnType("money");

                entity.Property(e => e.MontoIvadocumento)
                    .HasColumnType("money")
                    .HasColumnName("MontoIVADocumento");

                entity.Property(e => e.MontoIvamoratorio)
                    .HasColumnType("money")
                    .HasColumnName("MontoIVAMoratorio");

                entity.Property(e => e.MontoMoratorio).HasColumnType("money");

                entity.HasOne(d => d.IdAplicacionApartadoNavigation)
                    .WithMany(p => p.CvAplicacionApartadosDets)
                    .HasForeignKey(d => d.IdAplicacionApartado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvAplicacionApartadosDet_CvAplicacionApartados");

                entity.HasOne(d => d.IdPlanPagoDetNavigation)
                    .WithMany(p => p.CvAplicacionApartadosDets)
                    .HasForeignKey(d => d.IdPlanPagoDet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvAplicacionApartadosDet_CvPlanesPagosDet");
            });

            modelBuilder.Entity<CvAplicacionDeposito>(entity =>
            {
                entity.HasKey(e => e.IdAplicacionDeposito);

                entity.Property(e => e.DescripcionCancelacion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAplicacion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaCancelacion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaUltimaImpresion).HasColumnType("smalldatetime");

                entity.Property(e => e.MontoAbonoCapital).HasColumnType("money");

                entity.Property(e => e.MontoDocumento).HasColumnType("money");

                entity.Property(e => e.MontoExcedente).HasColumnType("money");

                entity.Property(e => e.MontoGastosAdicionales).HasColumnType("money");

                entity.Property(e => e.MontoInteres).HasColumnType("money");

                entity.Property(e => e.MontoIvaExcedente).HasColumnType("money");

                entity.Property(e => e.MontoIvadocumento)
                    .HasColumnType("money")
                    .HasColumnName("MontoIVADocumento");

                entity.Property(e => e.MontoIvamoratorio)
                    .HasColumnType("money")
                    .HasColumnName("MontoIVAMoratorio");

                entity.Property(e => e.MontoMoratorio).HasColumnType("money");

                entity.Property(e => e.Paridad)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdAjusteClienteNavigation)
                    .WithMany(p => p.CvAplicacionDepositos)
                    .HasForeignKey(d => d.IdAjusteCliente)
                    .HasConstraintName("FK_CvAplicacionDepositos_CvAjusteClientes");

                entity.HasOne(d => d.IdContratoNavigation)
                    .WithMany(p => p.CvAplicacionDepositos)
                    .HasForeignKey(d => d.IdContrato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvAplicacionDepositos_CvContratos");

                entity.HasOne(d => d.IdDepositoNavigation)
                    .WithMany(p => p.CvAplicacionDepositos)
                    .HasForeignKey(d => d.IdDeposito)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvAplicacionDepositos_CvDepositosCliente");

                entity.HasOne(d => d.IdPolizaNavigation)
                    .WithMany(p => p.CvAplicacionDepositoIdPolizaNavigations)
                    .HasForeignKey(d => d.IdPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvAplicacionDepositos_CtbMtoPolizas");

                entity.HasOne(d => d.IdPolizaInversaNavigation)
                    .WithMany(p => p.CvAplicacionDepositoIdPolizaInversaNavigations)
                    .HasForeignKey(d => d.IdPolizaInversa)
                    .HasConstraintName("FK_CvAplicacionDepositos_CtbMtoPolizas1");

                entity.HasOne(d => d.IdVendedorNavigation)
                    .WithMany(p => p.CvAplicacionDepositos)
                    .HasForeignKey(d => d.IdVendedor)
                    .HasConstraintName("FK_CvAplicacionDepositos_CvVendedores");
            });

            modelBuilder.Entity<CvAplicacionDepositosCfdi>(entity =>
            {
                entity.HasKey(e => e.IdAplicacionDepositosCfdi);

                entity.ToTable("CvAplicacionDepositosCFDI");

                entity.Property(e => e.IdAplicacionDepositosCfdi).HasColumnName("IdAplicacionDepositosCFDI");

                entity.Property(e => e.IdConceptoCfdi).HasColumnName("IdConceptoCFDI");

                entity.Property(e => e.Monto).HasColumnType("decimal(19, 4)");

                entity.HasOne(d => d.IdAplicacionDepositoNavigation)
                    .WithMany(p => p.CvAplicacionDepositosCfdis)
                    .HasForeignKey(d => d.IdAplicacionDeposito)
                    .HasConstraintName("FK_CvAplicacionDepositos");
            });

            modelBuilder.Entity<CvAplicacionDepositosDet>(entity =>
            {
                entity.HasKey(e => e.IdAplicacionDepositoDet);

                entity.ToTable("CvAplicacionDepositosDet");

                entity.Property(e => e.MontoAbonoCapital).HasColumnType("money");

                entity.Property(e => e.MontoAbonoCapitalBase).HasColumnType("money");

                entity.Property(e => e.MontoBase).HasColumnType("money");

                entity.Property(e => e.MontoDocumento).HasColumnType("money");

                entity.Property(e => e.MontoGastosAdicionales).HasColumnType("money");

                entity.Property(e => e.MontoGastosAdicionalesBase).HasColumnType("money");

                entity.Property(e => e.MontoInteres).HasColumnType("money");

                entity.Property(e => e.MontoInteresBase).HasColumnType("money");

                entity.Property(e => e.MontoIvaDocumentoBase).HasColumnType("money");

                entity.Property(e => e.MontoIvadocumento)
                    .HasColumnType("money")
                    .HasColumnName("MontoIVADocumento");

                entity.Property(e => e.MontoIvamoratorio)
                    .HasColumnType("money")
                    .HasColumnName("MontoIVAMoratorio");

                entity.Property(e => e.MontoMoratorio).HasColumnType("money");

                entity.HasOne(d => d.IdAplicacionDepositoNavigation)
                    .WithMany(p => p.CvAplicacionDepositosDets)
                    .HasForeignKey(d => d.IdAplicacionDeposito)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvAplicacionDepositosDet_CvAplicacionDepositos");

                entity.HasOne(d => d.IdPlanPagoDetNavigation)
                    .WithMany(p => p.CvAplicacionDepositosDets)
                    .HasForeignKey(d => d.IdPlanPagoDet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvAplicacionDepositosDet_CvPlanesPagosDet");
            });

            modelBuilder.Entity<CvAvale>(entity =>
            {
                entity.HasKey(e => e.IdAval);

                entity.HasIndex(e => e.IdCliente, "IX_CvAvales")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(30)
                    .HasColumnName("APellidoMaterno");

                entity.Property(e => e.ApellidoPaterno).HasMaxLength(30);

                entity.Property(e => e.Calle).HasMaxLength(80);

                entity.Property(e => e.CodPost).HasMaxLength(7);

                entity.Property(e => e.Colonia).HasMaxLength(100);

                entity.Property(e => e.MpioDeleg).HasMaxLength(30);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.NumOficial).HasMaxLength(8);

                entity.Property(e => e.Telefono).HasMaxLength(30);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithOne(p => p.CvAvale)
                    .HasForeignKey<CvAvale>(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvAvales_CvClientes");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.CvAvales)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_CvAvales_Estados");
            });

            modelBuilder.Entity<CvBeneficiario>(entity =>
            {
                entity.HasKey(e => e.IdBeneficiario);

                entity.HasIndex(e => e.IdCliente, "In_CvBeneficiariosIdCliente")
                    .HasFillFactor(90);

                entity.Property(e => e.ApellidoMaterno)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.ApellidoPaterno)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.PorParticipacion).HasColumnType("money");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.CvBeneficiarios)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvBeneficiarios_CvClientes");
            });

            modelBuilder.Entity<CvCamposRequerido>(entity =>
            {
                entity.HasKey(e => new { e.Tabla, e.Campo });

                entity.Property(e => e.Tabla)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Campo)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CvCancelacione>(entity =>
            {
                entity.HasKey(e => e.IdCancelacion)
                    .HasName("PK_CvDevoluciones");

                entity.HasIndex(e => e.FolioCancelacion, "IX_CvDevoluciones")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Lote)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.M2terreno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("M2Terreno");

                entity.Property(e => e.Manzana)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MontoApartadoSinAplicar).HasColumnType("money");

                entity.Property(e => e.MontoDevolucion).HasColumnType("money");

                entity.Property(e => e.MontoIva)
                    .HasColumnType("money")
                    .HasColumnName("MontoIVA");

                entity.Property(e => e.MontoIvaPenalizacion).HasColumnType("money");

                entity.Property(e => e.MontoPenalizacion).HasColumnType("money");

                entity.Property(e => e.Observaciones).HasMaxLength(50);

                entity.Property(e => e.PrecioTerreno).HasColumnType("money");

                entity.Property(e => e.Vivienda)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.CvCancelaciones)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvDevoluciones_CvClientes");

                entity.HasOne(d => d.IdContratoNavigation)
                    .WithMany(p => p.CvCancelaciones)
                    .HasForeignKey(d => d.IdContrato)
                    .HasConstraintName("FK_CvDevoluciones_CvContratos");

                entity.HasOne(d => d.IdPolizaNavigation)
                    .WithMany(p => p.CvCancelaciones)
                    .HasForeignKey(d => d.IdPoliza)
                    .HasConstraintName("FK_CvDevoluciones_CtbMtoPolizas");

                entity.HasOne(d => d.IdTipoFallaNavigation)
                    .WithMany(p => p.CvCancelaciones)
                    .HasForeignKey(d => d.IdTipoFalla)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvDevoluciones_CvTiposFallas");
            });

            modelBuilder.Entity<CvCasa>(entity =>
            {
                entity.HasKey(e => e.IdCasa);

                entity.ToTable("CvCasa");

                entity.HasIndex(e => e.Casa, "IX_CvCasaTexto")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdCasa).ValueGeneratedOnAdd();

                entity.Property(e => e.Casa)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CvCatConceptosCfdi>(entity =>
            {
                entity.HasKey(e => e.IdConceptoCfdi);

                entity.ToTable("CvCatConceptosCFDI");

                entity.HasIndex(e => e.Concepto, "IX_CvCatConceptosCFDI")
                    .IsUnique();

                entity.Property(e => e.IdConceptoCfdi).HasColumnName("IdConceptoCFDI");

                entity.Property(e => e.Concepto)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.IdProductoServicioSat).HasColumnName("IdProductoServicioSAT");

                entity.Property(e => e.IdUnidadSat).HasColumnName("IdUnidadSAT");

                entity.Property(e => e.Unidad)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProductoServicioSatNavigation)
                    .WithMany(p => p.CvCatConceptosCfdis)
                    .HasForeignKey(d => d.IdProductoServicioSat)
                    .HasConstraintName("FK_CvCatConceptosCFDI_AcCatProductosServicioSAT");

                entity.HasOne(d => d.IdUnidadSatNavigation)
                    .WithMany(p => p.CvCatConceptosCfdis)
                    .HasForeignKey(d => d.IdUnidadSat)
                    .HasConstraintName("FK_CvCatConceptosCFDI_AcCatUnidadesSAT");
            });

            modelBuilder.Entity<CvCetapa>(entity =>
            {
                entity.HasKey(e => e.IdCetapa)
                    .HasName("PK_CvPCEtapasIdEtapa");

                entity.ToTable("CvCEtapas");

                entity.HasIndex(e => new { e.IdCredito, e.IdEtapaCliente }, "IX_CvCEtapasCodigo")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdCetapa).HasColumnName("IdCEtapa");

                entity.Property(e => e.Duracion).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdCreditoNavigation)
                    .WithMany(p => p.CvCetapas)
                    .HasForeignKey(d => d.IdCredito)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvPCActividad_CvTiposCreditos");

                entity.HasOne(d => d.IdEtapaClienteNavigation)
                    .WithMany(p => p.CvCetapas)
                    .HasForeignKey(d => d.IdEtapaCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvPCActividad_CvActividadesClientes");
            });

            modelBuilder.Entity<CvCetapasDet>(entity =>
            {
                entity.HasKey(e => e.IdCetapaDet)
                    .HasName("PK_CvCEtapasDetIdEtapaDet");

                entity.ToTable("CvCEtapasDet");

                entity.HasIndex(e => new { e.IdCetapa, e.IdDocumentoCliente }, "IX_CvPCCEtapasDetCodigo")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdCetapaDet).HasColumnName("IdCEtapaDet");

                entity.Property(e => e.IdCetapa).HasColumnName("IdCEtapa");

                entity.HasOne(d => d.IdCetapaNavigation)
                    .WithMany(p => p.CvCetapasDets)
                    .HasForeignKey(d => d.IdCetapa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvPCActividadDet_CvPCActividad");

                entity.HasOne(d => d.IdDocumentoClienteNavigation)
                    .WithMany(p => p.CvCetapasDets)
                    .HasForeignKey(d => d.IdDocumentoCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvPCActividadDet_CvDocumentosClientes");
            });

            modelBuilder.Entity<CvCliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente);

                entity.HasIndex(e => e.IdCuentaPasivo, "IX_CvClientes")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuentaApartados, "IX_CvClientes_1")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuentaIntereses, "IX_CvClientes_2")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuentaMoratorios, "IX_CvClientes_3")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuentaGastosAdicionales, "IX_CvClientes_4")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuentaPasivoSaldoFavor, "IX_CvClientes_5")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Cliente, "In_CvClientesCliente")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.ApellidoMaterno)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ApellidoPaterno)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BancoSat)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BancoSAT");

                entity.Property(e => e.Calle).HasMaxLength(80);

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CodPost).HasMaxLength(7);

                entity.Property(e => e.Colonia).HasMaxLength(100);

                entity.Property(e => e.CuentaBancaria)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Curp)
                    .HasMaxLength(18)
                    .HasColumnName("CURP");

                entity.Property(e => e.Departamento).HasMaxLength(20);

                entity.Property(e => e.Email).HasMaxLength(1000);

                entity.Property(e => e.Fantiguedad)
                    .HasColumnType("money")
                    .HasColumnName("FAntiguedad");

                entity.Property(e => e.FaplicarAhorro).HasColumnName("FAplicarAhorro");

                entity.Property(e => e.Fcalificacion)
                    .HasColumnType("smallmoney")
                    .HasColumnName("FCalificacion");

                entity.Property(e => e.FcreditoConyugal).HasColumnName("FCreditoConyugal");

                entity.Property(e => e.FcreditoVigente)
                    .HasMaxLength(30)
                    .HasColumnName("FCreditoVigente");

                entity.Property(e => e.FdelegacionInfonavit)
                    .HasMaxLength(30)
                    .HasColumnName("FDelegacionInfonavit");

                entity.Property(e => e.FdependienteDiscapacitado).HasColumnName("FDependienteDiscapacitado");

                entity.Property(e => e.Fdiscapacitado).HasColumnName("FDiscapacitado");

                entity.Property(e => e.FechaAsignacionVivienda).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaFichaRapApartado).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaIngreso).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaNacimiento).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaUltimoContacto).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaVisita).HasColumnType("datetime");

                entity.Property(e => e.FesOfertaVinculante).HasColumnName("FEsOfertaVinculante");

                entity.Property(e => e.FesSegundoCredito).HasColumnName("FEsSegundoCredito");

                entity.Property(e => e.Fescolaridad).HasColumnName("FEscolaridad");

                entity.Property(e => e.FespecificaDiscapacidad)
                    .HasMaxLength(20)
                    .HasColumnName("FEspecificaDiscapacidad");

                entity.Property(e => e.FestadoCivil).HasColumnName("FEstadoCivil");

                entity.Property(e => e.FformaCredito).HasColumnName("FFormaCredito");

                entity.Property(e => e.FgastoPromMen)
                    .HasColumnType("money")
                    .HasColumnName("FGastoPromMen");

                entity.Property(e => e.Fhmayores18).HasColumnName("FHMayores18");

                entity.Property(e => e.Fhmenores18).HasColumnName("FHMenores18");

                entity.Property(e => e.FingresoMensComp)
                    .HasColumnType("money")
                    .HasColumnName("FIngresoMensComp");

                entity.Property(e => e.FingresoMensNoComp)
                    .HasColumnType("money")
                    .HasColumnName("FIngresoMensNoComp");

                entity.Property(e => e.FmontoAhorro)
                    .HasColumnType("money")
                    .HasColumnName("FMontoAhorro");

                entity.Property(e => e.FmontoAutorizado)
                    .HasColumnType("money")
                    .HasColumnName("FMontoAutorizado");

                entity.Property(e => e.FmontoPrecalificacion)
                    .HasColumnType("money")
                    .HasColumnName("FMontoPrecalificacion");

                entity.Property(e => e.FmontoSalario)
                    .HasColumnType("money")
                    .HasColumnName("FMontoSalario");

                entity.Property(e => e.Fnacionalidad)
                    .HasMaxLength(20)
                    .HasColumnName("FNacionalidad");

                entity.Property(e => e.FnumeroCredito)
                    .HasMaxLength(20)
                    .HasColumnName("FNumeroCredito");

                entity.Property(e => e.FopcCreditoVsm).HasColumnName("FOpcCreditoVSM");

                entity.Property(e => e.Foriginario)
                    .HasMaxLength(40)
                    .HasColumnName("FOriginario");

                entity.Property(e => e.FotrosPatrones).HasColumnName("FOtrosPatrones");

                entity.Property(e => e.FpensionAlimenticia)
                    .HasColumnType("money")
                    .HasColumnName("FPensionAlimenticia");

                entity.Property(e => e.FpersonasDiscapacitadas).HasColumnName("FPersonasDiscapacitadas");

                entity.Property(e => e.FpersonasVivenTrab).HasColumnName("FPersonasVivenTrab");

                entity.Property(e => e.FplazoCredito).HasColumnName("FPlazoCredito");

                entity.Property(e => e.FpuntosInfonavit)
                    .HasColumnType("smallmoney")
                    .HasColumnName("FPuntosInfonavit");

                entity.Property(e => e.FsalarioCuotaDiaria)
                    .HasColumnType("money")
                    .HasColumnName("FSalarioCuotaDiaria");

                entity.Property(e => e.FsaldoSubcuentaVivienda)
                    .HasColumnType("money")
                    .HasColumnName("FSaldoSubcuentaVivienda");

                entity.Property(e => e.Fsdi)
                    .HasColumnType("money")
                    .HasColumnName("FSDI");

                entity.Property(e => e.FtextoImnc)
                    .HasMaxLength(50)
                    .HasColumnName("FTextoIMNC");

                entity.Property(e => e.FtextoOtraDiscapacidad)
                    .HasMaxLength(50)
                    .HasColumnName("FTextoOtraDiscapacidad");

                entity.Property(e => e.FtipoDiscapacidad).HasColumnName("FTipoDiscapacidad");

                entity.Property(e => e.FtipoDiscapacidadDependiente).HasColumnName("FTipoDiscapacidadDependiente");

                entity.Property(e => e.IdCetapa).HasColumnName("IdCEtapa");

                entity.Property(e => e.IdCodigoPostalSat).HasColumnName("IdCodigoPostalSAT");

                entity.Property(e => e.IdFdestinoCredito).HasColumnName("IdFDestinoCredito");

                entity.Property(e => e.IdFproducto).HasColumnName("IdFProducto");

                entity.Property(e => e.IdPaisSat).HasColumnName("IdPaisSAT");

                entity.Property(e => e.IdRangoIngresoMc).HasColumnName("IdRangoIngresoMC");

                entity.Property(e => e.IdRangoIngresoMnc).HasColumnName("IdRangoIngresoMNC");

                entity.Property(e => e.Identificacion).HasMaxLength(30);

                entity.Property(e => e.IngresoAnual).HasColumnType("money");

                entity.Property(e => e.IngresoPresupuestal).HasColumnType("money");

                entity.Property(e => e.JefeInmediato).HasMaxLength(40);

                entity.Property(e => e.Lada)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Localidad).HasMaxLength(10);

                entity.Property(e => e.Lote).HasMaxLength(4);

                entity.Property(e => e.Manzana).HasMaxLength(6);

                entity.Property(e => e.MonedaSatdefault)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MonedaSATDefault");

                entity.Property(e => e.MontoEnganche).HasColumnType("money");

                entity.Property(e => e.MontoFichaRapApartado).HasColumnType("money");

                entity.Property(e => e.MpioDeleg).HasMaxLength(30);

                entity.Property(e => e.NoAfore)
                    .HasMaxLength(20)
                    .HasColumnName("NoAFORE");

                entity.Property(e => e.NoFovissste)
                    .HasMaxLength(20)
                    .HasColumnName("NoFOVISSSTE");

                entity.Property(e => e.NoImss)
                    .HasMaxLength(20)
                    .HasColumnName("NoIMSS");

                entity.Property(e => e.NoInfonavit)
                    .HasMaxLength(20)
                    .HasColumnName("NoINFONAVIT");

                entity.Property(e => e.NoIssste)
                    .HasMaxLength(20)
                    .HasColumnName("NoISSSTE");

                entity.Property(e => e.NoSar)
                    .HasMaxLength(20)
                    .HasColumnName("NoSAR");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.NumInterior).HasMaxLength(30);

                entity.Property(e => e.NumOficial).HasMaxLength(30);

                entity.Property(e => e.NumRegIdTrib)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Ocupacion).HasMaxLength(20);

                entity.Property(e => e.Pais)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Puesto).HasMaxLength(20);

                entity.Property(e => e.Referencia)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rfc)
                    .HasMaxLength(13)
                    .HasColumnName("RFC");

                entity.Property(e => e.Sexo).HasMaxLength(2);

                entity.Property(e => e.TelJefeInmediato).HasMaxLength(30);

                entity.Property(e => e.Telefono).HasMaxLength(30);

                entity.Property(e => e.TelefonoCelular).HasMaxLength(30);

                entity.HasOne(d => d.CasaNavigation)
                    .WithMany(p => p.CvClientes)
                    .HasForeignKey(d => d.Casa)
                    .HasConstraintName("FK_CvClientes_CvCasa");

                entity.HasOne(d => d.DirectorNavigation)
                    .WithMany(p => p.CvClienteDirectorNavigations)
                    .HasForeignKey(d => d.Director)
                    .HasConstraintName("FK_CvClientes_CvVendedores3");

                entity.HasOne(d => d.EconomiaNavigation)
                    .WithMany(p => p.CvClientes)
                    .HasForeignKey(d => d.Economia)
                    .HasConstraintName("FK_CvClientes_CvEconomia");

                entity.HasOne(d => d.FaplicarAhorroNavigation)
                    .WithMany(p => p.CvClientes)
                    .HasForeignKey(d => d.FaplicarAhorro)
                    .HasConstraintName("FK_CvClientes_CvFAplicarAhorro1");

                entity.HasOne(d => d.FcreditoConyugalNavigation)
                    .WithMany(p => p.CvClientes)
                    .HasForeignKey(d => d.FcreditoConyugal)
                    .HasConstraintName("FK_CvClientes_CvFCreditoConyugal");

                entity.HasOne(d => d.FescolaridadNavigation)
                    .WithMany(p => p.CvClientes)
                    .HasForeignKey(d => d.Fescolaridad)
                    .HasConstraintName("FK_CvClientes_CvFEscolaridad");

                entity.HasOne(d => d.FestadoCivilNavigation)
                    .WithMany(p => p.CvClientes)
                    .HasForeignKey(d => d.FestadoCivil)
                    .HasConstraintName("FK_CvClientes_CvFEstadoCivil");

                entity.HasOne(d => d.FformaCreditoNavigation)
                    .WithMany(p => p.CvClientes)
                    .HasForeignKey(d => d.FformaCredito)
                    .HasConstraintName("FK_CvClientes_CvFFormaCredito");

                entity.HasOne(d => d.FopcCreditoVsmNavigation)
                    .WithMany(p => p.CvClientes)
                    .HasForeignKey(d => d.FopcCreditoVsm)
                    .HasConstraintName("FK_CvClientes_CvFOpcCreditoVSM");

                entity.HasOne(d => d.FplazoCreditoNavigation)
                    .WithMany(p => p.CvClientes)
                    .HasForeignKey(d => d.FplazoCredito)
                    .HasConstraintName("FK_CvClientes_CvFPlazosCredito");

                entity.HasOne(d => d.FtipoDiscapacidadNavigation)
                    .WithMany(p => p.CvClienteFtipoDiscapacidadNavigations)
                    .HasForeignKey(d => d.FtipoDiscapacidad)
                    .HasConstraintName("FK_CvClientes_CvFTipoDiscapacidad");

                entity.HasOne(d => d.FtipoDiscapacidadDependienteNavigation)
                    .WithMany(p => p.CvClienteFtipoDiscapacidadDependienteNavigations)
                    .HasForeignKey(d => d.FtipoDiscapacidadDependiente)
                    .HasConstraintName("FK_CvClientes_CvFTipoDiscapacidad1");

                entity.HasOne(d => d.GerenteNavigation)
                    .WithMany(p => p.CvClienteGerenteNavigations)
                    .HasForeignKey(d => d.Gerente)
                    .HasConstraintName("FK_CvClientes_CvVendedores2");

                entity.HasOne(d => d.IdCetapaNavigation)
                    .WithMany(p => p.CvClientes)
                    .HasForeignKey(d => d.IdCetapa)
                    .HasConstraintName("FK_CvClientes_CvCEtapas");

                entity.HasOne(d => d.IdCodigoPostalSatNavigation)
                    .WithMany(p => p.CvClientes)
                    .HasForeignKey(d => d.IdCodigoPostalSat)
                    .HasConstraintName("FK_CvClientes_AcCatCodigosPostalesSAT");

                entity.HasOne(d => d.IdCreditoNavigation)
                    .WithMany(p => p.CvClientes)
                    .HasForeignKey(d => d.IdCredito)
                    .HasConstraintName("FK_CvClientes_CvCreditos");

                entity.HasOne(d => d.IdCuentaApartadosNavigation)
                    .WithMany(p => p.CvClienteIdCuentaApartadosNavigations)
                    .HasForeignKey(d => d.IdCuentaApartados)
                    .HasConstraintName("FK_CvClientes_Cuentas3");

                entity.HasOne(d => d.IdCuentaGastosAdicionalesNavigation)
                    .WithMany(p => p.CvClienteIdCuentaGastosAdicionalesNavigations)
                    .HasForeignKey(d => d.IdCuentaGastosAdicionales)
                    .HasConstraintName("FK_CvClientes_CtbCuentas");

                entity.HasOne(d => d.IdCuentaInteresesNavigation)
                    .WithMany(p => p.CvClienteIdCuentaInteresesNavigations)
                    .HasForeignKey(d => d.IdCuentaIntereses)
                    .HasConstraintName("FK_CvClientes_CtbCuentas2");

                entity.HasOne(d => d.IdCuentaMoratoriosNavigation)
                    .WithMany(p => p.CvClienteIdCuentaMoratoriosNavigations)
                    .HasForeignKey(d => d.IdCuentaMoratorios)
                    .HasConstraintName("FK_CvClientes_CtbCuentas1");

                entity.HasOne(d => d.IdCuentaPasivoNavigation)
                    .WithMany(p => p.CvClienteIdCuentaPasivoNavigations)
                    .HasForeignKey(d => d.IdCuentaPasivo)
                    .HasConstraintName("FK_CvClientes_Cuentas2");

                entity.HasOne(d => d.IdCuentaPasivoSaldoFavorNavigation)
                    .WithMany(p => p.CvClienteIdCuentaPasivoSaldoFavorNavigations)
                    .HasForeignKey(d => d.IdCuentaPasivoSaldoFavor)
                    .HasConstraintName("FK_CvClientes_CtbCuentas3");

                entity.HasOne(d => d.IdDisponibilidadCasaDeseadaNavigation)
                    .WithMany(p => p.CvClientes)
                    .HasForeignKey(d => d.IdDisponibilidadCasaDeseada)
                    .HasConstraintName("FK_CvClientes_CvDisponibilidadCasaDeseada");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.CvClientes)
                    .HasForeignKey(d => d.IdEmpresa)
                    .HasConstraintName("FK_CvClientes_CvEmpresas");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.CvClientes)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_CvClientes_Estados");

                entity.HasOne(d => d.IdEtapaClienteNavigation)
                    .WithMany(p => p.CvClientes)
                    .HasForeignKey(d => d.IdEtapaCliente)
                    .HasConstraintName("FK_CvClientes_CvEtapasClientes");

                entity.HasOne(d => d.IdFdestinoCreditoNavigation)
                    .WithMany(p => p.CvClientes)
                    .HasForeignKey(d => d.IdFdestinoCredito)
                    .HasConstraintName("FK_CvClientes_CvFDestinoCredito");

                entity.HasOne(d => d.IdFproductoNavigation)
                    .WithMany(p => p.CvClientes)
                    .HasForeignKey(d => d.IdFproducto)
                    .HasConstraintName("FK_CvClientes_CvFProducto");

                entity.HasOne(d => d.IdIdentificacionOficialNavigation)
                    .WithMany(p => p.CvClientes)
                    .HasForeignKey(d => d.IdIdentificacionOficial)
                    .HasConstraintName("FK_CvClientes_CvIdentificacionesOficiales");

                entity.HasOne(d => d.IdMedioNavigation)
                    .WithMany(p => p.CvClientes)
                    .HasForeignKey(d => d.IdMedio)
                    .HasConstraintName("FK_CvClientes_CvMedios");

                entity.HasOne(d => d.IdPaisSatNavigation)
                    .WithMany(p => p.CvClientes)
                    .HasForeignKey(d => d.IdPaisSat)
                    .HasConstraintName("FK_CvClientes_AcCatPaises");

                entity.HasOne(d => d.IdPrototipoDeseadoNavigation)
                    .WithMany(p => p.CvClienteIdPrototipoDeseadoNavigations)
                    .HasForeignKey(d => d.IdPrototipoDeseado)
                    .HasConstraintName("FK_CvClientes_CvPrototipos");

                entity.HasOne(d => d.IdPrototipoPreContratadoNavigation)
                    .WithMany(p => p.CvClienteIdPrototipoPreContratadoNavigations)
                    .HasForeignKey(d => d.IdPrototipoPreContratado)
                    .HasConstraintName("FK_CvClientes_CvPrototipos1");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.CvClientes)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvClientes_Proyectos");

                entity.HasOne(d => d.IdRangoIngresoMcNavigation)
                    .WithMany(p => p.CvClientes)
                    .HasForeignKey(d => d.IdRangoIngresoMc)
                    .HasConstraintName("FK_CvClientes_CvRangoIngresoMC");

                entity.HasOne(d => d.IdRangoIngresoMncNavigation)
                    .WithMany(p => p.CvClientes)
                    .HasForeignKey(d => d.IdRangoIngresoMnc)
                    .HasConstraintName("FK_CvClientes_CvRangoIngresoMNC");

                entity.HasOne(d => d.IdRangoMontoRentaNavigation)
                    .WithMany(p => p.CvClientes)
                    .HasForeignKey(d => d.IdRangoMontoRenta)
                    .HasConstraintName("FK_CvClientes_CvRangoMontoRenta");

                entity.HasOne(d => d.IdRangoPersonasHabitanCasaNavigation)
                    .WithMany(p => p.CvClientes)
                    .HasForeignKey(d => d.IdRangoPersonasHabitanCasa)
                    .HasConstraintName("FK_CvClientes_CvRangoPersonasHabitanCasa");

                entity.HasOne(d => d.IdSofolSolicitadaNavigation)
                    .WithMany(p => p.CvClientes)
                    .HasForeignKey(d => d.IdSofolSolicitada)
                    .HasConstraintName("FK_CvClientes_CvSofoles");

                entity.HasOne(d => d.IdTipoMonedaNavigation)
                    .WithMany(p => p.CvClientes)
                    .HasForeignKey(d => d.IdTipoMoneda)
                    .HasConstraintName("FK_CvClientes_AcCatMonedas");

                entity.HasOne(d => d.RegimenMatrimonialNavigation)
                    .WithMany(p => p.CvClientes)
                    .HasForeignKey(d => d.RegimenMatrimonial)
                    .HasConstraintName("FK_CvClientes_CvRegimenMatrimonial");

                entity.HasOne(d => d.Vendedor1Navigation)
                    .WithMany(p => p.CvClienteVendedor1Navigations)
                    .HasForeignKey(d => d.Vendedor1)
                    .HasConstraintName("FK_CvClientes_CvVendedores");

                entity.HasOne(d => d.Vendedor2Navigation)
                    .WithMany(p => p.CvClienteVendedor2Navigations)
                    .HasForeignKey(d => d.Vendedor2)
                    .HasConstraintName("FK_CvClientes_CvVendedores1");

                entity.HasOne(d => d.Vendedor3Navigation)
                    .WithMany(p => p.CvClienteVendedor3Navigations)
                    .HasForeignKey(d => d.Vendedor3)
                    .HasConstraintName("FK_CvClientes_CvVendedores5");

                entity.HasOne(d => d.Vendedor4Navigation)
                    .WithMany(p => p.CvClienteVendedor4Navigations)
                    .HasForeignKey(d => d.Vendedor4)
                    .HasConstraintName("FK_CvClientes_CvVendedores6");

                entity.HasOne(d => d.Vendedor5Navigation)
                    .WithMany(p => p.CvClienteVendedor5Navigations)
                    .HasForeignKey(d => d.Vendedor5)
                    .HasConstraintName("FK_CvClientes_CvVendedores7");

                entity.HasOne(d => d.VendedorExternoNavigation)
                    .WithMany(p => p.CvClienteVendedorExternoNavigations)
                    .HasForeignKey(d => d.VendedorExterno)
                    .HasConstraintName("FK_CvClientes_CvVendedores4");
            });

            modelBuilder.Entity<CvClienteEscrituracion>(entity =>
            {
                entity.HasKey(e => e.IdClienteEscrituracion);

                entity.ToTable("CvClienteEscrituracion");

                entity.Property(e => e.IdClienteEscrituracion).HasColumnName("idClienteEscrituracion");

                entity.Property(e => e.DescripcionCancelacion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAplicacion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaCancelacion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaEscrituraReal).HasColumnType("smalldatetime");

                entity.Property(e => e.FolioEscritura).HasMaxLength(20);

                entity.Property(e => e.MontoAnticipos).HasColumnType("money");

                entity.Property(e => e.MontoCostoTerreno).HasColumnType("money");

                entity.Property(e => e.MontoCostoVivienda).HasColumnType("money");

                entity.Property(e => e.MontoEscritura).HasColumnType("money");

                entity.Property(e => e.MontoIvaanticipos)
                    .HasColumnType("money")
                    .HasColumnName("MontoIVAAnticipos");

                entity.Property(e => e.MontoIvaescritura)
                    .HasColumnType("money")
                    .HasColumnName("MontoIVAEscritura");

                entity.Property(e => e.Paridad)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.CvClienteEscrituracions)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvClienteEscrituracion_CvClientes");

                entity.HasOne(d => d.IdPolizaNavigation)
                    .WithMany(p => p.CvClienteEscrituracionIdPolizaNavigations)
                    .HasForeignKey(d => d.IdPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvClienteEscrituracion_CtbMtoPolizas");

                entity.HasOne(d => d.IdPolizaInversaNavigation)
                    .WithMany(p => p.CvClienteEscrituracionIdPolizaInversaNavigations)
                    .HasForeignKey(d => d.IdPolizaInversa)
                    .HasConstraintName("FK_CvClienteEscrituracion_CtbMtoPolizas1");
            });

            modelBuilder.Entity<CvClientesFactura>(entity =>
            {
                entity.HasKey(e => e.IdClienteFactura);

                entity.HasIndex(e => e.FolioFiscalCfdi, "IX_CvClientesFacturas");

                entity.Property(e => e.CodigoAddenda)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoAuxiliar)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPostal)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CondicionesFactura)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Curp)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("CURP");

                entity.Property(e => e.Delegacion)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionCancelacion)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EstatusSat).HasColumnName("EstatusSAT");

                entity.Property(e => e.FacturaSerie)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCancelacion).HasColumnType("datetime");

                entity.Property(e => e.FechaFactura).HasColumnType("datetime");

                entity.Property(e => e.FechaFolioFiscalOrig).HasColumnType("datetime");

                entity.Property(e => e.FechaHora).HasColumnType("datetime");

                entity.Property(e => e.FechaMovimiento).HasColumnType("datetime");

                entity.Property(e => e.FechaSolicitudCancelacion).HasColumnType("datetime");

                entity.Property(e => e.FechaUltimaActualizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaUltimoCambio).HasColumnType("datetime");

                entity.Property(e => e.FolioFiscalCfdi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FolioFiscalCFDI");

                entity.Property(e => e.FolioFiscalOrig)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FormaDePago)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Localidad)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontoFiscal).HasColumnType("money");

                entity.Property(e => e.MontoFolioFiscalOrig).HasColumnType("money");

                entity.Property(e => e.MontoIvafiscal)
                    .HasColumnType("money")
                    .HasColumnName("MontoIVAFiscal");

                entity.Property(e => e.NoCertificado)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NoExterior)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoInterior)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumCtaPago)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Pais)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Referencia)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("RFC");

                entity.Property(e => e.SerieFolioFiscalOrig)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StrMetodosPago)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCiudadNavigation)
                    .WithMany(p => p.CvClientesFacturas)
                    .HasForeignKey(d => d.IdCiudad)
                    .HasConstraintName("FK_CvClientesFacturas_AcCatCiudades");

                entity.HasOne(d => d.IdCondicionPagoNavigation)
                    .WithMany(p => p.CvClientesFacturas)
                    .HasForeignKey(d => d.IdCondicionPago)
                    .HasConstraintName("FK_CvClientesFacturas_AcCondicionesPago");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.CvClientesFacturas)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_CvClientesFacturas_AcCatEstados");

                entity.HasOne(d => d.IdMetodoPagoNavigation)
                    .WithMany(p => p.CvClientesFacturas)
                    .HasForeignKey(d => d.IdMetodoPago)
                    .HasConstraintName("FK_CvClientesFacturas_AcMetodoPago");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.CvClientesFacturas)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvClientesFacturas_Proyectos");

                entity.HasOne(d => d.IdTipoMonedaNavigation)
                    .WithMany(p => p.CvClientesFacturas)
                    .HasForeignKey(d => d.IdTipoMoneda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvClientesFacturas_AcCatMonedas");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.CvClientesFacturaIdUsuarioNavigations)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvClientesFacturas_SegUsuarios2");

                entity.HasOne(d => d.IdUsuarioCancelacionNavigation)
                    .WithMany(p => p.CvClientesFacturaIdUsuarioCancelacionNavigations)
                    .HasForeignKey(d => d.IdUsuarioCancelacion)
                    .HasConstraintName("FK_CvClientesFacturas_SegUsuarios");

                entity.HasOne(d => d.IdUsuarioUltimoCambioNavigation)
                    .WithMany(p => p.CvClientesFacturaIdUsuarioUltimoCambioNavigations)
                    .HasForeignKey(d => d.IdUsuarioUltimoCambio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvClientesFacturas_SegUsuarios1");
            });

            modelBuilder.Entity<CvClientesFacturas2017>(entity =>
            {
                entity.HasKey(e => e.IdClienteFactura2017);

                entity.ToTable("CvClientesFacturas2017");

                entity.Property(e => e.ClaveConfirmacion)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Descuento).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.FechaTimbrado).HasColumnType("datetime");

                entity.Property(e => e.IdCatMonedasSat).HasColumnName("IdCatMonedasSAT");

                entity.Property(e => e.IdFormaPagoSat).HasColumnName("IdFormaPagoSAT");

                entity.Property(e => e.IdMetodoPagoSat).HasColumnName("IdMetodoPagoSAT");

                entity.Property(e => e.IdTipoComprobanteSat).HasColumnName("IdTipoComprobanteSAT");

                entity.Property(e => e.IdTipoRelacionSat).HasColumnName("IdTipoRelacionSAT");

                entity.Property(e => e.IdUsoCfdiSat).HasColumnName("IdUsoCfdiSAT");

                entity.Property(e => e.NumRegIdTribReceptor)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TipoCambio)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdCatMonedasSatNavigation)
                    .WithMany(p => p.CvClientesFacturas2017s)
                    .HasForeignKey(d => d.IdCatMonedasSat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvClientesFacturas2017_CtbCatMonedasSAT");

                entity.HasOne(d => d.IdClienteFacturaNavigation)
                    .WithMany(p => p.CvClientesFacturas2017s)
                    .HasForeignKey(d => d.IdClienteFactura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvClientesFacturas2017_CvClientesFacturas");

                entity.HasOne(d => d.IdFormaPagoSatNavigation)
                    .WithMany(p => p.CvClientesFacturas2017s)
                    .HasForeignKey(d => d.IdFormaPagoSat)
                    .HasConstraintName("FK_CvClientesFacturas2017_AcCatFormasPagoSAT");

                entity.HasOne(d => d.IdMetodoPagoSatNavigation)
                    .WithMany(p => p.CvClientesFacturas2017s)
                    .HasForeignKey(d => d.IdMetodoPagoSat)
                    .HasConstraintName("FK_CvClientesFacturas2017_AcCatMetodosPagoSAT");

                entity.HasOne(d => d.IdPaisReceptorNavigation)
                    .WithMany(p => p.CvClientesFacturas2017s)
                    .HasForeignKey(d => d.IdPaisReceptor)
                    .HasConstraintName("FK_CvClientesFacturas2017_AcCatPaises");

                entity.HasOne(d => d.IdTipoComprobanteSatNavigation)
                    .WithMany(p => p.CvClientesFacturas2017s)
                    .HasForeignKey(d => d.IdTipoComprobanteSat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvClientesFacturas2017_AcCatTiposComprobanteSAT");

                entity.HasOne(d => d.IdTipoRelacionSatNavigation)
                    .WithMany(p => p.CvClientesFacturas2017s)
                    .HasForeignKey(d => d.IdTipoRelacionSat)
                    .HasConstraintName("FK_CvClientesFacturas2017_AcCatTiposRelacionSAT");

                entity.HasOne(d => d.IdUsoCfdiSatNavigation)
                    .WithMany(p => p.CvClientesFacturas2017s)
                    .HasForeignKey(d => d.IdUsoCfdiSat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvClientesFacturas2017_AcCatUsosCFDISAT");
            });

            modelBuilder.Entity<CvClientesFacturasCfd>(entity =>
            {
                entity.HasKey(e => e.IdClienteFacturaCfd);

                entity.ToTable("CvClientesFacturasCFD");

                entity.Property(e => e.IdClienteFacturaCfd).HasColumnName("IdClienteFacturaCFD");

                entity.Property(e => e.FechaHora).HasColumnType("datetime");

                entity.Property(e => e.NombreXlsx)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("NombreXLSX");

                entity.Property(e => e.Xlsx).HasColumnName("XLSX");

                entity.Property(e => e.Xmlcfd)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("XMLCFD");

                entity.Property(e => e.XmlcfdsinAddenda)
                    .IsUnicode(false)
                    .HasColumnName("XMLCFDSinAddenda");

                entity.Property(e => e.Xmlpoliza)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("XMLPoliza");

                entity.HasOne(d => d.IdClienteFacturaNavigation)
                    .WithMany(p => p.CvClientesFacturasCfds)
                    .HasForeignKey(d => d.IdClienteFactura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvClientesFacturasCFD_CvClientesFacturas");
            });

            modelBuilder.Entity<CvClientesFacturasCfdirelac>(entity =>
            {
                entity.HasKey(e => e.IdCfdirelacionado);

                entity.ToTable("CvClientesFacturasCFDIRelac");

                entity.Property(e => e.IdCfdirelacionado).HasColumnName("IdCFDIRelacionado");

                entity.Property(e => e.Uuid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("UUID");

                entity.HasOne(d => d.IdClienteFactura2017Navigation)
                    .WithMany(p => p.CvClientesFacturasCfdirelacs)
                    .HasForeignKey(d => d.IdClienteFactura2017)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvClientesFacturasCFDIRelac_CvClientesFacturas2017");
            });

            modelBuilder.Entity<CvClientesFacturasDet>(entity =>
            {
                entity.HasKey(e => e.IdClienteFacturaDet);

                entity.ToTable("CvClientesFacturasDet");

                entity.Property(e => e.Cantidad).HasColumnType("money");

                entity.Property(e => e.DescripcionAuxiliar).IsUnicode(false);

                entity.Property(e => e.IdConceptoCfdi).HasColumnName("IdConceptoCFDI");

                entity.Property(e => e.IdProductoServicioSat).HasColumnName("IdProductoServicioSAT");

                entity.Property(e => e.IdUnidadSat).HasColumnName("IdUnidadSAT");

                entity.Property(e => e.MontoIva)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("MontoIVA");

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.HasOne(d => d.IdClienteFacturaNavigation)
                    .WithMany(p => p.CvClientesFacturasDets)
                    .HasForeignKey(d => d.IdClienteFactura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvClientesFacturasDet_CvClientesFacturas");

                entity.HasOne(d => d.IdConceptoCfdiNavigation)
                    .WithMany(p => p.CvClientesFacturasDets)
                    .HasForeignKey(d => d.IdConceptoCfdi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvClientesFacturasDet_CvCatConceptosCFDI");

                entity.HasOne(d => d.IdProductoServicioSatNavigation)
                    .WithMany(p => p.CvClientesFacturasDets)
                    .HasForeignKey(d => d.IdProductoServicioSat)
                    .HasConstraintName("FK_CvClientesFacturasDet_AcCatProductosServicioSAT");

                entity.HasOne(d => d.IdUnidadSatNavigation)
                    .WithMany(p => p.CvClientesFacturasDets)
                    .HasForeignKey(d => d.IdUnidadSat)
                    .HasConstraintName("FK_CvClientesFacturasDet_AcCatUnidadesSAT");
            });

            modelBuilder.Entity<CvClientesVistum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CvClientes_Vista");

                entity.Property(e => e.ApellidoMaterno)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.ApellidoPaterno)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.BancoSat)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BancoSAT");

                entity.Property(e => e.Calle).HasMaxLength(80);

                entity.Property(e => e.Casa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CodPost).HasMaxLength(7);

                entity.Property(e => e.Colonia).HasMaxLength(100);

                entity.Property(e => e.Contrato).HasMaxLength(20);

                entity.Property(e => e.Credito).HasMaxLength(20);

                entity.Property(e => e.CuentaBancaria)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Curp)
                    .HasMaxLength(18)
                    .HasColumnName("CURP");

                entity.Property(e => e.Departamento).HasMaxLength(20);

                entity.Property(e => e.Director).HasMaxLength(20);

                entity.Property(e => e.Economia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(1000);

                entity.Property(e => e.Empresa).HasMaxLength(100);

                entity.Property(e => e.Estado)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtapaCliente).HasMaxLength(20);

                entity.Property(e => e.FaplicarAhorro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAplicarAhorro");

                entity.Property(e => e.Fcalificacion)
                    .HasColumnType("smallmoney")
                    .HasColumnName("FCalificacion");

                entity.Property(e => e.FcreditoConyugal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FCreditoConyugal");

                entity.Property(e => e.FdelegacionInfonavit)
                    .HasMaxLength(30)
                    .HasColumnName("FDelegacionInfonavit");

                entity.Property(e => e.FdependienteDiscapacitado).HasColumnName("FDependienteDiscapacitado");

                entity.Property(e => e.Fdiscapacitado).HasColumnName("FDiscapacitado");

                entity.Property(e => e.FechaFichaRapApartado).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaIngreso).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaNacimiento).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaVisita).HasColumnType("datetime");

                entity.Property(e => e.FesOfertaVinculante).HasColumnName("FEsOfertaVinculante");

                entity.Property(e => e.Fescolaridad)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FEscolaridad");

                entity.Property(e => e.FestadoCivil)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FEstadoCivil");

                entity.Property(e => e.FformaCredito)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FFormaCredito");

                entity.Property(e => e.FgastoPromMen)
                    .HasColumnType("money")
                    .HasColumnName("FGastoPromMen");

                entity.Property(e => e.Fhmayores18).HasColumnName("FHMayores18");

                entity.Property(e => e.Fhmenores18).HasColumnName("FHMenores18");

                entity.Property(e => e.FingresoMensComp)
                    .HasColumnType("money")
                    .HasColumnName("FIngresoMensComp");

                entity.Property(e => e.FingresoMensNoComp)
                    .HasColumnType("money")
                    .HasColumnName("FIngresoMensNoComp");

                entity.Property(e => e.Flujo)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("flujo");

                entity.Property(e => e.FmontoAhorro)
                    .HasColumnType("money")
                    .HasColumnName("FMontoAhorro");

                entity.Property(e => e.FmontoAutorizado)
                    .HasColumnType("money")
                    .HasColumnName("FMontoAutorizado");

                entity.Property(e => e.FmontoPrecalificacion)
                    .HasColumnType("money")
                    .HasColumnName("FMontoPrecalificacion");

                entity.Property(e => e.FmontoSalario)
                    .HasColumnType("money")
                    .HasColumnName("FMontoSalario");

                entity.Property(e => e.Fnacionalidad)
                    .HasMaxLength(20)
                    .HasColumnName("FNacionalidad");

                entity.Property(e => e.FnumeroCredito)
                    .HasMaxLength(20)
                    .HasColumnName("FNumeroCredito");

                entity.Property(e => e.FolioIdentificacion).HasMaxLength(30);

                entity.Property(e => e.Folioapartado).HasColumnName("folioapartado");

                entity.Property(e => e.Folioporproyecto).HasColumnName("folioporproyecto");

                entity.Property(e => e.Foriginario)
                    .HasMaxLength(40)
                    .HasColumnName("FOriginario");

                entity.Property(e => e.FotrosPatrones).HasColumnName("FOtrosPatrones");

                entity.Property(e => e.FpensionAlimenticia)
                    .HasColumnType("money")
                    .HasColumnName("FPensionAlimenticia");

                entity.Property(e => e.FpersonasDiscapacitadas).HasColumnName("FPersonasDiscapacitadas");

                entity.Property(e => e.FpersonasVivenTrab).HasColumnName("FPersonasVivenTrab");

                entity.Property(e => e.FplazoCredito)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FPlazoCredito");

                entity.Property(e => e.FpuntosInfonavit)
                    .HasColumnType("smallmoney")
                    .HasColumnName("FPuntosInfonavit");

                entity.Property(e => e.FsalarioCuotaDiaria)
                    .HasColumnType("money")
                    .HasColumnName("FSalarioCuotaDiaria");

                entity.Property(e => e.FsaldoSubcuentaVivienda)
                    .HasColumnType("money")
                    .HasColumnName("FSaldoSubcuentaVivienda");

                entity.Property(e => e.Fsdi)
                    .HasColumnType("money")
                    .HasColumnName("FSDI");

                entity.Property(e => e.FtextoImnc)
                    .HasMaxLength(50)
                    .HasColumnName("FTextoIMNC");

                entity.Property(e => e.FtipoDiscapacidad)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FTipoDiscapacidad");

                entity.Property(e => e.FtipoDiscapacidadDependiente)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FTipoDiscapacidadDependiente");

                entity.Property(e => e.Gerente).HasMaxLength(20);

                entity.Property(e => e.Identificacion).HasMaxLength(20);

                entity.Property(e => e.IngresoAnual).HasColumnType("money");

                entity.Property(e => e.IngresoPresupuestal).HasColumnType("money");

                entity.Property(e => e.JefeInmediato).HasMaxLength(40);

                entity.Property(e => e.Localidad).HasMaxLength(10);

                entity.Property(e => e.Lote).HasMaxLength(4);

                entity.Property(e => e.Manzana).HasMaxLength(6);

                entity.Property(e => e.Medio).HasMaxLength(40);

                entity.Property(e => e.MonedaSatdefault)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MonedaSATDefault");

                entity.Property(e => e.MontoEnganche).HasColumnType("money");

                entity.Property(e => e.MontoFichaRapApartado).HasColumnType("money");

                entity.Property(e => e.MpioDeleg).HasMaxLength(30);

                entity.Property(e => e.NoAfore)
                    .HasMaxLength(20)
                    .HasColumnName("NoAFORE");

                entity.Property(e => e.NoFovissste)
                    .HasMaxLength(20)
                    .HasColumnName("NoFOVISSSTE");

                entity.Property(e => e.NoImss)
                    .HasMaxLength(20)
                    .HasColumnName("NoIMSS");

                entity.Property(e => e.NoInfonavit)
                    .HasMaxLength(20)
                    .HasColumnName("NoINFONAVIT");

                entity.Property(e => e.NoIssste)
                    .HasMaxLength(20)
                    .HasColumnName("NoISSSTE");

                entity.Property(e => e.NoSar)
                    .HasMaxLength(20)
                    .HasColumnName("NoSAR");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.NombreConyuge).HasMaxLength(92);

                entity.Property(e => e.NumInterior).HasMaxLength(30);

                entity.Property(e => e.NumOficial).HasMaxLength(30);

                entity.Property(e => e.Ocupacion).HasMaxLength(20);

                entity.Property(e => e.Pais)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Promocion)
                    .HasMaxLength(20)
                    .UseCollation("Traditional_Spanish_CI_AS");

                entity.Property(e => e.PrototipoDeseado).HasMaxLength(20);

                entity.Property(e => e.Puesto).HasMaxLength(20);

                entity.Property(e => e.Referencia)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RegimenMatrimonial)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rfc)
                    .HasMaxLength(14)
                    .HasColumnName("RFC");

                entity.Property(e => e.Sexo).HasMaxLength(2);

                entity.Property(e => e.SofolCredito).HasMaxLength(20);

                entity.Property(e => e.SofolSolicitada).HasMaxLength(20);

                entity.Property(e => e.TelJefeInmediato).HasMaxLength(30);

                entity.Property(e => e.Telefono).HasMaxLength(30);

                entity.Property(e => e.TelefonoCelular).HasMaxLength(30);

                entity.Property(e => e.Vendedor1).HasMaxLength(20);

                entity.Property(e => e.Vendedor2).HasMaxLength(20);

                entity.Property(e => e.Vendedor3).HasMaxLength(20);

                entity.Property(e => e.Vendedor4).HasMaxLength(20);

                entity.Property(e => e.VendedorExterno).HasMaxLength(20);

                entity.Property(e => e.Vivienda).HasMaxLength(20);
            });

            modelBuilder.Entity<CvComisione>(entity =>
            {
                entity.HasKey(e => e.IdComision);

                entity.HasIndex(e => e.FolioComision, "IX_CvComisiones")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.IdProyecto, e.IdVendedor }, "IX_CvComisiones_1")
                    .HasFillFactor(90);

                entity.Property(e => e.FechaFinal).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaInicial).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaPagada).HasColumnType("smalldatetime");

                entity.Property(e => e.MontoComisionesClientes).HasColumnType("money");

                entity.Property(e => e.MontoComisionesExtras).HasColumnType("money");

                entity.Property(e => e.MontoDeducciones).HasColumnType("money");

                entity.Property(e => e.MontoTotal).HasColumnType("money");

                entity.Property(e => e.Observaciones).HasMaxLength(200);

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.CvComisiones)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvComisiones_Proyectos");

                entity.HasOne(d => d.IdRequisicionNavigation)
                    .WithMany(p => p.CvComisiones)
                    .HasForeignKey(d => d.IdRequisicion)
                    .HasConstraintName("FK_CvComisiones_MtoRequisicion");

                entity.HasOne(d => d.IdVendedorNavigation)
                    .WithMany(p => p.CvComisiones)
                    .HasForeignKey(d => d.IdVendedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvComisiones_CvVendedores");
            });

            modelBuilder.Entity<CvComisionesDet>(entity =>
            {
                entity.HasKey(e => e.IdComisionDet);

                entity.ToTable("CvComisionesDet");

                entity.HasIndex(e => e.IdFlujoCliente, "IX_CvComisionesDet_1")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdComisionDeduccion, "IX_CvComisionesDet_2")
                    .HasFillFactor(90);

                entity.Property(e => e.DescriCancelacion).HasMaxLength(50);

                entity.Property(e => e.FechaTerminado).HasColumnType("smalldatetime");

                entity.Property(e => e.IdCetapa).HasColumnName("IdCEtapa");

                entity.Property(e => e.MontoComision).HasColumnType("money");

                entity.Property(e => e.MontoParaCalculo).HasColumnType("money");

                entity.Property(e => e.PorcentajeBaseParaCalculo).HasColumnType("smallmoney");

                entity.Property(e => e.PorcentajeComision).HasColumnType("smallmoney");

                entity.Property(e => e.TipoVendedor).HasMaxLength(15);

                entity.HasOne(d => d.IdCetapaNavigation)
                    .WithMany(p => p.CvComisionesDets)
                    .HasForeignKey(d => d.IdCetapa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvComisionesDet_CvCEtapas");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.CvComisionesDets)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvComisionesDet_CvClientes");

                entity.HasOne(d => d.IdComisionNavigation)
                    .WithMany(p => p.CvComisionesDets)
                    .HasForeignKey(d => d.IdComision)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvComisionesDet_CvComisiones");
            });

            modelBuilder.Entity<CvComplementoPago>(entity =>
            {
                entity.HasKey(e => e.IdComplementoPago);

                entity.ToTable("CvComplementoPago");

                entity.Property(e => e.CadenaPago).IsUnicode(false);

                entity.Property(e => e.CertificadoPago).IsUnicode(false);

                entity.Property(e => e.Confirmacion)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaBancariaCliente)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaBancariaDepositante)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaBancariaEmisor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionCancelacion)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.EstatusSat).HasColumnName("EstatusSAT");

                entity.Property(e => e.FechaCancelacion).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraComplemento).HasColumnType("datetime");

                entity.Property(e => e.FechaSolicitudCancelacion).HasColumnType("datetime");

                entity.Property(e => e.FechaUltimaActualizacion).HasColumnType("datetime");

                entity.Property(e => e.FolioFiscalCfdi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FolioFiscalCFDI");

                entity.Property(e => e.HoraDeposito).HasColumnType("datetime");

                entity.Property(e => e.IdCatMonedasSat).HasColumnName("IdCatMonedasSAT");

                entity.Property(e => e.IdCodigoPostalSat).HasColumnName("IdCodigoPostalSAT");

                entity.Property(e => e.IdFormaPagoSat).HasColumnName("IdFormaPagoSAT");

                entity.Property(e => e.MontoPago).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.NombreBancoExt)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.NumOperacion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumRegisIdentidadFis)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones).IsUnicode(false);

                entity.Property(e => e.ParidadOficial).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ResidenciaFiscal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RfcbancoCliente)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("RFCBancoCliente");

                entity.Property(e => e.RfcbancoEmisor)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("RFCBancoEmisor");

                entity.Property(e => e.SelloPago).IsUnicode(false);

                entity.Property(e => e.SerieComplementoPago)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCadPago)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCambio).HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.IdCatMonedasSatNavigation)
                    .WithMany(p => p.CvComplementoPagos)
                    .HasForeignKey(d => d.IdCatMonedasSat)
                    .HasConstraintName("FK_CvComplementoPago_CtbCatMonedasSat");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.CvComplementoPagos)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK_CvComplementoPago_CvClientes");

                entity.HasOne(d => d.IdDepositoNavigation)
                    .WithMany(p => p.CvComplementoPagos)
                    .HasForeignKey(d => d.IdDeposito)
                    .HasConstraintName("FK_CvComplementoPago_CvDepositosCliente");

                entity.HasOne(d => d.IdDepositoSofolNavigation)
                    .WithMany(p => p.CvComplementoPagos)
                    .HasForeignKey(d => d.IdDepositoSofol)
                    .HasConstraintName("FK_IdDepositoSofol");

                entity.HasOne(d => d.IdDepositoSofolDetNavigation)
                    .WithMany(p => p.CvComplementoPagos)
                    .HasForeignKey(d => d.IdDepositoSofolDet)
                    .HasConstraintName("FK_CvComplementoPago_CvDepositosSofolDet");

                entity.HasOne(d => d.IdFormaPagoSatNavigation)
                    .WithMany(p => p.CvComplementoPagos)
                    .HasForeignKey(d => d.IdFormaPagoSat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvComplementoPago_AcCatFormasPagoSAT");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.CvComplementoPagos)
                    .HasForeignKey(d => d.IdProyecto)
                    .HasConstraintName("FK_CvComplementoPago_Proyectos");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.CvComplementoPagoIdUsuarioNavigations)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvComplementoPago_SegUsuarios");

                entity.HasOne(d => d.IdUsuarioCancelacionNavigation)
                    .WithMany(p => p.CvComplementoPagoIdUsuarioCancelacionNavigations)
                    .HasForeignKey(d => d.IdUsuarioCancelacion)
                    .HasConstraintName("FK_CvComplementoPago_SegUsuarios1");
            });

            modelBuilder.Entity<CvComplementoPagoCfd>(entity =>
            {
                entity.HasKey(e => e.IdComplementoPagoCfd);

                entity.ToTable("CvComplementoPagoCFD");

                entity.Property(e => e.IdComplementoPagoCfd).HasColumnName("IdComplementoPagoCFD");

                entity.Property(e => e.FechaHora).HasColumnType("datetime");

                entity.Property(e => e.Xmlcfd)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("XMLCFD");

                entity.HasOne(d => d.IdComplementoPagoNavigation)
                    .WithMany(p => p.CvComplementoPagoCfds)
                    .HasForeignKey(d => d.IdComplementoPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvComplementoPagoCFD_CvComplementoPago");
            });

            modelBuilder.Entity<CvComplementoPagoCfdirelac>(entity =>
            {
                entity.HasKey(e => e.IdCfdirelacionado);

                entity.ToTable("CvComplementoPagoCFDIRelac");

                entity.Property(e => e.IdCfdirelacionado).HasColumnName("IdCFDIRelacionado");

                entity.Property(e => e.Cfdirelacionado)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CFDIRelacionado");

                entity.HasOne(d => d.IdComplementoPagoNavigation)
                    .WithMany(p => p.CvComplementoPagoCfdirelacs)
                    .HasForeignKey(d => d.IdComplementoPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvComplementoPagoCFDIRelac_CvComplementoPago");
            });

            modelBuilder.Entity<CvComplementoPagoDet>(entity =>
            {
                entity.HasKey(e => e.IdComplementoPagoDet);

                entity.ToTable("CvComplementoPagoDet");

                entity.Property(e => e.IdXmlproveedor).HasColumnName("IdXMLProveedor");

                entity.Property(e => e.ImportePagado).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SaldoAnterior).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SaldoInsoluto).HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.IdClienteFacturaNavigation)
                    .WithMany(p => p.CvComplementoPagoDets)
                    .HasForeignKey(d => d.IdClienteFactura)
                    .HasConstraintName("FK_CvComplementoPagoDet_CvClientesFacturas");

                entity.HasOne(d => d.IdComplementoPagoNavigation)
                    .WithMany(p => p.CvComplementoPagoDets)
                    .HasForeignKey(d => d.IdComplementoPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvComplementoPagoDet_CvComplementoPago");

                entity.HasOne(d => d.IdXmlproveedorNavigation)
                    .WithMany(p => p.CvComplementoPagoDets)
                    .HasForeignKey(d => d.IdXmlproveedor)
                    .HasConstraintName("FK_CvComplementoPagoDet_AcProveedoresXML");
            });

            modelBuilder.Entity<CvConstructora>(entity =>
            {
                entity.HasKey(e => e.IdConstructora);

                entity.HasIndex(e => e.Constructora, "In_CvConstructorasConstructora")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Constructora)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Domicilio).HasMaxLength(80);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fax)
                    .HasMaxLength(30)
                    .HasColumnName("FAX");

                entity.Property(e => e.RazonSocial)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RepLegal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Rfc)
                    .HasMaxLength(13)
                    .HasColumnName("RFC");

                entity.Property(e => e.Telefono).HasMaxLength(30);
            });

            modelBuilder.Entity<CvContrato>(entity =>
            {
                entity.HasKey(e => e.IdContrato);

                entity.HasIndex(e => new { e.IdProyecto, e.IdContrato }, "IX_CvContratosCodigo1")
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.IdCredito, e.IdContrato }, "IX_CvContratosCodigo2")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Contrato, "IX_CvContratosContrato")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.BaseCalculoComisiones).HasColumnType("money");

                entity.Property(e => e.Contrato)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.EsViviendaTerreno)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaFirma).HasColumnType("smalldatetime");

                entity.Property(e => e.MontoAjuste).HasColumnType("money");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.CvContratos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvContratos_CvClientes1");

                entity.HasOne(d => d.IdPlantillaContratoNavigation)
                    .WithMany(p => p.CvContratos)
                    .HasForeignKey(d => d.IdPlantillaContrato)
                    .HasConstraintName("FK_CvContratos_CvPlantillasContratos");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.CvContratos)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvContratos_Proyectos");
            });

            modelBuilder.Entity<CvContratosAccesorio>(entity =>
            {
                entity.HasKey(e => e.IdContratoAccesorio);

                entity.HasIndex(e => e.IdContrato, "In_CvContratosAccesoriosIdContrato")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdProyectoAccesorio, "In_CvContratosAccesoriosIdProyectoAccesorio")
                    .HasFillFactor(90);

                entity.Property(e => e.Cantidad)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.HasOne(d => d.IdContratoNavigation)
                    .WithMany(p => p.CvContratosAccesorios)
                    .HasForeignKey(d => d.IdContrato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvContratosAccesorios_CvContratos");

                entity.HasOne(d => d.IdPlanPagoNavigation)
                    .WithMany(p => p.CvContratosAccesorios)
                    .HasForeignKey(d => d.IdPlanPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvContratosAccesorios_CvPlanesPagos");

                entity.HasOne(d => d.IdProyectoAccesorioNavigation)
                    .WithMany(p => p.CvContratosAccesorios)
                    .HasForeignKey(d => d.IdProyectoAccesorio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvContratosAccesorios_CvProyectosAccesorios1");

                entity.HasOne(d => d.IdSerieNavigation)
                    .WithMany(p => p.CvContratosAccesorios)
                    .HasForeignKey(d => d.IdSerie)
                    .HasConstraintName("FK_CvContratosAccesorios_CvSeries");

                entity.HasOne(d => d.IdTipoMonedaNavigation)
                    .WithMany(p => p.CvContratosAccesorios)
                    .HasForeignKey(d => d.IdTipoMoneda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvContratosAccesorios_AcCatMonedas");
            });

            modelBuilder.Entity<CvConyuge>(entity =>
            {
                entity.HasKey(e => e.IdConyuge);

                entity.HasIndex(e => e.IdCliente, "In_CvConyugesIdCliente")
                    .HasFillFactor(90);

                entity.Property(e => e.ApellidoMaterno).HasMaxLength(30);

                entity.Property(e => e.ApellidoPaterno).HasMaxLength(30);

                entity.Property(e => e.Curp)
                    .HasMaxLength(18)
                    .HasColumnName("CURP");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNacimiento).HasColumnType("smalldatetime");

                entity.Property(e => e.FmontoAutorizado)
                    .HasColumnType("money")
                    .HasColumnName("FMontoAutorizado");

                entity.Property(e => e.FpensionAlimenticia)
                    .HasColumnType("money")
                    .HasColumnName("FPensionAlimenticia");

                entity.Property(e => e.IngresoMensComp).HasColumnType("money");

                entity.Property(e => e.Lada)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Nacionalidad).HasMaxLength(20);

                entity.Property(e => e.NoImss)
                    .HasMaxLength(20)
                    .HasColumnName("NoIMSS");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.PuntosInfonavit).HasColumnType("smallmoney");

                entity.Property(e => e.Rfc)
                    .HasMaxLength(13)
                    .HasColumnName("RFC");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoCelular)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.EscolaridadNavigation)
                    .WithMany(p => p.CvConyuges)
                    .HasForeignKey(d => d.Escolaridad)
                    .HasConstraintName("FK_CvConyuges_CvFEscolaridad");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.CvConyuges)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvConyuges_CvClientes");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.CvConyuges)
                    .HasForeignKey(d => d.IdEmpresa)
                    .HasConstraintName("FK_CvConyuges_CvEmpresas1");
            });

            modelBuilder.Entity<CvCotizacione>(entity =>
            {
                entity.HasKey(e => e.IdCotizacion);

                entity.Property(e => e.FechaCotizacion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaIndividualizacion).HasColumnType("smalldatetime");

                entity.Property(e => e.MontoApartado).HasColumnType("money");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TextoExtra)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CvCotizacionesDet>(entity =>
            {
                entity.HasKey(e => e.IdCotizacionDet);

                entity.ToTable("CvCotizacionesDet");

                entity.Property(e => e.AniosCredito).HasColumnType("money");

                entity.Property(e => e.AportacionPatronal).HasColumnType("money");

                entity.Property(e => e.IngresoMinimo).HasColumnType("money");

                entity.Property(e => e.InversionInicial).HasColumnType("money");

                entity.Property(e => e.MontoCredito).HasColumnType("money");

                entity.Property(e => e.PagoMensual).HasColumnType("money");

                entity.Property(e => e.PagoMensualNeto).HasColumnType("money");

                entity.HasOne(d => d.IdCotizacionNavigation)
                    .WithMany(p => p.CvCotizacionesDets)
                    .HasForeignKey(d => d.IdCotizacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvCotizacionesDet_CvCotizaciones");

                entity.HasOne(d => d.IdCreditoNavigation)
                    .WithMany(p => p.CvCotizacionesDets)
                    .HasForeignKey(d => d.IdCredito)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvCotizacionesDet_CvCreditos");
            });

            modelBuilder.Entity<CvCredito>(entity =>
            {
                entity.HasKey(e => e.IdCredito)
                    .HasName("PK_CvTiposCreditos");

                entity.HasIndex(e => e.Credito, "In_CvTiposCreditosCredito")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Ansi)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Credito)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.DatosAdicionales)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.EscalaRelleno).HasColumnType("smallmoney");

                entity.Property(e => e.Texto)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<CvDepositosCliente>(entity =>
            {
                entity.HasKey(e => e.IdDeposito);

                entity.ToTable("CvDepositosCliente");

                entity.HasIndex(e => e.FolioDeposito, "IX_CvDepositosCliente")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.AutomaticoDalton).HasDefaultValueSql("((0))");

                entity.Property(e => e.BancoExtDepositante)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BancoSatdepositante)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BancoSATDepositante");

                entity.Property(e => e.ClaveMetodoPago)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ClaveMonedaSat)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ClaveMonedaSAT");

                entity.Property(e => e.CuentaBancariaDepositante)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionCancelacion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaCancelacion).HasColumnType("smalldatetime");

                entity.Property(e => e.MontoTotalDeposito).HasColumnType("money");

                entity.Property(e => e.NumCheque)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Paridad)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Referencia)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rfcdepositante)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("RFCDepositante");

                entity.HasOne(d => d.IdCuentaBancariaNavigation)
                    .WithMany(p => p.CvDepositosClientes)
                    .HasForeignKey(d => d.IdCuentaBancaria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvDepositosCliente_CtaCuentas");

                entity.HasOne(d => d.IdPolizaNavigation)
                    .WithMany(p => p.CvDepositosClienteIdPolizaNavigations)
                    .HasForeignKey(d => d.IdPoliza)
                    .HasConstraintName("FK_CvDepositosCliente_CtbMtoPolizas");

                entity.HasOne(d => d.IdPolizaInversaNavigation)
                    .WithMany(p => p.CvDepositosClienteIdPolizaInversaNavigations)
                    .HasForeignKey(d => d.IdPolizaInversa)
                    .HasConstraintName("FK_CvDepositosCliente_CtbMtoPolizas1");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.CvDepositosClientes)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvDepositosCliente_Proyectos");
            });

            modelBuilder.Entity<CvDepositosSofol>(entity =>
            {
                entity.HasKey(e => e.IdDepositoSofol);

                entity.ToTable("CvDepositosSofol");

                entity.HasIndex(e => e.FolioDepositoSofol, "IX_CvDepositosSofolFolio")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.DescripcionCancelacion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAplicacion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaCancelacion).HasColumnType("smalldatetime");

                entity.Property(e => e.FolioSolicitud)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MontoAmortizaciones).HasColumnType("money");

                entity.Property(e => e.MontoComisiones).HasColumnType("money");

                entity.Property(e => e.MontoDeposito).HasColumnType("money");

                entity.Property(e => e.MontoPago).HasColumnType("money");

                entity.HasOne(d => d.IdCuentaBancariaNavigation)
                    .WithMany(p => p.CvDepositosSofols)
                    .HasForeignKey(d => d.IdCuentaBancaria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvDepositosSofol_CtaCuentas");

                entity.HasOne(d => d.IdPolizaNavigation)
                    .WithMany(p => p.CvDepositosSofolIdPolizaNavigations)
                    .HasForeignKey(d => d.IdPoliza)
                    .HasConstraintName("FK_CvDepositosSofol_CtbMtoPolizas");

                entity.HasOne(d => d.IdPolizaInversaNavigation)
                    .WithMany(p => p.CvDepositosSofolIdPolizaInversaNavigations)
                    .HasForeignKey(d => d.IdPolizaInversa)
                    .HasConstraintName("FK_CvDepositosSofol_CtbMtoPolizas1");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.CvDepositosSofols)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvDepositosSofol_Proyectos");

                entity.HasOne(d => d.IdSofolNavigation)
                    .WithMany(p => p.CvDepositosSofols)
                    .HasForeignKey(d => d.IdSofol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvDepositosSofol_CvSofoles");
            });

            modelBuilder.Entity<CvDepositosSofolCta>(entity =>
            {
                entity.HasKey(e => e.IdDepositoSofolCta);

                entity.HasIndex(e => e.IdCuenta, "IX_CvDepositosSofolCtas")
                    .HasFillFactor(90);

                entity.Property(e => e.IdExplosionInsumos).HasColumnName("idExplosionInsumos");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithMany(p => p.CvDepositosSofolCta)
                    .HasForeignKey(d => d.IdCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvDepositosSofolCtas_Cuentas1");

                entity.HasOne(d => d.IdDepositoSofolNavigation)
                    .WithMany(p => p.CvDepositosSofolCta)
                    .HasForeignKey(d => d.IdDepositoSofol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvDepositosSofolCtas_CvDepositosSofol");

                entity.HasOne(d => d.IdExplosionInsumosNavigation)
                    .WithMany(p => p.CvDepositosSofolCta)
                    .HasForeignKey(d => d.IdExplosionInsumos)
                    .HasConstraintName("FK_CvDepositosSofolCtas_AcExplosionInsumos");
            });

            modelBuilder.Entity<CvDepositosSofolDet>(entity =>
            {
                entity.HasKey(e => e.IdDepositoSofolDet);

                entity.ToTable("CvDepositosSofolDet");

                entity.Property(e => e.BancoExtDepositante)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BancoSatdepositante)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BancoSATDepositante");

                entity.Property(e => e.ClaveMetodoPago)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ClaveMonedaSat)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ClaveMonedaSAT");

                entity.Property(e => e.CuentaBancariaDepositante)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MontoAmortizacionPuente).HasColumnType("money");

                entity.Property(e => e.MontoBase).HasColumnType("money");

                entity.Property(e => e.MontoComisionPuente).HasColumnType("money");

                entity.Property(e => e.MontoDocumento).HasColumnType("money");

                entity.Property(e => e.MontoExcedente).HasColumnType("money");

                entity.Property(e => e.NumCheque)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rfcdepositante)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("RFCDepositante");

                entity.HasOne(d => d.IdAjusteClienteNavigation)
                    .WithMany(p => p.CvDepositosSofolDets)
                    .HasForeignKey(d => d.IdAjusteCliente)
                    .HasConstraintName("FK_CvDepositosSofolDet_CvAjusteClientes");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.CvDepositosSofolDets)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvDepositosSofolDet_CvClientes");

                entity.HasOne(d => d.IdContratoNavigation)
                    .WithMany(p => p.CvDepositosSofolDets)
                    .HasForeignKey(d => d.IdContrato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvDepositosSofolDet_CvContratos");

                entity.HasOne(d => d.IdDepositosofolNavigation)
                    .WithMany(p => p.CvDepositosSofolDets)
                    .HasForeignKey(d => d.IdDepositosofol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvDepositosSofolDet_CvDepositosSofol");

                entity.HasOne(d => d.IdPlanPagoDetNavigation)
                    .WithMany(p => p.CvDepositosSofolDets)
                    .HasForeignKey(d => d.IdPlanPagoDet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvDepositosSofolDet_CvPlanesPagosDet");
            });

            modelBuilder.Entity<CvDesarrollo>(entity =>
            {
                entity.HasKey(e => e.IdDesarrollo)
                    .HasName("PK_CvDesarrollo");

                entity.HasIndex(e => e.Desarrollo, "In_CvDesarrolloDesarrollo")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Desarrollo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Texto).HasMaxLength(40);
            });

            modelBuilder.Entity<CvDisponibilidadCasaDeseadum>(entity =>
            {
                entity.HasKey(e => e.IdDisponibilidadCasaDeseada);

                entity.HasIndex(e => e.DisponibilidadCasaDeseada, "IX_CvDisponibilidadCasaDeseada")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.DisponibilidadCasaDeseada)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CvDocumento>(entity =>
            {
                entity.HasKey(e => e.IdDocumento);

                entity.HasIndex(e => e.IdCredito, "In_CvDocumentosIdCredito")
                    .HasFillFactor(90);

                entity.Property(e => e.RutaDocumento)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Texto)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdCreditoNavigation)
                    .WithMany(p => p.CvDocumentos)
                    .HasForeignKey(d => d.IdCredito)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvDocumentos_CvTiposCreditos");
            });

            modelBuilder.Entity<CvDocumentosCliente>(entity =>
            {
                entity.HasKey(e => e.IdDocumentoCliente);

                entity.HasIndex(e => e.DocumentoCliente, "IX_CvDocumentosClientesDocumento")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.DocumentoCliente)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Texto)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<CvEconomium>(entity =>
            {
                entity.HasKey(e => e.IdEconomia);

                entity.HasIndex(e => e.Economia, "IX_CvEconomiaTexto")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdEconomia).ValueGeneratedOnAdd();

                entity.Property(e => e.Economia)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CvEmpresa>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa);

                entity.HasIndex(e => e.Empresa, "In_CvEmpresasEmpresa")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.CodPost).HasMaxLength(6);

                entity.Property(e => e.Colonia).HasMaxLength(30);

                entity.Property(e => e.Direccion).HasMaxLength(80);

                entity.Property(e => e.Empresa)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Extension)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Flocalidad)
                    .HasMaxLength(20)
                    .HasColumnName("FLocalidad");

                entity.Property(e => e.Flote)
                    .HasMaxLength(2)
                    .HasColumnName("FLote");

                entity.Property(e => e.Fmanzana)
                    .HasMaxLength(3)
                    .HasColumnName("FManzana");

                entity.Property(e => e.FnumExterior)
                    .HasMaxLength(4)
                    .HasColumnName("FNumExterior");

                entity.Property(e => e.FnumInterior)
                    .HasMaxLength(4)
                    .HasColumnName("FNumInterior");

                entity.Property(e => e.HoraFin).HasColumnType("smalldatetime");

                entity.Property(e => e.HoraInicio).HasColumnType("smalldatetime");

                entity.Property(e => e.Imss)
                    .HasMaxLength(20)
                    .HasColumnName("IMSS");

                entity.Property(e => e.Lada)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MpioDeleg).HasMaxLength(30);

                entity.Property(e => e.PuestoRepLegal).HasMaxLength(20);

                entity.Property(e => e.RazonSocial)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RegistroPatronal).HasMaxLength(11);

                entity.Property(e => e.RepLegal).HasMaxLength(50);

                entity.Property(e => e.Rfc)
                    .HasMaxLength(13)
                    .HasColumnName("RFC");

                entity.Property(e => e.Telefono).HasMaxLength(30);

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.CvEmpresas)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_CvEmpresas_Estados");

                entity.HasOne(d => d.IdSindicatoNavigation)
                    .WithMany(p => p.CvEmpresas)
                    .HasForeignKey(d => d.IdSindicato)
                    .HasConstraintName("FK_CvEmpresas_CvSindicatos");
            });

            modelBuilder.Entity<CvEtapa>(entity =>
            {
                entity.HasKey(e => e.IdEtapa);

                entity.HasIndex(e => e.Etapa, "IN_CvEtapas_Etapa")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Etapa)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Texto).HasMaxLength(40);
            });

            modelBuilder.Entity<CvEtapasCliente>(entity =>
            {
                entity.HasKey(e => e.IdEtapaCliente)
                    .HasName("PK_CvEtapasClientesIdEtapaCliente");

                entity.HasIndex(e => e.EtapaCliente, "IX_CvEtapasClientesEtapaCliente")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.EtapaCliente)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Texto)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasDefaultValueSql("(N'DESCRIPCION')");
            });

            modelBuilder.Entity<CvEtapasVivienda>(entity =>
            {
                entity.HasKey(e => e.IdEtapaVivienda)
                    .HasName("PK_CvEtapasViviendasIdEtapaVivienda");

                entity.HasIndex(e => e.EtapaVivienda, "In_CvEtapasViviendasEtapaVivienda")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.EtapaVivienda)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Texto)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasDefaultValueSql("(N'DESCRIPCION')");
            });

            modelBuilder.Entity<CvFaplicarAhorro>(entity =>
            {
                entity.HasKey(e => e.IdFaplicarAhorro);

                entity.ToTable("CvFAplicarAhorro");

                entity.HasIndex(e => e.FaplicarAhorro, "IX_CvFAplicarAhorroTexto")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdFaplicarAhorro)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IdFAplicarAhorro");

                entity.Property(e => e.FaplicarAhorro)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAplicarAhorro");
            });

            modelBuilder.Entity<CvFcreditoConyugal>(entity =>
            {
                entity.HasKey(e => e.IdFcreditoConyugal);

                entity.ToTable("CvFCreditoConyugal");

                entity.HasIndex(e => e.FcreditoConyugal, "IX_CvFCreditoConyugalTexto")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdFcreditoConyugal)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IdFCreditoConyugal");

                entity.Property(e => e.FcreditoConyugal)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FCreditoConyugal");
            });

            modelBuilder.Entity<CvFdestinoCredito>(entity =>
            {
                entity.HasKey(e => e.IdFdestinoCredito);

                entity.ToTable("CvFDestinoCredito");

                entity.HasIndex(e => e.FdestinoCredito, "IX_CvFDestinoCredito")
                    .IsUnique();

                entity.Property(e => e.IdFdestinoCredito).HasColumnName("IdFDestinoCredito");

                entity.Property(e => e.FdestinoCredito)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FDestinoCredito");
            });

            modelBuilder.Entity<CvFescolaridad>(entity =>
            {
                entity.HasKey(e => e.IdFescolaridad);

                entity.ToTable("CvFEscolaridad");

                entity.HasIndex(e => e.Fescolaridad, "IX_CvFEscolaridadTexto")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdFescolaridad)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IdFEscolaridad");

                entity.Property(e => e.Fescolaridad)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FEscolaridad");
            });

            modelBuilder.Entity<CvFestadoCivil>(entity =>
            {
                entity.HasKey(e => e.IdFestadoCivil);

                entity.ToTable("CvFEstadoCivil");

                entity.HasIndex(e => e.FestadoCivil, "IX_CvFEstadoCivilTexto")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdFestadoCivil)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IdFEstadoCivil");

                entity.Property(e => e.FestadoCivil)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FEstadoCivil");
            });

            modelBuilder.Entity<CvFestadoViviendum>(entity =>
            {
                entity.HasKey(e => e.IdFestadoVivienda)
                    .HasName("PK_CvFEstadoVivienda_1");

                entity.ToTable("CvFEstadoVivienda");

                entity.HasIndex(e => e.FestadoVivienda, "IX_CVFEstadoViviendaFEstadoVivienda")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Texto, "IX_CVFEstadoViviendaTexto")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdFestadoVivienda)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IdFEstadoVivienda");

                entity.Property(e => e.FestadoVivienda).HasColumnName("FEstadoVivienda");

                entity.Property(e => e.Texto)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CvFformaCredito>(entity =>
            {
                entity.HasKey(e => e.IdFformaCredito);

                entity.ToTable("CvFFormaCredito");

                entity.HasIndex(e => e.FformaCredito, "IX_CvFFormaCredito")
                    .IsUnique();

                entity.Property(e => e.IdFformaCredito)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IdFFormaCredito");

                entity.Property(e => e.FformaCredito)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FFormaCredito");
            });

            modelBuilder.Entity<CvFlineaCredito>(entity =>
            {
                entity.HasKey(e => e.IdFlineaCredito);

                entity.ToTable("CvFLineaCredito");

                entity.HasIndex(e => e.IdFlineaCredito, "IX_CvFLineaCreditoFLineaCredito")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Texto, "IX_CvFLineaCreditoTexto")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdFlineaCredito)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IdFLineaCredito");

                entity.Property(e => e.FlineaCredito).HasColumnName("FLineaCredito");

                entity.Property(e => e.Texto)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CvFlujoCliente>(entity =>
            {
                entity.HasKey(e => e.IdFlujoCliente)
                    .HasName("PK_CvFlujoCliente");

                entity.HasIndex(e => new { e.IdCliente, e.IdCetapa }, "IX_CvFlujoClienteCodigo")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.FechaInicio).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaTerminado).HasColumnType("smalldatetime");

                entity.Property(e => e.IdCetapa).HasColumnName("IdCEtapa");

                entity.HasOne(d => d.DirectorNavigation)
                    .WithMany(p => p.CvFlujoClienteDirectorNavigations)
                    .HasForeignKey(d => d.Director)
                    .HasConstraintName("FK_CvFlujoCliente_CvVendedores3");

                entity.HasOne(d => d.GerenteNavigation)
                    .WithMany(p => p.CvFlujoClienteGerenteNavigations)
                    .HasForeignKey(d => d.Gerente)
                    .HasConstraintName("FK_CvFlujoCliente_CvVendedores2");

                entity.HasOne(d => d.IdCetapaNavigation)
                    .WithMany(p => p.CvFlujoClientes)
                    .HasForeignKey(d => d.IdCetapa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvFlujoCliente_CvPCEtapa");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.CvFlujoClientes)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvFlujoCliente_CvClientes");

                entity.HasOne(d => d.Vendedor1Navigation)
                    .WithMany(p => p.CvFlujoClienteVendedor1Navigations)
                    .HasForeignKey(d => d.Vendedor1)
                    .HasConstraintName("FK_CvFlujoCliente_CvVendedores");

                entity.HasOne(d => d.Vendedor2Navigation)
                    .WithMany(p => p.CvFlujoClienteVendedor2Navigations)
                    .HasForeignKey(d => d.Vendedor2)
                    .HasConstraintName("FK_CvFlujoCliente_CvVendedores1");

                entity.HasOne(d => d.Vendedor3Navigation)
                    .WithMany(p => p.CvFlujoClienteVendedor3Navigations)
                    .HasForeignKey(d => d.Vendedor3)
                    .HasConstraintName("FK_CvFlujoClientes_CvVendedores");

                entity.HasOne(d => d.Vendedor4Navigation)
                    .WithMany(p => p.CvFlujoClienteVendedor4Navigations)
                    .HasForeignKey(d => d.Vendedor4)
                    .HasConstraintName("FK_CvFlujoClientes_CvVendedores1");

                entity.HasOne(d => d.VendedorExternoNavigation)
                    .WithMany(p => p.CvFlujoClienteVendedorExternoNavigations)
                    .HasForeignKey(d => d.VendedorExterno)
                    .HasConstraintName("FK_CvFlujoCliente_CvVendedores4");
            });

            modelBuilder.Entity<CvFlujoClientesDet>(entity =>
            {
                entity.HasKey(e => e.IdFlujoClienteDet)
                    .HasName("PK_CvFlujoClienteDet");

                entity.ToTable("CvFlujoClientesDet");

                entity.HasIndex(e => new { e.IdFlujoCliente, e.IdCetapaDet }, "IX_CvFlujoClienteDetCodigo")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.FechaTerminado).HasColumnType("smalldatetime");

                entity.Property(e => e.IdCetapaDet).HasColumnName("IdCEtapaDet");

                entity.Property(e => e.RutaDocumento)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCetapaDetNavigation)
                    .WithMany(p => p.CvFlujoClientesDets)
                    .HasForeignKey(d => d.IdCetapaDet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvFlujoClienteDet_CvPCActividadDet");

                entity.HasOne(d => d.IdFlujoClienteNavigation)
                    .WithMany(p => p.CvFlujoClientesDets)
                    .HasForeignKey(d => d.IdFlujoCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvFlujoClienteDet_CvFlujoCliente");
            });

            modelBuilder.Entity<CvFlujoVivienda>(entity =>
            {
                entity.HasKey(e => e.IdFlujoVivienda)
                    .HasName("PK_CvFlujoViviendasIdFlujoVivienda");

                entity.HasIndex(e => new { e.IdVivienda, e.IdPetapa }, "IX_CvFlujoViviendasCodigo")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.FechaInicio).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaTerminacion).HasColumnType("smalldatetime");

                entity.Property(e => e.IdPetapa).HasColumnName("IdPEtapa");

                entity.HasOne(d => d.IdPetapaNavigation)
                    .WithMany(p => p.CvFlujoVivienda)
                    .HasForeignKey(d => d.IdPetapa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvFlujoViviendas_CvPEtapas");
            });

            modelBuilder.Entity<CvFopcCreditoVsm>(entity =>
            {
                entity.HasKey(e => e.IdFopcCreditoVsm);

                entity.ToTable("CvFOpcCreditoVSM");

                entity.HasIndex(e => e.FopcCreditoVsm, "IX_CvFOpcCreditoVSM")
                    .IsUnique();

                entity.Property(e => e.IdFopcCreditoVsm)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IdFOpcCreditoVSM");

                entity.Property(e => e.FopcCreditoVsm)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FOpcCreditoVSM");
            });

            modelBuilder.Entity<CvFplazosCredito>(entity =>
            {
                entity.HasKey(e => e.IdFplazoCredito);

                entity.ToTable("CvFPlazosCredito");

                entity.HasIndex(e => e.FplazoCredito, "IX_CvFPlazosCredito")
                    .IsUnique();

                entity.Property(e => e.IdFplazoCredito)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IdFPlazoCredito");

                entity.Property(e => e.FplazoCredito)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FPlazoCredito");
            });

            modelBuilder.Entity<CvFproducto>(entity =>
            {
                entity.HasKey(e => e.IdFproducto);

                entity.ToTable("CvFProducto");

                entity.HasIndex(e => e.Fproducto, "IX_CvFProducto")
                    .IsUnique();

                entity.Property(e => e.IdFproducto).HasColumnName("IdFProducto");

                entity.Property(e => e.Fproducto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FProducto");
            });

            modelBuilder.Entity<CvFtipoCompra>(entity =>
            {
                entity.HasKey(e => e.IdFtipoCompra);

                entity.ToTable("CvFTipoCompra");

                entity.HasIndex(e => e.FtipoCompra, "IX_CvFTipoCompraFTipoCompra")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Texto, "IX_CvFTipoCompraTexto")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdFtipoCompra)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IdFTipoCompra");

                entity.Property(e => e.FtipoCompra).HasColumnName("FTipoCompra");

                entity.Property(e => e.Texto)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CvFtipoDiscapacidad>(entity =>
            {
                entity.HasKey(e => e.IdFtipoDiscapacidad);

                entity.ToTable("CvFTipoDiscapacidad");

                entity.HasIndex(e => e.FtipoDiscapacidad, "IX_CvFTipoDiscapacidadTexto")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdFtipoDiscapacidad)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IdFTipoDiscapacidad");

                entity.Property(e => e.FtipoDiscapacidad)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FTipoDiscapacidad");
            });

            modelBuilder.Entity<CvFtipoMercado>(entity =>
            {
                entity.HasKey(e => e.IdFtipoMercado);

                entity.ToTable("CvFTipoMercado");

                entity.HasIndex(e => e.FtipoMercado, "IX_CvFTipoMercadoFTipoMercado")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Texto, "IX_CvFTipoMercadoTexto")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdFtipoMercado)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IdFTipoMercado");

                entity.Property(e => e.FtipoMercado).HasColumnName("FTipoMercado");

                entity.Property(e => e.Texto)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CvFtipoOfertacion>(entity =>
            {
                entity.HasKey(e => e.IdFtipoOfertacion);

                entity.ToTable("CvFTipoOfertacion");

                entity.HasIndex(e => e.FtipoOfertacion, "IX_CvFTipoOfertacionFTipoOfertacion")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Texto, "IX_CvFTipoOfertacionTexto")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdFtipoOfertacion)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IdFTipoOfertacion");

                entity.Property(e => e.FtipoOfertacion).HasColumnName("FTipoOfertacion");

                entity.Property(e => e.Texto)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CvGravamene>(entity =>
            {
                entity.HasKey(e => e.IdGravamen);

                entity.HasIndex(e => e.Gravamen, "IX_CvGravamenes")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Gravamen)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Texto)
                    .IsRequired()
                    .HasMaxLength(70);
            });

            modelBuilder.Entity<CvIdentificacionesOficiale>(entity =>
            {
                entity.HasKey(e => e.IdIdentificacionOficial);

                entity.HasIndex(e => e.IdentificacionOficial, "IX_CvIdentificacionesOficiales")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdentificacionOficial)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Texto)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<CvInmobiliaria>(entity =>
            {
                entity.HasKey(e => e.IdInmobiliaria);

                entity.HasIndex(e => e.Inmobiliaria, "In_CvInmobiliariasInmobiliaria")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Contacto).HasMaxLength(50);

                entity.Property(e => e.Direccion).HasMaxLength(80);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FechaNacimiento).HasColumnType("smalldatetime");

                entity.Property(e => e.Inmobiliaria)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Nacionalidad).HasMaxLength(20);

                entity.Property(e => e.RazonSocial)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Rfc)
                    .HasMaxLength(13)
                    .HasColumnName("RFC");

                entity.Property(e => e.Telefono).HasMaxLength(30);
            });

            modelBuilder.Entity<CvManzana>(entity =>
            {
                entity.HasKey(e => e.IdManzana);

                entity.HasIndex(e => e.Manzana, "In_Manzanas")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdManzana).HasColumnName("idManzana");

                entity.Property(e => e.Manzana)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Texto).HasMaxLength(40);
            });

            modelBuilder.Entity<CvMedio>(entity =>
            {
                entity.HasKey(e => e.IdMedio)
                    .HasName("PK_CvCatMedios");

                entity.HasIndex(e => e.Medio, "In_CvCatMediosMedio")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Medio)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Texto)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasDefaultValueSql("(N'DESCRIPCION')");
            });

            modelBuilder.Entity<CvNotaria>(entity =>
            {
                entity.HasKey(e => e.IdNotaria);

                entity.HasIndex(e => e.Notaria, "In_CvNotariasNotaria")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Contacto).HasMaxLength(100);

                entity.Property(e => e.DireccionCompleta).HasMaxLength(250);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(30);

                entity.Property(e => e.NombreNotaria)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Notaria)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Notario)
                    .IsRequired()
                    .HasMaxLength(90);

                entity.Property(e => e.Telefono).HasMaxLength(30);
            });

            modelBuilder.Entity<CvNotasEscritura>(entity =>
            {
                entity.HasKey(e => e.IdNotaEscritura)
                    .HasName("PK_CvMovEscrituras");

                entity.HasIndex(e => new { e.Folio, e.IdTipoNota }, "IX_CvMovEscrituras")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Descripcion).HasMaxLength(40);

                entity.Property(e => e.DescripcionCancelacion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaCancelacion).HasColumnType("smalldatetime");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.MontoIva)
                    .HasColumnType("money")
                    .HasColumnName("MontoIVA");

                entity.HasOne(d => d.IdAjusteClienteNavigation)
                    .WithMany(p => p.CvNotasEscrituras)
                    .HasForeignKey(d => d.IdAjusteCliente)
                    .HasConstraintName("FK_CvMovEscrituras_CvAjusteClientes");

                entity.HasOne(d => d.IdClienteEscrituracionNavigation)
                    .WithMany(p => p.CvNotasEscrituras)
                    .HasForeignKey(d => d.IdClienteEscrituracion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvMovEscrituras_CvClienteEscrituracion");

                entity.HasOne(d => d.IdPolizaNavigation)
                    .WithMany(p => p.CvNotasEscrituraIdPolizaNavigations)
                    .HasForeignKey(d => d.IdPoliza)
                    .HasConstraintName("FK_CvMovEscrituras_CtbMtoPolizas");

                entity.HasOne(d => d.IdPolizaInversaNavigation)
                    .WithMany(p => p.CvNotasEscrituraIdPolizaInversaNavigations)
                    .HasForeignKey(d => d.IdPolizaInversa)
                    .HasConstraintName("FK_CvMovEscrituras_CtbMtoPolizas1");

                entity.HasOne(d => d.IdTipoNotaNavigation)
                    .WithMany(p => p.CvNotasEscrituras)
                    .HasForeignKey(d => d.IdTipoNota)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvMovEscrituras_CvTiposNotas");
            });

            modelBuilder.Entity<CvOpcionesPagoConEnganche>(entity =>
            {
                entity.HasKey(e => e.IdOpcionPagoConEnganche);

                entity.ToTable("CvOpcionesPagoConEnganche");

                entity.HasIndex(e => e.OpcionPagoConEnganche, "IX_CvOpcionesPagoConEnganche")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.NoPagosCredito).HasDefaultValueSql("((1))");

                entity.Property(e => e.NoPagosEnganche).HasDefaultValueSql("((1))");

                entity.Property(e => e.OpcionPagoConEnganche)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PorcentajeEnganche)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TasaIntAnualCredito).HasColumnType("smallmoney");

                entity.Property(e => e.TasaIntAnualEnganche).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<CvPagoLiberacionVivienda>(entity =>
            {
                entity.HasKey(e => e.IdPagoLiberacionVivienda);

                entity.HasIndex(e => e.IdCuentaCargo, "IX_CvPagoLiberacionViviendas")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuentaPasivo, "IX_CvPagoLiberacionViviendas_1")
                    .HasFillFactor(90);

                entity.Property(e => e.DescripcionCancelacion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaCancelacion).HasColumnType("smalldatetime");

                entity.Property(e => e.MontoPago).HasColumnType("money");

                entity.HasOne(d => d.IdCuentaCargoNavigation)
                    .WithMany(p => p.CvPagoLiberacionViviendaIdCuentaCargoNavigations)
                    .HasForeignKey(d => d.IdCuentaCargo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvPagoLiberacionViviendas_Cuentas");

                entity.HasOne(d => d.IdCuentaPasivoNavigation)
                    .WithMany(p => p.CvPagoLiberacionViviendaIdCuentaPasivoNavigations)
                    .HasForeignKey(d => d.IdCuentaPasivo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvPagoLiberacionViviendas_Cuentas1");

                entity.HasOne(d => d.IdInsumoNavigation)
                    .WithMany(p => p.CvPagoLiberacionVivienda)
                    .HasForeignKey(d => d.IdInsumo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvPagoLiberacionViviendas_Catalogo");

                entity.HasOne(d => d.IdPolizaNavigation)
                    .WithMany(p => p.CvPagoLiberacionViviendaIdPolizaNavigations)
                    .HasForeignKey(d => d.IdPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvPagoLiberacionViviendas_CtbMtoPolizas");

                entity.HasOne(d => d.IdPolizaInversaNavigation)
                    .WithMany(p => p.CvPagoLiberacionViviendaIdPolizaInversaNavigations)
                    .HasForeignKey(d => d.IdPolizaInversa)
                    .HasConstraintName("FK_CvPagoLiberacionViviendas_CtbMtoPolizas1");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.CvPagoLiberacionVivienda)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvPagoLiberacionViviendas_Proyectos");
            });

            modelBuilder.Entity<CvPagoLiberacionViviendasDet>(entity =>
            {
                entity.HasKey(e => e.IdPagoLiberacionViviendaDet);

                entity.ToTable("CvPagoLiberacionViviendasDet");

                entity.HasIndex(e => new { e.IdPagoLiberacionVivienda, e.IdVivienda }, "IX_CvPagoLiberacionViviendasDet")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.MontoAmortizacion).HasColumnType("money");

                entity.HasOne(d => d.IdPagoLiberacionViviendaNavigation)
                    .WithMany(p => p.CvPagoLiberacionViviendasDets)
                    .HasForeignKey(d => d.IdPagoLiberacionVivienda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvPagoLiberacionViviendasDet_CvPagoLiberacionViviendas");
            });

            modelBuilder.Entity<CvPaquetesInstitucione>(entity =>
            {
                entity.HasKey(e => e.IdPaqueteInstitucion);

                entity.HasIndex(e => new { e.IdProyectoPaquete, e.IdVivienda }, "IX_CvPaquetesInstituciones")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasOne(d => d.IdProyectoPaqueteNavigation)
                    .WithMany(p => p.CvPaquetesInstituciones)
                    .HasForeignKey(d => d.IdProyectoPaquete)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvPaquetesInstituciones_CvPaquetes");
            });

            modelBuilder.Entity<CvParametro>(entity =>
            {
                entity.HasKey(e => e.IdParametro);

                entity.HasIndex(e => e.Parametro, "In_CvParametrosParametro")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Explicacion).HasMaxLength(75);

                entity.Property(e => e.Parametro)
                    .IsRequired()
                    .HasMaxLength(35);

                entity.Property(e => e.Valor).HasMaxLength(255);
            });

            modelBuilder.Entity<CvPcecomisione>(entity =>
            {
                entity.HasKey(e => e.IdPcecomision)
                    .HasName("PK_CvPEComisiones");

                entity.ToTable("CvPCEComisiones");

                entity.HasIndex(e => new { e.IdProyectoCredito, e.IdCetapa }, "IX_CvPEComisionesCodigo")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdPcecomision).HasColumnName("IdPCEComision");

                entity.Property(e => e.ComisionDirector).HasColumnType("smallmoney");

                entity.Property(e => e.ComisionExterno).HasColumnType("smallmoney");

                entity.Property(e => e.ComisionGerente).HasColumnType("smallmoney");

                entity.Property(e => e.ComisionVendedor1).HasColumnType("smallmoney");

                entity.Property(e => e.ComisionVendedor2).HasColumnType("smallmoney");

                entity.Property(e => e.ComisionVendedor3).HasColumnType("smallmoney");

                entity.Property(e => e.ComisionVendedor4).HasColumnType("smallmoney");

                entity.Property(e => e.ComisionVendedor5).HasColumnType("smallmoney");

                entity.Property(e => e.IdCetapa).HasColumnName("IdCEtapa");

                entity.HasOne(d => d.IdCetapaNavigation)
                    .WithMany(p => p.CvPcecomisiones)
                    .HasForeignKey(d => d.IdCetapa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvPEComisiones_CvCEtapas");

                entity.HasOne(d => d.IdProyectoCreditoNavigation)
                    .WithMany(p => p.CvPcecomisiones)
                    .HasForeignKey(d => d.IdProyectoCredito)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvPEComisiones_CvProyectosCreditos");
            });

            modelBuilder.Entity<CvPetapa>(entity =>
            {
                entity.HasKey(e => e.IdPetapa)
                    .HasName("PK_CvPPEtapasIdPPEtapa");

                entity.ToTable("CvPEtapas");

                entity.HasIndex(e => new { e.IdPrototipo, e.IdEtapaVivienda }, "IX_CvPPEtapasCodigo")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdPetapa).HasColumnName("IdPEtapa");

                entity.Property(e => e.Renglon).HasDefaultValueSql("((10))");

                entity.HasOne(d => d.IdEtapaViviendaNavigation)
                    .WithMany(p => p.CvPetapas)
                    .HasForeignKey(d => d.IdEtapaVivienda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvProyectosPrototiposActividades_CvActividades");

                entity.HasOne(d => d.IdPrototipoNavigation)
                    .WithMany(p => p.CvPetapas)
                    .HasForeignKey(d => d.IdPrototipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvPPEtapas_CvPrototipos");
            });

            modelBuilder.Entity<CvPlanesPago>(entity =>
            {
                entity.HasKey(e => e.IdPlanPago);

                entity.HasIndex(e => new { e.IdContrato, e.PlanPago }, "IX_CvPlanesPagos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuentaSe, "IX_CvPlanesPagos_1")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuentaCe, "IX_CvPlanesPagos_2")
                    .HasFillFactor(90);

                entity.Property(e => e.ConsiderarInteresSsi).HasColumnName("ConsiderarInteresSSI");

                entity.Property(e => e.Descri)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasDefaultValueSql("(N'PLAN DE PAGOS')");

                entity.Property(e => e.IdCuentaCe).HasColumnName("IdCuentaCE");

                entity.Property(e => e.IdCuentaSe).HasColumnName("IdCuentaSE");

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.MontoIva)
                    .HasColumnType("money")
                    .HasColumnName("MontoIVA");

                entity.Property(e => e.MontoMensualidadSsi)
                    .HasColumnType("money")
                    .HasColumnName("MontoMensualidadSSI");

                entity.Property(e => e.Periodicidad).HasDefaultValueSql("((1))");

                entity.Property(e => e.PorcentajeEnganche).HasColumnType("smallmoney");

                entity.Property(e => e.PorcentajeIva)
                    .HasColumnType("smallmoney")
                    .HasColumnName("PorcentajeIVA");

                entity.Property(e => e.Prioridad).HasDefaultValueSql("((1))");

                entity.Property(e => e.TasaIntAnual).HasColumnType("smallmoney");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.HasOne(d => d.IdContratoNavigation)
                    .WithMany(p => p.CvPlanesPagos)
                    .HasForeignKey(d => d.IdContrato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvPlanesPagos_CvContratos");

                entity.HasOne(d => d.IdCuentaCeNavigation)
                    .WithMany(p => p.CvPlanesPagoIdCuentaCeNavigations)
                    .HasForeignKey(d => d.IdCuentaCe)
                    .HasConstraintName("FK_CvPlanesPagos_CtbCuentas1");

                entity.HasOne(d => d.IdCuentaSeNavigation)
                    .WithMany(p => p.CvPlanesPagoIdCuentaSeNavigations)
                    .HasForeignKey(d => d.IdCuentaSe)
                    .HasConstraintName("FK_CvPlanesPagos_CtbCuentas");

                entity.HasOne(d => d.IdTipoMonedaNavigation)
                    .WithMany(p => p.CvPlanesPagos)
                    .HasForeignKey(d => d.IdTipoMoneda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvPlanesPagos_AcCatMonedas");

                entity.HasOne(d => d.IdTipoPlanNavigation)
                    .WithMany(p => p.CvPlanesPagos)
                    .HasForeignKey(d => d.IdTipoPlan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvPlanesPagos_CvTiposPlan");
            });

            modelBuilder.Entity<CvPlanesPagosDet>(entity =>
            {
                entity.HasKey(e => e.IdPlanPagoDet);

                entity.ToTable("CvPlanesPagosDet");

                entity.HasIndex(e => new { e.IdPlanPago, e.PlanPagoDet }, "IX_CvPlanesPagosDetCodigo")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Concepto)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasDefaultValueSql("(N'\"')");

                entity.Property(e => e.FechaPlan).HasColumnType("smalldatetime");

                entity.Property(e => e.MontoBase).HasColumnType("money");

                entity.Property(e => e.MontoCapitalAmortizado).HasColumnType("money");

                entity.Property(e => e.MontoCapitalPactado).HasColumnType("money");

                entity.Property(e => e.MontoGastosAdicionales).HasColumnType("money");

                entity.Property(e => e.MontoInteres).HasColumnType("money");

                entity.Property(e => e.MontoIvaDocumento).HasColumnType("money");

                entity.Property(e => e.SaldoPendiente).HasColumnType("money");

                entity.Property(e => e.SaldoPendienteBase).HasColumnType("money");

                entity.Property(e => e.SaldoPendienteGastosAdicionales).HasColumnType("money");

                entity.Property(e => e.SaldoPendienteInteres).HasColumnType("money");

                entity.Property(e => e.SaldoPendienteIvaDocumento).HasColumnType("money");

                entity.HasOne(d => d.IdPlanPagoNavigation)
                    .WithMany(p => p.CvPlanesPagosDets)
                    .HasForeignKey(d => d.IdPlanPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvPlanesPagosDet_CvPlanesPagos");
            });

            modelBuilder.Entity<CvPlantillasContrato>(entity =>
            {
                entity.HasKey(e => e.IdPlantillaContrato);

                entity.HasIndex(e => e.PlantillaContrato, "IX_CvPlantillasContratos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdPlantillaContrato).HasColumnName("idPlantillaContrato");

                entity.Property(e => e.PlantillaContrato)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Ruta)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Texto).HasMaxLength(50);
            });

            modelBuilder.Entity<CvPlaza>(entity =>
            {
                entity.HasKey(e => e.IdPlaza)
                    .HasName("PK_CvPlaza");

                entity.HasIndex(e => e.Plaza, "In_CvPlazaPlaza")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Plaza)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Texto).HasMaxLength(40);

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.CvPlazas)
                    .HasForeignKey(d => d.IdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvPlaza_Estados");
            });

            modelBuilder.Entity<CvPpecosto>(entity =>
            {
                entity.HasKey(e => e.IdPpecosto);

                entity.ToTable("CvPPECostos");

                entity.HasIndex(e => new { e.IdProyectoPrototipo, e.IdPetapa }, "IX_CvPPECostos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdPpecosto).HasColumnName("IdPPECosto");

                entity.Property(e => e.Concepto).HasMaxLength(40);

                entity.Property(e => e.Costo).HasColumnType("money");

                entity.Property(e => e.IdPetapa).HasColumnName("IdPEtapa");

                entity.Property(e => e.Partida).HasMaxLength(20);

                entity.HasOne(d => d.IdPetapaNavigation)
                    .WithMany(p => p.CvPpecostos)
                    .HasForeignKey(d => d.IdPetapa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvPPECostos_CvPEtapas");

                entity.HasOne(d => d.IdProyectoPrototipoNavigation)
                    .WithMany(p => p.CvPpecostos)
                    .HasForeignKey(d => d.IdProyectoPrototipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvPPECostos_CvProyectosPrototipos");
            });

            modelBuilder.Entity<CvPppresupuesto>(entity =>
            {
                entity.HasKey(e => e.IdPppresupuesto);

                entity.ToTable("CvPPPresupuestos");

                entity.Property(e => e.IdPppresupuesto).HasColumnName("IdPPPresupuesto");

                entity.Property(e => e.AniosCredito).HasColumnType("money");

                entity.Property(e => e.AportacionPatronal).HasColumnType("money");

                entity.Property(e => e.IngresoMinimo).HasColumnType("money");

                entity.Property(e => e.InversionInicial).HasColumnType("money");

                entity.Property(e => e.MontoCredito).HasColumnType("money");

                entity.Property(e => e.PagoMensual).HasColumnType("money");

                entity.Property(e => e.PagoMensualNeto).HasColumnType("money");

                entity.HasOne(d => d.IdProyectoCreditoNavigation)
                    .WithMany(p => p.CvPppresupuestos)
                    .HasForeignKey(d => d.IdProyectoCredito)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvPPPresupuestos_CvProyectosCreditos");

                entity.HasOne(d => d.IdProyectoPrototipoNavigation)
                    .WithMany(p => p.CvPppresupuestos)
                    .HasForeignKey(d => d.IdProyectoPrototipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvPPPresupuestos_CvProyectosPrototipos");
            });

            modelBuilder.Entity<CvPromocione>(entity =>
            {
                entity.HasKey(e => e.IdPromocion);

                entity.HasIndex(e => e.Promocion, "IX_CvPromociones")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Promocion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .UseCollation("Traditional_Spanish_CI_AS");

                entity.Property(e => e.Texto)
                    .IsRequired()
                    .HasMaxLength(60)
                    .UseCollation("Traditional_Spanish_CI_AS");
            });

            modelBuilder.Entity<CvPromotora>(entity =>
            {
                entity.HasKey(e => e.IdPromotora);

                entity.HasIndex(e => e.Promotora, "IX_CvPromotoras")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Domicilio)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("FAX");

                entity.Property(e => e.Promotora)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RepLegal)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rfc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RFC");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CvPropietario>(entity =>
            {
                entity.HasKey(e => e.IdPropietario);

                entity.HasIndex(e => e.Propietario, "IX_CvPropietarios")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Propietario)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<CvPrototipo>(entity =>
            {
                entity.HasKey(e => e.IdPrototipo);

                entity.HasIndex(e => e.Prototipo, "In_CvPrototiposPrototipo")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Ansi).HasMaxLength(50);

                entity.Property(e => e.Comercial)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.EscalaRelleno).HasColumnType("smallmoney");

                entity.Property(e => e.Partida).HasMaxLength(30);

                entity.Property(e => e.Prototipo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SuperficieConstruida).HasColumnType("smallmoney");

                entity.Property(e => e.Texto).HasMaxLength(40);
            });

            modelBuilder.Entity<CvPrototiposAccesorio>(entity =>
            {
                entity.HasKey(e => e.IdPrototipoAccesorio);

                entity.HasIndex(e => new { e.IdProyecto, e.IdPrototipo, e.IdAccesorio }, "In_CvPrototiposAccesoriosCodigo")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Cantidad).HasColumnType("money");

                entity.HasOne(d => d.IdAccesorioNavigation)
                    .WithMany(p => p.CvPrototiposAccesorios)
                    .HasForeignKey(d => d.IdAccesorio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvPrototiposAccesorios_CvAccesorios");

                entity.HasOne(d => d.IdPrototipoNavigation)
                    .WithMany(p => p.CvPrototiposAccesorios)
                    .HasForeignKey(d => d.IdPrototipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvPrototiposAccesorios_CvPrototipos");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.CvPrototiposAccesorios)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvPrototiposAccesorios_Proyectos");
            });

            modelBuilder.Entity<CvPrototiposAdjunto>(entity =>
            {
                entity.HasKey(e => e.IdAdjunto);

                entity.HasIndex(e => e.IdPrototipo, "IX_CvPrototiposAdjuntosIdPrototipo")
                    .HasFillFactor(90);

                entity.Property(e => e.Ruta)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Texto)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdPrototipoNavigation)
                    .WithMany(p => p.CvPrototiposAdjuntos)
                    .HasForeignKey(d => d.IdPrototipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvPrototiposAdjuntos_CvPrototipos");
            });

            modelBuilder.Entity<CvProyectosAccesorio>(entity =>
            {
                entity.HasKey(e => e.IdProyectoAccesorio);

                entity.HasIndex(e => new { e.IdProyecto, e.IdAccesorio }, "In_CvProyectosAccesoriosCodigo")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Cantidad)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EsSerie).HasDefaultValueSql("((0))");

                entity.Property(e => e.Partida).HasMaxLength(30);

                entity.Property(e => e.Precio)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdAccesorioNavigation)
                    .WithMany(p => p.CvProyectosAccesorios)
                    .HasForeignKey(d => d.IdAccesorio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvProyectosAccesorios_CvAccesorios");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.CvProyectosAccesorios)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvProyectosAccesorios_Proyectos");

                entity.HasOne(d => d.IdTipoMonedaNavigation)
                    .WithMany(p => p.CvProyectosAccesorios)
                    .HasForeignKey(d => d.IdTipoMoneda)
                    .HasConstraintName("FK_CvProyectosAccesorios_AcCatMonedas");
            });

            modelBuilder.Entity<CvProyectosCredito>(entity =>
            {
                entity.HasKey(e => e.IdProyectoCredito);

                entity.HasIndex(e => new { e.IdProyecto, e.IdCredito }, "IX_CvProyectosCreditosCodigo")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.ConsecutivoReferencia)
                    .HasMaxLength(38)
                    .IsUnicode(false);

                entity.Property(e => e.InteresMoratorio).HasColumnType("smallmoney");

                entity.Property(e => e.NoFijoReferencia)
                    .HasMaxLength(38)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCreditoNavigation)
                    .WithMany(p => p.CvProyectosCreditos)
                    .HasForeignKey(d => d.IdCredito)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvProyectosCreditos_CvCreditos");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.CvProyectosCreditos)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvProyectosCreditos_Proyectos");
            });

            modelBuilder.Entity<CvProyectosCuentasDepCliente>(entity =>
            {
                entity.HasKey(e => e.IdProyectoCuentaDepCliente);

                entity.HasIndex(e => new { e.IdProyecto, e.IdCuentaBancaria }, "IX_CvProyectosCuentasDepClientes")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasOne(d => d.IdCuentaBancariaNavigation)
                    .WithMany(p => p.CvProyectosCuentasDepClientes)
                    .HasForeignKey(d => d.IdCuentaBancaria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvProyectosCuentasDepClientes_CtaCuentas");

                entity.HasOne(d => d.IdCuentaDepPorIdentificarNavigation)
                    .WithMany(p => p.CvProyectosCuentasDepClientes)
                    .HasForeignKey(d => d.IdCuentaDepPorIdentificar)
                    .HasConstraintName("FK_CvProyectosCuentasDepClientes_CtbCuentas");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.CvProyectosCuentasDepClientes)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvProyectosCuentasDepClientes_Proyectos");
            });

            modelBuilder.Entity<CvProyectosCuentasDepSofole>(entity =>
            {
                entity.HasKey(e => e.IdProyectoCuentaDepSofol);

                entity.HasIndex(e => new { e.IdProyecto, e.IdCuentaBancaria }, "IX_CvProyectosCuentasDepSofoles")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasOne(d => d.IdCuentaBancariaNavigation)
                    .WithMany(p => p.CvProyectosCuentasDepSofoles)
                    .HasForeignKey(d => d.IdCuentaBancaria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvProyectosCuentasDepSofoles_CtaCuentas");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.CvProyectosCuentasDepSofoles)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvProyectosCuentasDepSofoles_Proyectos");
            });

            modelBuilder.Entity<CvProyectosCuentasNota>(entity =>
            {
                entity.HasKey(e => e.IdProyectoCuentaNota);

                entity.HasIndex(e => new { e.IdProyecto, e.IdTipoNota }, "IX_CvProyectosCuentasNotas")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuenta, "IX_CvProyectosCuentasNotas_1")
                    .HasFillFactor(90);

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithMany(p => p.CvProyectosCuentasNota)
                    .HasForeignKey(d => d.IdCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvProyectosCuentasNotas_CtbCuentas");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.CvProyectosCuentasNota)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvProyectosCuentasNotas_Proyectos");

                entity.HasOne(d => d.IdTipoNotaNavigation)
                    .WithMany(p => p.CvProyectosCuentasNota)
                    .HasForeignKey(d => d.IdTipoNota)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvProyectosCuentasNotas_CvTiposNotas");
            });

            modelBuilder.Entity<CvProyectosCuentasXplan>(entity =>
            {
                entity.HasKey(e => e.IdProyectoCuentasXplan);

                entity.ToTable("CvProyectosCuentasXPlan");

                entity.HasIndex(e => new { e.IdProyecto, e.IdTipoPlan }, "IX_CvProyectosCuentasXPlan")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuentaSinEscritura, "IX_CvProyectosCuentasXPlan_1")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuentaConEscritura, "IX_CvProyectosCuentasXPlan_2")
                    .HasFillFactor(90);

                entity.Property(e => e.IdProyectoCuentasXplan).HasColumnName("IdProyectoCuentasXPlan");

                entity.Property(e => e.ConsiderarEnEscritura)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdCuentaConEscrituraNavigation)
                    .WithMany(p => p.CvProyectosCuentasXplanIdCuentaConEscrituraNavigations)
                    .HasForeignKey(d => d.IdCuentaConEscritura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvProyectosCuentasXPlan_CtbCuentas1");

                entity.HasOne(d => d.IdCuentaSinEscrituraNavigation)
                    .WithMany(p => p.CvProyectosCuentasXplanIdCuentaSinEscrituraNavigations)
                    .HasForeignKey(d => d.IdCuentaSinEscritura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvProyectosCuentasXPlan_CtbCuentas");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.CvProyectosCuentasXplans)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvProyectosCuentasXPlan_Proyectos");

                entity.HasOne(d => d.IdTipoPlanNavigation)
                    .WithMany(p => p.CvProyectosCuentasXplans)
                    .HasForeignKey(d => d.IdTipoPlan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvProyectosCuentasXPlan_CvTiposPlan");
            });

            modelBuilder.Entity<CvProyectosDescuento>(entity =>
            {
                entity.HasKey(e => e.IdProyectoDescuento);

                entity.HasIndex(e => new { e.IdProyectoPrototipo, e.IdTipoDescuento }, "IX_CvProyectosDescuentos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.PorcentajeDescuento).HasColumnType("smallmoney");

                entity.HasOne(d => d.IdProyectoPrototipoNavigation)
                    .WithMany(p => p.CvProyectosDescuentos)
                    .HasForeignKey(d => d.IdProyectoPrototipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvProyectosDescuentos_CvProyectosPrototipos");

                entity.HasOne(d => d.IdTipoDescuentoNavigation)
                    .WithMany(p => p.CvProyectosDescuentos)
                    .HasForeignKey(d => d.IdTipoDescuento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvProyectosDescuentos_CvTiposDescuentos");
            });

            modelBuilder.Entity<CvProyectosPaquete>(entity =>
            {
                entity.HasKey(e => e.IdProyectoPaquete);

                entity.HasIndex(e => new { e.IdProyecto, e.IdCredito, e.Clave }, "IX_CvProyectosPaquetesCodigo")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Nombre).HasMaxLength(40);

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.HasOne(d => d.IdCreditoNavigation)
                    .WithMany(p => p.CvProyectosPaquetes)
                    .HasForeignKey(d => d.IdCredito)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvProyectosPaquetes_CvCreditos");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.CvProyectosPaquetes)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvPaquetes_Proyectos");

                entity.HasOne(d => d.IdTipoMonedaNavigation)
                    .WithMany(p => p.CvProyectosPaquetes)
                    .HasForeignKey(d => d.IdTipoMoneda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvProyectosPaquetes_AcCatMonedas");
            });

            modelBuilder.Entity<CvProyectosPreciosLista>(entity =>
            {
                entity.HasKey(e => e.IdProyectoPrecioLista);

                entity.HasIndex(e => new { e.IdProyectoPrototipo, e.IdSubtipoTerreno }, "IX_CvProyectosPreciosListas")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.PrecioListaPorMetro2).HasColumnType("money");

                entity.HasOne(d => d.IdProyectoPrototipoNavigation)
                    .WithMany(p => p.CvProyectosPreciosLista)
                    .HasForeignKey(d => d.IdProyectoPrototipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvProyectosPreciosListas_CvProyectosPrototipos");

                entity.HasOne(d => d.IdSubtipoTerrenoNavigation)
                    .WithMany(p => p.CvProyectosPreciosLista)
                    .HasForeignKey(d => d.IdSubtipoTerreno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvProyectosPreciosListas_CvSubtiposTerrenos");
            });

            modelBuilder.Entity<CvProyectosPromocione>(entity =>
            {
                entity.HasKey(e => e.IdProyectoPromocion);

                entity.HasIndex(e => new { e.IdProyecto, e.IdPromocion }, "IX_CvProyectosPromociones")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasOne(d => d.IdPromocionNavigation)
                    .WithMany(p => p.CvProyectosPromociones)
                    .HasForeignKey(d => d.IdPromocion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvProyectosPromociones_CvPromociones");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.CvProyectosPromociones)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvProyectosPromociones_Proyectos");
            });

            modelBuilder.Entity<CvProyectosPrototipo>(entity =>
            {
                entity.HasKey(e => e.IdProyectoPrototipo);

                entity.HasIndex(e => new { e.IdProyecto, e.IdPrototipo }, "In_CvProyectosPrototiposIdProyectoIdPrototipo")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.BaseCalculoComisiones).HasColumnType("money");

                entity.Property(e => e.CostoTerreno).HasColumnType("money");

                entity.Property(e => e.CostoVivienda).HasColumnType("money");

                entity.Property(e => e.Descuento).HasColumnType("money");

                entity.Property(e => e.Enganche).HasColumnType("smallmoney");

                entity.Property(e => e.Partida).HasMaxLength(30);

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.PrecioTerreno).HasColumnType("money");

                entity.Property(e => e.RutaImagenCotizacion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ViviendasMax).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdPrototipoNavigation)
                    .WithMany(p => p.CvProyectosPrototipos)
                    .HasForeignKey(d => d.IdPrototipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvProyectosPrototipos_CvPrototipos");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.CvProyectosPrototipos)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvProyectosPrototipos_Proyectos");

                entity.HasOne(d => d.IdTipoMonedaNavigation)
                    .WithMany(p => p.CvProyectosPrototipos)
                    .HasForeignKey(d => d.IdTipoMoneda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvProyectosPrototipos_AcCatMonedas");
            });

            modelBuilder.Entity<CvProyectosVendedore>(entity =>
            {
                entity.HasKey(e => e.IdProyectoVendedor)
                    .HasName("PK_CvProyectoVendedor");

                entity.HasIndex(e => new { e.IdProyecto, e.IdVendedor }, "IX_CvProyectoVendedorIdProyectoIdVendedor")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.CvProyectosVendedores)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvProyectoVendedor_Proyectos1");

                entity.HasOne(d => d.IdVendedorNavigation)
                    .WithMany(p => p.CvProyectosVendedores)
                    .HasForeignKey(d => d.IdVendedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvProyectoVendedor_CvVendedores");
            });

            modelBuilder.Entity<CvRangoIngresoMc>(entity =>
            {
                entity.HasKey(e => e.IdRangoIngresoMc);

                entity.ToTable("CvRangoIngresoMC");

                entity.HasIndex(e => e.RangoIngresoMc, "IX_CvRangoIngresoMC")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdRangoIngresoMc).HasColumnName("IdRangoIngresoMC");

                entity.Property(e => e.RangoIngresoMc)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("RangoIngresoMC");
            });

            modelBuilder.Entity<CvRangoIngresoMnc>(entity =>
            {
                entity.HasKey(e => e.IdRangoIngresoMnc);

                entity.ToTable("CvRangoIngresoMNC");

                entity.HasIndex(e => e.RangoIngresoMnc, "IX_CvRangoIngresoMNC")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdRangoIngresoMnc).HasColumnName("IdRangoIngresoMNC");

                entity.Property(e => e.RangoIngresoMnc)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("RangoIngresoMNC");
            });

            modelBuilder.Entity<CvRangoMontoRentum>(entity =>
            {
                entity.HasKey(e => e.IdRangoMontoRenta);

                entity.HasIndex(e => e.RangoMontoRenta, "IX_CvRangoMontoRenta")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RangoMontoRenta)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CvRangoPersonasHabitanCasa>(entity =>
            {
                entity.HasKey(e => e.IdRangoPersonasHabitanCasa);

                entity.ToTable("CvRangoPersonasHabitanCasa");

                entity.HasIndex(e => e.RangoPersonasHabitanCasa, "IX_CvRangoPersonasHabitanCasa")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.RangoPersonasHabitanCasa)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CvReferencia>(entity =>
            {
                entity.HasKey(e => e.IdReferencia)
                    .HasName("PK_CvRefencias");

                entity.HasIndex(e => e.IdCliente, "In_CvRefenciasIdCliente")
                    .HasFillFactor(90);

                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ApellidoPaterno)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion).HasMaxLength(80);

                entity.Property(e => e.Familiar).HasDefaultValueSql("((1))");

                entity.Property(e => e.Lada)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(90);

                entity.Property(e => e.Parentesco).HasMaxLength(20);

                entity.Property(e => e.Telefono).HasMaxLength(30);

                entity.Property(e => e.TelefonoCelular)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.CvReferencia)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvReferencias_CvClientes");
            });

            modelBuilder.Entity<CvRegimenMatrimonial>(entity =>
            {
                entity.HasKey(e => e.IdRegimenMatrimonial);

                entity.ToTable("CvRegimenMatrimonial");

                entity.HasIndex(e => e.RegimenMatrimonial, "IX_CvRegimenMatrimonialTexto")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdRegimenMatrimonial).ValueGeneratedOnAdd();

                entity.Property(e => e.RegimenMatrimonial)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CvResumenFlujoCliente>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CvResumenFlujoClientes");

                entity.Property(e => e.ApellidoMaterno)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.ApellidoPaterno)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Credito).HasMaxLength(20);

                entity.Property(e => e.EtapaCliente).HasMaxLength(20);

                entity.Property(e => e.FechaInicio).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaProbableFin).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.Notas).HasColumnType("ntext");

                entity.Property(e => e.Proyecto)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SofolCredito).HasMaxLength(20);

                entity.Property(e => e.SofolPuente).HasMaxLength(20);

                entity.Property(e => e.Texto).HasMaxLength(40);

                entity.Property(e => e.Vivienda).HasMaxLength(20);
            });

            modelBuilder.Entity<CvResumenFlujoVivienda>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CvResumenFlujoViviendas");

                entity.Property(e => e.Cliente).HasMaxLength(20);

                entity.Property(e => e.Comercial).HasMaxLength(20);

                entity.Property(e => e.Costoacumulado)
                    .HasColumnType("money")
                    .HasColumnName("costoacumulado");

                entity.Property(e => e.Costoetapa)
                    .HasColumnType("money")
                    .HasColumnName("costoetapa");

                entity.Property(e => e.Duracionetapa).HasColumnName("duracionetapa");

                entity.Property(e => e.Etapaactual)
                    .HasMaxLength(20)
                    .HasColumnName("etapaactual");

                entity.Property(e => e.FechaInicio).HasColumnType("smalldatetime");

                entity.Property(e => e.Flujoterminado).HasColumnName("flujoterminado");

                entity.Property(e => e.Nombrecliente)
                    .HasMaxLength(142)
                    .HasColumnName("nombrecliente");

                entity.Property(e => e.Probabletermino)
                    .HasColumnType("datetime")
                    .HasColumnName("probabletermino");

                entity.Property(e => e.Prototipo).HasMaxLength(20);

                entity.Property(e => e.Proyecto)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Retrasoacumulado).HasColumnName("retrasoacumulado");

                entity.Property(e => e.Retrasoetapa).HasColumnName("retrasoetapa");

                entity.Property(e => e.Tienecliente).HasColumnName("tienecliente");

                entity.Property(e => e.Vivienda)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<CvResumenPago>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CvResumenPagos");

                entity.Property(e => e.ApellidoMaterno)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.ApellidoPaterno)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Contrato)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Credito).HasMaxLength(20);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.Vivienda).HasMaxLength(20);
            });

            modelBuilder.Entity<CvReubicacionesVivienda>(entity =>
            {
                entity.HasKey(e => e.IdReubicacion);

                entity.Property(e => e.Fecha).HasColumnType("smalldatetime");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.CvReubicacionesVivienda)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvReubicacionesViviendas_CvClientes");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.CvReubicacionesVivienda)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvReubicacionesViviendas_Proyectos");
            });

            modelBuilder.Entity<CvRfcCliente>(entity =>
            {
                entity.HasKey(e => e.IdRfcCliente);

                entity.HasIndex(e => e.Rfc, "IX_CvRfcClientes")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("RFC");
            });

            modelBuilder.Entity<CvRfcClientesDet>(entity =>
            {
                entity.HasKey(e => e.IdRfcClienteDet);

                entity.ToTable("CvRfcClientesDet");

                entity.Property(e => e.BaseDatos)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdRfcClienteNavigation)
                    .WithMany(p => p.CvRfcClientesDets)
                    .HasForeignKey(d => d.IdRfcCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvRfcClientesDet_CvRfcClientes");
            });

            modelBuilder.Entity<CvSeries>(entity =>
            {
                entity.HasKey(e => e.IdSerie);

                entity.HasIndex(e => new { e.Serie, e.IdProyectoAccesorio }, "In_CvSeriesSerieCodigo")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdProyectoAccesorioNavigation)
                    .WithMany(p => p.CvSeries)
                    .HasForeignKey(d => d.IdProyectoAccesorio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvSeries_CvProyectosAccesorios");
            });

            modelBuilder.Entity<CvSindicato>(entity =>
            {
                entity.HasKey(e => e.IdSindicato);

                entity.HasIndex(e => e.Sindicato, "In_CvSindicatosSindicato")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Sindicato)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<CvSofole>(entity =>
            {
                entity.HasKey(e => e.IdSofol);

                entity.HasIndex(e => e.Sofol, "In_CvSofolesSofol")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Domicilio).HasMaxLength(80);

                entity.Property(e => e.Fbanco)
                    .HasMaxLength(60)
                    .HasColumnName("FBanco");

                entity.Property(e => e.Fclave)
                    .HasMaxLength(18)
                    .HasColumnName("FClave");

                entity.Property(e => e.FnoCuenta)
                    .HasMaxLength(11)
                    .HasColumnName("FNoCuenta");

                entity.Property(e => e.FnombreBeneficiario)
                    .HasMaxLength(60)
                    .HasColumnName("FNombreBeneficiario");

                entity.Property(e => e.Fplaza)
                    .HasMaxLength(4)
                    .HasColumnName("FPlaza");

                entity.Property(e => e.MpioDeleg).HasMaxLength(30);

                entity.Property(e => e.RazonSocial)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RepLegal).HasMaxLength(50);

                entity.Property(e => e.Rfc)
                    .HasMaxLength(13)
                    .HasColumnName("RFC");

                entity.Property(e => e.Sofol)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Telefono).HasMaxLength(30);
            });

            modelBuilder.Entity<CvSubtiposTerreno>(entity =>
            {
                entity.HasKey(e => e.IdSubtipoTerreno);

                entity.HasIndex(e => e.SubtipoTerreno, "IX_CvSubtiposTerrenos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubtipoTerreno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CvSucursale>(entity =>
            {
                entity.HasKey(e => e.IdSucursal);

                entity.HasIndex(e => e.Sucursal, "IX_CvSucursales")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Sucursal)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Texto)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<CvTipoLote>(entity =>
            {
                entity.HasKey(e => e.IdTipoLote);

                entity.ToTable("CvTipoLote");

                entity.HasIndex(e => e.Texto, "IX_CvTipoLoteTexto")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.TipoLote, "IX_CvTipoLoteTipoLote")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdTipoLote).ValueGeneratedOnAdd();

                entity.Property(e => e.Texto)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CvTipoViviendum>(entity =>
            {
                entity.HasKey(e => e.IdTipoVivienda);

                entity.HasIndex(e => e.Texto, "IX_CvTipoViviendaTexto")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Texto)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CvTiposDescuento>(entity =>
            {
                entity.HasKey(e => e.IdTipoDescuento);

                entity.HasIndex(e => e.TipoDescuento, "IX_CvTiposDescuentos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDescuento)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CvTiposFalla>(entity =>
            {
                entity.HasKey(e => e.IdTipoFalla);

                entity.HasIndex(e => e.TipoFalla, "In_CvTiposFallasTipoFalla")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Texto)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.TipoFalla)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<CvTiposGravamenesFinanciero>(entity =>
            {
                entity.HasKey(e => e.IdTipoGravamenFinanciero);

                entity.HasIndex(e => e.IdTipoGravamenFinanciero, "IX_CvTiposGravamenesFinancieros")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.TipoGravamenFinanciero, "IX_CvTiposGravamenesFinancieros_1")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Texto)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.TipoGravamenFinanciero)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<CvTiposNota>(entity =>
            {
                entity.HasKey(e => e.IdTipoNota);

                entity.HasIndex(e => e.TipoNota, "IX_CvTiposNotas")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Cargo)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Descripcion).HasMaxLength(40);

                entity.Property(e => e.TipoNota)
                    .IsRequired()
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<CvTiposPlan>(entity =>
            {
                entity.HasKey(e => e.IdTipoPlan);

                entity.ToTable("CvTiposPlan");

                entity.HasIndex(e => e.TipoPlan, "IX_CvTiposPlan")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Texto).HasMaxLength(40);

                entity.Property(e => e.TipoPlan)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.IdFlujoNavigation)
                    .WithMany(p => p.CvTiposPlans)
                    .HasForeignKey(d => d.IdFlujo)
                    .HasConstraintName("FK_CvTiposPlan_AcCatFlujos");
            });

            modelBuilder.Entity<CvVendedore>(entity =>
            {
                entity.HasKey(e => e.IdVendedor);

                entity.HasIndex(e => e.Vendedor, "IX_CvVendedoresVendedor")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApellidoPaterno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cargo).HasMaxLength(40);

                entity.Property(e => e.Curp)
                    .HasMaxLength(18)
                    .HasColumnName("CURP");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMail");

                entity.Property(e => e.Fax).HasMaxLength(20);

                entity.Property(e => e.FechaAlta).HasColumnType("datetime");

                entity.Property(e => e.FechaBloqueo).HasColumnType("datetime");

                entity.Property(e => e.IdInsumo).HasColumnName("idInsumo");

                entity.Property(e => e.Lada).HasMaxLength(5);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.PorcentajeBaseParaCalculo).HasColumnType("smallmoney");

                entity.Property(e => e.Rfc)
                    .HasMaxLength(13)
                    .HasColumnName("RFC");

                entity.Property(e => e.Telefono).HasMaxLength(30);

                entity.Property(e => e.Tipo).HasDefaultValueSql("((1))");

                entity.Property(e => e.Vendedor)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.IdInsumoNavigation)
                    .WithMany(p => p.CvVendedores)
                    .HasForeignKey(d => d.IdInsumo)
                    .HasConstraintName("FK_CvVendedores_AcCatInsumos");

                entity.HasOne(d => d.IdPromotoraNavigation)
                    .WithMany(p => p.CvVendedores)
                    .HasForeignKey(d => d.IdPromotora)
                    .HasConstraintName("FK_CvVendedores_CvPromotoras");

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.CvVendedores)
                    .HasForeignKey(d => d.IdProveedor)
                    .HasConstraintName("FK_CvVendedores_Proveedores");

                entity.HasOne(d => d.IdSucursalNavigation)
                    .WithMany(p => p.CvVendedores)
                    .HasForeignKey(d => d.IdSucursal)
                    .HasConstraintName("FK_CvVendedores_CvSucursales");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.CvVendedores)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK_CvVendedores_SegUsuarios");
            });

            modelBuilder.Entity<CvVivienda>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AvanceObra).HasColumnType("smallmoney");

                entity.Property(e => e.BoletaPredial).HasMaxLength(30);

                entity.Property(e => e.Calle).HasMaxLength(150);

                entity.Property(e => e.CalleEste).HasMaxLength(500);

                entity.Property(e => e.CalleNorEste).HasMaxLength(500);

                entity.Property(e => e.CalleNorOeste).HasMaxLength(500);

                entity.Property(e => e.CalleNorte).HasMaxLength(500);

                entity.Property(e => e.CalleOeste).HasMaxLength(500);

                entity.Property(e => e.CalleSur).HasMaxLength(500);

                entity.Property(e => e.CalleSurEste).HasMaxLength(500);

                entity.Property(e => e.CalleSurOeste).HasMaxLength(500);

                entity.Property(e => e.ClaveCatastral).HasMaxLength(30);

                entity.Property(e => e.CodPost).HasMaxLength(6);

                entity.Property(e => e.ColindanciaEste)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ColindanciaNorEste)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ColindanciaNorOeste)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ColindanciaNorte)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ColindanciaOeste)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ColindanciaSur)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ColindanciaSurEste)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ColindanciaSurOeste)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia).HasMaxLength(100);

                entity.Property(e => e.CostoAvance).HasColumnType("money");

                entity.Property(e => e.CostoInteres).HasColumnType("money");

                entity.Property(e => e.CostoTerreno).HasColumnType("money");

                entity.Property(e => e.CostoVivienda).HasColumnType("money");

                entity.Property(e => e.Enganche).HasColumnType("smallmoney");

                entity.Property(e => e.EscrituraIndividual).HasMaxLength(20);

                entity.Property(e => e.EscrituraLote).HasMaxLength(20);

                entity.Property(e => e.FdictamenAprobado).HasColumnName("FDictamenAprobado");

                entity.Property(e => e.FechaAvaluo).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaDtu)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FechaDTU");

                entity.Property(e => e.FechaEntregaCliente).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaEntregaPromocion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaHabitabilidad).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaIndividual).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaLiberacion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaModificacionFlujo).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaProbableCobro).HasColumnType("smalldatetime");

                entity.Property(e => e.Festado).HasColumnName("FEstado");

                entity.Property(e => e.Flineadecredito).HasColumnName("FLineadecredito");

                entity.Property(e => e.FnoCuartos).HasColumnName("FNoCuartos");

                entity.Property(e => e.FnoDormitorios).HasColumnName("FNoDormitorios");

                entity.Property(e => e.FolioRegistroPublicoProp)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fsector)
                    .HasMaxLength(50)
                    .HasColumnName("FSector");

                entity.Property(e => e.FtipoCompra).HasColumnName("FTipoCompra");

                entity.Property(e => e.FtipoMercado).HasColumnName("FTipoMercado");

                entity.Property(e => e.FtipoOfertacion).HasColumnName("FTipoOfertacion");

                entity.Property(e => e.IdPetapa).HasColumnName("IdPEtapa");

                entity.Property(e => e.IdVivienda).ValueGeneratedOnAdd();

                entity.Property(e => e.ImporteEsquina).HasColumnType("money");

                entity.Property(e => e.ImporteMetrosExcedentes).HasColumnType("money");

                entity.Property(e => e.Individualizada).HasDefaultValueSql("((0))");

                entity.Property(e => e.LiberacionPesos).HasColumnType("money");

                entity.Property(e => e.LiberacionPuente).HasColumnType("money");

                entity.Property(e => e.LicConstruccion).HasMaxLength(50);

                entity.Property(e => e.LicenciaUsoDeSuelo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Localidad).HasMaxLength(100);

                entity.Property(e => e.Lote).HasMaxLength(4);

                entity.Property(e => e.LugarIndividual).HasMaxLength(50);

                entity.Property(e => e.M2construccion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("M2Construccion");

                entity.Property(e => e.M2excedente)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("M2Excedente");

                entity.Property(e => e.M2indiviso)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("M2Indiviso");

                entity.Property(e => e.M2terreno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("M2Terreno");

                entity.Property(e => e.MontoAmortizacionPuente).HasColumnType("money");

                entity.Property(e => e.MontoComisionPuente).HasColumnType("money");

                entity.Property(e => e.NumInterior).HasMaxLength(30);

                entity.Property(e => e.NumOficial).HasMaxLength(55);

                entity.Property(e => e.ObjetoAutocad).HasMaxLength(20);

                entity.Property(e => e.PavanceInfonavit)
                    .HasColumnType("money")
                    .HasColumnName("PAvanceInfonavit");

                entity.Property(e => e.PavanceSupervision)
                    .HasColumnType("money")
                    .HasColumnName("PAvanceSupervision");

                entity.Property(e => e.PrecioPuente).HasColumnType("money");

                entity.Property(e => e.PrecioReal).HasColumnType("money");

                entity.Property(e => e.PrecioTerreno).HasColumnType("money");

                entity.Property(e => e.Referencia).HasMaxLength(100);

                entity.Property(e => e.RegimenCondominio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RutaImagenColindancias)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RutaImagenLocalizacion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Seccion).HasMaxLength(20);

                entity.Property(e => e.ServidumbreDerecha)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ServidumbreFrontal)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ServidumbreIzquierda)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ServidumbreTrasera)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Texto)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.TipoLote).HasDefaultValueSql("((2))");

                entity.Property(e => e.ValorAvaluo).HasColumnType("money");

                entity.Property(e => e.VigenciaLicConstruccion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Vivienda)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.FestadoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Festado)
                    .HasConstraintName("FK_CvViviendas_CvFEstadoVivienda1");

                entity.HasOne(d => d.FlineadecreditoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Flineadecredito)
                    .HasConstraintName("FK_CvViviendas_CvFLineaCredito");

                entity.HasOne(d => d.FtipoCompraNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.FtipoCompra)
                    .HasConstraintName("FK_CvViviendas_CvFTipoCompra");

                entity.HasOne(d => d.FtipoCompra1)
                    .WithMany()
                    .HasForeignKey(d => d.FtipoCompra)
                    .HasConstraintName("FK_CvViviendas_CvFTipoMercado");

                entity.HasOne(d => d.FtipoOfertacionNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.FtipoOfertacion)
                    .HasConstraintName("FK_CvViviendas_CvFTipoOfertacion");

                entity.HasOne(d => d.IdCentroNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdCentro)
                    .HasConstraintName("FK_CvViviendas_Centros");

                entity.HasOne(d => d.IdDesarrolloNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdDesarrollo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvViviendas_CvDesarrollo");

                entity.HasOne(d => d.IdEtapaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdEtapa)
                    .HasConstraintName("FK_CvViviendas_CvEtapas");

                entity.HasOne(d => d.IdEtapaViviendaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdEtapaVivienda)
                    .HasConstraintName("FK_CvViviendas_CvEtapasViviendas");

                entity.HasOne(d => d.IdGravamen1Navigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdGravamen1)
                    .HasConstraintName("FK_CvViviendas_CvGravamenes");

                entity.HasOne(d => d.IdGravamen2Navigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdGravamen2)
                    .HasConstraintName("FK_CvViviendas_CvGravamenes1");

                entity.HasOne(d => d.IdManzanaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdManzana)
                    .HasConstraintName("FK_CvViviendas_CvManzanas");

                entity.HasOne(d => d.IdNotariaIndividualNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdNotariaIndividual)
                    .HasConstraintName("FK_CvViviendas_CvNotarias1");

                entity.HasOne(d => d.IdNotariaLoteNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdNotariaLote)
                    .HasConstraintName("FK_CvViviendas_CvNotarias");

                entity.HasOne(d => d.IdPetapaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdPetapa)
                    .HasConstraintName("FK_CvViviendas_CvPEtapas");

                entity.HasOne(d => d.IdPlazaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdPlaza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvViviendas_CvPlaza");

                entity.HasOne(d => d.IdPromocionNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdPromocion)
                    .HasConstraintName("FK_CvViviendas_CvPromociones");

                entity.HasOne(d => d.IdPropietarioNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdPropietario)
                    .HasConstraintName("FK_CvViviendas_CvPropietarios");

                entity.HasOne(d => d.IdPrototipoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdPrototipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvViviendas_CvPrototipos");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvViviendas_Proyectos");

                entity.HasOne(d => d.IdSubtipoTerrenoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdSubtipoTerreno)
                    .HasConstraintName("FK_CvViviendas_CvSubtiposTerrenos");

                entity.HasOne(d => d.IdSucursalNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdSucursal)
                    .HasConstraintName("FK_CvViviendas_CvSucursales");

                entity.HasOne(d => d.IdTipoGravamenFinanciero1Navigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdTipoGravamenFinanciero1)
                    .HasConstraintName("FK_CvViviendas_CvTiposGravamenesFinancieros");

                entity.HasOne(d => d.IdTipoGravamenFinanciero2Navigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdTipoGravamenFinanciero2)
                    .HasConstraintName("FK_CvViviendas_CvTiposGravamenesFinancieros1");

                entity.HasOne(d => d.IdTipoMonedaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdTipoMoneda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvViviendas_AcCatMonedas");

                entity.HasOne(d => d.TipoLoteNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.TipoLote)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvViviendas_CvTipoLote");

                entity.HasOne(d => d.TipoViviendaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.TipoVivienda)
                    .HasConstraintName("FK_CvViviendas_CvTipoVivienda1");
            });

            modelBuilder.Entity<CvViviendasAccesorio>(entity =>
            {
                entity.HasKey(e => e.IdViviendaAccesorio)
                    .HasName("PK_CvViviendasPaquetes");

                entity.HasIndex(e => new { e.IdVivienda, e.IdProyectoAccesorio, e.IdSerie }, "In_CvViviendasPaquetesIdViviendaCodigo")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Cantidad)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.HasOne(d => d.IdProyectoAccesorioNavigation)
                    .WithMany(p => p.CvViviendasAccesorios)
                    .HasForeignKey(d => d.IdProyectoAccesorio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvViviendasPaquetes_CvProyectosAccesorios");

                entity.HasOne(d => d.IdSerieNavigation)
                    .WithMany(p => p.CvViviendasAccesorios)
                    .HasForeignKey(d => d.IdSerie)
                    .HasConstraintName("FK_CvViviendasPaquetes_CvSeries");

                entity.HasOne(d => d.IdTipoMonedaNavigation)
                    .WithMany(p => p.CvViviendasAccesorios)
                    .HasForeignKey(d => d.IdTipoMoneda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CvViviendasAccesorios_AcCatMonedas");
            });

            modelBuilder.Entity<CvViviendasVistum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CvViviendas_Vista");

                entity.Property(e => e.AnsiCli)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AnsiViv).HasMaxLength(50);

                entity.Property(e => e.BoletaPredial).HasMaxLength(30);

                entity.Property(e => e.Calle).HasMaxLength(150);

                entity.Property(e => e.Centro)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ClaveCatastral).HasMaxLength(30);

                entity.Property(e => e.Cliente)
                    .HasMaxLength(165)
                    .HasColumnName("cliente");

                entity.Property(e => e.CodPost).HasMaxLength(6);

                entity.Property(e => e.Colonia).HasMaxLength(100);

                entity.Property(e => e.CostoTerreno).HasColumnType("money");

                entity.Property(e => e.CostoVivienda).HasColumnType("money");

                entity.Property(e => e.Credito).HasMaxLength(20);

                entity.Property(e => e.Desarrollo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Enganche).HasColumnType("smallmoney");

                entity.Property(e => e.EscalaRellenoCli).HasColumnType("smallmoney");

                entity.Property(e => e.EscalaRellenoViv).HasColumnType("smallmoney");

                entity.Property(e => e.EscrituraIndividual).HasMaxLength(20);

                entity.Property(e => e.EscrituraLote).HasMaxLength(20);

                entity.Property(e => e.Estado)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.EtapaCliente).HasMaxLength(20);

                entity.Property(e => e.EtapaConstruccion).HasMaxLength(20);

                entity.Property(e => e.EtapaVivienda).HasMaxLength(20);

                entity.Property(e => e.FdictamenAprobado).HasColumnName("FDictamenAprobado");

                entity.Property(e => e.FechaAvaluo).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaEntregaCliente).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaEntregaPromocion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaFirmaPuente).HasColumnType("datetime");

                entity.Property(e => e.FechaHabitabilidad).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaIndividual).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaLiberacion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaModificacionFlujo).HasColumnType("smalldatetime");

                entity.Property(e => e.Festado)
                    .HasMaxLength(50)
                    .HasColumnName("FEstado");

                entity.Property(e => e.FlineaDeCredito)
                    .HasMaxLength(50)
                    .HasColumnName("FLineaDeCredito");

                entity.Property(e => e.Flujo)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("flujo");

                entity.Property(e => e.FnoCuartos).HasColumnName("FNoCuartos");

                entity.Property(e => e.FnoDormitorios).HasColumnName("FNoDormitorios");

                entity.Property(e => e.FolioRegistroPublicoProp)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fraccionamiento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fsector)
                    .HasMaxLength(50)
                    .HasColumnName("FSector");

                entity.Property(e => e.FtipoCompra)
                    .HasMaxLength(50)
                    .HasColumnName("FTipoCompra");

                entity.Property(e => e.FtipoMercado)
                    .HasMaxLength(50)
                    .HasColumnName("FTipoMercado");

                entity.Property(e => e.FtipoOfertacion)
                    .HasMaxLength(50)
                    .HasColumnName("FTipoOfertacion");

                entity.Property(e => e.LiberacionPesos).HasColumnType("money");

                entity.Property(e => e.LiberacionPuente).HasColumnType("money");

                entity.Property(e => e.LicConstruccion).HasMaxLength(50);

                entity.Property(e => e.LicenciaUsoDeSuelo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LugarIndividual).HasMaxLength(50);

                entity.Property(e => e.M2construccion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("M2Construccion");

                entity.Property(e => e.M2excedente)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("M2Excedente");

                entity.Property(e => e.M2indiviso)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("M2Indiviso");

                entity.Property(e => e.M2terreno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("M2Terreno");

                entity.Property(e => e.Manzana).HasMaxLength(20);

                entity.Property(e => e.MontoAmortizacionPuente).HasColumnType("money");

                entity.Property(e => e.MontoComisionPuente).HasColumnType("money");

                entity.Property(e => e.NoCreditoPuente)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NoEscrituraPuente)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NotariaInd).HasMaxLength(20);

                entity.Property(e => e.NotariaLot).HasMaxLength(20);

                entity.Property(e => e.NotariaPuente).HasMaxLength(20);

                entity.Property(e => e.NumInterior).HasMaxLength(30);

                entity.Property(e => e.NumOficial).HasMaxLength(55);

                entity.Property(e => e.ObjetoAutocad).HasMaxLength(20);

                entity.Property(e => e.Observaciones).HasColumnType("ntext");

                entity.Property(e => e.PavanceInfonavit)
                    .HasColumnType("money")
                    .HasColumnName("PAvanceInfonavit");

                entity.Property(e => e.PavanceSupervision)
                    .HasColumnType("money")
                    .HasColumnName("PAvanceSupervision");

                entity.Property(e => e.Plaza)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PorcentajeAvance).HasColumnType("numeric(38, 19)");

                entity.Property(e => e.PrecioPuente).HasColumnType("money");

                entity.Property(e => e.PrecioReal).HasColumnType("money");

                entity.Property(e => e.PrecioTerreno).HasColumnType("money");

                entity.Property(e => e.Promocion)
                    .HasMaxLength(20)
                    .UseCollation("Traditional_Spanish_CI_AS");

                entity.Property(e => e.Prototipo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Seccion).HasMaxLength(20);

                entity.Property(e => e.SofolPuente).HasMaxLength(20);

                entity.Property(e => e.SubtipoTerreno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sucursal).HasMaxLength(20);

                entity.Property(e => e.Texto)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.TipoLote).HasMaxLength(50);

                entity.Property(e => e.TipoVivienda).HasMaxLength(50);

                entity.Property(e => e.ValorAvaluo).HasColumnType("money");

                entity.Property(e => e.Vinculada)
                    .HasMaxLength(20)
                    .HasColumnName("vinculada");

                entity.Property(e => e.Vivienda)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Vlote)
                    .HasMaxLength(4)
                    .HasColumnName("VLote");
            });

            modelBuilder.Entity<FefoliosCfdxRfc>(entity =>
            {
                entity.HasKey(e => e.IdFolioCfd);

                entity.ToTable("FEFoliosCFDxRFC");

                entity.HasIndex(e => e.Rfc, "IX_FEFoliosCFDxRFC");

                entity.Property(e => e.IdFolioCfd).HasColumnName("IdFolioCFD");

                entity.Property(e => e.AnoAprobacion)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FechaProceso).HasColumnType("datetime");

                entity.Property(e => e.NoAprobacion)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("RFC");

                entity.Property(e => e.Serie)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.FefoliosCfdxRfcs)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FEFoliosCFDxRFC_SegUsuarios");
            });

            modelBuilder.Entity<FeneodataCertificado>(entity =>
            {
                entity.HasKey(e => e.IdCertificado);

                entity.ToTable("FENeodataCertificados");

                entity.HasIndex(e => new { e.NoCertificado, e.IdMatrizSucursal }, "IX_FENeodataCertificados")
                    .IsUnique();

                entity.Property(e => e.Certificado)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.EsCfdi).HasColumnName("EsCFDI");

                entity.Property(e => e.EsCfiel).HasColumnName("EsCFiel");

                entity.Property(e => e.LlavePrivada)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.NoCertificado)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.VigenciaFinal).HasColumnType("datetime");

                entity.Property(e => e.VigenciaInicial).HasColumnType("datetime");

                entity.HasOne(d => d.IdMatrizSucursalNavigation)
                    .WithMany(p => p.FeneodataCertificados)
                    .HasForeignKey(d => d.IdMatrizSucursal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FENeodataCertificados_FENeodataMatrizSucursales");
            });

            modelBuilder.Entity<FeneodataFolio>(entity =>
            {
                entity.HasKey(e => e.IdFolio)
                    .HasName("PK_FEFolios");

                entity.ToTable("FENeodataFolios");

                entity.Property(e => e.Serie)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCertificadoNavigation)
                    .WithMany(p => p.FeneodataFolios)
                    .HasForeignKey(d => d.IdCertificado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FEFolios_FECertificados");
            });

            modelBuilder.Entity<FeneodataMatrizSucursale>(entity =>
            {
                entity.HasKey(e => e.IdMatrizSucursal)
                    .HasName("PK_FEMatrizSucursales");

                entity.ToTable("FENeodataMatrizSucursales");

                entity.Property(e => e.Calle)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPostal)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.IdCodigoPostalSat).HasColumnName("IdCodigoPostalSAT");

                entity.Property(e => e.IdPaisSat).HasColumnName("IdPaisSAT");

                entity.Property(e => e.Localidad)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.LugarDeExpedicion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MatrizSucursal)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Municipio)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.NoExterior)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoInterior)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Pais)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Referencia)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UsarEstimuloIvafronterizo).HasColumnName("UsarEstimuloIVAFronterizo");

                entity.HasOne(d => d.IdCodigoPostalSatNavigation)
                    .WithMany(p => p.FeneodataMatrizSucursales)
                    .HasForeignKey(d => d.IdCodigoPostalSat)
                    .HasConstraintName("FK_FENeodataMatrizSucursales_AcCatCodigosPostalesSAT");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.FeneodataMatrizSucursales)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_FEMatrizSucursales_AcCatEstados");

                entity.HasOne(d => d.IdPaisSatNavigation)
                    .WithMany(p => p.FeneodataMatrizSucursales)
                    .HasForeignKey(d => d.IdPaisSat)
                    .HasConstraintName("FK_FENeodataMatrizSucursales_AcCatPaises");
            });

            modelBuilder.Entity<Feregimene>(entity =>
            {
                entity.HasKey(e => e.IdRegimen);

                entity.ToTable("FERegimenes");

                entity.Property(e => e.IdRegimen).HasColumnName("idRegimen");

                entity.Property(e => e.Regimen)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCatRegimenNavigation)
                    .WithMany(p => p.Feregimenes)
                    .HasForeignKey(d => d.IdCatRegimen)
                    .HasConstraintName("FK_FERegimenes_AcCatRegimenesFiscalesSAT");
            });

            modelBuilder.Entity<FeseriesDigitalesXrfc>(entity =>
            {
                entity.HasKey(e => e.IdSerieDigital);

                entity.ToTable("FESeriesDigitalesXRFC");

                entity.HasIndex(e => e.Rfc, "IX_FESeriesDigitalesXRFC");

                entity.Property(e => e.EstadoCertificado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Estado_Certificado");

                entity.Property(e => e.FechaFinalCertificado)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Final_Certificado");

                entity.Property(e => e.FechaInicialCertificado)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Inicial_Certificado");

                entity.Property(e => e.FechaProceso).HasColumnType("datetime");

                entity.Property(e => e.NoSerie)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("No_Serie");

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("RFC");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.FeseriesDigitalesXrfcs)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FESeriesDigitalesXRFC_SegUsuarios");
            });

            modelBuilder.Entity<GruposReportesEjecutivo>(entity =>
            {
                entity.HasKey(e => e.IdGrupo);

                entity.HasIndex(e => e.Codigo, "IX_GruposReportesEjecutivosCodigo")
                    .IsUnique();

                entity.Property(e => e.IdGrupo).HasColumnName("idGrupo");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<GruposReportesEjecutivos2004>(entity =>
            {
                entity.HasKey(e => e.IdGrupo);

                entity.ToTable("GruposReportesEjecutivos2004");

                entity.HasIndex(e => e.Codigo, "IX_GruposReportesEjecutivos2004_Codigo")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdGrupoAux, "IX_GruposReportesEjecutivos2004_IdGrupoAux")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdGrupo).HasColumnName("idGrupo");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.IdGrupoAux).HasColumnName("idGrupoAux");
            });

            modelBuilder.Entity<NeoSysCatalogo>(entity =>
            {
                entity.HasKey(e => e.IdCatalogo);

                entity.HasIndex(e => e.NombreCatalogo, "IX_NeoSysCatalogos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdCatalogo)
                    .ValueGeneratedNever()
                    .HasColumnName("idCatalogo");

                entity.Property(e => e.NombreCatalogo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NeoSysCatalogosCamposOculto>(entity =>
            {
                entity.HasKey(e => e.IdCatalogoCampoOculto);

                entity.HasIndex(e => new { e.IdCatalogo, e.NombreCampo }, "IX_NeoSysCatalogosCamposOcultos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdCatalogoCampoOculto).HasColumnName("idCatalogoCampoOculto");

                entity.Property(e => e.IdCatalogo).HasColumnName("idCatalogo");

                entity.Property(e => e.NombreCampo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCatalogoNavigation)
                    .WithMany(p => p.NeoSysCatalogosCamposOcultos)
                    .HasForeignKey(d => d.IdCatalogo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NeoSysCatalogosCamposOcultos_NeoSysCatalogos");
            });

            modelBuilder.Entity<NeoSysCatalogosUsuario>(entity =>
            {
                entity.HasKey(e => e.IdCatalogoUsuario);

                entity.ToTable("NeoSysCatalogosUsuario");

                entity.HasIndex(e => new { e.IdCatalogo, e.Alias }, "IX_NeoSysCatalogosUsuario")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdCatalogoUsuario)
                    .ValueGeneratedNever()
                    .HasColumnName("idCatalogoUsuario");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AliasNeodata)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCatalogo).HasColumnName("idCatalogo");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.HasOne(d => d.IdCatalogoNavigation)
                    .WithMany(p => p.NeoSysCatalogosUsuarios)
                    .HasForeignKey(d => d.IdCatalogo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NeoSysCatalogosUsuario_NeoSysCatalogos");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.NeoSysCatalogosUsuarios)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NeoSysCatalogosUsuario_SegUsuarios");
            });

            modelBuilder.Entity<NeoSysCatalogosUsuarioC>(entity =>
            {
                entity.HasKey(e => e.IdCatalogoUsuarioC);

                entity.ToTable("NeoSysCatalogosUsuarioC");

                entity.HasIndex(e => new { e.IdCatalogoUsuario, e.NombreCampo }, "IX_NeoSysCatalogosUsuarioC")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdCatalogoUsuarioC).HasColumnName("idCatalogoUsuarioC");

                entity.Property(e => e.AliasCampo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AliasCodigoUnicoFk)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AliasCodigoUnicoFK");

                entity.Property(e => e.CamposAdicionalesFk)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CamposAdicionalesFK");

                entity.Property(e => e.CodigoUnicoFk)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CodigoUnicoFK");

                entity.Property(e => e.IdCatalogoUsuario).HasColumnName("idCatalogoUsuario");

                entity.Property(e => e.NeoEsFk).HasColumnName("neoEsFK");

                entity.Property(e => e.NeoObligatorio)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NeoTablaRelacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCampo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDato)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCatalogoUsuarioNavigation)
                    .WithMany(p => p.NeoSysCatalogosUsuarioCs)
                    .HasForeignKey(d => d.IdCatalogoUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NeoSysCatalogosUsuarioC_NeoSysCatalogosUsuario");
            });

            modelBuilder.Entity<NumerosConsecutivo>(entity =>
            {
                entity.HasKey(e => e.LlaveUnica);

                entity.HasIndex(e => e.Proceso, "IX_NumerosConsecutivos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Proceso)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Parametro>(entity =>
            {
                entity.HasKey(e => e.IdParametro);

                entity.HasIndex(e => e.Parametro1, "IX_Parametros")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Explicacion)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Parametro1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Parametro");

                entity.Property(e => e.Valor)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ParametroUsuario>(entity =>
            {
                entity.HasKey(e => e.IdParametroUsuario);

                entity.ToTable("ParametroUsuario");

                entity.HasIndex(e => new { e.IdUsuario, e.IdSistema }, "IX_ParametroUsuario")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasOne(d => d.IdSistemaNavigation)
                    .WithMany(p => p.ParametroUsuarios)
                    .HasForeignKey(d => d.IdSistema)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ParametroUsuario_SegSistemas");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.ParametroUsuarios)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ParametroUsuario_SegUsuarios");
            });

            modelBuilder.Entity<ParametrosCtasAntiLavado>(entity =>
            {
                entity.HasKey(e => e.IdParametroCtaAl);

                entity.ToTable("ParametrosCtasAntiLavado");

                entity.HasIndex(e => e.IdCtaAntilavado, "IX_ParametrosCtasAntiLavado")
                    .IsUnique();

                entity.Property(e => e.IdParametroCtaAl).HasColumnName("IdParametroCtaAL");

                entity.HasOne(d => d.IdCtaAntilavadoNavigation)
                    .WithOne(p => p.ParametrosCtasAntiLavado)
                    .HasForeignKey<ParametrosCtasAntiLavado>(d => d.IdCtaAntilavado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ParametrosCtasAntiLavado_CtbCuentas");
            });

            modelBuilder.Entity<PermisosErp2008>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Permisos ERP2008");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.GrupoDescripcion)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.NombrePermiso)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Permiso");

                entity.Property(e => e.SubGrupoDescripcion)
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Proyecto>(entity =>
            {
                entity.HasKey(e => e.IdProyecto);

                entity.HasIndex(e => e.Proyecto1, "IX_Proyectos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.CvCtaIvaTrasladado, "IX_Proyectos_1")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.CvCtaDevolucionesClientesSaldoFavor, "IX_Proyectos_10")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.CvCtaCancelacionIngresosClientes, "IX_Proyectos_11");

                entity.HasIndex(e => e.CvCtaIngresosPorCancelaciones, "IX_Proyectos_12")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.CvCtaCostoPorCasas, "IX_Proyectos_13")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.CvCtaCostoPorTerrenos, "IX_Proyectos_14")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.CvCtaTraspasoCostoPorTerrenos, "IX_Proyectos_15")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.CvCtaAnticiposClientes, "IX_Proyectos_16")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.CvCtaTraspasoCostoPorCasas, "IX_Proyectos_17")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.CvCtaIngresosPorVentasCasas, "IX_Proyectos_18")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.CvCtaIvaTrasladadoPorAplicar, "IX_Proyectos_19")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.CvCtaIntereses, "IX_Proyectos_2")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.CvCtaIngresosPorVentasTerrenos, "IX_Proyectos_20")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.CvCtaMoratorios, "IX_Proyectos_21")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuentaIvaalmacen, "IX_Proyectos_22")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.CvCtaApartados, "IX_Proyectos_3")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.CvCtaDepPorIdentificar, "IX_Proyectos_4")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.CuentaInterCentro, "IX_Proyectos_5")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.CvCtaDevolucionesClientes, "IX_Proyectos_6")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.CvCtaClientes, "IX_Proyectos_7")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.CvCtaGastosAdicionales, "IX_Proyectos_8")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdCuentaAlmacen, "IX_Proyectos_9")
                    .HasFillFactor(90);

                entity.Property(e => e.AcContabilidad)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AcFacturas)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AcOcompra)
                    .IsRequired()
                    .HasColumnName("AcOCompra")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AcRequisiciones)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Ansi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AoActCostoCantOriImp)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AoAgregarEstimaciones)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AoAgregarMovAlmacen)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AoAgregarOcpresupC).HasColumnName("AoAgregarOCPresupC");

                entity.Property(e => e.AoAgregarOcsubcontratos).HasColumnName("AoAgregarOCSubcontratos");

                entity.Property(e => e.AoAgregarSubcontratos)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AoControlPorPrototipo)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AoModificarEstimaciones)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AoModificarMovAlmacen)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AoModificarPresupC)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AoModificarSubcontratos)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AoValidarCostoDestajo)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AoValidarCostoSubcontrato)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AutenticacionImpPu2010).HasColumnName("AutenticacionImpPU2010");

                entity.Property(e => e.BaseDatosImpPu2010)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BaseDatosImpPU2010");

                entity.Property(e => e.CodigoPostal)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ContraseniaBdImpPu2010)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ContraseniaBdImpPU2010");

                entity.Property(e => e.ControladoXprograma).HasColumnName("ControladoXPrograma");

                entity.Property(e => e.CvActaConstitutivaEmpresa)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.CvAutenticacionWindowsAvanceObra).HasDefaultValueSql("((0))");

                entity.Property(e => e.CvBancoReferencia)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CvBdavanceObra)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CvBDAvanceObra");

                entity.Property(e => e.CvContraseniaBdavanceObra)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CvContraseniaBDAvanceObra");

                entity.Property(e => e.CvCuentaReferencia)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CvEmpresaClabe)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("CvEmpresaCLABE");

                entity.Property(e => e.CvEscrituraFraccionamiento)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.CvFechaBloqueoAjustesClientes)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))");

                entity.Property(e => e.CvFechaBloqueoApartados)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))");

                entity.Property(e => e.CvFechaBloqueoCancelaciones)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))");

                entity.Property(e => e.CvFechaBloqueoDepSofoles)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))");

                entity.Property(e => e.CvFechaBloqueoDepositos)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))");

                entity.Property(e => e.CvFechaBloqueoEscrituras)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))");

                entity.Property(e => e.CvFechaBloqueoNotasCreditoCargo)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))");

                entity.Property(e => e.CvFechaBloqueoPagos)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))");

                entity.Property(e => e.CvFechaFirmaPuente).HasColumnType("datetime");

                entity.Property(e => e.CvIdFlujoExcedentes).HasColumnName("CvIdFLujoExcedentes");

                entity.Property(e => e.CvIva)
                    .HasColumnType("smallmoney")
                    .HasColumnName("CvIVA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CvMontoCreditoPuente).HasColumnType("money");

                entity.Property(e => e.CvNoCreditoPuente)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CvNoEscrituraPuente)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CvRazonSocial)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CvRepresentanteLegalEmpresa)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CvRepresentanteLegalEmpresaApellidoMaterno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CvRepresentanteLegalEmpresaApellidoPaterno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CvRepresentanteLegalIdentificacion).HasMaxLength(30);

                entity.Property(e => e.CvRepresentanteLegalLada)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CvRepresentanteLegalTelefono)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CvRepresentanteLegalTelefonoCelular)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CvRfcEmpresa)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.CvRutaArchivoDigitoVerificador)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CvSalarioMinimo).HasColumnType("money");

                entity.Property(e => e.CvServidorAvanceObra)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CvUsuarioBdavanceObra)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CvUsuarioBDAvanceObra");

                entity.Property(e => e.CvValorDeEsquina).HasColumnType("money");

                entity.Property(e => e.CvValorPorMetroExcedente).HasColumnType("money");

                entity.Property(e => e.Delegacion)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DiaCapturaAlmacen)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ExpInsSeCalculoEnBaseApo).HasColumnName("ExpInsSeCalculoEnBaseAPO");

                entity.Property(e => e.Fax)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCheque)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))");

                entity.Property(e => e.FechaContabilidad)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))");

                entity.Property(e => e.FechaEstimaciones)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))");

                entity.Property(e => e.FechaFacturaCliente)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))");

                entity.Property(e => e.FechaFacturaProveedor)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))");

                entity.Property(e => e.FechaFinal).HasColumnType("datetime");

                entity.Property(e => e.FechaFinalProy).HasColumnType("datetime");

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioProy).HasColumnType("datetime");

                entity.Property(e => e.FechaMovAlm).HasColumnType("datetime");

                entity.Property(e => e.FechaPedido)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))");

                entity.Property(e => e.FechaRequisicion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))");

                entity.Property(e => e.FechaSubContratos)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))");

                entity.Property(e => e.Fraccionamiento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GenerarRequisicionesComer)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.HoraLabFin).HasColumnType("datetime");

                entity.Property(e => e.HoraLabIni).HasColumnType("datetime");

                entity.Property(e => e.IdCuentaIvaalmacen).HasColumnName("IdCuentaIVAAlmacen");

                entity.Property(e => e.IdMonedaCalculadaImpPu2010).HasColumnName("IdMonedaCalculadaImpPU2010");

                entity.Property(e => e.IdMonedaImpPu2010).HasColumnName("IdMonedaImpPU2010");

                entity.Property(e => e.IdPresupuestoImpPu2010).HasColumnName("IdPresupuestoImpPU2010");

                entity.Property(e => e.IdUnegociogeo).HasColumnName("IdUNegociogeo");

                entity.Property(e => e.IdUnidadNegocio).HasColumnName("idUnidadNegocio");

                entity.Property(e => e.ImportarDesdeLocalDb).HasColumnName("ImportarDesdeLocalDB");

                entity.Property(e => e.ImportarDesdeServidorSql).HasColumnName("ImportarDesdeServidorSQL");

                entity.Property(e => e.ImporteMaximoParaAutorizarEstimaciones).HasColumnType("money");

                entity.Property(e => e.ImporteMaximoParaAutorizarPedidos).HasColumnType("money");

                entity.Property(e => e.LugEntrMat)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ManejarIvaalmacen).HasColumnName("ManejarIVAAlmacen");

                entity.Property(e => e.MonedaCalculadaImpPu2010).HasColumnName("MonedaCalculadaImpPU2010");

                entity.Property(e => e.MonedaImpPu2010).HasColumnName("MonedaImpPU2010");

                entity.Property(e => e.MontoCorridaFinanciera).HasColumnType("money");

                entity.Property(e => e.MontoFacturadoInicial).HasColumnType("money");

                entity.Property(e => e.MultimonedaImpPu2010).HasColumnName("MultimonedaImpPU2010");

                entity.Property(e => e.NoConsecutivo)
                    .HasMaxLength(38)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Observac)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Periodicidad).HasDefaultValueSql("((1))");

                entity.Property(e => e.PorcentajeIva)
                    .HasColumnType("money")
                    .HasColumnName("PorcentajeIVA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PresupTopeLote)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PresupuestoImpPu2010)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PresupuestoImpPU2010");

                entity.Property(e => e.Proyecto1)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Proyecto");

                entity.Property(e => e.ProyectoAuxiliar)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Referencia)
                    .HasMaxLength(38)
                    .IsUnicode(false);

                entity.Property(e => e.RutaArchivoLocalDb)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("RutaArchivoLocalDB");

                entity.Property(e => e.RutaAutoCad)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RutaNomina)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.RutaPresupCliente)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.RutaPresupPrototipo)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.RutaPresupPu)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("RutaPresupPU");

                entity.Property(e => e.Servidor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServidorImpPu2010)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ServidorImpPU2010");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TipoGenPolizasAlmacen).HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuarioBdImpPu2010)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UsuarioBdImpPU2010");

                entity.Property(e => e.ValidarSoloVsExistencias).HasColumnName("validarSoloVsExistencias");

                entity.HasOne(d => d.CuentaInterCentroNavigation)
                    .WithMany(p => p.ProyectoCuentaInterCentroNavigations)
                    .HasForeignKey(d => d.CuentaInterCentro)
                    .HasConstraintName("FK_Proyectos_Cuentas3");

                entity.HasOne(d => d.CvCtaAnticiposClientesNavigation)
                    .WithMany(p => p.ProyectoCvCtaAnticiposClientesNavigations)
                    .HasForeignKey(d => d.CvCtaAnticiposClientes)
                    .HasConstraintName("FK_Proyectos_CtbCuentas9");

                entity.HasOne(d => d.CvCtaApartadosNavigation)
                    .WithMany(p => p.ProyectoCvCtaApartadosNavigations)
                    .HasForeignKey(d => d.CvCtaApartados)
                    .HasConstraintName("FK_Proyectos_Cuentas4");

                entity.HasOne(d => d.CvCtaCancelacionIngresosClientesNavigation)
                    .WithMany(p => p.ProyectoCvCtaCancelacionIngresosClientesNavigations)
                    .HasForeignKey(d => d.CvCtaCancelacionIngresosClientes)
                    .HasConstraintName("FK_Proyectos_CtbCuentas7");

                entity.HasOne(d => d.CvCtaClientesNavigation)
                    .WithMany(p => p.ProyectoCvCtaClientesNavigations)
                    .HasForeignKey(d => d.CvCtaClientes)
                    .HasConstraintName("FK_Proyectos_CtbCuentas10");

                entity.HasOne(d => d.CvCtaCostoPorCasasNavigation)
                    .WithMany(p => p.ProyectoCvCtaCostoPorCasasNavigations)
                    .HasForeignKey(d => d.CvCtaCostoPorCasas)
                    .HasConstraintName("FK_Proyectos_CtbCuentas15");

                entity.HasOne(d => d.CvCtaCostoPorTerrenosNavigation)
                    .WithMany(p => p.ProyectoCvCtaCostoPorTerrenosNavigations)
                    .HasForeignKey(d => d.CvCtaCostoPorTerrenos)
                    .HasConstraintName("FK_Proyectos_CtbCuentas16");

                entity.HasOne(d => d.CvCtaDepPorIdentificarNavigation)
                    .WithMany(p => p.ProyectoCvCtaDepPorIdentificarNavigations)
                    .HasForeignKey(d => d.CvCtaDepPorIdentificar)
                    .HasConstraintName("FK_Proyectos_Cuentas");

                entity.HasOne(d => d.CvCtaDevolucionesClientesNavigation)
                    .WithMany(p => p.ProyectoCvCtaDevolucionesClientesNavigations)
                    .HasForeignKey(d => d.CvCtaDevolucionesClientes)
                    .HasConstraintName("FK_Proyectos_CtbCuentas3");

                entity.HasOne(d => d.CvCtaDevolucionesClientesSaldoFavorNavigation)
                    .WithMany(p => p.ProyectoCvCtaDevolucionesClientesSaldoFavorNavigations)
                    .HasForeignKey(d => d.CvCtaDevolucionesClientesSaldoFavor)
                    .HasConstraintName("FK_Proyectos_CtbCuentas19");

                entity.HasOne(d => d.CvCtaGastosAdicionalesNavigation)
                    .WithMany(p => p.ProyectoCvCtaGastosAdicionalesNavigations)
                    .HasForeignKey(d => d.CvCtaGastosAdicionales)
                    .HasConstraintName("FK_Proyectos_CtbCuentas1");

                entity.HasOne(d => d.CvCtaIngresosPorCancelacionesNavigation)
                    .WithMany(p => p.ProyectoCvCtaIngresosPorCancelacionesNavigations)
                    .HasForeignKey(d => d.CvCtaIngresosPorCancelaciones)
                    .HasConstraintName("FK_Proyectos_CtbCuentas6");

                entity.HasOne(d => d.CvCtaIngresosPorVentasCasasNavigation)
                    .WithMany(p => p.ProyectoCvCtaIngresosPorVentasCasasNavigations)
                    .HasForeignKey(d => d.CvCtaIngresosPorVentasCasas)
                    .HasConstraintName("FK_Proyectos_CtbCuentas11");

                entity.HasOne(d => d.CvCtaIngresosPorVentasTerrenosNavigation)
                    .WithMany(p => p.ProyectoCvCtaIngresosPorVentasTerrenosNavigations)
                    .HasForeignKey(d => d.CvCtaIngresosPorVentasTerrenos)
                    .HasConstraintName("FK_Proyectos_CtbCuentas12");

                entity.HasOne(d => d.CvCtaInteresesNavigation)
                    .WithMany(p => p.ProyectoCvCtaInteresesNavigations)
                    .HasForeignKey(d => d.CvCtaIntereses)
                    .HasConstraintName("FK_Proyectos_CtbCuentas");

                entity.HasOne(d => d.CvCtaIvaTrasladadoNavigation)
                    .WithMany(p => p.ProyectoCvCtaIvaTrasladadoNavigations)
                    .HasForeignKey(d => d.CvCtaIvaTrasladado)
                    .HasConstraintName("FK_Proyectos_CtbCuentas4");

                entity.HasOne(d => d.CvCtaIvaTrasladadoPorAplicarNavigation)
                    .WithMany(p => p.ProyectoCvCtaIvaTrasladadoPorAplicarNavigations)
                    .HasForeignKey(d => d.CvCtaIvaTrasladadoPorAplicar)
                    .HasConstraintName("FK_Proyectos_CtbCuentas5");

                entity.HasOne(d => d.CvCtaMoratoriosNavigation)
                    .WithMany(p => p.ProyectoCvCtaMoratoriosNavigations)
                    .HasForeignKey(d => d.CvCtaMoratorios)
                    .HasConstraintName("FK_Proyectos_CtbCuentas2");

                entity.HasOne(d => d.CvCtaTraspasoCostoPorCasasNavigation)
                    .WithMany(p => p.ProyectoCvCtaTraspasoCostoPorCasasNavigations)
                    .HasForeignKey(d => d.CvCtaTraspasoCostoPorCasas)
                    .HasConstraintName("FK_Proyectos_CtbCuentas13");

                entity.HasOne(d => d.CvCtaTraspasoCostoPorTerrenosNavigation)
                    .WithMany(p => p.ProyectoCvCtaTraspasoCostoPorTerrenosNavigations)
                    .HasForeignKey(d => d.CvCtaTraspasoCostoPorTerrenos)
                    .HasConstraintName("FK_Proyectos_CtbCuentas14");

                entity.HasOne(d => d.CvIdFlujoAjustesNavigation)
                    .WithMany(p => p.ProyectoCvIdFlujoAjustesNavigations)
                    .HasForeignKey(d => d.CvIdFlujoAjustes)
                    .HasConstraintName("FK_Proyectos_AcCatFlujos5");

                entity.HasOne(d => d.CvIdFlujoCancelacionesNavigation)
                    .WithMany(p => p.ProyectoCvIdFlujoCancelacionesNavigations)
                    .HasForeignKey(d => d.CvIdFlujoCancelaciones)
                    .HasConstraintName("FK_Proyectos_AcCatFlujos4");

                entity.HasOne(d => d.CvIdFlujoDepositosNavigation)
                    .WithMany(p => p.ProyectoCvIdFlujoDepositosNavigations)
                    .HasForeignKey(d => d.CvIdFlujoDepositos)
                    .HasConstraintName("FK_Proyectos_AcCatFlujos");

                entity.HasOne(d => d.CvIdFlujoExcedentesNavigation)
                    .WithMany(p => p.ProyectoCvIdFlujoExcedentesNavigations)
                    .HasForeignKey(d => d.CvIdFlujoExcedentes)
                    .HasConstraintName("FK_Proyectos_AcCatFlujos7");

                entity.HasOne(d => d.CvIdFlujoGastosAdicionalesNavigation)
                    .WithMany(p => p.ProyectoCvIdFlujoGastosAdicionalesNavigations)
                    .HasForeignKey(d => d.CvIdFlujoGastosAdicionales)
                    .HasConstraintName("FK_Proyectos_AcCatFlujos3");

                entity.HasOne(d => d.CvIdFlujoInteresesNavigation)
                    .WithMany(p => p.ProyectoCvIdFlujoInteresesNavigations)
                    .HasForeignKey(d => d.CvIdFlujoIntereses)
                    .HasConstraintName("FK_Proyectos_AcCatFlujos2");

                entity.HasOne(d => d.CvIdFlujoMoratoriosNavigation)
                    .WithMany(p => p.ProyectoCvIdFlujoMoratoriosNavigations)
                    .HasForeignKey(d => d.CvIdFlujoMoratorios)
                    .HasConstraintName("FK_Proyectos_AcCatFlujos1");

                entity.HasOne(d => d.CvIdFlujoPenalizacionesNavigation)
                    .WithMany(p => p.ProyectoCvIdFlujoPenalizacionesNavigations)
                    .HasForeignKey(d => d.CvIdFlujoPenalizaciones)
                    .HasConstraintName("FK_Proyectos_AcCatFlujos6");

                entity.HasOne(d => d.CvIdNotariaPuenteNavigation)
                    .WithMany(p => p.Proyectos)
                    .HasForeignKey(d => d.CvIdNotariaPuente)
                    .HasConstraintName("FK_Proyectos_CvNotarias");

                entity.HasOne(d => d.CvIdSofolPuenteNavigation)
                    .WithMany(p => p.Proyectos)
                    .HasForeignKey(d => d.CvIdSofolPuente)
                    .HasConstraintName("FK_Proyectos_CvSofoles");

                entity.HasOne(d => d.CvIdTipoMonedaPuenteNavigation)
                    .WithMany(p => p.Proyectos)
                    .HasForeignKey(d => d.CvIdTipoMonedaPuente)
                    .HasConstraintName("FK_Proyectos_AcCatMonedas");

                entity.HasOne(d => d.IdAutorizoNavigation)
                    .WithMany(p => p.ProyectoIdAutorizoNavigations)
                    .HasForeignKey(d => d.IdAutorizo)
                    .HasConstraintName("FK_Proyectos_ACResponsables2");

                entity.HasOne(d => d.IdCiudadNavigation)
                    .WithMany(p => p.Proyectos)
                    .HasForeignKey(d => d.IdCiudad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Proyectos_AcCatCiudades");

                entity.HasOne(d => d.IdContabilidadNavigation)
                    .WithMany(p => p.ProyectoIdContabilidadNavigations)
                    .HasForeignKey(d => d.IdContabilidad)
                    .HasConstraintName("FK_Proyectos_ACResponsables1");

                entity.HasOne(d => d.IdCtaBancariaSocio1Navigation)
                    .WithMany(p => p.ProyectoIdCtaBancariaSocio1Navigations)
                    .HasForeignKey(d => d.IdCtaBancariaSocio1)
                    .HasConstraintName("FK_Proyectos_AcCuentasBancarias");

                entity.HasOne(d => d.IdCtaBancariaSocio2Navigation)
                    .WithMany(p => p.ProyectoIdCtaBancariaSocio2Navigations)
                    .HasForeignKey(d => d.IdCtaBancariaSocio2)
                    .HasConstraintName("FK_Proyectos_AcCuentasBancarias1");

                entity.HasOne(d => d.IdCuentaAlmacenNavigation)
                    .WithMany(p => p.ProyectoIdCuentaAlmacenNavigations)
                    .HasForeignKey(d => d.IdCuentaAlmacen)
                    .HasConstraintName("FK_Proyectos_CtbCuentas17");

                entity.HasOne(d => d.IdCuentaIvaalmacenNavigation)
                    .WithMany(p => p.ProyectoIdCuentaIvaalmacenNavigations)
                    .HasForeignKey(d => d.IdCuentaIvaalmacen)
                    .HasConstraintName("FK_Proyectos_CtbCuentas18");

                entity.HasOne(d => d.IdResponsableNavigation)
                    .WithMany(p => p.ProyectoIdResponsableNavigations)
                    .HasForeignKey(d => d.IdResponsable)
                    .HasConstraintName("FK_Proyectos_ACResponsables");

                entity.HasOne(d => d.IdResponsableProyectoNavigation)
                    .WithMany(p => p.ProyectoIdResponsableProyectoNavigations)
                    .HasForeignKey(d => d.IdResponsableProyecto)
                    .HasConstraintName("FK_Proyectos_ACResponsables4");

                entity.HasOne(d => d.IdRevisoNavigation)
                    .WithMany(p => p.ProyectoIdRevisoNavigations)
                    .HasForeignKey(d => d.IdReviso)
                    .HasConstraintName("FK_Proyectos_ACResponsables3");

                entity.HasOne(d => d.IdTipoPolizaTraspasoNavigation)
                    .WithMany(p => p.Proyectos)
                    .HasForeignKey(d => d.IdTipoPolizaTraspaso)
                    .HasConstraintName("FK_Proyectos_CtbTiposPoliza");

                entity.HasOne(d => d.IdTipoProyectoNavigation)
                    .WithMany(p => p.Proyectos)
                    .HasForeignKey(d => d.IdTipoProyecto)
                    .HasConstraintName("FK_Proyectos_AOTipoProyectos");

                entity.HasOne(d => d.IdUbicacionAlmacenNavigation)
                    .WithMany(p => p.Proyectos)
                    .HasForeignKey(d => d.IdUbicacionAlmacen)
                    .HasConstraintName("FK_Proyectos_AcAlmacenUbicaciones");

                entity.HasOne(d => d.IdUnegociogeoNavigation)
                    .WithMany(p => p.Proyectos)
                    .HasForeignKey(d => d.IdUnegociogeo)
                    .HasConstraintName("FK_Proyectos_AOUnidadNegocio");

                entity.HasOne(d => d.IdUnidadNegocioNavigation)
                    .WithMany(p => p.Proyectos)
                    .HasForeignKey(d => d.IdUnidadNegocio)
                    .HasConstraintName("FK_Proyectos_AcUnidadesNegocio");
            });

            modelBuilder.Entity<ProyectosAlmacenGeneral>(entity =>
            {
                entity.HasKey(e => e.IdProyectoAlmacenGeneral);

                entity.ToTable("ProyectosAlmacenGeneral");

                entity.HasIndex(e => new { e.IdAlmacenGeneral, e.IdAlmacenObra, e.IdAlmacenTransito }, "IX_ProyectosAlmacenGeneral")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdAlmacenObra, e.IdAlmacenTransito }, "IX_ProyectosAlmacenGeneral_1")
                    .IsUnique();

                entity.HasOne(d => d.IdAlmacenGeneralNavigation)
                    .WithMany(p => p.ProyectosAlmacenGeneralIdAlmacenGeneralNavigations)
                    .HasForeignKey(d => d.IdAlmacenGeneral)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProyectosAlmacenGeneral_Proyectos");

                entity.HasOne(d => d.IdAlmacenObraNavigation)
                    .WithMany(p => p.ProyectosAlmacenGeneralIdAlmacenObraNavigations)
                    .HasForeignKey(d => d.IdAlmacenObra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProyectosAlmacenGeneral_Proyectos1");

                entity.HasOne(d => d.IdAlmacenTransitoNavigation)
                    .WithMany(p => p.ProyectosAlmacenGeneralIdAlmacenTransitoNavigations)
                    .HasForeignKey(d => d.IdAlmacenTransito)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProyectosAlmacenGeneral_Proyectos2");
            });

            modelBuilder.Entity<ProyectosDetTac>(entity =>
            {
                entity.HasKey(e => e.IdProyectoDetTac);

                entity.ToTable("ProyectosDetTAC");

                entity.HasIndex(e => new { e.IdProyecto, e.IdCtaCostoTac }, "IX_ProyectosDetTAC");

                entity.Property(e => e.IdProyectoDetTac).HasColumnName("IdProyectoDetTAC");

                entity.Property(e => e.CostoInicial).HasColumnType("money");

                entity.Property(e => e.IdCtaCostoTac).HasColumnName("IdCtaCostoTAC");

                entity.HasOne(d => d.IdCtaCostoTacNavigation)
                    .WithMany(p => p.ProyectosDetTacs)
                    .HasForeignKey(d => d.IdCtaCostoTac)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProyectosDetTAC_CtbCuentas");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.ProyectosDetTacs)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProyectosDetTAC_Proyectos");
            });

            modelBuilder.Entity<ProyectosPorcenAportSocio>(entity =>
            {
                entity.HasKey(e => new { e.IdProyecto, e.IdCuenta });

                entity.Property(e => e.IdProyecto).HasColumnName("idProyecto");

                entity.Property(e => e.IdCuenta).HasColumnName("idCuenta");

                entity.Property(e => e.Porcentaje).HasColumnType("money");

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithMany(p => p.ProyectosPorcenAportSocios)
                    .HasForeignKey(d => d.IdCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProyectosPorcenAportSocios_CtbCuentas");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.ProyectosPorcenAportSocios)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProyectosPorcenAportSocios_Proyectos");
            });

            modelBuilder.Entity<PuUnidade>(entity =>
            {
                entity.HasKey(e => e.IdUnidad);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Unidad)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReCvApartado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RE_Cv_Apartados");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Crédito)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Etapa).HasMaxLength(40);

                entity.Property(e => e.FechaApartado)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Fecha Apartado");

                entity.Property(e => e.Lote).HasMaxLength(4);

                entity.Property(e => e.Manzana).HasMaxLength(20);

                entity.Property(e => e.Mes).HasMaxLength(30);

                entity.Property(e => e.MontoApartado)
                    .HasColumnType("money")
                    .HasColumnName("Monto apartado");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(142)
                    .HasColumnName("Nombre cliente");

                entity.Property(e => e.NombreProyecto)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Nombre proyecto");

                entity.Property(e => e.Plaza).HasMaxLength(20);

                entity.Property(e => e.PrecioVentaVivienda)
                    .HasColumnType("money")
                    .HasColumnName("Precio venta vivienda");

                entity.Property(e => e.Prototipo).HasMaxLength(20);

                entity.Property(e => e.Proyecto)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReCvCancelacione>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RE_Cv_Cancelaciones");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Contrato)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ContratoImpreso).HasColumnName("Contrato impreso");

                entity.Property(e => e.Crédito).HasMaxLength(20);

                entity.Property(e => e.DíasTranscurridos).HasColumnName("Días transcurridos");

                entity.Property(e => e.Ejecutivo).HasMaxLength(20);

                entity.Property(e => e.FechaCancelación)
                    .HasMaxLength(93)
                    .IsUnicode(false)
                    .HasColumnName("Fecha cancelación");

                entity.Property(e => e.FechaContrato)
                    .HasMaxLength(93)
                    .IsUnicode(false)
                    .HasColumnName("Fecha contrato");

                entity.Property(e => e.Mes).HasMaxLength(30);

                entity.Property(e => e.MontoAnticipos)
                    .HasColumnType("money")
                    .HasColumnName("Monto anticipos");

                entity.Property(e => e.MontoDevuelto)
                    .HasColumnType("money")
                    .HasColumnName("Monto devuelto");

                entity.Property(e => e.MontoIvaPenalización)
                    .HasColumnType("money")
                    .HasColumnName("Monto IVA penalización");

                entity.Property(e => e.MontoPenalización)
                    .HasColumnType("money")
                    .HasColumnName("Monto penalización");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(142)
                    .HasColumnName("Nombre cliente");

                entity.Property(e => e.NombreProyecto)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Nombre proyecto");

                entity.Property(e => e.Proyecto)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TipoFalla)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Tipo falla");
            });

            modelBuilder.Entity<ReCvClientesXcredito>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RE_Cv_ClientesXCreditos");

                entity.Property(e => e.Crédito)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.NombreProyecto)
                    .HasMaxLength(30)
                    .HasColumnName("Nombre proyecto");

                entity.Property(e => e.Proyecto)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCliente)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Tipo cliente");
            });

            modelBuilder.Entity<ReCvEfectividadMedio>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RE_Cv_EfectividadMedios");

                entity.Property(e => e.Medio)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.NombreProyecto)
                    .HasMaxLength(30)
                    .HasColumnName("Nombre proyecto");

                entity.Property(e => e.Proyecto)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCliente)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Tipo cliente");
            });

            modelBuilder.Entity<ReCvFirmada>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RE_Cv_Firmadas");

                entity.Property(e => e.Contrato)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Crédito)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Etapa).HasMaxLength(40);

                entity.Property(e => e.FechaContrato)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha contrato");

                entity.Property(e => e.Lote).HasMaxLength(4);

                entity.Property(e => e.Manzana).HasMaxLength(20);

                entity.Property(e => e.Mes).HasMaxLength(30);

                entity.Property(e => e.MesContable)
                    .HasMaxLength(62)
                    .IsUnicode(false)
                    .HasColumnName("Mes contable");

                entity.Property(e => e.NombreProyecto)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Nombre proyecto");

                entity.Property(e => e.Plaza).HasMaxLength(20);

                entity.Property(e => e.PrecioVentaVivienda)
                    .HasColumnType("money")
                    .HasColumnName("Precio venta vivienda");

                entity.Property(e => e.Prototipo).HasMaxLength(20);

                entity.Property(e => e.Proyecto)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReCvFlujoCliente>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RE_Cv_FlujoClientes");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasMaxLength(142);

                entity.Property(e => e.Ejecutivo).HasMaxLength(40);

                entity.Property(e => e.Etapa).HasMaxLength(40);

                entity.Property(e => e.EtapaCliente)
                    .HasMaxLength(20)
                    .HasColumnName("Etapa cliente");

                entity.Property(e => e.NombreProyecto)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Nombre proyecto");

                entity.Property(e => e.Proyecto)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReCvFlujoVivienda>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RE_Cv_FlujoViviendas");

                entity.Property(e => e.Etapa).HasMaxLength(40);

                entity.Property(e => e.EtapaVivienda)
                    .HasMaxLength(20)
                    .HasColumnName("Etapa vivienda");

                entity.Property(e => e.NombreProyecto)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Nombre proyecto");

                entity.Property(e => e.Proyecto)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Vivienda)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ReCvIngresosEsperado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RE_Cv_IngresosEsperados");

                entity.Property(e => e.Crédito)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CódigoCliente)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Código cliente");

                entity.Property(e => e.Etapa).HasMaxLength(40);

                entity.Property(e => e.FechaVencimiento)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Fecha vencimiento");

                entity.Property(e => e.Mes).HasMaxLength(30);

                entity.Property(e => e.Monto).HasColumnType("money");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(142)
                    .HasColumnName("Nombre Cliente");

                entity.Property(e => e.NombreProyecto)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Nombre proyecto");

                entity.Property(e => e.Plaza).HasMaxLength(20);

                entity.Property(e => e.Proyecto)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Semana).HasMaxLength(30);

                entity.Property(e => e.TipoPlan)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ReCvVentasXejecutivo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RE_Cv_VentasXEjecutivo");

                entity.Property(e => e.Ejecutivo).HasMaxLength(40);

                entity.Property(e => e.Importe).HasColumnType("money");

                entity.Property(e => e.NombreProyecto)
                    .HasMaxLength(30)
                    .HasColumnName("Nombre proyecto");

                entity.Property(e => e.Prototipo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Proyecto)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReCvVivienda>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RE_Cv_Viviendas");

                entity.Property(e => e.Desarrollo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.EstatusAsignación)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("Estatus asignación");

                entity.Property(e => e.EstatusConstrucción)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Estatus construcción");

                entity.Property(e => e.EstatusEscritura)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Estatus escritura");

                entity.Property(e => e.Etapa)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.NombreProyecto)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Nombre proyecto");

                entity.Property(e => e.Plaza)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PrecioVentaEscritura)
                    .HasColumnType("money")
                    .HasColumnName("Precio venta/escritura");

                entity.Property(e => e.Prototipo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PrototipoComercial)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Prototipo comercial");

                entity.Property(e => e.Proyecto)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TipoLote)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Tipo lote");

                entity.Property(e => e.Vivienda)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<RepDestajoNomina>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RepDestajoNomina");

                entity.Property(e => e.AnticipoCan).HasColumnType("money");

                entity.Property(e => e.Descuen).HasColumnType("money");

                entity.Property(e => e.FonGarAm).HasColumnType("money");

                entity.Property(e => e.FonGarCan).HasColumnType("money");

                entity.Property(e => e.Importe).HasColumnType("money");

                entity.Property(e => e.Liquido).HasColumnType("money");

                entity.Property(e => e.Subcont).HasMaxLength(10);

                entity.Property(e => e.SueldoLiquido).HasColumnType("money");

                entity.Property(e => e.TotalDeduc).HasColumnType("money");

                entity.Property(e => e.TotalPercep).HasColumnType("money");
            });

            modelBuilder.Entity<RepFinanciero>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RepFinanciero");

                entity.Property(e => e.AnticipoPorAmortizar).HasMaxLength(50);

                entity.Property(e => e.AnticipoPorAmortizarCliente).HasMaxLength(50);

                entity.Property(e => e.Anticipos).HasMaxLength(50);

                entity.Property(e => e.AvanceFinanciero).HasMaxLength(50);

                entity.Property(e => e.CostoDirectoObra).HasMaxLength(50);

                entity.Property(e => e.CostoDirectoObraP).HasMaxLength(50);

                entity.Property(e => e.CostoDirectoTotalObra).HasMaxLength(50);

                entity.Property(e => e.CostoDirectoTotalObraP).HasMaxLength(50);

                entity.Property(e => e.CostoIndirectoTotalObra).HasMaxLength(50);

                entity.Property(e => e.CostoIndirectoTotalObraP).HasMaxLength(50);

                entity.Property(e => e.CostoProf).HasMaxLength(50);

                entity.Property(e => e.CostoProfP).HasMaxLength(50);

                entity.Property(e => e.CostoProyecto).HasMaxLength(50);

                entity.Property(e => e.CostoTotal).HasMaxLength(50);

                entity.Property(e => e.CostoTotalP).HasMaxLength(50);

                entity.Property(e => e.CuentasPorCobrar).HasMaxLength(50);

                entity.Property(e => e.CuentasPorPagar).HasMaxLength(50);

                entity.Property(e => e.Egresos).HasMaxLength(50);

                entity.Property(e => e.EgresosVarios).HasMaxLength(50);

                entity.Property(e => e.Encabezado2).HasMaxLength(255);

                entity.Property(e => e.Estimaciones).HasMaxLength(50);

                entity.Property(e => e.FondoGarantia).HasMaxLength(50);

                entity.Property(e => e.IngresosVarios).HasMaxLength(50);

                entity.Property(e => e.MontoContrato).HasMaxLength(50);

                entity.Property(e => e.MontoOrdenesCambio).HasMaxLength(50);

                entity.Property(e => e.MontoTotalActContrato).HasMaxLength(50);

                entity.Property(e => e.NotasCredito).HasMaxLength(50);

                entity.Property(e => e.OIndirectos)
                    .HasMaxLength(50)
                    .HasColumnName("oIndirectos");

                entity.Property(e => e.ObraEjecutada).HasMaxLength(50);

                entity.Property(e => e.ObraEjecutadaNoEstimada).HasMaxLength(50);

                entity.Property(e => e.ObraEstimada).HasMaxLength(50);

                entity.Property(e => e.ObraEstimadaNoFacturada).HasMaxLength(50);

                entity.Property(e => e.ObraFacturada).HasMaxLength(50);

                entity.Property(e => e.Ot1)
                    .HasMaxLength(50)
                    .HasColumnName("ot1");

                entity.Property(e => e.Ot2)
                    .HasMaxLength(50)
                    .HasColumnName("ot2");

                entity.Property(e => e.Ot3)
                    .HasMaxLength(50)
                    .HasColumnName("ot3");

                entity.Property(e => e.Ot4)
                    .HasMaxLength(50)
                    .HasColumnName("ot4");

                entity.Property(e => e.Ot5)
                    .HasMaxLength(50)
                    .HasColumnName("ot5");

                entity.Property(e => e.Ot6)
                    .HasMaxLength(50)
                    .HasColumnName("ot6");

                entity.Property(e => e.Ot7)
                    .HasMaxLength(50)
                    .HasColumnName("ot7");

                entity.Property(e => e.Ot8)
                    .HasMaxLength(50)
                    .HasColumnName("ot8");

                entity.Property(e => e.Ot9)
                    .HasMaxLength(50)
                    .HasColumnName("ot9");

                entity.Property(e => e.Overhead).HasMaxLength(50);

                entity.Property(e => e.OverheadP).HasMaxLength(50);

                entity.Property(e => e.PeriodoEjecucionRango).HasMaxLength(50);

                entity.Property(e => e.PerodoEjecucionDias).HasMaxLength(50);

                entity.Property(e => e.ProvisionCosto).HasMaxLength(50);

                entity.Property(e => e.ProvisionIngresos).HasMaxLength(50);

                entity.Property(e => e.RIndirectos)
                    .HasMaxLength(50)
                    .HasColumnName("rIndirectos");

                entity.Property(e => e.RIndirectosP)
                    .HasMaxLength(50)
                    .HasColumnName("rIndirectosP");

                entity.Property(e => e.Rt1)
                    .HasMaxLength(50)
                    .HasColumnName("rt1");

                entity.Property(e => e.Rt2)
                    .HasMaxLength(50)
                    .HasColumnName("rt2");

                entity.Property(e => e.Rt3)
                    .HasMaxLength(50)
                    .HasColumnName("rt3");

                entity.Property(e => e.Rt4)
                    .HasMaxLength(50)
                    .HasColumnName("rt4");

                entity.Property(e => e.Rt5)
                    .HasMaxLength(50)
                    .HasColumnName("rt5");

                entity.Property(e => e.Rt6)
                    .HasMaxLength(50)
                    .HasColumnName("rt6");

                entity.Property(e => e.Rt7)
                    .HasMaxLength(50)
                    .HasColumnName("rt7");

                entity.Property(e => e.Rt8)
                    .HasMaxLength(50)
                    .HasColumnName("rt8");

                entity.Property(e => e.Rt9)
                    .HasMaxLength(50)
                    .HasColumnName("rt9");

                entity.Property(e => e.SobreCostos).HasMaxLength(50);

                entity.Property(e => e.Staff).HasMaxLength(50);

                entity.Property(e => e.Superavit).HasMaxLength(50);

                entity.Property(e => e.TotalIngresos).HasMaxLength(50);

                entity.Property(e => e.UtilidadObra).HasMaxLength(50);

                entity.Property(e => e.UtilidadObraP).HasMaxLength(50);

                entity.Property(e => e.ValorAlmacen).HasMaxLength(50);

                entity.Property(e => e.ValorObra).HasMaxLength(50);

                entity.Property(e => e.ValorObraEjecutada).HasMaxLength(50);

                entity.Property(e => e.ValorObraEjecutadaP).HasMaxLength(50);

                entity.Property(e => e.ValorObrap).HasMaxLength(50);
            });

            modelBuilder.Entity<ReportesEjecutivo>(entity =>
            {
                entity.HasKey(e => e.IdReporte);

                entity.HasIndex(e => e.Codigo, "IX_ReportesEjecutivosCodigo")
                    .IsUnique();

                entity.Property(e => e.IdReporte).HasColumnName("idReporte");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Descripcion).HasMaxLength(40);

                entity.Property(e => e.DocumentoExcel)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.HojaDatos)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IdGrupo).HasColumnName("idGrupo");

                entity.Property(e => e.NombreVista)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("nombreVista");

                entity.Property(e => e.SentenciaConsulta)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.IdGrupoNavigation)
                    .WithMany(p => p.ReportesEjecutivos)
                    .HasForeignKey(d => d.IdGrupo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportesEjecutivos_GruposReportesEjecutivos");
            });

            modelBuilder.Entity<ReportesEjecutivos2004>(entity =>
            {
                entity.HasKey(e => e.IdReporte);

                entity.ToTable("ReportesEjecutivos2004");

                entity.HasIndex(e => e.IdReporteAux, "IX_ReportesEjecutivos2004_IdAux")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdReporte).HasColumnName("idReporte");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasDefaultValueSql("('NOMBRE DEL REPORTE')");

                entity.Property(e => e.DocumentoExcel)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.HojaDatos)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IdGrupoAux).HasColumnName("idGrupoAux");

                entity.Property(e => e.IdProcesoAux).HasColumnName("idProcesoAux");

                entity.Property(e => e.IdReporteAux).HasColumnName("idReporteAux");

                entity.Property(e => e.NombreVista).HasMaxLength(255);

                entity.HasOne(d => d.IdGrupoAuxNavigation)
                    .WithMany(p => p.ReportesEjecutivos2004s)
                    .HasPrincipalKey(p => p.IdGrupoAux)
                    .HasForeignKey(d => d.IdGrupoAux)
                    .HasConstraintName("FK_ReportesEjecutivos2004_GruposReportesEjecutivos2004");

                entity.HasOne(d => d.IdProcesoAuxNavigation)
                    .WithMany(p => p.ReportesEjecutivos2004s)
                    .HasPrincipalKey(p => p.IdProcesoAux)
                    .HasForeignKey(d => d.IdProcesoAux)
                    .HasConstraintName("FK_ReportesEjecutivos2004_ReportesEjecutivos2004Procesos");
            });

            modelBuilder.Entity<ReportesEjecutivos2004Proceso>(entity =>
            {
                entity.HasKey(e => e.IdProceso);

                entity.HasIndex(e => e.Codigo, "IX_ReportesEjecutivos2004Procesos_Codigo")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdProcesoAux, "IX_ReportesEjecutivos2004Procesos_IdAux")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdProceso).HasColumnName("idProceso");

                entity.Property(e => e.Codigo).HasMaxLength(20);

                entity.Property(e => e.Descripcion).HasMaxLength(60);

                entity.Property(e => e.IdProcesoAux)
                    .IsRequired()
                    .HasColumnName("idProcesoAux");
            });

            modelBuilder.Entity<ReportesEjecutivos2004Tdinamica>(entity =>
            {
                entity.HasKey(e => e.IdReporteTablaDinamica);

                entity.ToTable("ReportesEjecutivos2004TDinamicas");

                entity.HasIndex(e => new { e.IdReporteAux, e.Codigo }, "IX_ReportesEjecutivos2004TDinamicas_Codigo")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdReporteTablaDinamica).HasColumnName("idReporteTablaDinamica");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IdReporteAux).HasColumnName("idReporteAux");

                entity.HasOne(d => d.IdReporteAuxNavigation)
                    .WithMany(p => p.ReportesEjecutivos2004Tdinamicas)
                    .HasPrincipalKey(p => p.IdReporteAux)
                    .HasForeignKey(d => d.IdReporteAux)
                    .HasConstraintName("FK_ReportesEjecutivos2004TDinamicas_ReportesEjecutivos2004");
            });

            modelBuilder.Entity<ReportesEjecutivosOpcione>(entity =>
            {
                entity.HasKey(e => e.IdRepEjOpcion)
                    .HasName("PK_ReportesEjOpciones");

                entity.HasIndex(e => new { e.IdReporteAux, e.IdUsuario, e.Parametro }, "IX_ReportesEjOpciones_Unico")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdRepEjOpcion).HasColumnName("idRepEjOpcion");

                entity.Property(e => e.IdReporteAux).HasColumnName("idReporteAux");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Parametro)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Valor).IsRequired();

                entity.HasOne(d => d.IdReporteAuxNavigation)
                    .WithMany(p => p.ReportesEjecutivosOpciones)
                    .HasPrincipalKey(p => p.IdReporteAux)
                    .HasForeignKey(d => d.IdReporteAux)
                    .HasConstraintName("FK_ReportesEjecutivosOpciones_ReportesEjecutivos2004");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.ReportesEjecutivosOpciones)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportesEjOpciones_RptUsuarios");
            });

            modelBuilder.Entity<ReportesEjecutivosTdinamica>(entity =>
            {
                entity.HasKey(e => e.IdReporteTablaDinamica);

                entity.ToTable("ReportesEjecutivosTDinamicas");

                entity.HasIndex(e => new { e.IdReporte, e.Codigo }, "IX_ReportesEjecutivosTDinamicasIdCodigo")
                    .IsUnique();

                entity.Property(e => e.IdReporteTablaDinamica).HasColumnName("idReporteTablaDinamica");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.IdReporte).HasColumnName("idReporte");

                entity.HasOne(d => d.IdReporteNavigation)
                    .WithMany(p => p.ReportesEjecutivosTdinamicas)
                    .HasForeignKey(d => d.IdReporte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportesEjecutivosTDinamicas_ReportesEjecutivos");
            });

            modelBuilder.Entity<RptControle>(entity =>
            {
                entity.HasKey(e => e.IdControl);

                entity.Property(e => e.IdControl).ValueGeneratedNever();

                entity.Property(e => e.Control)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<RptUsuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.HasIndex(e => new { e.IdSistema, e.Usuario }, "IX_RptUsuarios")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RptcadenaSql08>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RPTCadenaSQL08");

                entity.Property(e => e.IdReporte).HasColumnName("idReporte");

                entity.Property(e => e.IdSistema).HasColumnName("idSistema");

                entity.Property(e => e.NombreArchivo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StrFrom).HasColumnName("strFROM");

                entity.Property(e => e.StrSelect).HasColumnName("strSELECT");
            });

            modelBuilder.Entity<Rptopciones08>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RPTOpciones08");

                entity.HasIndex(e => new { e.IdReporte, e.IdSistema, e.IdUsuario }, "IX_RPTOpciones08")
                    .HasFillFactor(90);

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.IdReporte).HasColumnName("idReporte");

                entity.Property(e => e.IdSistema).HasColumnName("idSistema");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.NombreArchivo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK_RPTOpciones08_SegUsuarios");
            });

            modelBuilder.Entity<RutaReporte>(entity =>
            {
                entity.HasKey(e => e.Nombre)
                    .HasName("aaaaaRutaReportes_PK")
                    .IsClustered(false);

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.Ruta).HasMaxLength(255);
            });

            modelBuilder.Entity<SegGrupoPermiso>(entity =>
            {
                entity.HasKey(e => e.IdGrupoPermiso);

                entity.HasIndex(e => new { e.GrupoPermiso, e.IdSistema }, "IX_SegGrupoPermisos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdGrupoPermiso).ValueGeneratedNever();

                entity.Property(e => e.GrupoPermiso)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdSistemaNavigation)
                    .WithMany(p => p.SegGrupoPermisos)
                    .HasForeignKey(d => d.IdSistema)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SegGrupoPermisos_SegSistemas");
            });

            modelBuilder.Entity<SegPerfil>(entity =>
            {
                entity.HasKey(e => e.IdPerfil);

                entity.ToTable("SegPerfil");

                entity.HasIndex(e => new { e.IdSistema, e.Descripcion }, "IX_SegPerfil")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MascPermisos).HasColumnName("Masc_Permisos");

                entity.Property(e => e.UMascPermisos)
                    .HasColumnType("ntext")
                    .HasColumnName("u_Masc_Permisos");

                entity.HasOne(d => d.IdSistemaNavigation)
                    .WithMany(p => p.SegPerfils)
                    .HasForeignKey(d => d.IdSistema)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SegPerfil_SegSistemas");
            });

            modelBuilder.Entity<SegPermiso>(entity =>
            {
                entity.HasKey(e => new { e.Permiso, e.IdSistema });

                entity.HasIndex(e => new { e.IdSistema, e.NombrePermiso }, "IX_SegPermisos")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.GrupoDescripcion)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.NombrePermiso)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Permiso");

                entity.Property(e => e.SubGrupoDescripcion)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdGrupoPermisoNavigation)
                    .WithMany(p => p.SegPermisos)
                    .HasForeignKey(d => d.IdGrupoPermiso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SegPermisos_GrupoPermisos");

                entity.HasOne(d => d.IdSistemaNavigation)
                    .WithMany(p => p.SegPermisos)
                    .HasForeignKey(d => d.IdSistema)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SegPermisos_SegSistemas");
            });

            modelBuilder.Entity<SegScriptsEjecutado>(entity =>
            {
                entity.HasKey(e => e.IdScript);

                entity.HasIndex(e => e.Codigo, "IX_SegScriptsEjecutados")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdScript).HasColumnName("idScript");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SegSistema>(entity =>
            {
                entity.HasKey(e => e.IdSistema);

                entity.HasIndex(e => e.Nombre, "IX_SegSistemas")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdSistema).ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Texto).HasMaxLength(80);
            });

            modelBuilder.Entity<SegUsuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.HasIndex(e => e.Usuario, "IX_SegUsuarios")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Bloqueado)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FechaCambioPwd).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<SegUsuariosSistema>(entity =>
            {
                entity.HasKey(e => new { e.IdSistema, e.IdUsuario });

                entity.Property(e => e.MascPermisos).HasColumnName("Masc_Permisos");

                entity.Property(e => e.UMascPermisos)
                    .HasColumnType("ntext")
                    .HasColumnName("u_Masc_Permisos");

                entity.HasOne(d => d.IdPerfilNavigation)
                    .WithMany(p => p.SegUsuariosSistemas)
                    .HasForeignKey(d => d.IdPerfil)
                    .HasConstraintName("FK_SegUsuariosSistemas_Perfil");

                entity.HasOne(d => d.IdSistemaNavigation)
                    .WithMany(p => p.SegUsuariosSistemas)
                    .HasForeignKey(d => d.IdSistema)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SegUsuariosSistemas_SegSistemas");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.SegUsuariosSistemas)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SegUsuariosSistemas_Usuarios");
            });

            modelBuilder.Entity<SegUsuariosXproyecto>(entity =>
            {
                entity.HasKey(e => new { e.IdUsuario, e.IdProyecto, e.IdSistema });

                entity.ToTable("SegUsuariosXProyecto");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.IdProyecto).HasColumnName("idProyecto");

                entity.Property(e => e.IdSistema).HasColumnName("idSistema");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.SegUsuariosXproyectos)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SegUsuariosXProyecto_Proyectos");

                entity.HasOne(d => d.IdSistemaNavigation)
                    .WithMany(p => p.SegUsuariosXproyectos)
                    .HasForeignKey(d => d.IdSistema)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SegUsuariosXProyecto_SegSistemas");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.SegUsuariosXproyectos)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SegUsuariosXProyecto_SegUsuarios");
            });

            modelBuilder.Entity<SegUsuariosXproyectoRemesa>(entity =>
            {
                entity.HasKey(e => new { e.IdUsuario, e.IdProyecto });

                entity.ToTable("SegUsuariosXProyectoRemesas");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.IdProyecto).HasColumnName("idProyecto");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.SegUsuariosXproyectoRemesas)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SegUsuariosXProyectoRemesas_Proyectos");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.SegUsuariosXproyectoRemesas)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SegUsuariosXProyectoRemesas_SegUsuarios");
            });

            modelBuilder.Entity<UCmbpermisoGrabado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("u_CMBPermisoGrabado");
            });

            modelBuilder.Entity<USegGrupoPermiso>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("u_SegGrupoPermisos");

                entity.Property(e => e.GrupoPermiso)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<USegPermiso>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("u_SegPermisos");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.GrupoDescripcion)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.NombrePermiso)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Permiso");

                entity.Property(e => e.SubGrupoDescripcion)
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Usuario");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Nombre).HasMaxLength(40);

                entity.Property(e => e.Password).HasMaxLength(15);
            });

            modelBuilder.Entity<biz.erpmet.Model.Version>(entity =>
            {
                entity.HasKey(e => e.IdVersion);

                entity.ToTable("Version");

                entity.HasIndex(e => e.LlaveUnica, "IX_Version_Unico")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.IdVersion).HasColumnName("idVersion");

                entity.Property(e => e.EstructuraOk).HasColumnName("EstructuraOK");

                entity.Property(e => e.Hora)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("('0000')");

                entity.Property(e => e.LlaveUnica).HasDefaultValueSql("((1))");

                entity.Property(e => e.Version1)
                    .HasMaxLength(10)
                    .HasColumnName("Version");

                entity.Property(e => e.VersionMayor)
                    .HasColumnName("versionMayor")
                    .HasDefaultValueSql("((0))");
            });
            
            modelBuilder.Entity<SaldoInicial2021>(entity =>
            {
                entity.HasNoKey();
            });
            
            modelBuilder.Entity<FinancialReportRepository.MainAccountEvaluation>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<FinancialReportRepository.BalanceSheetSummary>(entity =>
            {
                entity.HasNoKey();
            });
            
            modelBuilder.Entity<FinancialReportRepository.FundingInvestmentOperation>(entity =>
            {
                entity.HasNoKey();
            });
            
            modelBuilder.Entity<FamilyMaterial>(entity =>
            {
                entity.HasNoKey();
            });
            
            modelBuilder.Entity<PurchaseHistory>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<PriceTrend>(entity =>
            {
                entity.HasNoKey();
            });
                
            modelBuilder.Entity<TopProveedor>(entity =>
            {
                entity.HasNoKey();
            });
            
            modelBuilder.Entity<OperatingResultsSummary>(entity =>
            {
                entity.HasNoKey();
            });
            
            modelBuilder.Entity<Top5KilosMounting>(entity =>
            {
                entity.HasNoKey();
            });
            
            modelBuilder.Entity<CashFlow>(entity =>
            {
                entity.HasNoKey();
            });
            
            modelBuilder.Entity<IncomeStatement>(entity =>
            {
                entity.HasNoKey();
            });
            
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
