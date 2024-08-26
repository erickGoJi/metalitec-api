using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvReubicacionesVivienda
    {
        public int IdReubicacion { get; set; }
        public int IdProyecto { get; set; }
        public int IdCliente { get; set; }
        public int IdViviendaAnterior { get; set; }
        public int IdViviendaNueva { get; set; }
        public DateTime Fecha { get; set; }

        public virtual CvCliente IdClienteNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
    }
}
