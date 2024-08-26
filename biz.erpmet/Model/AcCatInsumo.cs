using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatInsumo
    {
        public AcCatInsumo()
        {
            AcCostosXproyectos = new HashSet<AcCostosXproyecto>();
            AcExplosionInsumos = new HashSet<AcExplosionInsumo>();
            AcModelosPolizaInsumos = new HashSet<AcModelosPolizaInsumo>();
            AcNominaModelosInsumos = new HashSet<AcNominaModelosInsumo>();
            AcproveedoresInsumos = new HashSet<AcproveedoresInsumo>();
            AoCatConceptoIdDestajoNavigations = new HashSet<AoCatConcepto>();
            AoCatConceptoIdSubcontratoNavigations = new HashSet<AoCatConcepto>();
            AoCatConceptoIdSubmoNavigations = new HashSet<AoCatConcepto>();
            AoExpXpartida = new HashSet<AoExpXpartidum>();
            CvPagoLiberacionVivienda = new HashSet<CvPagoLiberacionVivienda>();
            CvVendedores = new HashSet<CvVendedore>();
        }

        public int IdInsumo { get; set; }
        public string Insumo { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionLarga { get; set; }
        public int IdTipoMoneda { get; set; }
        public int IdUnidad { get; set; }
        public int IdTipoInsumo { get; set; }
        public decimal Costo { get; set; }
        public DateTime FechaCalculo { get; set; }
        public int IdUsuario { get; set; }
        public int IdFamilia { get; set; }
        public int IdCuenta { get; set; }
        public bool DepSofol { get; set; }
        public int? IdProveedorDefault { get; set; }
        public bool PagoComisionesCv { get; set; }
        public bool EsSubInsumo { get; set; }
        public bool EsInsumoPadre { get; set; }
        public int? IdInsumoPadre { get; set; }
        public short TipoPorcentaje { get; set; }
        public int Nivel { get; set; }
        public decimal PrecioVentaCalculado { get; set; }
        public decimal PrecioVentaAlzado { get; set; }
        public bool? ControladoXprograma { get; set; }
        public short PeriodosAnticipacion { get; set; }
        public bool GastosFinancieros { get; set; }
        public decimal CantidadMinimaDeCompra { get; set; }
        public int? IdUnidadConversion { get; set; }
        public decimal FactorDeConversion { get; set; }

        public virtual CtbCuenta IdCuentaNavigation { get; set; }
        public virtual AcFamilia IdFamiliaNavigation { get; set; }
        public virtual AcProveedore IdProveedorDefaultNavigation { get; set; }
        public virtual AcTiposInsumo IdTipoInsumoNavigation { get; set; }
        public virtual AcCatMoneda IdTipoMonedaNavigation { get; set; }
        public virtual AcCatUnidade IdUnidadConversionNavigation { get; set; }
        public virtual AcCatUnidade IdUnidadNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<AcCostosXproyecto> AcCostosXproyectos { get; set; }
        public virtual ICollection<AcExplosionInsumo> AcExplosionInsumos { get; set; }
        public virtual ICollection<AcModelosPolizaInsumo> AcModelosPolizaInsumos { get; set; }
        public virtual ICollection<AcNominaModelosInsumo> AcNominaModelosInsumos { get; set; }
        public virtual ICollection<AcproveedoresInsumo> AcproveedoresInsumos { get; set; }
        public virtual ICollection<AoCatConcepto> AoCatConceptoIdDestajoNavigations { get; set; }
        public virtual ICollection<AoCatConcepto> AoCatConceptoIdSubcontratoNavigations { get; set; }
        public virtual ICollection<AoCatConcepto> AoCatConceptoIdSubmoNavigations { get; set; }
        public virtual ICollection<AoExpXpartidum> AoExpXpartida { get; set; }
        public virtual ICollection<CvPagoLiberacionVivienda> CvPagoLiberacionVivienda { get; set; }
        public virtual ICollection<CvVendedore> CvVendedores { get; set; }
    }
}
