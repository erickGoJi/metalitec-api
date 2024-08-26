using System.ComponentModel;

namespace api.metalitec.project.Models
{
    public class BudgetAdvanceDto
    {
        [Description("idproyecto")]
        public int IdProyecto { get; set; }
        [Description("proyecto")]
        public string Proyecto { get; set; }
        [Description("ingresos")]
        public decimal Ingresos { get; set; }
        [Description("COSTO")]
        public decimal Costo { get; set; }
        [Description("PESO PROYECTO")]
        public decimal? Total { get; set; }
    }
}