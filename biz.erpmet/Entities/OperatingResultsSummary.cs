using System.ComponentModel;

namespace biz.erpmet.Entities
{
    public class OperatingResultsSummary
    {
        public string anio { get; set; }
        public string mes { get; set; }
        public int IdProyecto { get; set; }
        public string Proyecto { get; set; }
        public decimal Ingresos { get; set; }
        public decimal Costos { get; set; }
        public decimal UtilidadBruta { get; set; }
        public decimal Gastos { get; set; }
        public decimal EBITDA { get; set; }
        public decimal Depreciacion { get; set; }
        public decimal Interes { get; set; }
        public decimal UtilidadNeta { get; set; }
        // public decimal UtilidadNetaPercentage { get; set; }
        // public decimal IngresosAcumulados20 { get; set; }
        // public decimal IngresosAcumulados21 { get; set; }
        // public decimal CostosAcumulados21 { get; set; }
        // public decimal CostosAcumulados20 { get; set; }
        // public decimal UtilidadBrutaAcumulados21 { get; set; }
        // public decimal UtilidadBrutaAcumulados20 { get; set; }
        // public decimal GastosAcumulados21 { get; set; }
        // public decimal GastosAcumulados20 { get; set; }
        // public decimal EBITDAAcumulados21 { get; set; }
        // public decimal EBITDAAcumulados20 { get; set; }
        // public decimal EBITDAPercentageAcumulados21 { get; set; }
        // public decimal EBITDAPercentageAcumulados20 { get; set; }
        // public decimal DepreciacionAcumulados21 { get; set; }
        // public decimal DepreciacionAcumulados20 { get; set; }
        // public decimal UtilidadNetaAcumulados21 { get; set; }
        // public decimal UtilidadNetaAcumulados20 { get; set; }
        // public decimal UtilidadNetaPercentageAcumulados21 { get; set; }
        // public decimal UtilidadNetaPercentageAcumulados20 { get; set; }
        // public decimal InteresAcumulados21 { get; set; }
        // public decimal InteresAcumulados20 { get; set; }
    }
    
    public class OperatingResultsSummaryReturn
    {
        public string anio { get; set; }
        public string mes { get; set; }
        public int IdProyecto { get; set; }
        public string Proyecto { get; set; }
        // Ingresos
        public decimal? IngresosActual { get; set; }
        public decimal? IngresosPreviousMonth { get; set; }
        public decimal? IngresosLastYear { get; set; }
        // Costos
        public decimal? CostosActual { get; set; }
        public decimal? CostosPreviousMonth { get; set; }
        public decimal? CostosLastYear { get; set; }
        // Utilidad Bruta
        public decimal? UtilidadBrutaActual { get; set; }
        public decimal? UtilidadBrutaPreviousMonth { get; set; }
        public decimal? UtilidadBrutaLastYear { get; set; }
        //Gastos Generales y Admin.
        public decimal? GastosActual { get; set; }
        public decimal? GastosPreviousMonth { get; set; }
        public decimal? GastosLastYear { get; set; }
        // EBITDA
        public decimal? EBITDAActual { get; set; }
        public decimal? EBITDAPreviousMonth { get; set; }
        public decimal? EBITDALastYear { get; set; }
        // %EBITDA
        public decimal? EBITDAPercentageActual { get; set; }
        public decimal? EBITDAPercentagePreviousMonth { get; set; }
        public decimal? EBITDAPercentageLastYear { get; set; }
        // Depreciacion
        public decimal? DepreciacionActual { get; set; }
        public decimal? DepreciacionPreviousMonth { get; set; }
        public decimal? DepreciacionLastYear { get; set; }
        // Interes
        public decimal? InteresActual { get; set; }
        public decimal? InteresPreviousMonth { get; set; }
        public decimal? InteresLastYear { get; set; }
        // UTILIDAD NETA
        public decimal? UtilidadNetaActual { get; set; }
        public decimal? UtilidadNetaPreviousMonth { get; set; }
        public decimal? UtilidadNetaLastYear { get; set; }
        // %Utilidad Neta
        public decimal? UtilidadNetaPercentageActual { get; set; }
        public decimal? UtilidadNetaPercentagePreviousMonth { get; set; }
        public decimal? UtilidadNetaPercentageLastYear { get; set; }
        // YOY
        public decimal? YOYIngresos { get; set; }
        public decimal? YOYCostosVentas { get; set; }
        public decimal? YOYUtilidadBruta { get; set; }
        public decimal? YOYEBITDA { get; set; }
        public decimal? YOYUtilidadNeta { get; set; }
        // MOM
        [Description("m-o-m")]
        public decimal? MOMIngresos { get; set; }
        [Description("m-o-m")]
        public decimal? MOMEBITDA { get; set; }
        [Description("m-o-m")]
        public decimal? MOMUtilidadNeta { get; set; }
        // public decimal IngresosAcumulados20 { get; set; }
        // public decimal IngresosAcumulados21 { get; set; }
        // public decimal CostosAcumulados21 { get; set; }
        // public decimal CostosAcumulados20 { get; set; }
        // public decimal UtilidadBrutaAcumulados21 { get; set; }
        // public decimal UtilidadBrutaAcumulados20 { get; set; }
        // public decimal GastosAcumulados21 { get; set; }
        // public decimal GastosAcumulados20 { get; set; }
        // public decimal EBITDAAcumulados21 { get; set; }
        // public decimal EBITDAAcumulados20 { get; set; }
        // public decimal EBITDAPercentageAcumulados21 { get; set; }
        // public decimal EBITDAPercentageAcumulados20 { get; set; }
        // public decimal DepreciacionAcumulados21 { get; set; }
        // public decimal DepreciacionAcumulados20 { get; set; }
        // public decimal UtilidadNetaAcumulados21 { get; set; }
        // public decimal UtilidadNetaAcumulados20 { get; set; }
        // public decimal UtilidadNetaPercentageAcumulados21 { get; set; }
        // public decimal UtilidadNetaPercentageAcumulados20 { get; set; }
        // public decimal InteresAcumulados21 { get; set; }
        // public decimal InteresAcumulados20 { get; set; }
    }
}