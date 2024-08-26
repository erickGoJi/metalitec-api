using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvTiposNota
    {
        public CvTiposNota()
        {
            CvNotasEscrituras = new HashSet<CvNotasEscritura>();
            CvProyectosCuentasNota = new HashSet<CvProyectosCuentasNota>();
        }

        public int IdTipoNota { get; set; }
        public string TipoNota { get; set; }
        public string Descripcion { get; set; }
        public bool? Cargo { get; set; }
        public bool EsAnticipo { get; set; }

        public virtual ICollection<CvNotasEscritura> CvNotasEscrituras { get; set; }
        public virtual ICollection<CvProyectosCuentasNota> CvProyectosCuentasNota { get; set; }
    }
}
