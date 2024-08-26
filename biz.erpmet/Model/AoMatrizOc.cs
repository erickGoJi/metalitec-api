using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AoMatrizOc
    {
        public AoMatrizOc()
        {
            AoMatrizOcdets = new HashSet<AoMatrizOcdet>();
        }

        public int IdMatrizOc { get; set; }
        public int IdConcepto { get; set; }
        public int NumeroOrdenCambio { get; set; }
        public int IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public string RazonCambio { get; set; }

        public virtual AoCatConcepto IdConceptoNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<AoMatrizOcdet> AoMatrizOcdets { get; set; }
    }
}
