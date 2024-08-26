using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class BiCatModulo
    {
        public BiCatModulo()
        {
            Bitacoras = new HashSet<Bitacora>();
        }

        public int IdModulo { get; set; }
        public string Modulo { get; set; }

        public virtual ICollection<Bitacora> Bitacoras { get; set; }
    }
}
