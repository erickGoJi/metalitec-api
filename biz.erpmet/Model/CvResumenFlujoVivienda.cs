using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvResumenFlujoVivienda
    {
        public int IdVivienda { get; set; }
        public string Vivienda { get; set; }
        public int? IdFlujoVivienda { get; set; }
        public bool? Flujoterminado { get; set; }
        public DateTime? FechaInicio { get; set; }
        public string Etapaactual { get; set; }
        public string Prototipo { get; set; }
        public string Comercial { get; set; }
        public bool? Tienecliente { get; set; }
        public string Cliente { get; set; }
        public int? IdCliente { get; set; }
        public int IdProyecto { get; set; }
        public string Proyecto { get; set; }
        public short? Duracionetapa { get; set; }
        public int? Retrasoetapa { get; set; }
        public DateTime? Probabletermino { get; set; }
        public int? Retrasoacumulado { get; set; }
        public string Nombrecliente { get; set; }
        public decimal? Costoetapa { get; set; }
        public decimal? Costoacumulado { get; set; }
    }
}
