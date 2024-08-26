using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcNominaTipo
    {
        public AcNominaTipo()
        {
            AcNominaPolizas = new HashSet<AcNominaPoliza>();
            AcProyectosNominaModelos = new HashSet<AcProyectosNominaModelo>();
        }

        public int IdNominaTipo { get; set; }
        public int NominaTipo { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<AcNominaPoliza> AcNominaPolizas { get; set; }
        public virtual ICollection<AcProyectosNominaModelo> AcProyectosNominaModelos { get; set; }
    }
}
