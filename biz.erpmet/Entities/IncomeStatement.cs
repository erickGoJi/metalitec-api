using System.ComponentModel;

namespace biz.erpmet.Entities
{
    public class IncomeStatement
    {
        public int IdProyecto { get; set; }
        public string proyecto { get; set; }
        public decimal Costo { get; set; }
        public decimal Ingresos { get; set; }
        public decimal Gastos { get; set; }
        [Description("Utilidad Neta")]
        public decimal UtilidadNeta { get; set; }
        public string mes { get; set; }
        public string anio { get; set; }
    }
}