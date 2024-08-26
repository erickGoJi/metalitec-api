using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatTasaOcuotaSat
    {
        public int IdTasaOcuota { get; set; }
        public string RangoOfijo { get; set; }
        public decimal? ValorMinimo { get; set; }
        public decimal? ValorMaximo { get; set; }
        public string DescripcionImpuesto { get; set; }
        public string CodigoFactor { get; set; }
        public bool EsTraslado { get; set; }
        public bool EsRetencion { get; set; }
        public DateTime? FechaIniVig { get; set; }
        public DateTime? FechaFinVig { get; set; }
        public string Version { get; set; }
    }
}
