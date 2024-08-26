using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcNominaModelo
    {
        public AcNominaModelo()
        {
            AcNominaModelosCuenta = new HashSet<AcNominaModelosCuenta>();
            AcNominaModelosInsumos = new HashSet<AcNominaModelosInsumo>();
            AcNominaPolizas = new HashSet<AcNominaPoliza>();
            AcProyectosNominaModelos = new HashSet<AcProyectosNominaModelo>();
        }

        public int IdNominaModelo { get; set; }
        public int NominaModelo { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<AcNominaModelosCuenta> AcNominaModelosCuenta { get; set; }
        public virtual ICollection<AcNominaModelosInsumo> AcNominaModelosInsumos { get; set; }
        public virtual ICollection<AcNominaPoliza> AcNominaPolizas { get; set; }
        public virtual ICollection<AcProyectosNominaModelo> AcProyectosNominaModelos { get; set; }
    }
}
