using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class ReCvIngresosEsperado
    {
        public string Plaza { get; set; }
        public string Proyecto { get; set; }
        public string NombreProyecto { get; set; }
        public string Etapa { get; set; }
        public string TipoPlan { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string CódigoCliente { get; set; }
        public string NombreCliente { get; set; }
        public string Crédito { get; set; }
        public int? Año { get; set; }
        public string Mes { get; set; }
        public string Semana { get; set; }
    }
}
