using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvFlujoVivienda
    {
        public int IdFlujoVivienda { get; set; }
        public int IdVivienda { get; set; }
        public int IdPetapa { get; set; }
        public bool Terminada { get; set; }
        public DateTime? FechaTerminacion { get; set; }
        public DateTime? FechaInicio { get; set; }

        public virtual CvPetapa IdPetapaNavigation { get; set; }
    }
}
