using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvVivienda
    {
        public int IdVivienda { get; set; }
        public string Vivienda { get; set; }
        public int IdPlaza { get; set; }
        public int IdDesarrollo { get; set; }
        public string Lote { get; set; }
        public int IdProyecto { get; set; }
        public int IdPrototipo { get; set; }
        public int? IdNotariaLote { get; set; }
        public string EscrituraLote { get; set; }
        public int? IdNotariaIndividual { get; set; }
        public string EscrituraIndividual { get; set; }
        public DateTime? FechaIndividual { get; set; }
        public string LugarIndividual { get; set; }
        public bool? Individualizada { get; set; }
        public DateTime? FechaLiberacion { get; set; }
        public decimal LiberacionPuente { get; set; }
        public decimal LiberacionPesos { get; set; }
        public decimal PrecioPuente { get; set; }
        public string Calle { get; set; }
        public string Colonia { get; set; }
        public string CodPost { get; set; }
        public string NumOficial { get; set; }
        public string NumInterior { get; set; }
        public string M2terreno { get; set; }
        public string M2construccion { get; set; }
        public string M2excedente { get; set; }
        public string M2indiviso { get; set; }
        public string ColindanciaNorte { get; set; }
        public string ColindanciaSur { get; set; }
        public string ColindanciaEste { get; set; }
        public string ColindanciaOeste { get; set; }
        public string ColindanciaNorEste { get; set; }
        public string ColindanciaSurEste { get; set; }
        public string ColindanciaNorOeste { get; set; }
        public string ColindanciaSurOeste { get; set; }
        public string CalleNorte { get; set; }
        public string CalleSur { get; set; }
        public string CalleEste { get; set; }
        public string CalleOeste { get; set; }
        public string CalleNorEste { get; set; }
        public string CalleSurEste { get; set; }
        public string CalleNorOeste { get; set; }
        public string CalleSurOeste { get; set; }
        public string ServidumbreFrontal { get; set; }
        public string ServidumbreTrasera { get; set; }
        public string ServidumbreDerecha { get; set; }
        public string ServidumbreIzquierda { get; set; }
        public int IdTipoMoneda { get; set; }
        public decimal PrecioTerreno { get; set; }
        public decimal PrecioReal { get; set; }
        public decimal Enganche { get; set; }
        public DateTime? FechaAvaluo { get; set; }
        public decimal ValorAvaluo { get; set; }
        public decimal CostoAvance { get; set; }
        public decimal CostoInteres { get; set; }
        public int? TipoVivienda { get; set; }
        public DateTime? FechaHabitabilidad { get; set; }
        public byte TipoLote { get; set; }
        public int? IdEtapaVivienda { get; set; }
        public int? IdCentro { get; set; }
        public string Texto { get; set; }
        public string ObjetoAutocad { get; set; }
        public string ClaveCatastral { get; set; }
        public string LicConstruccion { get; set; }
        public string BoletaPredial { get; set; }
        public decimal AvanceObra { get; set; }
        public byte FnoCuartos { get; set; }
        public byte FnoDormitorios { get; set; }
        public byte? Festado { get; set; }
        public string Fsector { get; set; }
        public byte? FtipoOfertacion { get; set; }
        public byte? Flineadecredito { get; set; }
        public bool FdictamenAprobado { get; set; }
        public byte? FtipoCompra { get; set; }
        public byte? FtipoMercado { get; set; }
        public int? IdEtapa { get; set; }
        public int? IdPetapa { get; set; }
        public string Observaciones { get; set; }
        public int? IdManzana { get; set; }
        public int? IdPropietario { get; set; }
        public int? IdTipoGravamenFinanciero1 { get; set; }
        public int? IdGravamen1 { get; set; }
        public int? IdTipoGravamenFinanciero2 { get; set; }
        public int? IdGravamen2 { get; set; }
        public int? IdPromocion { get; set; }
        public bool PromocionEntregada { get; set; }
        public DateTime? FechaEntregaPromocion { get; set; }
        public int? IdSucursal { get; set; }
        public string Seccion { get; set; }
        public DateTime? FechaModificacionFlujo { get; set; }
        public bool Asignada { get; set; }
        public string FolioRegistroPublicoProp { get; set; }
        public string LicenciaUsoDeSuelo { get; set; }
        public DateTime? FechaEntregaCliente { get; set; }
        public decimal MontoComisionPuente { get; set; }
        public decimal MontoAmortizacionPuente { get; set; }
        public bool IncluirEnCreditoPuente { get; set; }
        public string RutaImagenLocalizacion { get; set; }
        public string RutaImagenColindancias { get; set; }
        public int? IdSubtipoTerreno { get; set; }
        public DateTime? FechaProbableCobro { get; set; }
        public DateTime? FechaDtu { get; set; }
        public bool EsEsquina { get; set; }
        public decimal ImporteEsquina { get; set; }
        public string RegimenCondominio { get; set; }
        public int NoEdificiosPorLicConstruccion { get; set; }
        public decimal ImporteMetrosExcedentes { get; set; }
        public string VigenciaLicConstruccion { get; set; }
        public decimal PavanceSupervision { get; set; }
        public decimal PavanceInfonavit { get; set; }
        public decimal CostoTerreno { get; set; }
        public decimal CostoVivienda { get; set; }
        public string Localidad { get; set; }
        public string Referencia { get; set; }

        public virtual CvFestadoViviendum FestadoNavigation { get; set; }
        public virtual CvFlineaCredito FlineadecreditoNavigation { get; set; }
        public virtual CvFtipoMercado FtipoCompra1 { get; set; }
        public virtual CvFtipoCompra FtipoCompraNavigation { get; set; }
        public virtual CvFtipoOfertacion FtipoOfertacionNavigation { get; set; }
        public virtual Centro IdCentroNavigation { get; set; }
        public virtual CvDesarrollo IdDesarrolloNavigation { get; set; }
        public virtual CvEtapa IdEtapaNavigation { get; set; }
        public virtual CvEtapasVivienda IdEtapaViviendaNavigation { get; set; }
        public virtual CvGravamene IdGravamen1Navigation { get; set; }
        public virtual CvGravamene IdGravamen2Navigation { get; set; }
        public virtual CvManzana IdManzanaNavigation { get; set; }
        public virtual CvNotaria IdNotariaIndividualNavigation { get; set; }
        public virtual CvNotaria IdNotariaLoteNavigation { get; set; }
        public virtual CvPetapa IdPetapaNavigation { get; set; }
        public virtual CvPlaza IdPlazaNavigation { get; set; }
        public virtual CvPromocione IdPromocionNavigation { get; set; }
        public virtual CvPropietario IdPropietarioNavigation { get; set; }
        public virtual CvPrototipo IdPrototipoNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual CvSubtiposTerreno IdSubtipoTerrenoNavigation { get; set; }
        public virtual CvSucursale IdSucursalNavigation { get; set; }
        public virtual CvTiposGravamenesFinanciero IdTipoGravamenFinanciero1Navigation { get; set; }
        public virtual CvTiposGravamenesFinanciero IdTipoGravamenFinanciero2Navigation { get; set; }
        public virtual AcCatMoneda IdTipoMonedaNavigation { get; set; }
        public virtual CvTipoLote TipoLoteNavigation { get; set; }
        public virtual CvTipoViviendum TipoViviendaNavigation { get; set; }
    }
}
