using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvPetapa
    {
        public CvPetapa()
        {
            CvFlujoVivienda = new HashSet<CvFlujoVivienda>();
            CvPpecostos = new HashSet<CvPpecosto>();
        }

        public int IdPetapa { get; set; }
        public int IdPrototipo { get; set; }
        public int IdEtapaVivienda { get; set; }
        public int Renglon { get; set; }
        public short Dias { get; set; }
        public short DiasParaTerminar { get; set; }

        public virtual CvEtapasVivienda IdEtapaViviendaNavigation { get; set; }
        public virtual CvPrototipo IdPrototipoNavigation { get; set; }
        public virtual ICollection<CvFlujoVivienda> CvFlujoVivienda { get; set; }
        public virtual ICollection<CvPpecosto> CvPpecostos { get; set; }
    }
}
