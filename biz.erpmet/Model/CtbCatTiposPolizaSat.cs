using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CtbCatTiposPolizaSat
    {
        public CtbCatTiposPolizaSat()
        {
            CtbTiposPolizas = new HashSet<CtbTiposPoliza>();
        }

        public int IdTipoPolizaSat { get; set; }
        public int Tipo { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<CtbTiposPoliza> CtbTiposPolizas { get; set; }
    }
}
