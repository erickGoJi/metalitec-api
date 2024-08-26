using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcTipDocAlmacen
    {
        public AcTipDocAlmacen()
        {
            AcAlmacenConsecutivos = new HashSet<AcAlmacenConsecutivo>();
            AcAlmacenEntrada = new HashSet<AcAlmacenEntrada>();
            AcAlmacenSalida = new HashSet<AcAlmacenSalida>();
        }

        public int IdTipDocAlmacen { get; set; }
        public string TipDoc { get; set; }
        public string Descripcion { get; set; }
        public bool Salida { get; set; }
        public int IdTipoPoliza { get; set; }

        public virtual CtbTiposPoliza IdTipoPolizaNavigation { get; set; }
        public virtual ICollection<AcAlmacenConsecutivo> AcAlmacenConsecutivos { get; set; }
        public virtual ICollection<AcAlmacenEntrada> AcAlmacenEntrada { get; set; }
        public virtual ICollection<AcAlmacenSalida> AcAlmacenSalida { get; set; }
    }
}
