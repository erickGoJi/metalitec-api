using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AoPrototipo
    {
        public AoPrototipo()
        {
            AoPrototiposDets = new HashSet<AoPrototiposDet>();
            Centros = new HashSet<Centro>();
        }

        public int IdPrototipo { get; set; }
        public int IdProyecto { get; set; }
        public string Prototipo { get; set; }
        public string Descripcion { get; set; }

        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual ICollection<AoPrototiposDet> AoPrototiposDets { get; set; }
        public virtual ICollection<Centro> Centros { get; set; }
    }
}
