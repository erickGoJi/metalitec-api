using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class ReCvVentasXejecutivo
    {
        public string Ejecutivo { get; set; }
        public string Prototipo { get; set; }
        public string Proyecto { get; set; }
        public string NombreProyecto { get; set; }
        public int? Cantidad { get; set; }
        public decimal? Importe { get; set; }
    }
}
