namespace biz.erpmet.Entities
{
    public class PriceTrend
    {
        public int Anio { get; set; }
        public int Mes { get; set; }
        public decimal CostoNeto { get; set; }
        public string Tipo { get; set; }
        public string Insumo { get; set; }
        public string DescripcionLarga { get; set; }
        public int IdInsumo { get; set; }
    }
}