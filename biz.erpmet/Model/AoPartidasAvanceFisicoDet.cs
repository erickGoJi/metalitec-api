using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AoPartidasAvanceFisicoDet
    {
        public int IdPartidaAvanceFisicoDet { get; set; }
        public int IdPartidaAvanceFisico { get; set; }
        public int IdPartida { get; set; }
        public decimal Porcentaje { get; set; }

        public virtual AoPartidasAvanceFisico IdPartidaAvanceFisicoNavigation { get; set; }
        public virtual AoPartida IdPartidaNavigation { get; set; }
    }
}
