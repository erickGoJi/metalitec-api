using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcTiposCuadrillaNomina
    {
        public AcTiposCuadrillaNomina()
        {
            AcNominaModelosInsumos = new HashSet<AcNominaModelosInsumo>();
        }

        public int IdTipoCuadrillaNomina { get; set; }
        public string TipoCuadrillaNomina { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<AcNominaModelosInsumo> AcNominaModelosInsumos { get; set; }
    }
}
