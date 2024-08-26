using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvPlantillasContrato
    {
        public CvPlantillasContrato()
        {
            CvContratos = new HashSet<CvContrato>();
        }

        public int IdPlantillaContrato { get; set; }
        public string PlantillaContrato { get; set; }
        public string Texto { get; set; }
        public string Ruta { get; set; }

        public virtual ICollection<CvContrato> CvContratos { get; set; }
    }
}
