using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatNumsPedimentoAdSat
    {
        public int IdNumPedimentoAdSat { get; set; }
        public string CodigoAduana { get; set; }
        public string CodigoPatenteAduanal { get; set; }
        public string EjercicioSat { get; set; }
        public string CantidadSat { get; set; }
        public DateTime? FechaIniVig { get; set; }
        public DateTime? FechaFinVig { get; set; }
        public string Version { get; set; }
    }
}
