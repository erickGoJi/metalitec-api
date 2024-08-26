using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AounidadNegociogeo
    {
        public AounidadNegociogeo()
        {
            AoPartida = new HashSet<AoPartida>();
            Proyectos = new HashSet<Proyecto>();
        }

        public int IdUnegociogeo { get; set; }
        public string Unegocio { get; set; }
        public string Texto { get; set; }

        public virtual ICollection<AoPartida> AoPartida { get; set; }
        public virtual ICollection<Proyecto> Proyectos { get; set; }
    }
}
