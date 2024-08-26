using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class BiHistorico
    {
        public BiHistorico()
        {
            BiHistoricoDets = new HashSet<BiHistoricoDet>();
        }

        public int IdHistorico { get; set; }
        public int IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Detalle { get; set; }
        public int Tipo { get; set; }
        public int IdProyecto { get; set; }

        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<BiHistoricoDet> BiHistoricoDets { get; set; }
    }
}
