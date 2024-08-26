using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AoSubcontratosOc
    {
        public AoSubcontratosOc()
        {
            AoSubcontratosOcdets = new HashSet<AoSubcontratosOcdet>();
        }

        public int IdSubcontratoOc { get; set; }
        public int IdSubcontrato { get; set; }
        public int NumeroOrdenCambio { get; set; }
        public int IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public string RazonCambio { get; set; }
        public bool ImportadoDaltonDin { get; set; }
        public DateTime? FechaImportacionDaltonDin { get; set; }
        public int? IntInmordenDeCambioDinkey { get; set; }

        public virtual AoSubContrato IdSubcontratoNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<AoSubcontratosOcdet> AoSubcontratosOcdets { get; set; }
    }
}
