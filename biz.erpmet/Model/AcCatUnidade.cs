using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatUnidade
    {
        public AcCatUnidade()
        {
            AcCatInsumoIdUnidadConversionNavigations = new HashSet<AcCatInsumo>();
            AcCatInsumoIdUnidadNavigations = new HashSet<AcCatInsumo>();
        }

        public int IdUnidad { get; set; }
        public string Unidad { get; set; }
        public string Descripcion { get; set; }
        public int? IdUnidadSat { get; set; }

        public virtual AcCatUnidadesSat IdUnidadSatNavigation { get; set; }
        public virtual ICollection<AcCatInsumo> AcCatInsumoIdUnidadConversionNavigations { get; set; }
        public virtual ICollection<AcCatInsumo> AcCatInsumoIdUnidadNavigations { get; set; }
    }
}
