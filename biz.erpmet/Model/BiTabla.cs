using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class BiTabla
    {
        public BiTabla()
        {
            Bitacoras = new HashSet<Bitacora>();
        }

        public int IdTabla { get; set; }
        public string Tabla { get; set; }

        public virtual ICollection<Bitacora> Bitacoras { get; set; }
    }
}
