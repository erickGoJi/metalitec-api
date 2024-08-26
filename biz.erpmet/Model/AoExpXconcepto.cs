using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AoExpXconcepto
    {
        public AoExpXconcepto()
        {
            AoMatrizOcdets = new HashSet<AoMatrizOcdet>();
        }

        public int IdExpXconcepto { get; set; }
        public int IdConcepto { get; set; }
        public int IdCostoXproyecto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal CantidadOc { get; set; }
        public bool SalidaPorPaquete { get; set; }
        public bool InsumoSuministrado { get; set; }
        public bool Marca { get; set; }

        public virtual AoCatConcepto IdConceptoNavigation { get; set; }
        public virtual AcCostosXproyecto IdCostoXproyectoNavigation { get; set; }
        public virtual ICollection<AoMatrizOcdet> AoMatrizOcdets { get; set; }
    }
}
