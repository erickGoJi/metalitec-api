using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class FeseriesDigitalesXrfc
    {
        public int IdSerieDigital { get; set; }
        public string Rfc { get; set; }
        public string NoSerie { get; set; }
        public DateTime FechaInicialCertificado { get; set; }
        public DateTime FechaFinalCertificado { get; set; }
        public string EstadoCertificado { get; set; }
        public DateTime FechaProceso { get; set; }
        public int IdUsuario { get; set; }

        public virtual SegUsuario IdUsuarioNavigation { get; set; }
    }
}
