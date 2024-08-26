using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class BiCatProceso
    {
        public BiCatProceso()
        {
            Bitacoras = new HashSet<Bitacora>();
        }

        public int IdProceso { get; set; }
        public string Proceso { get; set; }

        public virtual ICollection<Bitacora> Bitacoras { get; set; }
    }
}
