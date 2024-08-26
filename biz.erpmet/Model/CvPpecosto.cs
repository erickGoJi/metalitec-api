using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvPpecosto
    {
        public int IdPpecosto { get; set; }
        public int IdProyectoPrototipo { get; set; }
        public int IdPetapa { get; set; }
        public decimal Costo { get; set; }
        public string Concepto { get; set; }
        public string Partida { get; set; }

        public virtual CvPetapa IdPetapaNavigation { get; set; }
        public virtual CvProyectosPrototipo IdProyectoPrototipoNavigation { get; set; }
    }
}
