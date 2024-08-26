using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class ReCvApartado
    {
        public string Plaza { get; set; }
        public string Proyecto { get; set; }
        public string NombreProyecto { get; set; }
        public string Etapa { get; set; }
        public decimal MontoApartado { get; set; }
        public string Prototipo { get; set; }
        public decimal? PrecioVentaVivienda { get; set; }
        public string Crédito { get; set; }
        public string Lote { get; set; }
        public string Manzana { get; set; }
        public DateTime FechaApartado { get; set; }
        public int? Año { get; set; }
        public string Mes { get; set; }
        public string Cliente { get; set; }
        public string NombreCliente { get; set; }
    }
}
