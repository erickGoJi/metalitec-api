using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AoExpXpartidum
    {
        public int IdExpXpartida { get; set; }
        public int IdPartida { get; set; }
        public int IdProyecto { get; set; }
        public int IdInsumo { get; set; }
        public decimal CantidadRequisicion { get; set; }

        public virtual AcCatInsumo IdInsumoNavigation { get; set; }
        public virtual AoPartida IdPartidaNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
    }
}
