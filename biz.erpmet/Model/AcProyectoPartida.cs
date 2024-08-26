using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcProyectoPartida
    {
        public AcProyectoPartida()
        {
            AcConceptosDetNcs = new HashSet<AcConceptosDetNc>();
            AcContratosDets = new HashSet<AcContratosDet>();
        }

        public int IdProyectoPartida { get; set; }
        public int IdProyecto { get; set; }
        public string Partida { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionLarga { get; set; }

        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual ICollection<AcConceptosDetNc> AcConceptosDetNcs { get; set; }
        public virtual ICollection<AcContratosDet> AcContratosDets { get; set; }
    }
}
