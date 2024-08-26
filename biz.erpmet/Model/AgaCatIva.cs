using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AgaCatIva
    {
        public AgaCatIva()
        {
            CtbCuenta = new HashSet<CtbCuenta>();
        }

        public int IdAgaCatIva { get; set; }
        public string CodigoIva { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<CtbCuenta> CtbCuenta { get; set; }
    }
}
