using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatAduanasSat
    {
        public int IdAduana { get; set; }
        public string CodigoAduana { get; set; }
        public string Descripcion { get; set; }
        public string Version { get; set; }
        public DateTime? FechaIniVig { get; set; }
        public DateTime? FechaFinVig { get; set; }
    }
}
