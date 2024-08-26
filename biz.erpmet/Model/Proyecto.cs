using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class Proyecto
    {
        public Proyecto()
        {
            AcAditivasExplosions = new HashSet<AcAditivasExplosion>();
            AcAlmacenConsecutivos = new HashSet<AcAlmacenConsecutivo>();
            AcAlmacenEntrada = new HashSet<AcAlmacenEntrada>();
            AcAlmacenOproduccions = new HashSet<AcAlmacenOproduccion>();
            AcAlmacenSalidaIdProyectoDestinoNavigations = new HashSet<AcAlmacenSalida>();
            AcAlmacenSalidaIdProyectoNavigations = new HashSet<AcAlmacenSalida>();
            AcAlmacenTraspasoIdProyectoDestinoNavigations = new HashSet<AcAlmacenTraspaso>();
            AcAlmacenTraspasoIdProyectoOrigenNavigations = new HashSet<AcAlmacenTraspaso>();
            AcBancosEgresos = new HashSet<AcBancosEgreso>();
            AcBancosEgresosDets = new HashSet<AcBancosEgresosDet>();
            AcBancosEgresosInsumos = new HashSet<AcBancosEgresosInsumo>();
            AcBancosIngresos = new HashSet<AcBancosIngreso>();
            AcBancosTraspasoIdProyectoDestinoNavigations = new HashSet<AcBancosTraspaso>();
            AcBancosTraspasoIdProyectoOrigenNavigations = new HashSet<AcBancosTraspaso>();
            AcCatInsumosProrrateos = new HashSet<AcCatInsumosProrrateo>();
            AcCfditraslados = new HashSet<AcCfditraslado>();
            AcComplementoPagos = new HashSet<AcComplementoPago>();
            AcContratos = new HashSet<AcContrato>();
            AcCostosXproyectos = new HashSet<AcCostosXproyecto>();
            AcExplosionInsumos = new HashSet<AcExplosionInsumo>();
            AcFacturasProveedores = new HashSet<AcFacturasProveedore>();
            AcFlujoEfectivoOtrosIngresosEgresos = new HashSet<AcFlujoEfectivoOtrosIngresosEgreso>();
            AcGastosFinancieros = new HashSet<AcGastosFinanciero>();
            AcGastosFinancierosDets = new HashSet<AcGastosFinancierosDet>();
            AcGastosXcomprobarDets = new HashSet<AcGastosXcomprobarDet>();
            AcGastosXcomprobars = new HashSet<AcGastosXcomprobar>();
            AcGeneradorPolizas = new HashSet<AcGeneradorPoliza>();
            AcNominaPolizas = new HashSet<AcNominaPoliza>();
            AcOrdenProduccionIdProyectoDestinoNavigations = new HashSet<AcOrdenProduccion>();
            AcOrdenProduccionIdProyectoNavigations = new HashSet<AcOrdenProduccion>();
            AcPedidos = new HashSet<AcPedido>();
            AcPedidosBitacoras = new HashSet<AcPedidosBitacora>();
            AcProrrateoCostos = new HashSet<AcProrrateoCosto>();
            AcProyectoConceptos = new HashSet<AcProyectoConcepto>();
            AcProyectoPartida = new HashSet<AcProyectoPartida>();
            AcProyectosNominaModelos = new HashSet<AcProyectosNominaModelo>();
            AcRelAforoProyectos = new HashSet<AcRelAforoProyecto>();
            AcRelCuentaProyectoDets = new HashSet<AcRelCuentaProyectoDet>();
            AcRelCuentaProyectos = new HashSet<AcRelCuentaProyecto>();
            AcRelInterestaProyectos = new HashSet<AcRelInterestaProyecto>();
            AcRelRemanentesProyectos = new HashSet<AcRelRemanentesProyecto>();
            AcRelSeleccionProyectoAcums = new HashSet<AcRelSeleccionProyectoAcum>();
            AcRelSeleccionProyectos = new HashSet<AcRelSeleccionProyecto>();
            AcRequisicionBitacoras = new HashSet<AcRequisicionBitacora>();
            AcRequisicionesNavigation = new HashSet<AcRequisicione>();
            AcSolicitudMaterialIdAlmacenGeneralNavigations = new HashSet<AcSolicitudMaterial>();
            AcSolicitudMaterialIdAlmacenObraNavigations = new HashSet<AcSolicitudMaterial>();
            AcSolicitudMaterialIdAlmacenTransitoNavigations = new HashSet<AcSolicitudMaterial>();
            AoAnticiposDestajista = new HashSet<AoAnticiposDestajista>();
            AoCatConceptos = new HashSet<AoCatConcepto>();
            AoDestajistasContratistasPu2010s = new HashSet<AoDestajistasContratistasPu2010>();
            AoDestajosEsts = new HashSet<AoDestajosEst>();
            AoExpXpartida = new HashSet<AoExpXpartidum>();
            AoPartida = new HashSet<AoPartida>();
            AoPartidasAvanceFisicos = new HashSet<AoPartidasAvanceFisico>();
            AoPresupuestoControlOcs = new HashSet<AoPresupuestoControlOc>();
            AoPresupuestoControls = new HashSet<AoPresupuestoControl>();
            AoPrototipos = new HashSet<AoPrototipo>();
            AoSubContratos = new HashSet<AoSubContrato>();
            AoSubContratosEsts = new HashSet<AoSubContratosEst>();
            AoestimadoTerminacions = new HashSet<AoestimadoTerminacion>();
            Aomizars = new HashSet<Aomizar>();
            BiHistoricos = new HashSet<BiHistorico>();
            Centros = new HashSet<Centro>();
            CtbConsecutivosPolizasXanios = new HashSet<CtbConsecutivosPolizasXanio>();
            CtbConsecutivosPolizasXmes = new HashSet<CtbConsecutivosPolizasXme>();
            CtbPolizas = new HashSet<CtbPoliza>();
            CtbPolizasDets = new HashSet<CtbPolizasDet>();
            CtbSaldoXflujos = new HashSet<CtbSaldoXflujo>();
            CtbSaldosCuentasProyectos = new HashSet<CtbSaldosCuentasProyecto>();
            CvApartados = new HashSet<CvApartado>();
            CvClientes = new HashSet<CvCliente>();
            CvClientesFacturas = new HashSet<CvClientesFactura>();
            CvComisiones = new HashSet<CvComisione>();
            CvComplementoPagos = new HashSet<CvComplementoPago>();
            CvContratos = new HashSet<CvContrato>();
            CvDepositosClientes = new HashSet<CvDepositosCliente>();
            CvDepositosSofols = new HashSet<CvDepositosSofol>();
            CvPagoLiberacionVivienda = new HashSet<CvPagoLiberacionVivienda>();
            CvPrototiposAccesorios = new HashSet<CvPrototiposAccesorio>();
            CvProyectosAccesorios = new HashSet<CvProyectosAccesorio>();
            CvProyectosCreditos = new HashSet<CvProyectosCredito>();
            CvProyectosCuentasDepClientes = new HashSet<CvProyectosCuentasDepCliente>();
            CvProyectosCuentasDepSofoles = new HashSet<CvProyectosCuentasDepSofole>();
            CvProyectosCuentasNota = new HashSet<CvProyectosCuentasNota>();
            CvProyectosCuentasXplans = new HashSet<CvProyectosCuentasXplan>();
            CvProyectosPaquetes = new HashSet<CvProyectosPaquete>();
            CvProyectosPromociones = new HashSet<CvProyectosPromocione>();
            CvProyectosPrototipos = new HashSet<CvProyectosPrototipo>();
            CvProyectosVendedores = new HashSet<CvProyectosVendedore>();
            CvReubicacionesVivienda = new HashSet<CvReubicacionesVivienda>();
            ProyectosAlmacenGeneralIdAlmacenGeneralNavigations = new HashSet<ProyectosAlmacenGeneral>();
            ProyectosAlmacenGeneralIdAlmacenObraNavigations = new HashSet<ProyectosAlmacenGeneral>();
            ProyectosAlmacenGeneralIdAlmacenTransitoNavigations = new HashSet<ProyectosAlmacenGeneral>();
            ProyectosDetTacs = new HashSet<ProyectosDetTac>();
            ProyectosPorcenAportSocios = new HashSet<ProyectosPorcenAportSocio>();
            SegUsuariosXproyectoRemesas = new HashSet<SegUsuariosXproyectoRemesa>();
            SegUsuariosXproyectos = new HashSet<SegUsuariosXproyecto>();
        }

        public int IdProyecto { get; set; }
        public string Proyecto1 { get; set; }
        public int? IdUnidadNegocio { get; set; }
        public int? IdInmobiliaria { get; set; }
        public int? IdConstructora { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Colonia { get; set; }
        public int IdCiudad { get; set; }
        public string Delegacion { get; set; }
        public string CodigoPostal { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string Mail { get; set; }
        public string LugEntrMat { get; set; }
        public string Servidor { get; set; }
        public string RutaPresupPu { get; set; }
        public string RutaPresupCliente { get; set; }
        public string RutaPresupPrototipo { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFinal { get; set; }
        public short SemanaLaboral { get; set; }
        public short NumPeriodos { get; set; }
        public DateTime? HoraLabIni { get; set; }
        public DateTime? HoraLabFin { get; set; }
        public short Periodicidad { get; set; }
        public string Observac { get; set; }
        public bool ExplosionCerrada { get; set; }
        public bool TipoPresup { get; set; }
        public bool Cerrado { get; set; }
        public string RutaAutoCad { get; set; }
        public bool Finiquitado { get; set; }
        public int? IdAutorizo { get; set; }
        public int? IdReviso { get; set; }
        public int? IdResponsable { get; set; }
        public int? IdContabilidad { get; set; }
        public string Ansi { get; set; }
        public int? AvanceSegunSofol { get; set; }
        public int? ColorRelleno { get; set; }
        public DateTime? FechaFinalProy { get; set; }
        public DateTime? FechaInicioProy { get; set; }
        public bool PertCalculado { get; set; }
        public int? TipoRelleno { get; set; }
        public decimal? PorcentajeIva { get; set; }
        public string RutaNomina { get; set; }
        public string Fraccionamiento { get; set; }
        public string Referencia { get; set; }
        public string NoConsecutivo { get; set; }
        public decimal? CvIva { get; set; }
        public int? CvCtaDepPorIdentificar { get; set; }
        public DateTime? FechaMovAlm { get; set; }
        public string PresupTopeLote { get; set; }
        public DateTime FechaRequisicion { get; set; }
        public DateTime FechaPedido { get; set; }
        public DateTime FechaFacturaProveedor { get; set; }
        public DateTime FechaFacturaCliente { get; set; }
        public DateTime FechaCheque { get; set; }
        public DateTime FechaContabilidad { get; set; }
        public DateTime FechaSubContratos { get; set; }
        public DateTime FechaEstimaciones { get; set; }
        public DateTime DiaCapturaAlmacen { get; set; }
        public bool RequiereCalcular { get; set; }
        public int MesCostoPromedio { get; set; }
        public int? IdTipoProyecto { get; set; }
        public int? ProyectoPadre { get; set; }
        public decimal MontoCorridaFinanciera { get; set; }
        public int? IdUnegociogeo { get; set; }
        public bool ValidaEstimacion { get; set; }
        public int? CuentaInterCentro { get; set; }
        public string CvRazonSocial { get; set; }
        public DateTime CvFechaBloqueoApartados { get; set; }
        public DateTime CvFechaBloqueoDepositos { get; set; }
        public DateTime CvFechaBloqueoPagos { get; set; }
        public DateTime CvFechaBloqueoEscrituras { get; set; }
        public DateTime CvFechaBloqueoDepSofoles { get; set; }
        public DateTime CvFechaBloqueoCancelaciones { get; set; }
        public DateTime CvFechaBloqueoNotasCreditoCargo { get; set; }
        public DateTime CvFechaBloqueoAjustesClientes { get; set; }
        public int? CvCtaApartados { get; set; }
        public string CvNoCreditoPuente { get; set; }
        public int? CvIdSofolPuente { get; set; }
        public int? CvIdNotariaPuente { get; set; }
        public string CvNoEscrituraPuente { get; set; }
        public DateTime? CvFechaFirmaPuente { get; set; }
        public int? CvIdTipoMonedaPuente { get; set; }
        public decimal CvMontoCreditoPuente { get; set; }
        public int CvNoViviendasPuente { get; set; }
        public bool ControladoXprograma { get; set; }
        public int? CvCtaIntereses { get; set; }
        public int? CvCtaGastosAdicionales { get; set; }
        public int? CvCtaMoratorios { get; set; }
        public bool? AoModificarPresupC { get; set; }
        public bool AoAgregarOcpresupC { get; set; }
        public bool? AoModificarSubcontratos { get; set; }
        public bool AoAgregarOcsubcontratos { get; set; }
        public bool? AoAgregarSubcontratos { get; set; }
        public bool? AoModificarEstimaciones { get; set; }
        public bool? AoAgregarEstimaciones { get; set; }
        public bool? AoModificarMovAlmacen { get; set; }
        public bool? AoAgregarMovAlmacen { get; set; }
        public bool? AcRequisiciones { get; set; }
        public bool? AcOcompra { get; set; }
        public bool? AoValidarCostoSubcontrato { get; set; }
        public bool? AoValidarCostoDestajo { get; set; }
        public bool? AcFacturas { get; set; }
        public bool? AcContabilidad { get; set; }
        public int? CvCtaIvaTrasladado { get; set; }
        public int? CvCtaIvaTrasladadoPorAplicar { get; set; }
        public int CvConsecutivoCuentasClientes { get; set; }
        public int? CvCtaDevolucionesClientes { get; set; }
        public int? CvCtaIngresosPorCancelaciones { get; set; }
        public int? CvCtaAnticiposClientes { get; set; }
        public int? CvCtaClientes { get; set; }
        public bool FacturaTopadaVsExplosion { get; set; }
        public bool AgregarInsumosExplosion { get; set; }
        public int? CvCtaIngresosPorVentasCasas { get; set; }
        public int? CvCtaIngresosPorVentasTerrenos { get; set; }
        public int? CvCtaTraspasoCostoPorCasas { get; set; }
        public int? CvCtaTraspasoCostoPorTerrenos { get; set; }
        public int? CvCtaCostoPorCasas { get; set; }
        public int? CvCtaCostoPorTerrenos { get; set; }
        public int? IdCuentaAlmacen { get; set; }
        public int? IdTipoPolizaTraspaso { get; set; }
        public short TipoGenPolizasAlmacen { get; set; }
        public bool AcBancos { get; set; }
        public bool AoInventarioInicial { get; set; }
        public bool AcFacturasClientes { get; set; }
        public bool? GenerarRequisicionesComer { get; set; }
        public bool CvGenerarReferenciasPorCredito { get; set; }
        public string CvRutaArchivoDigitoVerificador { get; set; }
        public bool GeneraAlmacen { get; set; }
        public bool ManejarIvaalmacen { get; set; }
        public int? IdCuentaIvaalmacen { get; set; }
        public bool? AoControlPorPrototipo { get; set; }
        public bool AoPermitirCostoContratoMayor { get; set; }
        public bool AoPermitirCostoDestajoMayor { get; set; }
        public int? CvCtaDevolucionesClientesSaldoFavor { get; set; }
        public int? CvIdFlujoDepositos { get; set; }
        public int? CvIdFlujoMoratorios { get; set; }
        public int? CvIdFlujoIntereses { get; set; }
        public int? CvIdFlujoGastosAdicionales { get; set; }
        public int? CvIdFlujoCancelaciones { get; set; }
        public int? CvIdFlujoAjustes { get; set; }
        public int? CvIdFlujoPenalizaciones { get; set; }
        public string CvServidorAvanceObra { get; set; }
        public string CvBdavanceObra { get; set; }
        public string CvUsuarioBdavanceObra { get; set; }
        public string CvContraseniaBdavanceObra { get; set; }
        public bool? CvAutenticacionWindowsAvanceObra { get; set; }
        public int? CvIdProyectoAvanceObra { get; set; }
        public bool AoModificarPrograma { get; set; }
        public bool ExpInsSeCalculoEnBaseApo { get; set; }
        public int ExpInsPeriodoCalculo { get; set; }
        public bool RequerirPartidaEnAditivas { get; set; }
        public bool AgregarInsumosMatriz { get; set; }
        public bool PasarseExpInsMatriz { get; set; }
        public int? CvIdFlujoExcedentes { get; set; }
        public bool ValidarSoloVsExistencias { get; set; }
        public string CvRepresentanteLegalEmpresa { get; set; }
        public string CvActaConstitutivaEmpresa { get; set; }
        public string CvRfcEmpresa { get; set; }
        public string CvEscrituraFraccionamiento { get; set; }
        public string ServidorImpPu2010 { get; set; }
        public string BaseDatosImpPu2010 { get; set; }
        public string UsuarioBdImpPu2010 { get; set; }
        public string ContraseniaBdImpPu2010 { get; set; }
        public int? IdPresupuestoImpPu2010 { get; set; }
        public bool AutenticacionImpPu2010 { get; set; }
        public int? IdMonedaImpPu2010 { get; set; }
        public int? IdResponsableProyecto { get; set; }
        public int? IdMonedaCalculadaImpPu2010 { get; set; }
        public bool MultimonedaImpPu2010 { get; set; }
        public decimal CvValorPorMetroExcedente { get; set; }
        public decimal CvValorDeEsquina { get; set; }
        public string CvRepresentanteLegalEmpresaApellidoPaterno { get; set; }
        public string CvRepresentanteLegalEmpresaApellidoMaterno { get; set; }
        public string CvEmpresaClabe { get; set; }
        public string CvRepresentanteLegalLada { get; set; }
        public string CvRepresentanteLegalTelefono { get; set; }
        public string CvRepresentanteLegalTelefonoCelular { get; set; }
        public decimal CvSalarioMinimo { get; set; }
        public int? IdUbicacionAlmacen { get; set; }
        public short TipoAlmacen { get; set; }
        public bool ValidarActividadesProgramadas { get; set; }
        public int? IdCtaBancariaSocio1 { get; set; }
        public string CvBancoReferencia { get; set; }
        public int? IdCtaBancariaSocio2 { get; set; }
        public string CvCuentaReferencia { get; set; }
        public int? IdCtaBancariaSocio3 { get; set; }
        public decimal MontoFacturadoInicial { get; set; }
        public string PresupuestoImpPu2010 { get; set; }
        public int? MonedaCalculadaImpPu2010 { get; set; }
        public bool CierreTraspasoCosto { get; set; }
        public int? MonedaImpPu2010 { get; set; }
        public string CvRepresentanteLegalIdentificacion { get; set; }
        public bool? AoActCostoCantOriImp { get; set; }
        public string RutaArchivoLocalDb { get; set; }
        public decimal ImporteMaximoParaAutorizarPedidos { get; set; }
        public bool ImportarDesdeLocalDb { get; set; }
        public bool ImportarDesdeServidorSql { get; set; }
        public decimal ImporteMaximoParaAutorizarEstimaciones { get; set; }
        public int? CvCtaCancelacionIngresosClientes { get; set; }
        public bool AoPermitirNegativosConceptos { get; set; }
        public string ProyectoAuxiliar { get; set; }

        public virtual CtbCuenta CuentaInterCentroNavigation { get; set; }
        public virtual CtbCuenta CvCtaAnticiposClientesNavigation { get; set; }
        public virtual CtbCuenta CvCtaApartadosNavigation { get; set; }
        public virtual CtbCuenta CvCtaCancelacionIngresosClientesNavigation { get; set; }
        public virtual CtbCuenta CvCtaClientesNavigation { get; set; }
        public virtual CtbCuenta CvCtaCostoPorCasasNavigation { get; set; }
        public virtual CtbCuenta CvCtaCostoPorTerrenosNavigation { get; set; }
        public virtual CtbCuenta CvCtaDepPorIdentificarNavigation { get; set; }
        public virtual CtbCuenta CvCtaDevolucionesClientesNavigation { get; set; }
        public virtual CtbCuenta CvCtaDevolucionesClientesSaldoFavorNavigation { get; set; }
        public virtual CtbCuenta CvCtaGastosAdicionalesNavigation { get; set; }
        public virtual CtbCuenta CvCtaIngresosPorCancelacionesNavigation { get; set; }
        public virtual CtbCuenta CvCtaIngresosPorVentasCasasNavigation { get; set; }
        public virtual CtbCuenta CvCtaIngresosPorVentasTerrenosNavigation { get; set; }
        public virtual CtbCuenta CvCtaInteresesNavigation { get; set; }
        public virtual CtbCuenta CvCtaIvaTrasladadoNavigation { get; set; }
        public virtual CtbCuenta CvCtaIvaTrasladadoPorAplicarNavigation { get; set; }
        public virtual CtbCuenta CvCtaMoratoriosNavigation { get; set; }
        public virtual CtbCuenta CvCtaTraspasoCostoPorCasasNavigation { get; set; }
        public virtual CtbCuenta CvCtaTraspasoCostoPorTerrenosNavigation { get; set; }
        public virtual AcCatFlujo CvIdFlujoAjustesNavigation { get; set; }
        public virtual AcCatFlujo CvIdFlujoCancelacionesNavigation { get; set; }
        public virtual AcCatFlujo CvIdFlujoDepositosNavigation { get; set; }
        public virtual AcCatFlujo CvIdFlujoExcedentesNavigation { get; set; }
        public virtual AcCatFlujo CvIdFlujoGastosAdicionalesNavigation { get; set; }
        public virtual AcCatFlujo CvIdFlujoInteresesNavigation { get; set; }
        public virtual AcCatFlujo CvIdFlujoMoratoriosNavigation { get; set; }
        public virtual AcCatFlujo CvIdFlujoPenalizacionesNavigation { get; set; }
        public virtual CvNotaria CvIdNotariaPuenteNavigation { get; set; }
        public virtual CvSofole CvIdSofolPuenteNavigation { get; set; }
        public virtual AcCatMoneda CvIdTipoMonedaPuenteNavigation { get; set; }
        public virtual Acresponsable IdAutorizoNavigation { get; set; }
        public virtual AcCatCiudade IdCiudadNavigation { get; set; }
        public virtual Acresponsable IdContabilidadNavigation { get; set; }
        public virtual AcCuentasBancaria IdCtaBancariaSocio1Navigation { get; set; }
        public virtual AcCuentasBancaria IdCtaBancariaSocio2Navigation { get; set; }
        public virtual CtbCuenta IdCuentaAlmacenNavigation { get; set; }
        public virtual CtbCuenta IdCuentaIvaalmacenNavigation { get; set; }
        public virtual Acresponsable IdResponsableNavigation { get; set; }
        public virtual Acresponsable IdResponsableProyectoNavigation { get; set; }
        public virtual Acresponsable IdRevisoNavigation { get; set; }
        public virtual CtbTiposPoliza IdTipoPolizaTraspasoNavigation { get; set; }
        public virtual AotipoProyecto IdTipoProyectoNavigation { get; set; }
        public virtual AcAlmacenUbicacione IdUbicacionAlmacenNavigation { get; set; }
        public virtual AounidadNegociogeo IdUnegociogeoNavigation { get; set; }
        public virtual AcUnidadesNegocio IdUnidadNegocioNavigation { get; set; }
        public virtual AcProyectosConsecutivo AcProyectosConsecutivo { get; set; }
        public virtual ICollection<AcAditivasExplosion> AcAditivasExplosions { get; set; }
        public virtual ICollection<AcAlmacenConsecutivo> AcAlmacenConsecutivos { get; set; }
        public virtual ICollection<AcAlmacenEntrada> AcAlmacenEntrada { get; set; }
        public virtual ICollection<AcAlmacenOproduccion> AcAlmacenOproduccions { get; set; }
        public virtual ICollection<AcAlmacenSalida> AcAlmacenSalidaIdProyectoDestinoNavigations { get; set; }
        public virtual ICollection<AcAlmacenSalida> AcAlmacenSalidaIdProyectoNavigations { get; set; }
        public virtual ICollection<AcAlmacenTraspaso> AcAlmacenTraspasoIdProyectoDestinoNavigations { get; set; }
        public virtual ICollection<AcAlmacenTraspaso> AcAlmacenTraspasoIdProyectoOrigenNavigations { get; set; }
        public virtual ICollection<AcBancosEgreso> AcBancosEgresos { get; set; }
        public virtual ICollection<AcBancosEgresosDet> AcBancosEgresosDets { get; set; }
        public virtual ICollection<AcBancosEgresosInsumo> AcBancosEgresosInsumos { get; set; }
        public virtual ICollection<AcBancosIngreso> AcBancosIngresos { get; set; }
        public virtual ICollection<AcBancosTraspaso> AcBancosTraspasoIdProyectoDestinoNavigations { get; set; }
        public virtual ICollection<AcBancosTraspaso> AcBancosTraspasoIdProyectoOrigenNavigations { get; set; }
        public virtual ICollection<AcCatInsumosProrrateo> AcCatInsumosProrrateos { get; set; }
        public virtual ICollection<AcCfditraslado> AcCfditraslados { get; set; }
        public virtual ICollection<AcComplementoPago> AcComplementoPagos { get; set; }
        public virtual ICollection<AcContrato> AcContratos { get; set; }
        public virtual ICollection<AcCostosXproyecto> AcCostosXproyectos { get; set; }
        public virtual ICollection<AcExplosionInsumo> AcExplosionInsumos { get; set; }
        public virtual ICollection<AcFacturasProveedore> AcFacturasProveedores { get; set; }
        public virtual ICollection<AcFlujoEfectivoOtrosIngresosEgreso> AcFlujoEfectivoOtrosIngresosEgresos { get; set; }
        public virtual ICollection<AcGastosFinanciero> AcGastosFinancieros { get; set; }
        public virtual ICollection<AcGastosFinancierosDet> AcGastosFinancierosDets { get; set; }
        public virtual ICollection<AcGastosXcomprobarDet> AcGastosXcomprobarDets { get; set; }
        public virtual ICollection<AcGastosXcomprobar> AcGastosXcomprobars { get; set; }
        public virtual ICollection<AcGeneradorPoliza> AcGeneradorPolizas { get; set; }
        public virtual ICollection<AcNominaPoliza> AcNominaPolizas { get; set; }
        public virtual ICollection<AcOrdenProduccion> AcOrdenProduccionIdProyectoDestinoNavigations { get; set; }
        public virtual ICollection<AcOrdenProduccion> AcOrdenProduccionIdProyectoNavigations { get; set; }
        public virtual ICollection<AcPedido> AcPedidos { get; set; }
        public virtual ICollection<AcPedidosBitacora> AcPedidosBitacoras { get; set; }
        public virtual ICollection<AcProrrateoCosto> AcProrrateoCostos { get; set; }
        public virtual ICollection<AcProyectoConcepto> AcProyectoConceptos { get; set; }
        public virtual ICollection<AcProyectoPartida> AcProyectoPartida { get; set; }
        public virtual ICollection<AcProyectosNominaModelo> AcProyectosNominaModelos { get; set; }
        public virtual ICollection<AcRelAforoProyecto> AcRelAforoProyectos { get; set; }
        public virtual ICollection<AcRelCuentaProyectoDet> AcRelCuentaProyectoDets { get; set; }
        public virtual ICollection<AcRelCuentaProyecto> AcRelCuentaProyectos { get; set; }
        public virtual ICollection<AcRelInterestaProyecto> AcRelInterestaProyectos { get; set; }
        public virtual ICollection<AcRelRemanentesProyecto> AcRelRemanentesProyectos { get; set; }
        public virtual ICollection<AcRelSeleccionProyectoAcum> AcRelSeleccionProyectoAcums { get; set; }
        public virtual ICollection<AcRelSeleccionProyecto> AcRelSeleccionProyectos { get; set; }
        public virtual ICollection<AcRequisicionBitacora> AcRequisicionBitacoras { get; set; }
        public virtual ICollection<AcRequisicione> AcRequisicionesNavigation { get; set; }
        public virtual ICollection<AcSolicitudMaterial> AcSolicitudMaterialIdAlmacenGeneralNavigations { get; set; }
        public virtual ICollection<AcSolicitudMaterial> AcSolicitudMaterialIdAlmacenObraNavigations { get; set; }
        public virtual ICollection<AcSolicitudMaterial> AcSolicitudMaterialIdAlmacenTransitoNavigations { get; set; }
        public virtual ICollection<AoAnticiposDestajista> AoAnticiposDestajista { get; set; }
        public virtual ICollection<AoCatConcepto> AoCatConceptos { get; set; }
        public virtual ICollection<AoDestajistasContratistasPu2010> AoDestajistasContratistasPu2010s { get; set; }
        public virtual ICollection<AoDestajosEst> AoDestajosEsts { get; set; }
        public virtual ICollection<AoExpXpartidum> AoExpXpartida { get; set; }
        public virtual ICollection<AoPartida> AoPartida { get; set; }
        public virtual ICollection<AoPartidasAvanceFisico> AoPartidasAvanceFisicos { get; set; }
        public virtual ICollection<AoPresupuestoControlOc> AoPresupuestoControlOcs { get; set; }
        public virtual ICollection<AoPresupuestoControl> AoPresupuestoControls { get; set; }
        public virtual ICollection<AoPrototipo> AoPrototipos { get; set; }
        public virtual ICollection<AoSubContrato> AoSubContratos { get; set; }
        public virtual ICollection<AoSubContratosEst> AoSubContratosEsts { get; set; }
        public virtual ICollection<AoestimadoTerminacion> AoestimadoTerminacions { get; set; }
        public virtual ICollection<Aomizar> Aomizars { get; set; }
        public virtual ICollection<BiHistorico> BiHistoricos { get; set; }
        public virtual ICollection<Centro> Centros { get; set; }
        public virtual ICollection<CtbConsecutivosPolizasXanio> CtbConsecutivosPolizasXanios { get; set; }
        public virtual ICollection<CtbConsecutivosPolizasXme> CtbConsecutivosPolizasXmes { get; set; }
        public virtual ICollection<CtbPoliza> CtbPolizas { get; set; }
        public virtual ICollection<CtbPolizasDet> CtbPolizasDets { get; set; }
        public virtual ICollection<CtbSaldoXflujo> CtbSaldoXflujos { get; set; }
        public virtual ICollection<CtbSaldosCuentasProyecto> CtbSaldosCuentasProyectos { get; set; }
        public virtual ICollection<CvApartado> CvApartados { get; set; }
        public virtual ICollection<CvCliente> CvClientes { get; set; }
        public virtual ICollection<CvClientesFactura> CvClientesFacturas { get; set; }
        public virtual ICollection<CvComisione> CvComisiones { get; set; }
        public virtual ICollection<CvComplementoPago> CvComplementoPagos { get; set; }
        public virtual ICollection<CvContrato> CvContratos { get; set; }
        public virtual ICollection<CvDepositosCliente> CvDepositosClientes { get; set; }
        public virtual ICollection<CvDepositosSofol> CvDepositosSofols { get; set; }
        public virtual ICollection<CvPagoLiberacionVivienda> CvPagoLiberacionVivienda { get; set; }
        public virtual ICollection<CvPrototiposAccesorio> CvPrototiposAccesorios { get; set; }
        public virtual ICollection<CvProyectosAccesorio> CvProyectosAccesorios { get; set; }
        public virtual ICollection<CvProyectosCredito> CvProyectosCreditos { get; set; }
        public virtual ICollection<CvProyectosCuentasDepCliente> CvProyectosCuentasDepClientes { get; set; }
        public virtual ICollection<CvProyectosCuentasDepSofole> CvProyectosCuentasDepSofoles { get; set; }
        public virtual ICollection<CvProyectosCuentasNota> CvProyectosCuentasNota { get; set; }
        public virtual ICollection<CvProyectosCuentasXplan> CvProyectosCuentasXplans { get; set; }
        public virtual ICollection<CvProyectosPaquete> CvProyectosPaquetes { get; set; }
        public virtual ICollection<CvProyectosPromocione> CvProyectosPromociones { get; set; }
        public virtual ICollection<CvProyectosPrototipo> CvProyectosPrototipos { get; set; }
        public virtual ICollection<CvProyectosVendedore> CvProyectosVendedores { get; set; }
        public virtual ICollection<CvReubicacionesVivienda> CvReubicacionesVivienda { get; set; }
        public virtual ICollection<ProyectosAlmacenGeneral> ProyectosAlmacenGeneralIdAlmacenGeneralNavigations { get; set; }
        public virtual ICollection<ProyectosAlmacenGeneral> ProyectosAlmacenGeneralIdAlmacenObraNavigations { get; set; }
        public virtual ICollection<ProyectosAlmacenGeneral> ProyectosAlmacenGeneralIdAlmacenTransitoNavigations { get; set; }
        public virtual ICollection<ProyectosDetTac> ProyectosDetTacs { get; set; }
        public virtual ICollection<ProyectosPorcenAportSocio> ProyectosPorcenAportSocios { get; set; }
        public virtual ICollection<SegUsuariosXproyectoRemesa> SegUsuariosXproyectoRemesas { get; set; }
        public virtual ICollection<SegUsuariosXproyecto> SegUsuariosXproyectos { get; set; }
    }
}
