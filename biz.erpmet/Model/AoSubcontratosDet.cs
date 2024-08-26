using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AoSubcontratosDet
    {
        public AoSubcontratosDet()
        {
            AoSubContratosEstDets = new HashSet<AoSubContratosEstDet>();
            AoSubcontratosDetCostos = new HashSet<AoSubcontratosDetCosto>();
            AoSubcontratosOcdets = new HashSet<AoSubcontratosOcdet>();
        }

        public int IdSubcontratoDet { get; set; }
        public int IdSubcontrato { get; set; }
        public int Renglon { get; set; }
        public int IdPresupuestoControl { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Costo { get; set; }
        public decimal CantidadOc { get; set; }
        public decimal CantidadEstimada { get; set; }
        public int? ControlPu2010 { get; set; }

        public virtual AoPresupuestoControl IdPresupuestoControlNavigation { get; set; }
        public virtual AoSubContrato IdSubcontratoNavigation { get; set; }
        public virtual ICollection<AoSubContratosEstDet> AoSubContratosEstDets { get; set; }
        public virtual ICollection<AoSubcontratosDetCosto> AoSubcontratosDetCostos { get; set; }
        public virtual ICollection<AoSubcontratosOcdet> AoSubcontratosOcdets { get; set; }
    }
}
