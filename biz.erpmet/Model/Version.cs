using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class Version
    {
        public int IdVersion { get; set; }
        public int LlaveUnica { get; set; }
        public string Version1 { get; set; }
        public string Hora { get; set; }
        public int? VersionMayor { get; set; }
        public bool? AsignaDatosDefault { get; set; }
        public bool? EstructuraOk { get; set; }
    }
}
