using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AoPartidasAvanceFisico
    {
        public AoPartidasAvanceFisico()
        {
            AoPartidasAvanceFisicoDets = new HashSet<AoPartidasAvanceFisicoDet>();
        }

        public int IdPartidaAvanceFisico { get; set; }
        public int IdProyecto { get; set; }
        public int Folio { get; set; }
        public DateTime Fecha { get; set; }

        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual ICollection<AoPartidasAvanceFisicoDet> AoPartidasAvanceFisicoDets { get; set; }
    }
}
