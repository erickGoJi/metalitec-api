using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvCliente
    {
        public CvCliente()
        {
            CvApartados = new HashSet<CvApartado>();
            CvBeneficiarios = new HashSet<CvBeneficiario>();
            CvCancelaciones = new HashSet<CvCancelacione>();
            CvClienteEscrituracions = new HashSet<CvClienteEscrituracion>();
            CvComisionesDets = new HashSet<CvComisionesDet>();
            CvComplementoPagos = new HashSet<CvComplementoPago>();
            CvContratos = new HashSet<CvContrato>();
            CvConyuges = new HashSet<CvConyuge>();
            CvDepositosSofolDets = new HashSet<CvDepositosSofolDet>();
            CvFlujoClientes = new HashSet<CvFlujoCliente>();
            CvReferencia = new HashSet<CvReferencia>();
            CvReubicacionesVivienda = new HashSet<CvReubicacionesVivienda>();
        }

        public int IdCliente { get; set; }
        public string Cliente { get; set; }
        public int IdProyecto { get; set; }
        public int? IdVivienda { get; set; }
        public int? IdCredito { get; set; }
        public int? Vendedor1 { get; set; }
        public int? Vendedor2 { get; set; }
        public int? Gerente { get; set; }
        public int? Director { get; set; }
        public int? VendedorExterno { get; set; }
        public int? IdEstado { get; set; }
        public int? IdEtapaCliente { get; set; }
        public int? IdEmpresa { get; set; }
        public int? IdMedio { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Calle { get; set; }
        public string Colonia { get; set; }
        public string CodPost { get; set; }
        public string MpioDeleg { get; set; }
        public string Localidad { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Rfc { get; set; }
        public string Curp { get; set; }
        public string NoImss { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Departamento { get; set; }
        public string Puesto { get; set; }
        public string Ocupacion { get; set; }
        public string JefeInmediato { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string TelJefeInmediato { get; set; }
        public byte Desplante { get; set; }
        public int Area { get; set; }
        public byte Recamaras { get; set; }
        public byte Cajones { get; set; }
        public int Bodega { get; set; }
        public decimal MontoEnganche { get; set; }
        public DateTime? FechaVisita { get; set; }
        public bool? Prospecto { get; set; }
        public string NumOficial { get; set; }
        public string NumInterior { get; set; }
        public string Lote { get; set; }
        public string Manzana { get; set; }
        public string Sexo { get; set; }
        public string NoInfonavit { get; set; }
        public string NoIssste { get; set; }
        public string NoSar { get; set; }
        public string NoFovissste { get; set; }
        public string NoAfore { get; set; }
        public string Identificacion { get; set; }
        public byte? RegimenMatrimonial { get; set; }
        public byte? Economia { get; set; }
        public short BimestresCotizados { get; set; }
        public byte? Casa { get; set; }
        public bool? Aval { get; set; }
        public string Notas { get; set; }
        public string Fnacionalidad { get; set; }
        public byte? FestadoCivil { get; set; }
        public decimal FingresoMensComp { get; set; }
        public decimal FingresoMensNoComp { get; set; }
        public decimal Fantiguedad { get; set; }
        public string FcreditoVigente { get; set; }
        public byte? FcreditoConyugal { get; set; }
        public string FdelegacionInfonavit { get; set; }
        public decimal FgastoPromMen { get; set; }
        public string Foriginario { get; set; }
        public decimal FsalarioCuotaDiaria { get; set; }
        public decimal Fsdi { get; set; }
        public string FtextoImnc { get; set; }
        public byte? Fescolaridad { get; set; }
        public byte FpersonasVivenTrab { get; set; }
        public byte Fhmayores18 { get; set; }
        public byte Fhmenores18 { get; set; }
        public bool? FotrosPatrones { get; set; }
        public bool? Fdiscapacitado { get; set; }
        public byte? FtipoDiscapacidad { get; set; }
        public decimal FpensionAlimenticia { get; set; }
        public decimal FsaldoSubcuentaVivienda { get; set; }
        public decimal FmontoAhorro { get; set; }
        public bool? FdependienteDiscapacitado { get; set; }
        public byte? FtipoDiscapacidadDependiente { get; set; }
        public byte? FaplicarAhorro { get; set; }
        public decimal FmontoAutorizado { get; set; }
        public decimal FmontoPrecalificacion { get; set; }
        public string FnumeroCredito { get; set; }
        public byte FpersonasDiscapacitadas { get; set; }
        public string FtextoOtraDiscapacidad { get; set; }
        public string FespecificaDiscapacidad { get; set; }
        public decimal FpuntosInfonavit { get; set; }
        public decimal FmontoSalario { get; set; }
        public decimal Fcalificacion { get; set; }
        public int? IdCetapa { get; set; }
        public DateTime? FechaAsignacionVivienda { get; set; }
        public bool Cancelado { get; set; }
        public bool Escriturado { get; set; }
        public int? IdCuentaPasivo { get; set; }
        public decimal IngresoAnual { get; set; }
        public string TelefonoCelular { get; set; }
        public decimal IngresoPresupuestal { get; set; }
        public int? IdPrototipoDeseado { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public bool TelefonosConfirmados { get; set; }
        public int? IdIdentificacionOficial { get; set; }
        public bool EsEmpresa { get; set; }
        public DateTime? FechaUltimoContacto { get; set; }
        public int? IdPrototipoPreContratado { get; set; }
        public int CambioProyecto { get; set; }
        public string Referencia { get; set; }
        public int? IdCuentaApartados { get; set; }
        public decimal MontoFichaRapApartado { get; set; }
        public DateTime? FechaFichaRapApartado { get; set; }
        public int? IdSofolSolicitada { get; set; }
        public int? IdCuentaGastosAdicionales { get; set; }
        public int? IdCuentaMoratorios { get; set; }
        public int? IdCuentaIntereses { get; set; }
        public int? IdRangoIngresoMc { get; set; }
        public int? IdRangoIngresoMnc { get; set; }
        public int? IdRangoMontoRenta { get; set; }
        public int? IdRangoPersonasHabitanCasa { get; set; }
        public int? IdDisponibilidadCasaDeseada { get; set; }
        public int? NoCuentaContable { get; set; }
        public int? IdCuentaPasivoSaldoFavor { get; set; }
        public bool EscrituradoReal { get; set; }
        public int? IdTipoMoneda { get; set; }
        public int? IdFproducto { get; set; }
        public int? IdFdestinoCredito { get; set; }
        public string Lada { get; set; }
        public string Pais { get; set; }
        public string CuentaBancaria { get; set; }
        public byte? FformaCredito { get; set; }
        public byte? FplazoCredito { get; set; }
        public bool FesSegundoCredito { get; set; }
        public byte? FopcCreditoVsm { get; set; }
        public bool FesOfertaVinculante { get; set; }
        public bool PagoElectronico { get; set; }
        public string BancoSat { get; set; }
        public string MonedaSatdefault { get; set; }
        public int? Vendedor3 { get; set; }
        public int? Vendedor4 { get; set; }
        public int? IdCodigoPostalSat { get; set; }
        public int? IdPaisSat { get; set; }
        public string NumRegIdTrib { get; set; }
        public int? Vendedor5 { get; set; }

        public virtual CvCasa CasaNavigation { get; set; }
        public virtual CvVendedore DirectorNavigation { get; set; }
        public virtual CvEconomium EconomiaNavigation { get; set; }
        public virtual CvFaplicarAhorro FaplicarAhorroNavigation { get; set; }
        public virtual CvFcreditoConyugal FcreditoConyugalNavigation { get; set; }
        public virtual CvFescolaridad FescolaridadNavigation { get; set; }
        public virtual CvFestadoCivil FestadoCivilNavigation { get; set; }
        public virtual CvFformaCredito FformaCreditoNavigation { get; set; }
        public virtual CvFopcCreditoVsm FopcCreditoVsmNavigation { get; set; }
        public virtual CvFplazosCredito FplazoCreditoNavigation { get; set; }
        public virtual CvFtipoDiscapacidad FtipoDiscapacidadDependienteNavigation { get; set; }
        public virtual CvFtipoDiscapacidad FtipoDiscapacidadNavigation { get; set; }
        public virtual CvVendedore GerenteNavigation { get; set; }
        public virtual CvCetapa IdCetapaNavigation { get; set; }
        public virtual AcCatCodigosPostalesSat IdCodigoPostalSatNavigation { get; set; }
        public virtual CvCredito IdCreditoNavigation { get; set; }
        public virtual CtbCuenta IdCuentaApartadosNavigation { get; set; }
        public virtual CtbCuenta IdCuentaGastosAdicionalesNavigation { get; set; }
        public virtual CtbCuenta IdCuentaInteresesNavigation { get; set; }
        public virtual CtbCuenta IdCuentaMoratoriosNavigation { get; set; }
        public virtual CtbCuenta IdCuentaPasivoNavigation { get; set; }
        public virtual CtbCuenta IdCuentaPasivoSaldoFavorNavigation { get; set; }
        public virtual CvDisponibilidadCasaDeseadum IdDisponibilidadCasaDeseadaNavigation { get; set; }
        public virtual CvEmpresa IdEmpresaNavigation { get; set; }
        public virtual AcCatEstado IdEstadoNavigation { get; set; }
        public virtual CvEtapasCliente IdEtapaClienteNavigation { get; set; }
        public virtual CvFdestinoCredito IdFdestinoCreditoNavigation { get; set; }
        public virtual CvFproducto IdFproductoNavigation { get; set; }
        public virtual CvIdentificacionesOficiale IdIdentificacionOficialNavigation { get; set; }
        public virtual CvMedio IdMedioNavigation { get; set; }
        public virtual AcCatPaise IdPaisSatNavigation { get; set; }
        public virtual CvPrototipo IdPrototipoDeseadoNavigation { get; set; }
        public virtual CvPrototipo IdPrototipoPreContratadoNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual CvRangoIngresoMc IdRangoIngresoMcNavigation { get; set; }
        public virtual CvRangoIngresoMnc IdRangoIngresoMncNavigation { get; set; }
        public virtual CvRangoMontoRentum IdRangoMontoRentaNavigation { get; set; }
        public virtual CvRangoPersonasHabitanCasa IdRangoPersonasHabitanCasaNavigation { get; set; }
        public virtual CvSofole IdSofolSolicitadaNavigation { get; set; }
        public virtual AcCatMoneda IdTipoMonedaNavigation { get; set; }
        public virtual CvRegimenMatrimonial RegimenMatrimonialNavigation { get; set; }
        public virtual CvVendedore Vendedor1Navigation { get; set; }
        public virtual CvVendedore Vendedor2Navigation { get; set; }
        public virtual CvVendedore Vendedor3Navigation { get; set; }
        public virtual CvVendedore Vendedor4Navigation { get; set; }
        public virtual CvVendedore Vendedor5Navigation { get; set; }
        public virtual CvVendedore VendedorExternoNavigation { get; set; }
        public virtual CvAvale CvAvale { get; set; }
        public virtual ICollection<CvApartado> CvApartados { get; set; }
        public virtual ICollection<CvBeneficiario> CvBeneficiarios { get; set; }
        public virtual ICollection<CvCancelacione> CvCancelaciones { get; set; }
        public virtual ICollection<CvClienteEscrituracion> CvClienteEscrituracions { get; set; }
        public virtual ICollection<CvComisionesDet> CvComisionesDets { get; set; }
        public virtual ICollection<CvComplementoPago> CvComplementoPagos { get; set; }
        public virtual ICollection<CvContrato> CvContratos { get; set; }
        public virtual ICollection<CvConyuge> CvConyuges { get; set; }
        public virtual ICollection<CvDepositosSofolDet> CvDepositosSofolDets { get; set; }
        public virtual ICollection<CvFlujoCliente> CvFlujoClientes { get; set; }
        public virtual ICollection<CvReferencia> CvReferencia { get; set; }
        public virtual ICollection<CvReubicacionesVivienda> CvReubicacionesVivienda { get; set; }
    }
}
