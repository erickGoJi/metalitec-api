using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class FeneodataFolio
    {
        public int IdFolio { get; set; }
        public int IdCertificado { get; set; }
        public string Serie { get; set; }
        public int FolioInicial { get; set; }
        public int FolioFinal { get; set; }
        public int FolioActual { get; set; }
        public long? NoAprobacion { get; set; }
        public int? AnoAprobacion { get; set; }
        public bool Predeterminado { get; set; }

        public virtual FeneodataCertificado IdCertificadoNavigation { get; set; }
    }
}
