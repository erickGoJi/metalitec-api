using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatPatentesAduanalesSat
    {
        public int IdPatenteAduanal { get; set; }
        public string CodigoPatenteAduanal { get; set; }
        public DateTime? FechaIniVig { get; set; }
        public DateTime? FechaFinVig { get; set; }
        public string Version { get; set; }
    }
}
