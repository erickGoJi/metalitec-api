using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcNominaCatalogoConcepto
    {
        public AcNominaCatalogoConcepto()
        {
            AcNominaModelosCuenta = new HashSet<AcNominaModelosCuenta>();
            AcNominaModelosInsumos = new HashSet<AcNominaModelosInsumo>();
        }

        public int IdNominaConcepto { get; set; }
        public int Concepto { get; set; }
        public string Descripcion { get; set; }
        public bool EsPercepcion { get; set; }
        public string Formula { get; set; }

        public virtual ICollection<AcNominaModelosCuenta> AcNominaModelosCuenta { get; set; }
        public virtual ICollection<AcNominaModelosInsumo> AcNominaModelosInsumos { get; set; }
    }
}
