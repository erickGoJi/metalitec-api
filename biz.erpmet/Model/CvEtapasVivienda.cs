using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvEtapasVivienda
    {
        public CvEtapasVivienda()
        {
            CvPetapas = new HashSet<CvPetapa>();
        }

        public int IdEtapaVivienda { get; set; }
        public string EtapaVivienda { get; set; }
        public string Texto { get; set; }
        public int ColorRelleno { get; set; }

        public virtual ICollection<CvPetapa> CvPetapas { get; set; }
    }
}
